using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ComandosYMenus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TextBlock> listaDeTextBox;

        TextBlock hijoCopiado;
        public MainWindow()
        {
          listaDeTextBox = new ObservableCollection<TextBlock>();

            InitializeComponent();

            ListaDeHorasListBox.DataContext = listaDeTextBox;
        }

        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBlock hijo = new TextBlock();
            hijo.Text = "Item añadido a las " + DateTime.Now.ToLongTimeString();
            listaDeTextBox.Add(hijo);
        }

        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listaDeTextBox.Count < 10)
            {
                e.CanExecute = true;
            }
            else {
                e.CanExecute = false;
            }
        }

        private void CopyCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            hijoCopiado = (TextBlock)ListaDeHorasListBox.SelectedItem;
            
        }

        private void CopyCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listaDeTextBox.Count > 0 && ListaDeHorasListBox.SelectedItem != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }


        private void PasteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            TextBlock aux = new TextBlock();

            aux.Text = hijoCopiado.Text;
            listaDeTextBox.Add(aux);

            hijoCopiado = null;
        }

        private void PasteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (hijoCopiado != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void VaciarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            listaDeTextBox.Clear();
        }

        private void VaciarCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listaDeTextBox.Count > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void ExitCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void ExitCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
