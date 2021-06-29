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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"PC\SQLEXPRESS";       // сервер
                builder.InitialCatalog = "Shvetso_Sasha";         // название БД
                builder.IntegratedSecurity = true;     // проверка подлинности                
                Manager.connection = new SqlConnection(builder.ConnectionString);
            }
            catch (SqlException e)
            {
                MessageBox.Show((e.Number).ToString() + " " + e.Message);
            }
            MainFrame.Navigate(new FirstPage());
            Manager.MainFrame = MainFrame;

        }
    }
}
