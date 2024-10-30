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

namespace WpfApp1
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
            //string name = TextBox.Text; // Получаем текст из текстового поля
            //string surname = TextBoxtwo.Text;
            //MessageBox.Show("Привет, " + name + " " + surname + "!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Правильно! Зеленый — это результат смешения синего и желтого.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Неправильно. Попробуй снова!");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Неправильно. Попробуй снова!");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private int clickCount = 0;
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            clickCount++; // Увеличиваем счетчик на 1
            ClickCounterLabel.Content = "Кликов: " + clickCount; // Обновляем текст метки
        }
    }
}
