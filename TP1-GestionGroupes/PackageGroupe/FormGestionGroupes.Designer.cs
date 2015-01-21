namespace AppStagiaires.PackageGroupe
{
    partial class FormGestionGroupes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btMettreAjour = new System.Windows.Forms.Button();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(449, 126);
            this.btAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(100, 28);
            this.btAjouter.TabIndex = 2;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(449, 162);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btSupprimer.TabIndex = 3;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btMettreAjour
            // 
            this.btMettreAjour.Location = new System.Drawing.Point(449, 198);
            this.btMettreAjour.Margin = new System.Windows.Forms.Padding(4);
            this.btMettreAjour.Name = "btMettreAjour";
            this.btMettreAjour.Size = new System.Drawing.Size(100, 28);
            this.btMettreAjour.TabIndex = 4;
            this.btMettreAjour.Text = "Mettre à jour";
            this.btMettreAjour.UseVisualStyleBackColor = true;
            this.btMettreAjour.Click += new System.EventHandler(this.btMettreAjour_Click);
            // 
            // groupeDataGridView
            // 
            this.groupeDataGridView.AutoGenerateColumns = false;
            this.groupeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupeDataGridView.DataSource = this.groupeBindingSource;
            this.groupeDataGridView.Location = new System.Drawing.Point(12, 126);
            this.groupeDataGridView.Name = "groupeDataGridView";
            this.groupeDataGridView.RowTemplate.Height = 24;
            this.groupeDataGridView.Size = new System.Drawing.Size(379, 220);
            this.groupeDataGridView.TabIndex = 5;
            // 
            // FormGestionGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 452);
            this.Controls.Add(this.groupeDataGridView);
            this.Controls.Add(this.btMettreAjour);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionGroupes";
            this.Text = "FormGestionGroupes";
            this.Load += new System.EventHandler(this.FormGestionGroupes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btMettreAjour;
        private System.Windows.Forms.BindingSource groupeBindingSource;
        private System.Windows.Forms.DataGridView groupeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}