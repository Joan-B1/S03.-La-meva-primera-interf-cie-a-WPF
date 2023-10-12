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

namespace S05_Events_i_Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> wpf c# Crear solo el xaml utilitzant events i grid un taulell d escacs 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Button botonClickeado = (Button)sender;
            string nombreBoton = botonClickeado.Name;

            switch (nombreBoton)
            {
                case "A_8":
                    MessageBox.Show("Estás en la posición A_8");
                    break;
                case "B_8":
                    MessageBox.Show("Estás en la posición B_8");
                    break;

                case "A_7":
                    MessageBox.Show("Estás en la posición A_7");
                    break;
                case "B_7":
                    MessageBox.Show("Estás en la posición B_7");
                    break;

                case "A_6":
                    MessageBox.Show("Estás en la posición A_6");
                    break;
                case "B_6":
                    MessageBox.Show("Estás en la posición B_6");
                    break;

                case "A_5":
                    MessageBox.Show("Estás en la posición A_5");
                    break;
                case "B_5":
                    MessageBox.Show("Estás en la posición B_5");
                    break;

                case "A_4":
                    MessageBox.Show("Estás en la posición A_4");
                    break;
                case "B_4":
                    MessageBox.Show("Estás en la posición B_4");
                    break;

                case "A_3":
                    MessageBox.Show("Estás en la posición A_3");
                    break;
                case "B_3":
                    MessageBox.Show("Estás en la posición B_3");
                    break;

                case "A_2":
                    MessageBox.Show("Estás en la posición A_2");
                    break;
                case "B_2":
                    MessageBox.Show("Estás en la posición B_2");
                    break;

                case "A_1":
                    MessageBox.Show("Estás en la posición A_1");
                    break;
                case "B_1":
                    MessageBox.Show("Estás en la posición B_1");
                    break;

                case "C_8":
                    MessageBox.Show("Estás en la posición C_8");
                    break;
                case "D_8":
                    MessageBox.Show("Estás en la posición D_8");
                    break;

                case "C_7":
                    MessageBox.Show("Estás en la posición C_7");
                    break;
                case "D_7":
                    MessageBox.Show("Estás en la posición D_7");
                    break;

                case "C_6":
                    MessageBox.Show("Estás en la posición C_6");
                    break;
                case "D_6":
                    MessageBox.Show("Estás en la posición D_6");
                    break;

                case "C_5":
                    MessageBox.Show("Estás en la posición C_5");
                    break;
                case "D_5":
                    MessageBox.Show("Estás en la posición D_5");
                    break;

                case "C_4":
                    MessageBox.Show("Estás en la posición C_4");
                    break;
                case "D_4":
                    MessageBox.Show("Estás en la posición D_4");
                    break;

                case "C_3":
                    MessageBox.Show("Estás en la posición C_3");
                    break;
                case "D_3":
                    MessageBox.Show("Estás en la posición D_3");
                    break;

                case "C_2":
                    MessageBox.Show("Estás en la posición C_2");
                    break;
                case "D_2":
                    MessageBox.Show("Estás en la posición D_2");
                    break;

                case "C_1":
                    MessageBox.Show("Estás en la posición C_1");
                    break;
                case "D_1":
                    MessageBox.Show("Estás en la posición D_1");
                    break;

                case "E_8":
                    MessageBox.Show("Estás en la posición E_8");
                    break;
                case "F_8":
                    MessageBox.Show("Estás en la posición F_8");
                    break;

                case "E_7":
                    MessageBox.Show("Estás en la posición E_7");
                    break;
                case "F_7":
                    MessageBox.Show("Estás en la posición F_7");
                    break;

                case "E_6":
                    MessageBox.Show("Estás en la posición E_6");
                    break;
                case "F_6":
                    MessageBox.Show("Estás en la posición F_6");
                    break;

                case "E_5":
                    MessageBox.Show("Estás en la posición E_5");
                    break;
                case "F_5":
                    MessageBox.Show("Estás en la posición F_5");
                    break;

                case "E_4":
                    MessageBox.Show("Estás en la posición E_4");
                    break;
                case "F_4":
                    MessageBox.Show("Estás en la posición F_4");
                    break;

                case "E_3":
                    MessageBox.Show("Estás en la posición E_3");
                    break;
                case "F_3":
                    MessageBox.Show("Estás en la posición F_3");
                    break;

                case "E_2":
                    MessageBox.Show("Estás en la posición E_2");
                    break;
                case "F_2":
                    MessageBox.Show("Estás en la posición F_2");
                    break;

                case "E_1":
                    MessageBox.Show("Estás en la posición E_1");
                    break;
                case "F_1":
                    MessageBox.Show("Estás en la posición F_1");
                    break;

                case "G_8":
                    MessageBox.Show("Estás en la posición G_8");
                    break;
                case "H_8":
                    MessageBox.Show("Estás en la posición H_8");
                    break;

                case "G_7":
                    MessageBox.Show("Estás en la posición G_7");
                    break;
                case "H_7":
                    MessageBox.Show("Estás en la posición H_7");
                    break;

                case "G_6":
                    MessageBox.Show("Estás en la posición G_6");
                    break;
                case "H_6":
                    MessageBox.Show("Estás en la posición H_6");
                    break;

                case "G_5":
                    MessageBox.Show("Estás en la posición G_5");
                    break;
                case "H_5":
                    MessageBox.Show("Estás en la posición H_5");
                    break;

                case "G_4":
                    MessageBox.Show("Estás en la posición G_4");
                    break;
                case "H_4":
                    MessageBox.Show("Estás en la posición H_4");
                    break;

                case "G_3":
                    MessageBox.Show("Estás en la posición G_3");
                    break;
                case "H_3":
                    MessageBox.Show("Estás en la posición H_3");
                    break;

                case "G_2":
                    MessageBox.Show("Estás en la posición G_2");
                    break;
                case "H_2":
                    MessageBox.Show("Estás en la posición H_2");
                    break;

                case "G_1":
                    MessageBox.Show("Estás en la posición G_1");
                    break;
                case "H_1":
                    MessageBox.Show("Estás en la posición H_1");
                    break;

                default:
                    MessageBox.Show("Posición no reconocida");
                    break;
            }



        }
    }
    }

