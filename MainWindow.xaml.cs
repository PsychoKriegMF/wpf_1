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

namespace wpf_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
             * -FontFamily -  семейство шрифта(Arial и т.д.)Название шрифта указывается полностью и с соблюдением регистра
             * -FontSize - размер шрифта
             * -FontStyle - наклон шрифта(Normal, italic, Oblique)
             * -FontWeight - толщина шрифта(Black, Bold)
             * -TextDecorations - линию для текста(Baseline и Underline - подчеркивание, Overline - надчеркивание, Strikethrought - зачеркивание)
             */
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string text = "Hello";
            if(text != "")
            {
                MessageBox.Show(text);
            }
        }

        
    }
}