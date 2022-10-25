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

namespace Pedra_Papel_e_Tesoura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contadorMeusPontos = 0;
        int contadorPC = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imgPapel.Visibility = Visibility.Visible;
            imgPedra.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;
            Adversario();
            vitoria();
            empate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            imgPapel.Visibility = Visibility.Hidden;
            imgPedra.Visibility = Visibility.Visible;
            imgTesoura.Visibility = Visibility.Hidden;
            Adversario();
            vitoria();
            empate();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            imgPapel.Visibility = Visibility.Hidden;
            imgPedra.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Visible;
            Adversario();
            vitoria();
            empate();
        }

        private void Adversario()
        {
            Random random = new Random();
            int pc = random.Next(0, 3);
            switch(pc)
            {
                case 0:
                    imgPapel2.Visibility = Visibility.Hidden;
                    imgPedra2.Visibility = Visibility.Hidden;
                    imgTesoura2.Visibility = Visibility.Visible;
                    break;

                case 1:
                    imgPapel2.Visibility = Visibility.Hidden;
                    imgPedra2.Visibility = Visibility.Visible;
                    imgTesoura2.Visibility = Visibility.Hidden;
                    break;

                case 2:
                    imgPapel2.Visibility = Visibility.Visible;
                    imgPedra2.Visibility = Visibility.Hidden;
                    imgTesoura2.Visibility = Visibility.Hidden;
                    break;

            }
        }

        private void vitoria()
        {
            if (imgPapel.Visibility == Visibility.Visible && imgPedra2.Visibility == Visibility.Visible)
            {
                contadorMeusPontos++;
                txtPlacar.Text = "Você venceu";
                txtPlacarVoce.Text = contadorMeusPontos.ToString();
            }
            else if (imgPedra.Visibility == Visibility.Visible && imgTesoura2.Visibility == Visibility.Visible)
            {
                contadorMeusPontos++;
                txtPlacar.Text = "Você venceu";
                txtPlacarVoce.Text = contadorMeusPontos.ToString();
            }
            else if (imgTesoura.Visibility == Visibility.Visible && imgPapel2.Visibility == Visibility.Visible)
            {
                contadorMeusPontos++;
                txtPlacar.Text = "Você venceu";
                txtPlacarVoce.Text = contadorMeusPontos.ToString();
            }
            else if (imgPapel2.Visibility == Visibility.Visible && imgPedra.Visibility == Visibility.Visible)
            {
                contadorPC++;
                txtPlacar.Text = "PC venceu";
                txtPlacarComputador.Text = contadorPC.ToString();
            }
            else if (imgPedra2.Visibility == Visibility.Visible && imgTesoura.Visibility == Visibility.Visible)
            {
                contadorPC++;
                txtPlacar.Text = "PC venceu";
                txtPlacarComputador.Text = contadorPC.ToString();
            }
            else if (imgTesoura2.Visibility == Visibility.Visible && imgPapel.Visibility == Visibility.Visible)
            {
                contadorPC++;
                txtPlacar.Text = "PC venceu";
                txtPlacarComputador.Text = contadorPC.ToString();
            }
        }

        private void empate()
        {
            if (imgPapel.Visibility == Visibility.Visible && imgPapel2.Visibility == Visibility.Visible)
            {
                txtPlacar.Text = "Deu empate";
            }
            else if (imgPedra.Visibility == Visibility.Visible && imgPedra2.Visibility == Visibility.Visible)
            {
                txtPlacar.Text = "Deu empate";
            }
            else if (imgTesoura.Visibility == Visibility.Visible && imgTesoura2.Visibility == Visibility.Visible)
            {
                txtPlacar.Text = "Deu empate";
            }
        }
    }
}
