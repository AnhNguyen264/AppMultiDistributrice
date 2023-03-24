using System;

namespace AppMultiDistributrice
{
    /// ====================================================================================
    /// <summary>
    ///	Énumération de différents breuvages.
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public enum SorteBreuvage { Coke = 2, SevenUp = 4, JusDePommes = 8, TheGlace = 16 };
    
    /// ===========================================================================
    /// <summary>
    ///  Modélise une machine distributrice offrant 4 breuvages différents. 
    ///  On peut recharger la machine et obtenir des informations sur les quantités
    ///  de canettes restant dans la machine.
    /// </summary>
    /// ---------------------------------------------------------------------------
    public class Distributrice
    {
        #region CONSTANTE
        /// -------------------------------------------------------------
        /// <summary>
        /// Représente la quantité maximale d'un breuvage
        /// </summary>
        /// -------------------------------------------------------------
        private const int MAX_QUANTITE = 5;
        #endregion

        #region CHAMPS et PROPRIÉTÉS
        /// <summary>
        /// Nombre de "Coke" disponibles dans la machine distributrice
        /// </summary>
        private int m_nbCoke;
        /// <summary>
        /// Nombre de "7up" disponibles dans la machine distributrice
        /// </summary>
        private int m_nb7up;
        /// <summary>
        /// Nombre de "Jus de pommes" disponibles dans la machine distributrice
        /// </summary>
        private int m_nbJusPomme;
        /// <summary>
        /// Nombre de "Thé glacé" disponibles dans la machine distributrice
        /// </summary>
        private int m_nbTheGlace;
       

        private string m_emplacement;
        //------------------------------------
        /// <summary>
        /// Obtient l'emplacment de la machine.
        /// </summary>
        /// -----------------------------------
        public string Emplacement
        {
            get { return m_emplacement; }
        }
        //==========================================================
        /// <summary>
        /// Obtient la quantité totale de cannettes dans la machine.
        /// </summary>
        /// --------------------------------------------------------
        public int QuantiteTotale
        {
            get
            {
                return m_nb7up + m_nbCoke + m_nbJusPomme + m_nbTheGlace;

            }
        }

        //========================================================================================
        /// <summary>
        ///   Obtient si oui ou non la machine est vide.
        /// </summary>
        /// -------------------------------------------------------------------------------------
        public bool EstVide
        {
            get { return m_nbCoke == 0 && m_nb7up == 0 && m_nbJusPomme == 0 && m_nbTheGlace == 0; }
        }
        //========================================================================================
        /// <summary>
        ///   Obtient si oui ou non la machine est pleine.
        /// </summary>
        /// -------------------------------------------------------------------------------------
        public bool EstPleine
        {
            get { return m_nbCoke == MAX_QUANTITE && m_nb7up == MAX_QUANTITE && m_nbJusPomme == MAX_QUANTITE && m_nbTheGlace == MAX_QUANTITE; }
        }

        #endregion

        #region CONTRUCTEURS
        ///==============================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Machine 
        ///  avec un nombre maximum de canettes pour chacun des breuvages. 
        /// </summary>
        /// --------------------------------------------------------------
        public Distributrice()
        {
            Recharger();
        }
        ///==============================================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Machine à l'emplacment indiqué
        ///  et avec un nombre maximum de canettes pour chacun des breuvages. 
        /// </summary>
        /// ------------------------------------------------------------------------------
        public Distributrice(string pEmplacement)
        {
            m_emplacement = pEmplacement;
            Recharger();
        }
        ///==============================================================
        /// <summary>
        ///  Initialise une nouvelle instance de la classe Machine 
        ///  avec les nombres de canettes spécifiés pour chacun des breuvage. 
        /// </summary>
        /// --------------------------------------------------------------
        public Distributrice(int pNbCoke, int pNb7Up, int pNbJusDePommme, int pNbTheGlace)
        {
            if (pNbCoke < 0 || pNbCoke > MAX_QUANTITE)
                throw new ArgumentOutOfRangeException("pNbCoke", pNbCoke, "doit être compris entre 0 et " + MAX_QUANTITE);

            if (pNb7Up < 0 || pNb7Up > MAX_QUANTITE)
                throw new ArgumentOutOfRangeException("pNb7Up", pNb7Up, "doit être compris entre 0 et " + MAX_QUANTITE);

            if (pNbJusDePommme < 0 || pNbJusDePommme > MAX_QUANTITE)
                throw new ArgumentOutOfRangeException("pNbJusDePommme", pNbJusDePommme, "doit être compris entre 0 et " + MAX_QUANTITE);

            if (pNbTheGlace < 0 || pNbTheGlace > MAX_QUANTITE)
                throw new ArgumentOutOfRangeException("pNbTheGlace", pNbTheGlace, "doit être compris entre 0 et " + MAX_QUANTITE);

            m_nbCoke = pNbCoke;
            m_nb7up = pNb7Up;
            m_nbJusPomme = pNbJusDePommme;
            m_nbTheGlace = pNbTheGlace;
        }
        #endregion

        #region MÉTHODES
        ///====================================================================================
        /// <summary>
        /// Recharge la machine en ré-initialisant les quantités de chaque breuvage au maximum.
        /// </summary>
        /// -----------------------------------------------------------------------------------
        public void Recharger()
        {
            m_nbCoke = MAX_QUANTITE;
            m_nb7up = MAX_QUANTITE;
            m_nbJusPomme = MAX_QUANTITE;
            m_nbTheGlace = MAX_QUANTITE;
        }
        ///======================================================================
        /// <summary>
        ///  Obtient la quantité de cannettes disponible du breuvage spécifié.
        /// </summary>
        /// <param name="pBreuvage">breuvage à vérifier</param>
        /// <returns>quantité de canettes</returns>
        /// ---------------------------------------------------------------------
        public int Quantite(SorteBreuvage pBreuvage)
        {
            switch (pBreuvage)
            {
                case SorteBreuvage.Coke:
                    return m_nbCoke;
                case SorteBreuvage.SevenUp:
                    return m_nb7up;
                case SorteBreuvage.JusDePommes:
                    return m_nbJusPomme;
                case SorteBreuvage.TheGlace:
                    return m_nbTheGlace;
                default:
                    return -1;
            }
        }
        //================================================================================
        /// <summary>
        ///  Ejecte le breuvage spécifié , c'est-à-dire décrémente le nombre de canettes
        ///  du breuvage spécifié s'il en reste.
        /// </summary>
        /// <param name="pBreuvage">breuvage à modifier</param>
        /// ------------------------------------------------------------------------------
        public void Ejecter(SorteBreuvage pBreuvage)
        {
            if (!EstDisponible(pBreuvage))
            {
                throw new InvalidOperationException();
            }

            switch (pBreuvage)
            {
                case SorteBreuvage.Coke:
                    m_nbCoke--;
                    break;
                case SorteBreuvage.SevenUp:
                    m_nb7up--;
                    break;
                case SorteBreuvage.JusDePommes:
                    m_nbJusPomme--;
                    break;
                case SorteBreuvage.TheGlace:
                    m_nbTheGlace--;
                    break;
            }
        }
         //=======================================================
        /// <summary>
        ///  Obtient si oui ou non s'il reste du breuvage spécifié
        /// </summary>
        /// <param name="pBreuvage">breuvage à vérifier</param>
        /// <returns>disponible ou non </returns>
        /// -----------------------------------------------------
        public bool EstDisponible(SorteBreuvage pBreuvage)
        {
            bool estDisponible = false;

            switch (pBreuvage)
            {
                case SorteBreuvage.Coke:
                       estDisponible = m_nbCoke > 0;
                       break;
                case SorteBreuvage.SevenUp:
                       estDisponible = m_nb7up > 0;
                       break;
                case SorteBreuvage.JusDePommes:
                       estDisponible = m_nbJusPomme > 0;
                       break;
                case SorteBreuvage.TheGlace:
                       estDisponible = m_nbTheGlace > 0;
                       break;
            }
            return estDisponible;
        }
    }
    #endregion
}
