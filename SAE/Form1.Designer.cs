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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlBarre = new Panel();
            lblTitre = new Label();
            btnQuitter = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnCalculer2 = new Button();
            txtAdresseIPCIDR = new TextBox();
            txtAdresseIP = new TextBox();
            txtMasque = new TextBox();
            btnCalculer = new Button();
            lblOU = new Label();
            pnlAffiche = new Panel();
            txtMasqueBinaire = new TextBox();
            txtAdresseBinaire = new TextBox();
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
            pnlBarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlAffiche.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBarre
            // 
            pnlBarre.BackColor = Color.FromArgb(10, 18, 80);
            pnlBarre.Controls.Add(lblTitre);
            pnlBarre.Controls.Add(btnQuitter);
            pnlBarre.Location = new Point(0, 0);
            pnlBarre.Name = "pnlBarre";
            pnlBarre.Size = new Size(712, 66);
            pnlBarre.TabIndex = 3;
            pnlBarre.MouseDown += pnlBarre_MouseDown;
            pnlBarre.MouseMove += pnlBarre_MouseMove;
            pnlBarre.MouseUp += pnlBarre_MouseUp;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = SystemColors.ControlLightLight;
            lblTitre.Location = new Point(12, 14);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(298, 30);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Calculateur de Masque Réseau";
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = Color.FromArgb(10, 18, 80);
            btnQuitter.BackgroundImage = (Image)resources.GetObject("btnQuitter.BackgroundImage");
            btnQuitter.BackgroundImageLayout = ImageLayout.Stretch;
            btnQuitter.FlatAppearance.BorderSize = 0;
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Location = new Point(473, 12);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(40, 41);
            btnQuitter.TabIndex = 0;
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.MouseClick += btnQuitter_MouseClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 807);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(0, 109, 160);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCalculer2);
            panel1.Controls.Add(txtAdresseIPCIDR);
            panel1.Controls.Add(txtAdresseIP);
            panel1.Controls.Add(txtMasque);
            panel1.Controls.Add(btnCalculer);
            panel1.Controls.Add(lblOU);
            panel1.Location = new Point(69, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 150);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // btnCalculer2
            // 
            btnCalculer2.Location = new Point(289, 26);
            btnCalculer2.Name = "btnCalculer2";
            btnCalculer2.Size = new Size(75, 23);
            btnCalculer2.TabIndex = 11;
            btnCalculer2.Text = "Calculer";
            btnCalculer2.UseVisualStyleBackColor = true;
            btnCalculer2.Click += btnCalculer2_Click_1;
            // 
            // txtAdresseIPCIDR
            // 
            txtAdresseIPCIDR.BackColor = Color.White;
            txtAdresseIPCIDR.ForeColor = SystemColors.ScrollBar;
            txtAdresseIPCIDR.Location = new Point(25, 26);
            txtAdresseIPCIDR.Name = "txtAdresseIPCIDR";
            txtAdresseIPCIDR.Size = new Size(117, 23);
            txtAdresseIPCIDR.TabIndex = 6;
            txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
            txtAdresseIPCIDR.Enter += txtAdresseIPCIDR_Enter;
            txtAdresseIPCIDR.Leave += txtAdresseIPCIDR_Leave;
            // 
            // txtAdresseIP
            // 
            txtAdresseIP.BackColor = Color.White;
            txtAdresseIP.ForeColor = SystemColors.ScrollBar;
            txtAdresseIP.Location = new Point(25, 99);
            txtAdresseIP.Name = "txtAdresseIP";
            txtAdresseIP.Size = new Size(117, 23);
            txtAdresseIP.TabIndex = 7;
            txtAdresseIP.Text = "Adresse IPV4";
            txtAdresseIP.Enter += txtAdresseIP_Enter;
            txtAdresseIP.Leave += txtAdresseIP_Leave;
            // 
            // txtMasque
            // 
            txtMasque.BackColor = Color.White;
            txtMasque.ForeColor = SystemColors.ScrollBar;
            txtMasque.Location = new Point(148, 99);
            txtMasque.Name = "txtMasque";
            txtMasque.Size = new Size(117, 23);
            txtMasque.TabIndex = 8;
            txtMasque.Text = "Masque";
            txtMasque.Enter += txtMasque_Enter_1;
            txtMasque.Leave += txtMasque_Leave_1;
            // 
            // btnCalculer
            // 
            btnCalculer.Location = new Point(289, 99);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(75, 23);
            btnCalculer.TabIndex = 10;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = true;
            btnCalculer.Click += btnCalculer_Click;
            // 
            // lblOU
            // 
            lblOU.AutoSize = true;
            lblOU.Location = new Point(25, 66);
            lblOU.Name = "lblOU";
            lblOU.Size = new Size(24, 15);
            lblOU.TabIndex = 9;
            lblOU.Text = "OU";
            // 
            // pnlAffiche
            // 
            pnlAffiche.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAffiche.BackColor = Color.FromArgb(0, 109, 160);
            pnlAffiche.BorderStyle = BorderStyle.FixedSingle;
            pnlAffiche.Controls.Add(txtMasqueBinaire);
            pnlAffiche.Controls.Add(txtAdresseBinaire);
            pnlAffiche.Controls.Add(txtNombreMachineDispoAffiche);
            pnlAffiche.Controls.Add(btnResetALL2);
            pnlAffiche.Controls.Add(lblReseau);
            pnlAffiche.Controls.Add(txtNombreIPDispoAffiche);
            pnlAffiche.Controls.Add(txtAdresseBroadcastAffiche);
            pnlAffiche.Controls.Add(txtDerniereAdresseAffiche);
            pnlAffiche.Controls.Add(txtPremiereAdresseAffiche);
            pnlAffiche.Controls.Add(txtAdresseReseauAffiche);
            pnlAffiche.Controls.Add(txtMasqueInverseAffiche);
            pnlAffiche.Controls.Add(txtMasqueReseauAffiche);
            pnlAffiche.Controls.Add(txtCIDRAffiche);
            pnlAffiche.Controls.Add(txtClasseIPAffiche);
            pnlAffiche.Location = new Point(69, 292);
            pnlAffiche.Name = "pnlAffiche";
            pnlAffiche.Size = new Size(388, 484);
            pnlAffiche.TabIndex = 6;
            pnlAffiche.Paint += pnlAffiche_Paint;
            // 
            // txtMasqueBinaire
            // 
            txtMasqueBinaire.Location = new Point(25, 398);
            txtMasqueBinaire.Name = "txtMasqueBinaire";
            txtMasqueBinaire.Size = new Size(329, 23);
            txtMasqueBinaire.TabIndex = 23;
            txtMasqueBinaire.Text = "Masque en Binaire :";
            // 
            // txtAdresseBinaire
            // 
            txtAdresseBinaire.Location = new Point(25, 369);
            txtAdresseBinaire.Name = "txtAdresseBinaire";
            txtAdresseBinaire.Size = new Size(329, 23);
            txtAdresseBinaire.TabIndex = 22;
            txtAdresseBinaire.Text = "Adresse IP en Binaire :";
            // 
            // txtNombreMachineDispoAffiche
            // 
            txtNombreMachineDispoAffiche.Location = new Point(25, 282);
            txtNombreMachineDispoAffiche.Name = "txtNombreMachineDispoAffiche";
            txtNombreMachineDispoAffiche.Size = new Size(329, 23);
            txtNombreMachineDispoAffiche.TabIndex = 21;
            txtNombreMachineDispoAffiche.Text = "Nombre de machines disponibles :";
            // 
            // btnResetALL2
            // 
            btnResetALL2.BackgroundImage = (Image)resources.GetObject("btnResetALL2.BackgroundImage");
            btnResetALL2.BackgroundImageLayout = ImageLayout.Stretch;
            btnResetALL2.FlatAppearance.BorderSize = 0;
            btnResetALL2.FlatStyle = FlatStyle.Flat;
            btnResetALL2.Location = new Point(25, 439);
            btnResetALL2.Name = "btnResetALL2";
            btnResetALL2.Size = new Size(48, 40);
            btnResetALL2.TabIndex = 18;
            btnResetALL2.UseVisualStyleBackColor = true;
            btnResetALL2.Click += btnResetALL2_Click_1;
            // 
            // lblReseau
            // 
            lblReseau.AutoSize = true;
            lblReseau.Location = new Point(25, 220);
            lblReseau.Name = "lblReseau";
            lblReseau.Size = new Size(127, 15);
            lblReseau.TabIndex = 13;
            lblReseau.Text = "------------------------";
            // 
            // txtNombreIPDispoAffiche
            // 
            txtNombreIPDispoAffiche.Location = new Point(25, 253);
            txtNombreIPDispoAffiche.Name = "txtNombreIPDispoAffiche";
            txtNombreIPDispoAffiche.Size = new Size(329, 23);
            txtNombreIPDispoAffiche.TabIndex = 20;
            txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : ";
            // 
            // txtAdresseBroadcastAffiche
            // 
            txtAdresseBroadcastAffiche.Location = new Point(25, 175);
            txtAdresseBroadcastAffiche.Name = "txtAdresseBroadcastAffiche";
            txtAdresseBroadcastAffiche.Size = new Size(329, 23);
            txtAdresseBroadcastAffiche.TabIndex = 19;
            txtAdresseBroadcastAffiche.Text = "Adresse de broadcast :";
            // 
            // txtDerniereAdresseAffiche
            // 
            txtDerniereAdresseAffiche.Location = new Point(25, 340);
            txtDerniereAdresseAffiche.Name = "txtDerniereAdresseAffiche";
            txtDerniereAdresseAffiche.Size = new Size(329, 23);
            txtDerniereAdresseAffiche.TabIndex = 17;
            txtDerniereAdresseAffiche.Text = "Dernière adresse : ";
            // 
            // txtPremiereAdresseAffiche
            // 
            txtPremiereAdresseAffiche.Location = new Point(25, 311);
            txtPremiereAdresseAffiche.Name = "txtPremiereAdresseAffiche";
            txtPremiereAdresseAffiche.Size = new Size(329, 23);
            txtPremiereAdresseAffiche.TabIndex = 16;
            txtPremiereAdresseAffiche.Text = "Première adresse : ";
            // 
            // txtAdresseReseauAffiche
            // 
            txtAdresseReseauAffiche.Location = new Point(25, 146);
            txtAdresseReseauAffiche.Name = "txtAdresseReseauAffiche";
            txtAdresseReseauAffiche.Size = new Size(329, 23);
            txtAdresseReseauAffiche.TabIndex = 15;
            txtAdresseReseauAffiche.Text = "Adresse de réseau :";
            // 
            // txtMasqueInverseAffiche
            // 
            txtMasqueInverseAffiche.Location = new Point(25, 116);
            txtMasqueInverseAffiche.Name = "txtMasqueInverseAffiche";
            txtMasqueInverseAffiche.Size = new Size(329, 23);
            txtMasqueInverseAffiche.TabIndex = 14;
            txtMasqueInverseAffiche.Text = "Masque inverse :";
            // 
            // txtMasqueReseauAffiche
            // 
            txtMasqueReseauAffiche.Location = new Point(25, 87);
            txtMasqueReseauAffiche.Name = "txtMasqueReseauAffiche";
            txtMasqueReseauAffiche.Size = new Size(329, 23);
            txtMasqueReseauAffiche.TabIndex = 12;
            txtMasqueReseauAffiche.Text = "Masque de réseau :";
            // 
            // txtCIDRAffiche
            // 
            txtCIDRAffiche.Location = new Point(25, 58);
            txtCIDRAffiche.Name = "txtCIDRAffiche";
            txtCIDRAffiche.Size = new Size(329, 23);
            txtCIDRAffiche.TabIndex = 11;
            txtCIDRAffiche.Text = "CIDR :";
            // 
            // txtClasseIPAffiche
            // 
            txtClasseIPAffiche.Location = new Point(25, 29);
            txtClasseIPAffiche.Name = "txtClasseIPAffiche";
            txtClasseIPAffiche.Size = new Size(329, 23);
            txtClasseIPAffiche.TabIndex = 10;
            txtClasseIPAffiche.Text = "Classe IP :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 807);
            Controls.Add(pnlAffiche);
            Controls.Add(panel1);
            Controls.Add(pnlBarre);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            pnlBarre.ResumeLayout(false);
            pnlBarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAffiche.ResumeLayout(false);
            pnlAffiche.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBarre;
        private Button btnQuitter;
        private Label lblTitre;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnCalculer2;
        private TextBox txtAdresseIPCIDR;
        private TextBox txtAdresseIP;
        private TextBox txtMasque;
        private Button btnResetALL;
        private Button btnCalculer;
        private Label lblOU;
        private Panel pnlAffiche;
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
        private TextBox txtMasqueBinaire;
        private TextBox txtAdresseBinaire;
    }
}
