﻿using System;
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
using Logica;

namespace PresentacionWpf.Forms
{
    /// <summary>
    /// Lógica de interacción para UcVerContactos.xaml
    /// </summary>
    public partial class UcVerContactos : UserControl
    {
        ContactoBLL cbll;

        public UcVerContactos()
        {
            InitializeComponent();
            cbll = new ContactoBLL();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<Persona> contactos = cbll.Listar();
            if (contactos.Count == 0)
            {
                MessageBox.Show("No existen contactos para mostrar","Ver contactos",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                DgContactos.ItemsSource = contactos;
            }

            
        }
    }
}
