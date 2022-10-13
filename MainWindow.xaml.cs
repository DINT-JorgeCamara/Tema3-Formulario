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

namespace Tema3_Formulario
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

        private void RatonEncima(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image info = (Image)sender;
            if(info.Tag.ToString() == "nombre")
            {
                info.ToolTip = "Máximo 100 caracteres";
            }
            else if(info.Tag.ToString() == "edad")
            {
                info.ToolTip = "Número entre 0 y 100";
            }
            else
            {
                info.ToolTip = "Incluir el código postal";
            }
        }
    }
}
