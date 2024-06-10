namespace SAE
{
    partial class Form2
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
            grpCalculateurMasque = new GroupBox();
            btnCalculer2 = new Button();
            txtAdresseIPCIDR = new TextBox();
            txtAdresseIP = new TextBox();
            txtMasque = new TextBox();
            btnResetALL = new Button();
            btnCalculer = new Button();
            lblOU = new Label();
            grpAffichage = new GroupBox();
            txtNombreMachineDispoAffiche = new TextBox();
            btnResetALL2 = new Button();
            lblReseau = new Label();
            txtNombreIPDispoAffiche = new TextBox();
            txtAdresseBroadcastAffiche = new TextBox();
            txtDerniereAdresseAffiche = new TextBox();
            txtPremiereAdresseAffiche = new TextBox();
            txtAdresseReseauAffiche = new TextBox();
            txtMasqueInverseAffiche = new TextBox();
            txtMasqueReseauAffiche = new TextBox();
            txtCIDRAffiche = new TextBox();
            txtClasseIPAffiche = new TextBox();
            grpCalculateurMasque.SuspendLayout();
            grpAffichage.SuspendLayout();
            SuspendLayout();
            // 
            // grpCalculateurMasque
            // 
            grpCalculateurMasque.BackColor = Color.FromArgb(0, 109, 160);
            grpCalculateurMasque.BackgroundImageLayout = ImageLayout.Center;
            grpCalculateurMasque.Controls.Add(btnCalculer2);
            grpCalculateurMasque.Controls.Add(txtAdresseIPCIDR);
            grpCalculateurMasque.Controls.Add(txtAdresseIP);
            grpCalculateurMasque.Controls.Add(txtMasque);
            grpCalculateurMasque.Controls.Add(btnResetALL);
            grpCalculateurMasque.Controls.Add(btnCalculer);
            grpCalculateurMasque.Controls.Add(lblOU);
            grpCalculateurMasque.FlatStyle = FlatStyle.Flat;
            grpCalculateurMasque.ForeColor = SystemColors.ControlText;
            grpCalculateurMasque.Location = new Point(207, 115);
            grpCalculateurMasque.Name = "grpCalculateurMasque";
            grpCalculateurMasque.Size = new Size(387, 220);
            grpCalculateurMasque.TabIndex = 1;
            grpCalculateurMasque.TabStop = false;
            // 
            // btnCalculer2
            // 
            btnCalculer2.Location = new Point(292, 39);
            btnCalculer2.Name = "btnCalculer2";
            btnCalculer2.Size = new Size(75, 23);
            btnCalculer2.TabIndex = 4;
            btnCalculer2.Text = "Calculer";
            btnCalculer2.UseVisualStyleBackColor = true;
            // 
            // txtAdresseIPCIDR
            // 
            txtAdresseIPCIDR.BackColor = Color.White;
            txtAdresseIPCIDR.ForeColor = SystemColors.ScrollBar;
            txtAdresseIPCIDR.Location = new Point(28, 39);
            txtAdresseIPCIDR.Name = "txtAdresseIPCIDR";
            txtAdresseIPCIDR.Size = new Size(117, 23);
            txtAdresseIPCIDR.TabIndex = 0;
            txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
            // 
            // txtAdresseIP
            // 
            txtAdresseIP.BackColor = Color.White;
            txtAdresseIP.ForeColor = SystemColors.ScrollBar;
            txtAdresseIP.Location = new Point(28, 110);
            txtAdresseIP.Name = "txtAdresseIP";
            txtAdresseIP.Size = new Size(117, 23);
            txtAdresseIP.TabIndex = 1;
            txtAdresseIP.Text = "Adresse IPV4";
            // 
            // txtMasque
            // 
            txtMasque.BackColor = Color.White;
            txtMasque.ForeColor = SystemColors.ScrollBar;
            txtMasque.Location = new Point(151, 110);
            txtMasque.Name = "txtMasque";
            txtMasque.Size = new Size(117, 23);
            txtMasque.TabIndex = 2;
            txtMasque.Text = "Masque";
            // 
            // btnResetALL
            // 
            btnResetALL.Location = new Point(28, 155);
            btnResetALL.Name = "btnResetALL";
            btnResetALL.Size = new Size(75, 23);
            btnResetALL.TabIndex = 5;
            btnResetALL.Text = "Reset ALL";
            btnResetALL.UseVisualStyleBackColor = true;
            // 
            // btnCalculer
            // 
            btnCalculer.Location = new Point(292, 110);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(75, 23);
            btnCalculer.TabIndex = 3;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = true;
            // 
            // lblOU
            // 
            lblOU.AutoSize = true;
            lblOU.Location = new Point(28, 80);
            lblOU.Name = "lblOU";
            lblOU.Size = new Size(24, 15);
            lblOU.TabIndex = 2;
            lblOU.Text = "OU";
            // 
            // grpAffichage
            // 
            grpAffichage.BackColor = Color.FromArgb(0, 109, 160);
            grpAffichage.BackgroundImageLayout = ImageLayout.None;
            grpAffichage.Controls.Add(txtNombreMachineDispoAffiche);
            grpAffichage.Controls.Add(btnResetALL2);
            grpAffichage.Controls.Add(lblReseau);
            grpAffichage.Controls.Add(txtNombreIPDispoAffiche);
            grpAffichage.Controls.Add(txtAdresseBroadcastAffiche);
            grpAffichage.Controls.Add(txtDerniereAdresseAffiche);
            grpAffichage.Controls.Add(txtPremiereAdresseAffiche);
            grpAffichage.Controls.Add(txtAdresseReseauAffiche);
            grpAffichage.Controls.Add(txtMasqueInverseAffiche);
            grpAffichage.Controls.Add(txtMasqueReseauAffiche);
            grpAffichage.Controls.Add(txtCIDRAffiche);
            grpAffichage.Controls.Add(txtClasseIPAffiche);
            grpAffichage.FlatStyle = FlatStyle.Flat;
            grpAffichage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAffichage.Location = new Point(115, 13);
            grpAffichage.Name = "grpAffichage";
            grpAffichage.Size = new Size(387, 425);
            grpAffichage.TabIndex = 3;
            grpAffichage.TabStop = false;
            // 
            // txtNombreMachineDispoAffiche
            // 
            txtNombreMachineDispoAffiche.Location = new Point(28, 341);
            txtNombreMachineDispoAffiche.Name = "txtNombreMachineDispoAffiche";
            txtNombreMachineDispoAffiche.Size = new Size(305, 23);
            txtNombreMachineDispoAffiche.TabIndex = 9;
            txtNombreMachineDispoAffiche.Text = "Nombre de machines disponibles :";
            // 
            // btnResetALL2
            // 
            btnResetALL2.Location = new Point(28, 387);
            btnResetALL2.Name = "btnResetALL2";
            btnResetALL2.Size = new Size(75, 23);
            btnResetALL2.TabIndex = 7;
            btnResetALL2.Text = "Reset ALL";
            btnResetALL2.UseVisualStyleBackColor = true;
            // 
            // lblReseau
            // 
            lblReseau.AutoSize = true;
            lblReseau.Location = new Point(28, 165);
            lblReseau.Name = "lblReseau";
            lblReseau.Size = new Size(127, 15);
            lblReseau.TabIndex = 3;
            lblReseau.Text = "------------------------";
            // 
            // txtNombreIPDispoAffiche
            // 
            txtNombreIPDispoAffiche.Location = new Point(28, 312);
            txtNombreIPDispoAffiche.Name = "txtNombreIPDispoAffiche";
            txtNombreIPDispoAffiche.Size = new Size(305, 23);
            txtNombreIPDispoAffiche.TabIndex = 8;
            txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : ";
            // 
            // txtAdresseBroadcastAffiche
            // 
            txtAdresseBroadcastAffiche.Location = new Point(28, 283);
            txtAdresseBroadcastAffiche.Name = "txtAdresseBroadcastAffiche";
            txtAdresseBroadcastAffiche.Size = new Size(305, 23);
            txtAdresseBroadcastAffiche.TabIndex = 7;
            txtAdresseBroadcastAffiche.Text = "Adresse de broadcast :";
            // 
            // txtDerniereAdresseAffiche
            // 
            txtDerniereAdresseAffiche.Location = new Point(28, 254);
            txtDerniereAdresseAffiche.Name = "txtDerniereAdresseAffiche";
            txtDerniereAdresseAffiche.Size = new Size(305, 23);
            txtDerniereAdresseAffiche.TabIndex = 6;
            txtDerniereAdresseAffiche.Text = "Dernière adresse : ";
            // 
            // txtPremiereAdresseAffiche
            // 
            txtPremiereAdresseAffiche.Location = new Point(28, 225);
            txtPremiereAdresseAffiche.Name = "txtPremiereAdresseAffiche";
            txtPremiereAdresseAffiche.Size = new Size(305, 23);
            txtPremiereAdresseAffiche.TabIndex = 5;
            txtPremiereAdresseAffiche.Text = "Première adresse : ";
            // 
            // txtAdresseReseauAffiche
            // 
            txtAdresseReseauAffiche.Location = new Point(28, 196);
            txtAdresseReseauAffiche.Name = "txtAdresseReseauAffiche";
            txtAdresseReseauAffiche.Size = new Size(305, 23);
            txtAdresseReseauAffiche.TabIndex = 4;
            txtAdresseReseauAffiche.Text = "Adresse de réseau :";
            // 
            // txtMasqueInverseAffiche
            // 
            txtMasqueInverseAffiche.Location = new Point(28, 128);
            txtMasqueInverseAffiche.Name = "txtMasqueInverseAffiche";
            txtMasqueInverseAffiche.Size = new Size(305, 23);
            txtMasqueInverseAffiche.TabIndex = 3;
            txtMasqueInverseAffiche.Text = "Masque inverse :";
            // 
            // txtMasqueReseauAffiche
            // 
            txtMasqueReseauAffiche.Location = new Point(28, 99);
            txtMasqueReseauAffiche.Name = "txtMasqueReseauAffiche";
            txtMasqueReseauAffiche.Size = new Size(305, 23);
            txtMasqueReseauAffiche.TabIndex = 2;
            txtMasqueReseauAffiche.Text = "Masque de réseau :";
            // 
            // txtCIDRAffiche
            // 
            txtCIDRAffiche.Location = new Point(28, 70);
            txtCIDRAffiche.Name = "txtCIDRAffiche";
            txtCIDRAffiche.Size = new Size(305, 23);
            txtCIDRAffiche.TabIndex = 1;
            txtCIDRAffiche.Text = "CIDR :";
            // 
            // txtClasseIPAffiche
            // 
            txtClasseIPAffiche.Location = new Point(28, 41);
            txtClasseIPAffiche.Name = "txtClasseIPAffiche";
            txtClasseIPAffiche.Size = new Size(305, 23);
            txtClasseIPAffiche.TabIndex = 0;
            txtClasseIPAffiche.Text = "Classe IP :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(grpAffichage);
            Controls.Add(grpCalculateurMasque);
            Name = "Form2";
            Text = "Form2";
            grpCalculateurMasque.ResumeLayout(false);
            grpCalculateurMasque.PerformLayout();
            grpAffichage.ResumeLayout(false);
            grpAffichage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCalculateurMasque;
        private Button btnCalculer2;
        private TextBox txtAdresseIPCIDR;
        private TextBox txtAdresseIP;
        private TextBox txtMasque;
        private Button btnResetALL;
        private Button btnCalculer;
        private Label lblOU;
        private GroupBox grpAffichage;
        private TextBox txtNombreMachineDispoAffiche;
        private Button btnResetALL2;
        private Label lblReseau;
        private TextBox txtNombreIPDispoAffiche;
        private TextBox txtAdresseBroadcastAffiche;
        private TextBox txtDerniereAdresseAffiche;
        private TextBox txtPremiereAdresseAffiche;
        private TextBox txtAdresseReseauAffiche;
        private TextBox txtMasqueInverseAffiche;
        private TextBox txtMasqueReseauAffiche;
        private TextBox txtCIDRAffiche;
        private TextBox txtClasseIPAffiche;
    }
}