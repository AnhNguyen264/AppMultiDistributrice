using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppMultiDistributrice
{
    public partial class FrmListeMachines : Form
    {
        private List<Distributrice> m_colDistributrices;
        //TODO  ajouter un paramètre à FrmListeMachines pour pouvoir recevoir une 
		//      référence vers la liste de machines distributrices du formulaire principal
		//---------------------------------

        public FrmListeMachines()
        {
            InitializeComponent();
            //TODO assignez à m_colDistributrices la référence passée en paramètre au formulaires
			//----------------------
			
			
            AfficherInformations();
        }
        /// ----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Affiche dans le sous-formulaire l'emplacement et la quantité totale de cannettes
        /// pour chacune des machines de la collection.
        /// </summary>
        /// ----------------------------------------------------------------------------------------------------
        private void AfficherInformations()
        {
            // Compléter le code pour afficher les informations des machines

        }
        //===================================================================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        //===================================================================================================
        private void chkMachinesPleines_CheckedChanged(object sender, EventArgs e)
        {
            AfficherInformations();
        }
    }
}
