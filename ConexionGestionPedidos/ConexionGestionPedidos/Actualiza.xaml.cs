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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {

        SqlConnection miConexionSql;

        private int z;

        public Actualiza(int elId)
        {
            InitializeComponent();

            z = elId;

            string miConexion = ConfigurationManager.ConnectionStrings
            ["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string consulta = "UPDATE cliente SET nombre=@nombre WHERE Id=" + z;

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);
                
                miSqlCommand.ExecuteNonQuery();

                miConexionSql.Close();

            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.ToString());
            }
        }
    }
}
