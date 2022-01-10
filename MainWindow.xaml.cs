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
            var message = CdoWrapper.LoadMessage(nameEml);

            // afficher le corps
            to.Text = "De :" + message.To;
            from.Text = "A :" + message.From;
            subject.Text = "Sujet :" + message.Subject;
            textBody.Text = "Message : \n"+message.TextBodyPart.GetString();
          

            if (message.ReceivedTime.ToString() != "30/12/1899 00:00:00")
            {
                date.Text = "Envoyé le "+message.ReceivedTime.ToString();
            }
            else
            {
                date.Text = "Date d'envoi inconnue";
            }

            //pièce jointe

           if (message.Attachments.Count > 0)
            {
                for (int i = 1; i < message.Attachments.Count + 1; i++)
                {
                    files.Text += "Pièce(s) jointe(s)"+i+" \n nom :"+
                        message.Attachments[i].FileName +" "+ 
                        message.Attachments[i].ContentMediaType+ ", poids:" + 
                       (message.Attachments[i].GetDecodedContentStream().Size /1000)+" Ko \n";
                }
            }
            else
            {
                files.Text = "Pièce(s) jointe(s): 0";
            }
        }
    }    
}
