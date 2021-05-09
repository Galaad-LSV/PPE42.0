using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PPE4.Models;
using PPE4.Services;
using Xamarin.Forms;

namespace PPE4.VuesModeles
{
    public class AuthentificationVueModele : BaseVueModele
    {
        #region Attributs
        private string _identifiant;
        private string _motDePasse;
        #endregion
        #region Constructeurs
        public AuthentificationVueModele()
        {
            CommandeButtonLogIn = new Command(ActionPage);
        }
        #endregion
        #region Getters/Setters
        public ICommand CommandeButtonLogIn { get; }
        public string Identifiant
        {
            get
            {
                return _identifiant;
            }
            set
            {
                if (_identifiant != value)
                {
                    _identifiant = value;
                    OnPropertyChanged(nameof(Identifiant));
                }
            }
        }
        public string MotDePasse
        {
            get
            {
                return _motDePasse;
            }
            set
            {
                if (_motDePasse != value)
                {
                    _motDePasse = value;
                    OnPropertyChanged(nameof(MotDePasse));
                }
            }
        }
        #endregion
        #region Methodes


        public void ActionPage()
        {
            if (Utilisateur.CollClasse.FindAll(x => x.Nom == Identifiant).Exists(x => x.Mdp == MotDePasse)) Application.Current.MainPage = new NavigationPage(new ListingPage());
        }
        #endregion
    }
}
