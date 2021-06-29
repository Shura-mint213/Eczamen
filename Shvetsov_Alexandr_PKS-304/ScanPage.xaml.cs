using System;
using System.Collections.Generic;
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
using System.Windows.Controls;
using System.Data.SqlClient;

namespace Shvetsov_Alexandr_PKS_304
{
    /// <summary>
    /// Логика взаимодействия для ScanPage.xaml
    /// </summary>
    public partial class ScanPage : Page
    {
        public class Opiration
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Coverage { get; set; }
            public string Price { get; set; }
        }
        public class TV_channel
        {
            public string Name2 { get; set; }
            public string Coverage2 { get; set; }
            public string Descriptions2 { get; set; }
            public string launch2 { get; set; }
        }
        public class Union
        {
            public string ID_TV3 { get; set; }
            public string ID_Operation3 { get; set; }
        }
        public ScanPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Opiration_Button_Click(object sender, RoutedEventArgs e)
        {
            OpirationDataGrid.Visibility = Visibility.Visible;
            TV_channelDataGrid.Visibility = Visibility.Hidden;
            UnionDataGrid.Visibility = Visibility.Hidden;
            OptionTextBox.Visibility = Visibility.Visible;
            TV_channelTextBox.Visibility = Visibility.Hidden;
            UnionTextBox.Visibility = Visibility.Hidden;
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                string sqlExpression = "SELECT * FROM dbo.Opiration";
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                List<Opiration> Opirations = new List<Opiration>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Opiration st = new Opiration();
                        st.Name = reader[1].ToString();
                        st.Type = reader[2].ToString();
                        st.Coverage = reader[3].ToString();
                        st.Price = reader[4].ToString();
                        Opirations.Add(st);
                    }
                    OpirationDataGrid.ItemsSource = Opirations;
                    OpirationDataGrid.Columns[4].Visibility = Visibility.Hidden;
                    OpirationDataGrid.Columns[5].Visibility = Visibility.Hidden;
                    OpirationDataGrid.Columns[6].Visibility = Visibility.Hidden;
                    OpirationDataGrid.Columns[7].Visibility = Visibility.Hidden;
                    Manager.connection.Close();
                }
                else
                {
                    MessageBox.Show("stop");
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show((error.Number).ToString() + " " + error.Message);
            }
        }

        private void TV_channel_Button_Click(object sender, RoutedEventArgs e)
        {
            OpirationDataGrid.Visibility = Visibility.Hidden;
            TV_channelDataGrid.Visibility = Visibility.Visible;
            UnionDataGrid.Visibility = Visibility.Hidden;
            OptionTextBox.Visibility = Visibility.Hidden;
            TV_channelTextBox.Visibility = Visibility.Visible;
            UnionTextBox.Visibility = Visibility.Hidden;
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                string sqlExpression = "SELECT * FROM TV_channel";
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                List<TV_channel> TV_channels = new List<TV_channel>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TV_channel st = new TV_channel();
                        st.Name2 = reader[1].ToString();
                        st.Coverage2 = reader[2].ToString();
                        st.Descriptions2 = reader[3].ToString();
                        st.launch2 = reader[4].ToString();
                        st.launch2 = st.launch2.Substring(0, st.launch2.Length - 7);
                        TV_channels.Add(st);
                    }
                    TV_channelDataGrid.ItemsSource = TV_channels;
                    TV_channelDataGrid.Columns[4].Visibility = Visibility.Hidden;
                    TV_channelDataGrid.Columns[5].Visibility = Visibility.Hidden;
                    TV_channelDataGrid.Columns[6].Visibility = Visibility.Hidden;
                    TV_channelDataGrid.Columns[7].Visibility = Visibility.Hidden;
                    Manager.connection.Close();
                }
                else
                {
                    MessageBox.Show("stop");
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show((error.Number).ToString() + " " + error.Message);
            }
        }

        private void Union_Button_Click(object sender, RoutedEventArgs e)
        {
            OpirationDataGrid.Visibility = Visibility.Hidden;
            TV_channelDataGrid.Visibility = Visibility.Hidden;
            UnionDataGrid.Visibility = Visibility.Visible;
            OptionTextBox.Visibility = Visibility.Hidden;
            TV_channelTextBox.Visibility = Visibility.Hidden;
            UnionTextBox.Visibility = Visibility.Visible;
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                string sqlExpression = "SELECT * FROM [Union]";
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                List<Union> Unions = new List<Union>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Union st = new Union();
                        st.ID_TV3 = reader[0].ToString();
                        st.ID_Operation3 = reader[1].ToString();
                        Unions.Add(st);
                    }
                    UnionDataGrid.ItemsSource = Unions;
                    UnionDataGrid.Columns[2].Visibility = Visibility.Hidden;
                    UnionDataGrid.Columns[3].Visibility = Visibility.Hidden;
                    Manager.connection.Close();
                }
                else
                {
                    MessageBox.Show("stop");
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show((error.Number).ToString() + " " + error.Message);
            }
        }
        private void Union_TextChanged(object sender, TextChangedEventArgs e)
        {
            OpirationDataGrid.Visibility = Visibility.Hidden;
            TV_channelDataGrid.Visibility = Visibility.Hidden;
            UnionDataGrid.Visibility = Visibility.Visible;
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                string sqlExpression = "SELECT * From [Union] where ID_TV Like '%" + UnionTextBox.Text + "%'";
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                List<Union> Unions = new List<Union>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Union st = new Union();
                        st.ID_TV3 = reader[0].ToString();
                        st.ID_Operation3 = reader[1].ToString();
                        Unions.Add(st);
                    }
                    UnionDataGrid.ItemsSource = Unions;
                    UnionDataGrid.Columns[2].Visibility = Visibility.Hidden;
                    UnionDataGrid.Columns[3].Visibility = Visibility.Hidden;
                    Manager.connection.Close();
                }
                else
                {
                 
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show((error.Number).ToString() + " " + error.Message);
            }
        }
        private void TV_channel_TextChanged(object sender, TextChangedEventArgs e)
        {
            OpirationDataGrid.Visibility = Visibility.Hidden;
            TV_channelDataGrid.Visibility = Visibility.Visible;
            UnionDataGrid.Visibility = Visibility.Hidden;
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                string sqlExpression = "SELECT * From TV_channel where Name Like '%" + TV_channelTextBox.Text + "%'";
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                List<TV_channel> TV_channels = new List<TV_channel>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TV_channel st = new TV_channel();
                        st.Name2 = reader[1].ToString();
                        st.Coverage2 = reader[2].ToString();
                        st.Descriptions2 = reader[3].ToString();
                        st.launch2 = reader[4].ToString();
                        st.launch2 = st.launch2.Substring(0, st.launch2.Length - 7);
                        TV_channels.Add(st);
                    }
                    TV_channelDataGrid.ItemsSource = TV_channels;
                    TV_channelDataGrid.Columns[4].Visibility = Visibility.Hidden;
                    TV_channelDataGrid.Columns[5].Visibility = Visibility.Hidden;
                    TV_channelDataGrid.Columns[6].Visibility = Visibility.Hidden;
                    TV_channelDataGrid.Columns[7].Visibility = Visibility.Hidden;
                    Manager.connection.Close();
                }
                else
                {
                    MessageBox.Show("stop");
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show((error.Number).ToString() + " " + error.Message);
            }
        }

        private void Option_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                string Like = OptionTextBox.Text;
                string sqlExpression = "SELECT * From Opiration where Name Like '%" + Like + "%'";
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                List<Opiration> Opirations = new List<Opiration>();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Opiration st = new Opiration();
                        st.Name = reader[1].ToString();
                        st.Type = reader[2].ToString();
                        st.Coverage = reader[3].ToString();
                        st.Price = reader[4].ToString();
                        Opirations.Add(st);
                    }
                    OpirationDataGrid.ItemsSource = Opirations;
                    OpirationDataGrid.Columns[4].Visibility = Visibility.Hidden;
                    OpirationDataGrid.Columns[5].Visibility = Visibility.Hidden;
                    OpirationDataGrid.Columns[6].Visibility = Visibility.Hidden;
                    OpirationDataGrid.Columns[7].Visibility = Visibility.Hidden;
                    Manager.connection.Close();
                }
                else
                {
                }
                reader.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show((error.Number).ToString() + " " + error.Message);
            }
        }
    }
}
