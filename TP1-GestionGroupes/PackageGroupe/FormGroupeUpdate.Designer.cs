namespace PackageGroupe
{
    partial class FormGroupeUpdate
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.btMiseAjour = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(72, 91);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(72, 123);
            nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(41, 17);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(123, 87);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupeBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(123, 119);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(132, 22);
            this.nomTextBox.TabIndex = 4;
            // 
            // btMiseAjour
            // 
            this.btMiseAjour.Location = new System.Drawing.Point(123, 167);
            this.btMiseAjour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMiseAjour.Name = "btMiseAjour";
            this.btMiseAjour.Size = new System.Drawing.Size(100, 28);
            this.btMiseAjour.TabIndex = 5;
            this.btMiseAjour.Text = "Mise à jour";
            this.btMiseAjour.UseVisualStyleBackColor = true;
            this.btMiseAjour.Click += new System.EventHandler(this.btMiseAjour_Click);
            // 
            // FormGroupeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.btMiseAjour);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGroupeUpdate";
            this.Text = "FormGroupeUpdate";
            this.Load += new System.EventHandler(this.FormGroupeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource groupeBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button btMiseAjour;
    }
}