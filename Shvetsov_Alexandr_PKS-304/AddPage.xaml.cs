using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Shvetsov_Alexandr_PKS_304
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void AddOpiration_Button_Click(object sender, RoutedEventArgs e)
        {
            int error = 0;
            int ID_Operation = 0;
            Manager.connection.Close();
            Manager.connection.Open();
            string sqlExpression = "SELECT ID_Operation FROM Opiration";
            SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (ID_Operation < Convert.ToInt32(reader[0].ToString()))
                    {
                        ID_Operation = Convert.ToInt32(reader[0].ToString());
                    }
                    else { }
                }
                ID_Operation++;
            }
            reader.Close();
            Manager.connection.Close();

                sqlExpression = "INSERT INTO Opiration (ID_Operation,Name,Type,Coverage,Price) " +
                    "VALUES (@ID_Operation, @Name, @Type, @Coverage, @Price)";
                try
                {
                    Manager.connection.Close();
                    Manager.connection.Open();
                    command = new SqlCommand(sqlExpression, Manager.connection);
                    SqlParameter CodeBookParam = new SqlParameter("@ID_Operation", ID_Operation);
                    command.Parameters.Add(CodeBookParam);
                    SqlParameter PhotosParam = new SqlParameter("@Name", NameTextBox.Text);
                    command.Parameters.Add(PhotosParam);
                    SqlParameter NameBookParam = new SqlParameter("@Type", TypeTextBox.Text);
                    command.Parameters.Add(NameBookParam);
                    SqlParameter NameAvtorParam = new SqlParameter("@Coverage", CoverTextBox.Text);
                    command.Parameters.Add(NameAvtorParam);
                    SqlParameter SurnameAvtorParam = new SqlParameter("@Price", float.Parse(PriceTextBox.Text));
                    command.Parameters.Add(SurnameAvtorParam);
                    command.ExecuteNonQuery();
                    reader.Close();
                Manager.connection.Close();
                MessageBox.Show("Данный добавленны");
                }
                catch (SqlException Error)
                {
                    MessageBox.Show(Error.Message);
                }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void AddTV_channel_Button_Click(object sender, RoutedEventArgs e)
        {
            int error = 0;
            int ID_TV = 0;
            Manager.connection.Close();
            Manager.connection.Open();
            string sqlExpression = "SELECT ID_TV FROM TV_channel";
            SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (ID_TV < Convert.ToInt32(reader[0].ToString()))
                    {
                        ID_TV = Convert.ToInt32(reader[0].ToString());
                    }
                    else { }
                }
                ID_TV++;
            }
            reader.Close();
            Manager.connection.Close();

            sqlExpression = "INSERT INTO TV_channel (ID_TV, Name, Coverage, Descriptions, launch) " +
                "VALUES (@ID_TV, @Name, @Coverage, @Descriptions, @launch)";
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                command = new SqlCommand(sqlExpression, Manager.connection);
                SqlParameter CodeBookParam = new SqlParameter("@ID_TV", ID_TV);
                command.Parameters.Add(CodeBookParam);
                SqlParameter PhotosParam = new SqlParameter("@Name", NameID_TVTextBox.Text);
                command.Parameters.Add(PhotosParam);
                SqlParameter NameBookParam = new SqlParameter("@Coverage", CoverageID_TVTextBox.Text);
                command.Parameters.Add(NameBookParam);
                SqlParameter NameAvtorParam = new SqlParameter("@Descriptions", DescriptionsTextBox.Text);
                command.Parameters.Add(NameAvtorParam);
                SqlParameter SurnameAvtorParam = new SqlParameter("@launch", LaunchTextBox.Text);
                command.Parameters.Add(SurnameAvtorParam);
                command.ExecuteNonQuery();
                reader.Close();
                Manager.connection.Close();
                MessageBox.Show("Данный добавленны");
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void AddUnion_Button_Click(object sender, RoutedEventArgs e)
        {

            string sqlExpression = "INSERT INTO [Union] (ID_TV, ID_Operation) " +
                "VALUES (@ID_TV, @ID_Operation)";
            try
            {
                Manager.connection.Close();
                Manager.connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, Manager.connection);
                SqlParameter CodeBookParam = new SqlParameter("@ID_TV", ID_TVKopiratorTextBox.Text);
                command.Parameters.Add(CodeBookParam);
                SqlParameter PhotosParam = new SqlParameter("@ID_Operation", IDKopiratorTextBox.Text);
                command.Parameters.Add(PhotosParam);
                command.ExecuteNonQuery();
                Manager.connection.Close();
                MessageBox.Show("Данный добавленны");
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
