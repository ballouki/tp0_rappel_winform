using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PackageGroupe;

namespace AppStagiaires.PackageGroupe{

    public partial class FormGroupe : Form{
    
        public FormGroupe()
        {
            InitializeComponent();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            GestionGroupes.Ajouter(g);

        }

        private void FormGroupe_Load(object sender, EventArgs e)
        {

        }

       
    }
}
