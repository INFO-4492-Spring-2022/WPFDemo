using System;
using System.Collections.Generic;
using System.IO;
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


namespace WPFDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        string[,] checkColors;


        public MainWindow() {
            InitializeComponent();
            fillColors();
        }

        private void fillColors() {
            checkColors = new string[,] {
                {"0" ,"Red"},
                {"1" ,"Blue"},
                {"2" ,"Green"},
                {"3" ,"Yellow"},
                {"4" ,"Gray"},
                {"5" ,"Purple"},
                {"6" ,"Brown"},
                {"7" ,"Black"},
                {"8" ,"Pink"},
                {"9" ,"Olive"},
                {"10" ,"Lavender"},
                {"11" ,"Khaki"}
            };
        }

        private void btnGo_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("Hello You clicked Go");
            string yourName = txtName.Text;
            tbOutput.Text = "Go " + yourName;
            bool thing = false; // true || false || null

            if (thing) {
                MessageBox.Show("It was true");
            } else {
                MessageBox.Show("It was false");
            }

            if (chkHasCookie.IsChecked == true) {
                tbOutput.Text += " has a cookie";
            } else if (chkHasCookie.IsChecked == false) {
                tbOutput.Text += " has NO cookie";
            } else { // null
                tbOutput.Text += " might have a cookie";
            }


        }

        private void btnStop_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show("You clicked Stop");
            string yourName = txtName.Text;
            tbOutput.Text = "STOP " + yourName + "!";
        }

        private void btnHighLightCheck_Click(object sender, RoutedEventArgs e) {
            string btnNumber = txtCheckNumber.Text;
            //MessageBox.Show(btnNumber);

            //chkHasCookie_#  (# 0-11)

            CheckBox chk = (CheckBox)this.FindName("chkHasCookie_" + btnNumber);

            //MessageBox.Show(chk.ToString());
            if (chk != null) {
                //chk.Background = new SolidColorBrush(Colors.Yellow);
                string colorName;
                for (int ndx = 0; ndx < 12; ndx++) {
                    if (btnNumber == checkColors[ndx, 0]) {
                        colorName = checkColors[ndx, 1];
                        //MessageBox.Show(colorName);
                        Color ourColor = (Color)ColorConverter.ConvertFromString(colorName);
                        chk.Background = new SolidColorBrush(ourColor);
                    }
                }


            }

        }

        private void btnReadText_Click(object sender, RoutedEventArgs e) {

            //string alllines = File.ReadAllText("data.txt");
            //MessageBox.Show(alllines);

            string[] lines = File.ReadAllLines("data.txt");
            tbOutput.Text = "";
            for (int ndx = 0; ndx < lines.Length; ndx++) {
                //MessageBox.Show(lines[ndx]);
                string lineOfText = lines[ndx];
                tbOutput.Text += lineOfText[1];
            }

            

        }
    }
}
