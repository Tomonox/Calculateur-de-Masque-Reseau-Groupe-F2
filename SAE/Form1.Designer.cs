namespace SAE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpCalculateurMasque = new GroupBox();
            lblErreur = new Label();
            btnResetALL = new Button();
            btnCalculer2 = new Button();
            btnCalculer = new Button();
            lblOU = new Label();
            txtMasque = new TextBox();
            txtAdresseIP = new TextBox();
            txtAdresseIPCIDR = new TextBox();
            grpAffichage = new GroupBox();
            btnResetALL2 = new Button();
            txtDerniereMachineAffiche = new TextBox();
            txtPremiereMachineAffiche = new TextBox();
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
            grpCalculateurMasque.Anchor = AnchorStyles.None;
            grpCalculateurMasque.BackColor = Color.FromArgb(217, 217, 217);
            grpCalculateurMasque.Controls.Add(lblErreur);
            grpCalculateurMasque.Controls.Add(btnResetALL);
            grpCalculateurMasque.Controls.Add(btnCalculer2);
            grpCalculateurMasque.Controls.Add(btnCalculer);
            grpCalculateurMasque.Controls.Add(lblOU);
            grpCalculateurMasque.Controls.Add(txtMasque);
            grpCalculateurMasque.Controls.Add(txtAdresseIP);
            grpCalculateurMasque.Controls.Add(txtAdresseIPCIDR);
            grpCalculateurMasque.Location = new Point(241, 30);
            grpCalculateurMasque.Name = "grpCalculateurMasque";
            grpCalculateurMasque.Size = new Size(387, 220);
            grpCalculateurMasque.TabIndex = 0;
            grpCalculateurMasque.TabStop = false;
            grpCalculateurMasque.Text = "Calculateur";
            grpCalculateurMasque.Enter += groupBox1_Enter;
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.BackColor = SystemColors.Control;
            lblErreur.ForeColor = SystemColors.Control;
            lblErreur.Location = new Point(28, 193);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(87, 15);
            lblErreur.TabIndex = 6;
            lblErreur.Text = "Message Erreur";
            // 
            // btnResetALL
            // 
            btnResetALL.BackColor = Color.Gainsboro;
            btnResetALL.Location = new Point(28, 155);
            btnResetALL.Name = "btnResetALL";
            btnResetALL.Size = new Size(75, 23);
            btnResetALL.TabIndex = 5;
            btnResetALL.Text = "Reset ALL";
            btnResetALL.UseVisualStyleBackColor = false;
            btnResetALL.Click += btnResetALL_Click;
            // 
            // btnCalculer2
            // 
            btnCalculer2.BackColor = Color.Gainsboro;
            btnCalculer2.ForeColor = SystemColors.ControlText;
            btnCalculer2.Location = new Point(292, 39);
            btnCalculer2.Name = "btnCalculer2";
            btnCalculer2.Size = new Size(75, 23);
            btnCalculer2.TabIndex = 4;
            btnCalculer2.Text = "Calculer";
            btnCalculer2.UseVisualStyleBackColor = false;
            btnCalculer2.Click += btnCalculer2_Click;
            // 
            // btnCalculer
            // 
            btnCalculer.BackColor = Color.Gainsboro;
            btnCalculer.Location = new Point(292, 110);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(75, 23);
            btnCalculer.TabIndex = 3;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = false;
            btnCalculer.Click += btnENVOYER_Click;
            // 
            // lblOU
            // 
            lblOU.AutoSize = true;
            lblOU.Location = new Point(28, 80);
            lblOU.Name = "lblOU";
            lblOU.Size = new Size(24, 15);
            lblOU.TabIndex = 2;
            lblOU.Text = "OU";
            lblOU.Click += label1_Click_1;
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
            txtMasque.TextChanged += txtMasque_TextChanged;
            txtMasque.Enter += txtMasque_Enter;
            txtMasque.Leave += txtMasque_Leave;
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
            txtAdresseIP.TextChanged += txtAdresseIP_TextChanged;
            txtAdresseIP.Enter += txtAdresseIP_Enter_1;
            txtAdresseIP.Leave += txtAdresseIP_Leave_1;
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
            txtAdresseIPCIDR.TextChanged += txtAdresseIPCIDR_TextChanged;
            txtAdresseIPCIDR.Enter += txtAdresseIPCIDR_Enter_1;
            txtAdresseIPCIDR.Leave += txtAdresseIPCIDR_Leave;
            // 
            // grpAffichage
            // 
            grpAffichage.Anchor = AnchorStyles.None;
            grpAffichage.BackColor = Color.FromArgb(217, 217, 217);
            grpAffichage.Controls.Add(btnResetALL2);
            grpAffichage.Controls.Add(txtDerniereMachineAffiche);
            grpAffichage.Controls.Add(txtPremiereMachineAffiche);
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
            grpAffichage.Location = new Point(243, 256);
            grpAffichage.Name = "grpAffichage";
            grpAffichage.Size = new Size(387, 471);
            grpAffichage.TabIndex = 2;
            grpAffichage.TabStop = false;
            grpAffichage.Text = "Affiche";
            grpAffichage.Enter += grpAffichage_Enter;
            // 
            // btnResetALL2
            // 
            btnResetALL2.BackColor = Color.Gainsboro;
            btnResetALL2.Location = new Point(28, 433);
            btnResetALL2.Name = "btnResetALL2";
            btnResetALL2.Size = new Size(75, 23);
            btnResetALL2.TabIndex = 7;
            btnResetALL2.Text = "Reset ALL";
            btnResetALL2.UseVisualStyleBackColor = false;
            btnResetALL2.Click += btnResetALL2_Click;
            // 
            // txtDerniereMachineAffiche
            // 
            txtDerniereMachineAffiche.Location = new Point(28, 392);
            txtDerniereMachineAffiche.Name = "txtDerniereMachineAffiche";
            txtDerniereMachineAffiche.Size = new Size(305, 23);
            txtDerniereMachineAffiche.TabIndex = 10;
            txtDerniereMachineAffiche.Text = "Derniere Machine :";
            txtDerniereMachineAffiche.TextChanged += textBox2_TextChanged;
            // 
            // txtPremiereMachineAffiche
            // 
            txtPremiereMachineAffiche.Location = new Point(28, 363);
            txtPremiereMachineAffiche.Name = "txtPremiereMachineAffiche";
            txtPremiereMachineAffiche.Size = new Size(305, 23);
            txtPremiereMachineAffiche.TabIndex = 9;
            txtPremiereMachineAffiche.Text = "Premiere Machine :";
            txtPremiereMachineAffiche.TextChanged += txtPremiereMachineAffiche_TextChanged;
            // 
            // lblReseau
            // 
            lblReseau.AutoSize = true;
            lblReseau.Location = new Point(28, 166);
            lblReseau.Name = "lblReseau";
            lblReseau.Size = new Size(97, 15);
            lblReseau.TabIndex = 3;
            lblReseau.Text = "En mode reseau :";
            // 
            // txtNombreIPDispoAffiche
            // 
            txtNombreIPDispoAffiche.Location = new Point(28, 312);
            txtNombreIPDispoAffiche.Name = "txtNombreIPDispoAffiche";
            txtNombreIPDispoAffiche.Size = new Size(305, 23);
            txtNombreIPDispoAffiche.TabIndex = 8;
            txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : ";
            txtNombreIPDispoAffiche.TextChanged += txtNombreIPDispoAffiche_TextChanged;
            // 
            // txtAdresseBroadcastAffiche
            // 
            txtAdresseBroadcastAffiche.Location = new Point(28, 283);
            txtAdresseBroadcastAffiche.Name = "txtAdresseBroadcastAffiche";
            txtAdresseBroadcastAffiche.Size = new Size(305, 23);
            txtAdresseBroadcastAffiche.TabIndex = 7;
            txtAdresseBroadcastAffiche.Text = "Adresse de broadcast :";
            txtAdresseBroadcastAffiche.TextChanged += txtAdresseBroadcastAffiche_TextChanged;
            // 
            // txtDerniereAdresseAffiche
            // 
            txtDerniereAdresseAffiche.Location = new Point(28, 254);
            txtDerniereAdresseAffiche.Name = "txtDerniereAdresseAffiche";
            txtDerniereAdresseAffiche.Size = new Size(305, 23);
            txtDerniereAdresseAffiche.TabIndex = 6;
            txtDerniereAdresseAffiche.Text = "Dernière adresse : ";
            txtDerniereAdresseAffiche.TextChanged += txtDerniereAdresseAffiche_TextChanged;
            // 
            // txtPremiereAdresseAffiche
            // 
            txtPremiereAdresseAffiche.Location = new Point(28, 225);
            txtPremiereAdresseAffiche.Name = "txtPremiereAdresseAffiche";
            txtPremiereAdresseAffiche.Size = new Size(305, 23);
            txtPremiereAdresseAffiche.TabIndex = 5;
            txtPremiereAdresseAffiche.Text = "Première adresse : ";
            txtPremiereAdresseAffiche.TextChanged += txtPremiereAdresseAffiche_TextChanged;
            // 
            // txtAdresseReseauAffiche
            // 
            txtAdresseReseauAffiche.Location = new Point(28, 196);
            txtAdresseReseauAffiche.Name = "txtAdresseReseauAffiche";
            txtAdresseReseauAffiche.Size = new Size(305, 23);
            txtAdresseReseauAffiche.TabIndex = 4;
            txtAdresseReseauAffiche.Text = "Adresse de réseau :";
            txtAdresseReseauAffiche.TextChanged += txtAdresseReseauAffiche_TextChanged;
            // 
            // txtMasqueInverseAffiche
            // 
            txtMasqueInverseAffiche.Location = new Point(28, 128);
            txtMasqueInverseAffiche.Name = "txtMasqueInverseAffiche";
            txtMasqueInverseAffiche.Size = new Size(305, 23);
            txtMasqueInverseAffiche.TabIndex = 3;
            txtMasqueInverseAffiche.Text = "Masque inverse :";
            txtMasqueInverseAffiche.TextChanged += txtMasqueInverseAffiche_TextChanged;
            // 
            // txtMasqueReseauAffiche
            // 
            txtMasqueReseauAffiche.Location = new Point(28, 99);
            txtMasqueReseauAffiche.Name = "txtMasqueReseauAffiche";
            txtMasqueReseauAffiche.Size = new Size(305, 23);
            txtMasqueReseauAffiche.TabIndex = 2;
            txtMasqueReseauAffiche.Text = "Masque de réseau :";
            txtMasqueReseauAffiche.TextChanged += txtMasqueSousReseauAffiche_TextChanged;
            // 
            // txtCIDRAffiche
            // 
            txtCIDRAffiche.Location = new Point(28, 70);
            txtCIDRAffiche.Name = "txtCIDRAffiche";
            txtCIDRAffiche.Size = new Size(305, 23);
            txtCIDRAffiche.TabIndex = 1;
            txtCIDRAffiche.Text = "CIDR :";
            txtCIDRAffiche.TextChanged += txtCIDRAffiche_TextChanged;
            // 
            // txtClasseIPAffiche
            // 
            txtClasseIPAffiche.Location = new Point(28, 41);
            txtClasseIPAffiche.Name = "txtClasseIPAffiche";
            txtClasseIPAffiche.Size = new Size(305, 23);
            txtClasseIPAffiche.TabIndex = 0;
            txtClasseIPAffiche.Text = "Classe IP :";
            txtClasseIPAffiche.TextChanged += txtClasseIPAffiche_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 180, 164);
            ClientSize = new Size(941, 774);
            Controls.Add(grpAffichage);
            Controls.Add(grpCalculateurMasque);
            Name = "Form1";
            Text = "Calculateur de Masque Réseau";
            Load += Form1_Load;
            grpCalculateurMasque.ResumeLayout(false);
            grpCalculateurMasque.PerformLayout();
            grpAffichage.ResumeLayout(false);
            grpAffichage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCalculateurMasque;
        private TextBox txtAdresseIPCIDR;
        private TextBox txtMasque;
        private TextBox txtAdresseIP;
        private Label lblOU;
        private Button btnCalculer;
        private Button btnResetALL;
        private Button btnCalculer2;
        private GroupBox grpAffichage;
        private TextBox txtClasseIPAffiche;
        private Label lblReseau;
        private TextBox txtNombreIPDispoAffiche;
        private TextBox txtAdresseBroadcastAffiche;
        private TextBox txtDerniereAdresseAffiche;
        private TextBox txtPremiereAdresseAffiche;
        private TextBox txtAdresseReseauAffiche;
        private TextBox txtMasqueInverseAffiche;
        private TextBox txtMasqueReseauAffiche;
        private TextBox txtCIDRAffiche;
        private TextBox txtDerniereMachineAffiche;
        private TextBox txtPremiereMachineAffiche;
        private Label lblErreur;
        private Button btnResetALL2;
    }
}
