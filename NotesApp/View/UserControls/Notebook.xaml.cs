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

namespace NotesApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for Notebook.xaml
    /// </summary>
    public partial class Notebook : UserControl
    {
        public Model.Notebook DisplayNotebook
        {
            get { return (Model.Notebook)GetValue(notebookProperty); }
            set { SetValue(notebookProperty, value); }
        }

        // Using a DependencyProperty as the backing store for notebook.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty notebookProperty =
            DependencyProperty.Register("DisplayNotebook", typeof(Model.Notebook), typeof(Notebook), new PropertyMetadata(null, SetValues));

        private static void SetValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Notebook notebook = d as Notebook;

            if(notebook != null)
            {
                notebook.notebookNameTextBlock.Text = (e.NewValue as Model.Notebook).Name;
            }
        }

        public Notebook()
        {
            InitializeComponent();
        }
    }
}
