using System;
using System.Windows.Forms;

namespace AppMultiDistributrice
{
    public partial class FrmInventaire : Form
    {
        //TODO  Ajouter un paramètre à FrmInventaire pour pouvoir passer les infos des machines
		//-------------------------------------

        public FrmInventaire(string pInfo)
        {
            InitializeComponent();


            // Compléter le code pour afficher les informations des machines

        }
        //======================================================
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
