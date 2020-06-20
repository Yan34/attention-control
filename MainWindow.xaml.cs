using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //если в поля координат введены неотрицательные целые числа
            if (Regex.IsMatch(boxX1.Text, "^\\d+") && Regex.IsMatch(boxX2.Text, "^\\d+") && Regex.IsMatch(boxY1.Text, "^\\d+") && Regex.IsMatch(boxY2.Text, "^\\d+"))
            {
                tmp_leftUpX = Convert.ToInt32(boxX1.Text); tmp_leftUpY = Convert.ToInt32(boxY1.Text); tmp_rightDownX = Convert.ToInt32(boxX2.Text); tmp_rightDownY = Convert.ToInt32(boxY2.Text);
                //если координаты введены верно
                if (!(tmp_leftUpX >= tmp_rightDownX || tmp_leftUpY >= tmp_rightDownY))
                {
                    //задать координаты
                    leftUpX = tmp_leftUpX; leftUpY = tmp_leftUpY; rightDownX = tmp_rightDownX; rightDownY = tmp_rightDownY;
                    labelAreaCoordinates.Text = "Установлены координаты:\nX1 = " + leftUpX + "\nY1 = " + leftUpY + "\nX2 = " + rightDownX + "\nY2 = " + rightDownY;
                }
            }
            //иначе
            else
            {
                //сообщить, что координаты введены неверно
                labelAreaCoordinates.Text = "Координаты введены неверно";
                leftUpX = -1; leftUpY = -1; rightDownX = -1; rightDownY = -1;
            }
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
