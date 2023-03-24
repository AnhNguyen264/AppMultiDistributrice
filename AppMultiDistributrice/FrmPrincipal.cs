using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppMultiDistributrice
{
    ///==============================================================================
    /// <summary>
    /// Simule plusieurs machines distributrices qui contiennent différentes breuvages.
    /// </summary>
    /// =============================================================================
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        //=====================================================
        //  CHAMP:  Variable  membre de la classe FrmPrincipal
        //-----------------------------------------------------
        private Distributrice m_objMachineCourante;
        private List<Distributrice> m_colDistributrices ;
        private string[] m_tabNomsMachines = { "Cafétéria", "Café étudiant", "Entrée principale", 
                                               "Gymnase", "Centre sportif" , "Syndicat"};

        //=====================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //------------------------------------------------------------------------------
            // TODO 01 : Instancier la collection de machines et la remplir
            //          à l'aide des infos fournies dans le tableau des noms de machines.
            //          On suppose que chaque machine sera chargée à la quantité maximale.
            //------------------------------------------------------------------------------
         
           m_colDistributrices = new List<Distributrice>();
          
            for(int index=0; index<m_tabNomsMachines.Length; index++) { 
               Distributrice objDist = new Distributrice(m_tabNomsMachines[index]);
                m_colDistributrices.Add(objDist);
            }
          


        }
        //==============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// =================================================================================
        /// <summary>
        /// Affiche les informations dans la section "Infos sur la machine".
        /// </summary>
        /// =================================================================================
        private void AfficherInfosMachine()
        {
            // --> Allez chercher le code que vous avez fait à l'exercice --> une distributrice
            txtNbCokes.Text = m_objMachineCourante.Quantite(SorteBreuvage.Coke).ToString();
            txtNb7Up.Text = m_objMachineCourante.Quantite(SorteBreuvage.SevenUp).ToString();
            txtNbJusDePommes.Text = m_objMachineCourante.Quantite(SorteBreuvage.JusDePommes).ToString();
            txtNbTheGlace.Text = m_objMachineCourante.Quantite(SorteBreuvage.TheGlace).ToString();
            txtEtat.Text = m_objMachineCourante.QuantiteTotale.ToString();


        }
        //==============================================================================
        /// <summary>
        ///   Activer ou désactiver les boutons correspondant aux différents breuvages.
        /// </summary>
        /// ---------------------------------------------------------------------------
        private void MettreAJourBoutons()
        {
            // --> Allez chercher le code que vous avez fait à l'exercice --> une distributrice
            btnObtenirUnCoke.Enabled = m_objMachineCourante.EstDisponible(SorteBreuvage.Coke);
            btnObtenirUn7Up.Enabled = m_objMachineCourante.EstDisponible(SorteBreuvage.SevenUp);
            btnObtenirUnJusDePommes.Enabled = m_objMachineCourante.EstDisponible(SorteBreuvage.JusDePommes);
            btnObtenirUnTheGlace.Enabled = m_objMachineCourante.EstDisponible(SorteBreuvage.TheGlace);
        }
        //=====================================================================================
        /// <summary>
        /// Ejecter le breuvage demandé et mettre à jours les boutons
        /// </summary>
        /// <param name="pBreuvage">breuvage demandé par le client</param>
        /// -----------------------------------------------------------------------------------
        private void ObtenirUnBreuvage(SorteBreuvage pBreuvage)
        {
            // --> Allez chercher le code que vous avez fait à l'exercice --> une distributrice
            m_objMachineCourante.Ejecter(pBreuvage);
            AfficherInfosMachine();
            MettreAJourBoutons();
        }
        //=====================================================================================
        private void btnObtenirUnCoke_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.Coke);
        }
        //=====================================================================================
        private void btnObtenirUn7Up_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.SevenUp);
        }
        //=====================================================================================
        private void btnObtenirUnJusDePommes_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.JusDePommes);
        }
        //=====================================================================================
        private void btnObtenirUnTheGlace_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.TheGlace);
        }

        //====================================================================================
        private void btnRecharger_Click(object sender, EventArgs e)
        {
            // --> Allez chercher le code que vous avez fait à l'exercice --> une distributrice
            m_objMachineCourante.Recharger();
            AfficherInfosMachine();
            MettreAJourBoutons();
        }
        //====================================================================================
        private void cboMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO 02 : Changer la machine courante par celle sélectionnée dans cboMachines.
            if (cboMachines.SelectedIndex != -1)
            {
                m_objMachineCourante = m_colDistributrices[cboMachines.SelectedIndex];

            }
            // TODO 03 : Afficher les informations de la machine courante
           
            AfficherInfosMachine();
            MettreAJourBoutons();
        }
        //------------------------------------------------------------------------------------
        private void mnuAffichageInventaire_Click(object sender, EventArgs e)
        {
            // TODO 04 : Modifier le constructeur de FrmInventaire afin qu'il accepte une string en paramètre


            // TODO 05 : Préparer une chaîne contenant les informations des machines séparées par des '|'
            //        Commencer par fabriquer la string à partir des informations mémorisées dans m_colMachines
            // Exemple : "Cafétéria ----> 20|Café étudiant ----> 15"

            // TODO 06 : Instancier et afficher le sous-formulaire FrmInventaire.
            // Le formulaire FrmInventaire doit recevoir en paramètre une string avec les lignes d'information séparées
            // par le caractère '|'

            // TODO 07 : Ajouter le code dans le constructeur du formulaire FrmInventaire afin d'afficher les informations
            // des machines




        }
        //------------------------------------------------------------------------------------
        private void mnuAffichageListeDesMachines_Click(object sender, EventArgs e)
        {
            // TODO 08 : Modifier le constructeur de FrmListeMachines afin qu'il accepte une collection de distributrices 
            // en paramètre.

            // TODO 09 : Compléter le code du formulaire afin qu'il afficher les informations appropriées (voir Démo)

            // TODO 10 : Afficher le sous-formulaire FrmListeMachines et fournir la collection 
            // des machines distributrices en paramètre.




        }
    }
}