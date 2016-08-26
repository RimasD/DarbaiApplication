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

namespace DarbaiApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DarbuAtlikimas> atlikimas;
        int k;
        int kk;
        int sk = 0;

        public MainWindow()
        {

            InitializeComponent();
            atlikimas = new List<DarbuAtlikimas>();

            updateList();
        }

        void updateList()
        {
            listDarbai.Items.Clear();
            foreach (DarbuAtlikimas a in atlikimas)
            {
                listDarbai.Items.Add(a.sk + "  -  " + a.darb + "  :    " + a.atl);
            }


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string darb;
            string atl;

            darb = Convert.ToString(textDarbai.Text);
            atl = Convert.ToString(textAtlikimas.Text);
            sk++;
            atlikimas.Add(new DarbuAtlikimas(sk, darb, atl));

            foreach (DarbuAtlikimas a in atlikimas)
            {


                listDarbai.Items.Add(a.sk + "  -  " + a.darb + "   :    " + a.atl);

            }
            if (atl == "+")
            {
                k++;
            }
            if (atl == "-")
            {
                kk++;
            }


            labelNe.Content = kk;
            labelAtlikti.Content = k;
          updateList();
          
        }

        private void listDarbai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listDarbai_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            textEdit.Text = Convert.ToString(listDarbai.SelectedIndex);
            int nr = listDarbai.SelectedIndex;
            atlikimas[nr].atl = " + ";
           
        
            labelNe.Content = kk-1;
           
            updateList();JournalEntry
           

        }
    }
}
