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
using Negocio;

namespace Presentacion.Forms
{
    /// <summary>
    /// Lógica de interacción para UcCategoria.xaml
    /// </summary>
    public partial class UcCategoria : UserControl
    {

        CategoriaBLL catBll = new CategoriaBLL();
        public UcCategoria()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //recuperando dato del formulario
                string nombre = TxtNombre.Text.Trim();
                catBll.Add(nombre);

                MessageBox.Show("Categoria Agregada", "Nueva Categoría", MessageBoxButton.OK, MessageBoxImage.Information);
                TxtNombre.Text = string.Empty;
            }catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Nueva Categoría", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
