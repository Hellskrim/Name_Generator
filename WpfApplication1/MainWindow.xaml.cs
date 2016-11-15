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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string Generuj()
        {
            Random rand = new Random();
            int n = int.Parse(comboBox.SelectionBoxItem.ToString());
            char[] tab= new char[n];
            string temp = "";
            for(int i = 0; i<tab.Length;i++)
            {
                if (i == 0)
                {
                    tab[i] = (char)rand.Next(65, 91);
                }
                if (i > 0)
                {
                    do
                        tab[i] = (char)rand.Next(97, 123);
                    while (tab[i - 1] == tab[i]);
                }
                temp += tab[i];
            }
            return temp;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = Generuj();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
