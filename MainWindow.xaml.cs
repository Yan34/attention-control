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
using Tobii.Interaction;

namespace attention_control
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float leftUpX, leftUpY, rightDownX, rightDownY;

        public float tmp_leftUpX, tmp_leftUpY, tmp_rightDownX, tmp_rightDownY;

        private bool isEnabled;

        public MainWindow()
        {
            InitializeComponent();
            isEnabled = false;
            leftUpX = -1; leftUpY = -1; rightDownX = -1; rightDownY = -1;
            labelAlert.Visibility = Visibility.Hidden;
        }

        private void btnManualCoords_Click(object sender, RoutedEventArgs e)
        {
            //если координаты введены верно
                //задать координаты
            //иначе
                //сообщить, что координаты введены неверно
        }

        private void btnStartStop_Click(object sender, RoutedEventArgs e)
        {
            //если отслеживание не запущено
                //если координаты не заданы
                    //сообщить, что координаты не заданы
                //иначе
                    //начать отслеживание взгляда...
            //иначе
                //прекратить отслеживание взгляда...
        }
    }
}
