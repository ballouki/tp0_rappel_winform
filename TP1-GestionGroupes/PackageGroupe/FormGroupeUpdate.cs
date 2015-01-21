using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PackageGroupe{

    public partial class FormGroupeUpdate : Form{
   
        public FormGroupeUpdate()
        {
            InitializeComponent();
        }

        public void MiseAjour(Groupe g) 
        {

            idTextBox.Text = g.Id.ToString();
            nomTextBox.Text = g.Nom;
        }

        private void btMiseAjour_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe();
            g.Id = int.Parse(idTextBox.Text);
            g.Nom = nomTextBox.Text;
            GestionGroupes.MiseAJour(g);
        }

        private void FormGroupeUpdate_Load(object sender, EventArgs e)
        {

        }

       
    }
}
