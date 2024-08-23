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

namespace PresentacionWpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hola");
            UserControl nuevo = new Forms.UcNuevoContacto();
            this.GrdMain.Children.Clear();
            this.GrdMain.Children.Add(nuevo);
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            UserControl listar = new Forms.UcVerContactos();
            this.GrdMain.Children.Clear();
            this.GrdMain.Children.Add(listar);
        }
    }
}
