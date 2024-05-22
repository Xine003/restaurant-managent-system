using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restaurantSystem.DesignCodes;
using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;



namespace restaurantSystem
{
    public partial class Dashboard : Form
    {
        private DB db = new DB();
        public Dashboard()
        {
            InitializeComponent();
            DesignCodes.Borders.SetBorderRadius(panel2, 20);
            DesignCodes.Borders.SetBorderRadius(panel3, 20);
            DesignCodes.Borders.SetBorderRadius(panel4, 20);
            DesignCodes.Borders.SetBorderRadius(panel5, 20);
            DesignCodes.Borders.SetBorderRadius(panel6, 20);
            PopulatePieChart();
            PopulateLineGraph();
            PopulateComboBox();
            PopulateTotalRevenue();
            PopulateTotalOrders();
        }


        private void PopulateTotalRevenue()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";
            string query = "SELECT SUM(totalAmount) AS TotalRevenue FROM historytransaction";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Convert the result to a double
                        double totalRevenues = Convert.ToDouble(result);

                        // Display the total revenue in the TextBox named totalRevenue
                        totalRevenue.Text = totalRevenues.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PopulateTotalOrders()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";
            string query = "SELECT COUNT(DISTINCT ORNumber) FROM historytransaction";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string ordersCompletedTotal = Convert.ToString(result);
                        ordersCompleted.Text = ordersCompletedTotal + " orders";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PopulateComboBox()
        {
       
            List<string> items = new List<string>
            {
                "Daily",
                "Monthly",
                "Yearly",
            };

            comboBox1.DataSource = items;
        }



        private void PopulatePieChart()
        {
          
            chart1.Series.Clear();

           
            DataTable dt = new DataTable();
            string query = "SELECT orderName FROM historytransaction LIMIT 5";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());

            adapter.Fill(dt);

           
            var orderCounts = dt.AsEnumerable()
                                .GroupBy(row => row.Field<string>("orderName"))
                                .Select(group => new
                                {
                                    OrderName = group.Key,
                                    Count = group.Count()
                                })
                                .OrderByDescending(x => x.Count);

           
            Series series = new Series("Orders");
            series.ChartType = SeriesChartType.Pie;

            int totalOrders = orderCounts.Sum(x => x.Count); 

         
            foreach (var order in orderCounts)
            {
                double percentage = (double)order.Count / totalOrders * 100;
                DataPoint dataPoint = series.Points.Add(order.Count);
                dataPoint.LegendText = $"{order.OrderName} ({percentage:F2}%)";
                
            }

           
            chart1.Series.Add(series);

           
            chart1.Legends.Add(new Legend("OrdersLegend"));
            chart1.Series[0].Legend = "OrdersLegend";
        }

        private void PopulateLineGraph()
        {
           
            chart2.Series.Clear();

         
            DataTable dt = new DataTable();
            string query = "SELECT date, SUM(totalAmount) AS TotalSales FROM historytransaction GROUP BY date";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());

            adapter.Fill(dt);

           
            Series series = new Series("Total Sales");
            series.ChartType = SeriesChartType.Line;

         
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = Convert.ToDateTime(row["date"]);
                double totalSales = Convert.ToDouble(row["TotalSales"]);

                
                string formattedDate = date.ToString("MM/dd");

                series.Points.AddXY(formattedDate, totalSales);
            }

            chart2.Series.Add(series);

            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd"; 
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; 
            chart2.ChartAreas[0].AxisY.LabelStyle.Format = "C"; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();
            PopulateLineGraphFilter(selectedFilter);
        }

        private void PopulateLineGraphFilter(string filter)
        {
            chart2.Series.Clear();

            string query = "";

            switch (filter)
            {
                case "Daily":
                    query = "SELECT date, SUM(totalAmount) AS TotalSales FROM historytransaction GROUP BY date";
                    break;
                case "Monthly":
                    query = "SELECT CONCAT(MONTH(date), '/', YEAR(date)) AS MonthYear, SUM(totalAmount) AS TotalSales " +
                            "FROM historytransaction GROUP BY CONCAT(MONTH(date), '/', YEAR(date))";
                    break;
                case "Yearly":
                    query = "SELECT YEAR(date) AS Year, SUM(totalAmount) AS TotalSales FROM historytransaction GROUP BY YEAR(date)";
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.getConnection());
                adapter.Fill(dt);

                Series series = new Series("Total Sales");
                series.ChartType = SeriesChartType.Line;

                foreach (DataRow row in dt.Rows)
                {
                    double totalSales = Convert.ToDouble(row["TotalSales"]);
                    string formattedDate = "";

                    if (filter == "Daily")
                    {
                        DateTime date = Convert.ToDateTime(row["date"]);
                        formattedDate = date.ToString("MM/dd");
                    }
                    else if (filter == "Monthly")
                    {
                        // Extract month and year from the concatenated string
                        string[] monthYear = row["MonthYear"].ToString().Split('/');
                        int month = Convert.ToInt32(monthYear[0]);
                        string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                        formattedDate = $"{monthName} {monthYear[1]}";
                    }
                    else if (filter == "Yearly")
                    {
                        formattedDate = row["Year"].ToString();
                    }

                    series.Points.AddXY(formattedDate, totalSales);
                }

                chart2.Series.Add(series);

                chart2.ChartAreas[0].AxisX.LabelStyle.Format = filter == "Yearly" ? "" : "MM/dd";
                chart2.ChartAreas[0].AxisX.Interval = 1;
                chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart2.ChartAreas[0].AxisY.LabelStyle.Format = "C";
            }
        }

        private void totalRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
