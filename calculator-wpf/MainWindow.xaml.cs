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

namespace CalculatorWpf
{
    /// <summary>
    /// Класс для реализации логики взаимодействия для окном MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Метод для работы с окном.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement element in MainRoot.Children)
            {
                if (element is Button button)
                {
                    button.Click += ButtonClick;
                }
            }
        }

        /// <summary>
        /// Метод для обработки события нажатия на кнопку калькулятора.
        /// </summary>
        /// <param name="sender">Объект, который вызвал данное событие.</param>
        /// <param name="e">Информация о данном событии.</param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var str = (string) ((Button) e.OriginalSource).Content;
            textLabel.Text = str;
        }
    }
}
