 using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string wygenerowaneHaslo = "Hasło nie zostało wygenerowane";

        

        public MainWindow()
        {
        }

        private string GenerujHaslo(int dlugosc, bool czyWielkieLitery, bool czyCyfry, bool czySpecjalne)
            {
            string maleLitery = "qwertyuiopasdfghjklzxcvbnm";
            string znakiSpecjalne = "!@#$%^&*()_+";
            string Wielkielitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string cyfry = "0123456789";

            Random random = new Random();
            char[] haslo = new char[dlugosc];
            for (int i = 0; i < dlugosc; i++)
            {
                haslo[i] = maleLitery[random.Next(maleLitery.Length)];

            }
            if (czyWielkieLitery && dlugosc > 1)
            {
                haslo[0] = Wielkielitery[random.Next(Wielkielitery.Length)];
            }
            if (czyCyfry && dlugosc > 2)
            {
                haslo[1] = cyfry(random.Next(cyfry.Length));
            }
            if (czySpecjalne && dlugosc > 3)
            {
                haslo[dlugosc - 1] = znakiSpecjalne[random.Next(znakiSpecjalne.Length)];
            }
            return new string(haslo);

        }

        private void generujHaslo_Click(int dlugosc, bool czyWielkieLitery, bool czyCyfry, bool czySpecjalne)
        {
           
        }
    }
}