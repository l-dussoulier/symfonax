using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Symfony
{
    public partial class MainPage : ContentPage
    {
        public List<RecupListeUser> resultatWeb;
        public List<Materiel> listeMat;
        public MainPage()
        {
            listeMat = new List<Materiel>();
            InitializeComponent();
            Recuperation();
            CreationLabel();



        }



        public void Recuperation()
        {
            var ser = new ServicesWeb();

            Task<List<RecupListeUser>> listeTask = ser.GetInfosAsync();

            listeTask.ContinueWith(tache =>
            {
                List<RecupListeUser> resultat = tache?.Result;
                // traitement
                resultatWeb = resultat;
                Debug.WriteLine(Layout.Children.LongCount());
                foreach (RecupListeUser u in resultat) // permet de remettre ensemble les elements dans l'objet
                {
                    Debug.WriteLine("ID :  " + u.id);
                    Debug.WriteLine("Catégorie : " + u.categorie);
                    Debug.WriteLine("Marque : " + u.marque);
                    Debug.WriteLine("Description : " + u.description);
                    Debug.WriteLine("Etat : " + u.etat);
                    Debug.WriteLine(" ");

                    Debug.WriteLine("ID :  " + u.id);
                    Debug.WriteLine("Catégorie : " + u.categorie);
                    Debug.WriteLine("Marque : " + u.marque);
                    Debug.WriteLine("Description : " + u.description);
                    Debug.WriteLine("Etat : " + u.etat);
                    Debug.WriteLine(" ");

                    var Mat = new Materiel();
                    Mat.Id = u.id;
                    Mat.Categorie = u.categorie;
                    Mat.Marque = u.marque;
                    Mat.Description = u.description;
                    Mat.Etat = u.etat;

                    listeMat.Add(Mat);



                }            

            });
            Debug.WriteLine(listeMat.LongCount());
             foreach (Materiel e in listeMat)
                { 
                    var labelllll = new Label { Text = "prout"};
                    Layout.Children.Add(labelllll);
                    Debug.WriteLine(Layout.Children.LongCount());
                }


        }

        public void CreationLabel()
        {

           
            //foreach (RecupListeUser u in resultatWeb)
            //{

            //}
        }



    }
}
