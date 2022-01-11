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

namespace DZ5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class Aeroflot
    {
        public int flight;
        public string destination;
        public int tickets;


        public Aeroflot()
        {
            flight = 0;
            destination = "";
            tickets = 0;

        }

        public void add(int a, string b, int c)
        {
            flight = a;
            destination = b;
            tickets = c;
        }


    }
    public partial class MainWindow : Window
    {
        int N = 0;
        Aeroflot[] info = new Aeroflot[40];
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                info[i] = new Aeroflot();
            }
            info[0].add(232, "Москва", 40);
            info[1].add(67, " Киров", 1);
            info[2].add(345, "Елец", 133);
            info[3].add(678, "Липецк", 6);
            info[4].add(234, "Тамбов", 89);
            info[5].add(765, "Ярославль", 222);
            info[6].add(68, " Омск", 60);
            info[7].add(56, " Новокузнецк", 34);
            info[8].add(45, " Воронеж", 11);
            info[9].add(70, " Казань", 5);
        }

        private void infoall_Click(object sender, RoutedEventArgs e)
        {
            infoall.Text = "";
            for (int i = 0; i < 10; i++) {
                infoall.Text +="Номер рейса: "+ String.Format(" {0} ", info[i].flight) +"место назначения: "+ info[i].destination +" осталось билетов: "+ String.Format(" {0} ", info[i].tickets) + "\n";
                    }
        }

        private void bron_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                broninfo.Content = "";
                int vvod = Convert.ToInt32(addbron.Text);
                int n = -1;
                for (int i = 0; i < 10; i++)
                {
                    if (vvod == info[i].flight)
                    {
                        n = i;
                        if (info[n].tickets == 0)
                        {
                            broninfo.Content = "билетов не осталось";
                        }
                        else
                        {
                            info[n].tickets--;
                            broninfo.Content += "вы забронировали билет на рейс номер: " + info[n].flight;
                        }
                        break;
                    }
                }
                if (n == -1)
                {
                    broninfo.Content += "нет рейса с таким номером";
                }
            }
            catch 
            {
                broninfo.Content += "вводите целые числа";
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int f = 0;
                ticketinfo.Content = "";
                for (int i = 0; i < 10; i++)
                {
                    if (addticket.Text == info[i].destination)
                    {
                        ticketinfo.Content += "Осталось билетов:" + info[i].tickets;
                        f = 1;
                    }
                }
                if (f == 0)
                {
                    ticketinfo.Content += "нет такого рейса";
                }
            }
            catch
            {
                ticketinfo.Content += "вводите слова на кириллице";
            }
        }


    }
}
