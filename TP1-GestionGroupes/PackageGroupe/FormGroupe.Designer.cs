namespace AppStagiaires.PackageGroupe
{
    partial class FormGroupe
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.btEnregistrer = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(92, 26);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(92, 58);
            nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(41, 17);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(143, 22);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(143, 54);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomTextBox.TabIndex = 4;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Location = new System.Drawing.Point(143, 106);
            this.btEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btEnregistrer.TabIndex = 5;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // FormGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 156);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGroupe";
            this.Text = "FormGroupe";
            this.Load += new System.EventHandler(this.FormGroupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button btEnregistrer;
    }
}