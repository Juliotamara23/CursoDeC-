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
            MuestraTodosPedidos();
        }

        private void MuestraClientes()
        {

            try
            {
                string consulta = "SELECT * FROM cliente";

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
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraPedidos()
        {
            try
            {
                string consulta = "SELECT * FROM Pedido p INNER JOIN cliente c ON c.ID=p.cCliente " +
            "WHERE C.ID=@ClienteId";

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
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "SELECT *, CONCAT (CCliente, ' ', fechaPedido, ' ', formaPago) AS InfoCompleta FROM pedido ";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable pedidosTabla = new DataTable();
                    miAdaptadorSql.Fill(pedidosTabla);

                    todosPedidos.DisplayMemberPath = "InfoCompleta";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTabla.DefaultView;
                }
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString());  
            }
        }

        SqlConnection miConexionSql;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());

            string consulta = "DELETE FROM pedido WHERE ID = @PedidoId";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@PedidoId", todosPedidos.SelectedValue);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraTodosPedidos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO cliente (nombre) VALUES (@nombre)";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();

            insertaCliente.Text = "";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM cliente WHERE ID = @ClienteId";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();
        }
        
        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)listaClientes.SelectedValue);


            try
            {
                string consulta = "SELECT nombre FROM cliente WHERE Id=@ClId";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlCommand);

                using (miAdaptadorSql)
                {
                    miSqlCommand.Parameters.AddWithValue("@ClId", listaClientes.SelectedValue);
                    
                    DataTable clienteTabla= new DataTable();

                    miAdaptadorSql.Fill(clienteTabla);

                    ventanaActualizar.cuadroActualiza.Text = clienteTabla.Rows[0]["nombre"].ToString();
                }
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.ToString());
            }

            ventanaActualizar.ShowDialog();

            MuestraClientes();
        }
    }
}
