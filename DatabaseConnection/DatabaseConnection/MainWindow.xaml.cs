using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatabaseConnection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Invoking fillGrid() method when window is initialized
            fillGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //connection
            //invoking connectDB() method from DbConnection class
            MySqlConnection con = new DbConnection().connectDB();

            //Insert query
            //Concat operator is used to combine the string values ("+") this is it
            string sql = "INSERT INTO items(item_name,unit_price,stock)VALUES(@name,@price,@stock)";

            //creating command object
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", TxtName.Text);
            cmd.Parameters.AddWithValue("@price", Convert.ToDouble(TxtPrice.Text));
            cmd.Parameters.AddWithValue("@stock", Convert.ToDouble(TxtStock.Text));

            //Opening the connection
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item Inserted Successfully");

            //Clear the textboxes after inserting the data
            TxtId.Clear();
            TxtName.Clear(); 
            TxtPrice.Clear(); 
            TxtStock.Clear();

            //Refresh the data grid
            fillGrid();
        }

        public void fillGrid()
        {
            //Connection
            MySqlConnection con = new DbConnection().connectDB();

            //SQL Quary
            string sql = "SELECT * FROM items";

            //Data Adapter : Executes the query and stores the data from the query
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

            //Storing data from adapter into a table like structure
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //Set the data source of the data grid as the data table
            GrdItems.ItemsSource = dt.DefaultView;
        }


        //Search button click event
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Connection
            MySqlConnection con = new DbConnection().connectDB();
            //Query
            string sql = "SELECT * FROM items WHERE item_name=@name";

            //Command
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", TxtSearch.Text);

            //Open the connection
            con.Open();

            //Store data from select query to a data reader to access one record
            MySqlDataReader rdr = cmd.ExecuteReader();

            //Read data
            if (rdr.Read()) {
                TxtId.Text = rdr.GetInt32("id").ToString();
                TxtName.Text = rdr.GetString("item_name");
                TxtPrice.Text = rdr.GetDouble("unit_price").ToString();
                TxtStock.Text = rdr.GetDouble("stock").ToString();
                TxtSearch.Clear();
            }
            else {
                MessageBox.Show("Do not have items with the name provided");
                TxtSearch.Clear();
            }
            con.Close();
        }

        //Delete button
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection con = new DbConnection().connectDB();
            string sql = "DELETE FROM items WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TxtId.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item Deleted Successfully");
            
            TxtSearch.Clear();
            TxtId.Clear();
            TxtName.Clear();
            TxtPrice.Clear();
            TxtStock.Clear();

            //Refresh the data grid
            fillGrid();
        }


        //Edit button
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection con = new DbConnection().connectDB();
            string sql = "Update items SET item_name=@name, unit_price=@price, stock=@stock WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TxtId.Text));
            cmd.Parameters.AddWithValue("@name", TxtName.Text);
            cmd.Parameters.AddWithValue("@price", Convert.ToDouble(TxtPrice.Text));
            cmd.Parameters.AddWithValue("@stock", Convert.ToDouble(TxtStock.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item Updated Successfully");

            TxtSearch.Clear();
            TxtId.Clear();
            TxtName.Clear();
            TxtPrice.Clear();
            TxtStock.Clear();

            //Refresh the data grid
            fillGrid();
        }
    }
}
