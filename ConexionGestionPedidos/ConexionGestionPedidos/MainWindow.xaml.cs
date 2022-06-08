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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings
                ["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();
        }

        private void MuestraClientes()
        {
            string consulta = "Select * from cliente";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable clienteTabla = new DataTable();

                miAdaptadorSql.Fill(clienteTabla);

                listaClientes.DisplayMemberPath = "nombre";
                listaClientes.SelectedValuePath = "Id";
                listaClientes.ItemsSource = clienteTabla.DefaultView;

            }
        }

        private void MuestraPedidos()
        {
            string consulta = "Select * from Pedido p inner join cliente c on c.ID=p.cCliente " +
                "where C.ID=@ClienteId";

            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

            using (miAdaptadorSql)
            {

                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                DataTable pedidosTabla = new DataTable();

                miAdaptadorSql.Fill(pedidosTabla);

                pedidosCliente.DisplayMemberPath = "fechaPedido";
                pedidosCliente.SelectedValuePath = "Id";
                pedidosCliente.ItemsSource = pedidosTabla.DefaultView;

            }
        }

        SqlConnection miConexionSql;

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");
            MuestraPedidos();
        }
    }
}
