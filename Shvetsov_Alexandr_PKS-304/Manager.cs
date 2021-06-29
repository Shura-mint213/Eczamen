using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace Shvetsov_Alexandr_PKS_304
{
    class Manager
    {
        public static SqlConnection connection { get; set; }
        public static Frame MainFrame { get; set; }
    }
}
