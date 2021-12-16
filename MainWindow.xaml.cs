using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace wpfEmail
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



        private void Source_Loaded(object sender, RoutedEventArgs e)
        {
            // verification que le dossier source existe et creation du dossier si il n'existe pas
            if (!Directory.Exists(@"c:\source\"))
            {
                _ = Directory.CreateDirectory(@"c:\source\");
            }

            // récupération d'une tableau contenant tout les fichiers du dossier source
            string[] filePaths = Directory.GetFiles(@"c:\source\", "*.eml");

            // ajout des fichiers dans un combobox
            foreach (string file in filePaths)
            {
                _ = source.Items.Add(file);
            }
        }

        private void Source_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // récuperation du fichier a analyser
            var nameEml = source.SelectedItem.ToString();
           
            // afficher le corps
            var message = CdoWrapper.LoadMessage(nameEml);
            subject.Text = message.Subject;
            textBody.Text = message.TextBodyPart.GetString();


        }
    }    
}
