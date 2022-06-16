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

namespace test_C
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<char> Bracket_List = new List<char>();
            foreach (char NextChar in TB_test.Text)
            {
                switch (NextChar)
                {
                    case '{':
                        Bracket_List.Add(NextChar);
                        break;
                    case '(':
                        Bracket_List.Add(NextChar);
                        break;
                    case '[':
                        Bracket_List.Add(NextChar);
                        break;

                    case '}':
                        if (Bracket_List.Count != 0 && Bracket_List[Bracket_List.Count - 1] == '{') Bracket_List.RemoveAt(Bracket_List.Count - 1);
                        else Bracket_List.Add(NextChar);
                        break;
                    case ')':
                        if (Bracket_List.Count != 0 && Bracket_List[Bracket_List.Count - 1] == '(') Bracket_List.RemoveAt(Bracket_List.Count - 1);
                        else Bracket_List.Add(NextChar);
                        break;
                    case ']':
                        if (Bracket_List.Count != 0 && Bracket_List[Bracket_List.Count - 1] == '[') Bracket_List.RemoveAt(Bracket_List.Count - 1);
                        else Bracket_List.Add(NextChar);
                        break;
                }
            }

            if (Bracket_List.Count == 0)
            {
                Label_test.Content = "Все скобки в списке закрыты!";
                Label_test.Foreground = Brushes.Green;
            }
            else
            {
                Label_test.Content = "В списке имеются незакрытые скобки!";
                Label_test.Foreground = Brushes.Red;
            }
        }
    }
}
