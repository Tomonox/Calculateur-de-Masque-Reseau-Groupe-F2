namespace SAE
{
    public partial class Form1 : Form
    {
        private string PlaceholderText;

        public Form1()
        {
            InitializeComponent();
            InitializeGroupBoxTextBoxes();
            InitializePlaceholder();
        }

        private void InitializeGroupBoxTextBoxes()
        {
            foreach (Control control in grpAffichage.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.TabStop = false;
                }
            }
        }

        private void InitializePlaceholder()
        {
            txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
            txtAdresseIPCIDR.ForeColor = SystemColors.GrayText;

            txtAdresseIP.Text = "Adresse IPV4";
            txtAdresseIP.ForeColor = SystemColors.GrayText;

            txtMasque.Text = "Masque";
            txtMasque.ForeColor = SystemColors.GrayText;
        }


        private void txtAdresseIPCIDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresseIPCIDR_Enter_1(object sender, EventArgs e)
        {

            if (txtAdresseIPCIDR.Text == "Adresse IPV4 / CIDR")
            {
                txtAdresseIPCIDR.Text = "";
                txtAdresseIPCIDR.ForeColor = SystemColors.ControlText;
            }
        }



        private void txtAdresseIP_Enter_1(object sender, EventArgs e)
        {

            if (txtAdresseIP.Text == "Adresse IPV4")
            {
                txtAdresseIP.Text = "";
                txtAdresseIP.ForeColor = SystemColors.ControlText; 
            }
        }

        private void txtAdresseIP_Leave_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtAdresseIP.Text))
            {
                txtAdresseIP.Text = "Adresse IPV4";
                txtAdresseIP.ForeColor = SystemColors.GrayText; 
            }
        }

        /// Bordel
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtAdresseIP_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void btnENVOYER_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void txtClasseIPAffiche_TextChanged(object sender, EventArgs e) { }
        private void grpAffichage_Enter(object sender, EventArgs e) { }
        private void btnCalculer2_Click(object sender, EventArgs e) { }
        private void txtMasque_TextChanged(object sender, EventArgs e) { }
        private void btnResetALL_Click(object sender, EventArgs e)
        {
            txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
            txtAdresseIPCIDR.ForeColor = SystemColors.GrayText;

            txtAdresseIP.Text = "Adresse IPV4";
            txtAdresseIP.ForeColor = SystemColors.GrayText;

            txtMasque.Text = "Masque";
            txtMasque.ForeColor = SystemColors.GrayText;
        }
        
        private void txtCIDRAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtMasqueSousReseauAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtMasqueInverseAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtAdresseReseauAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtPremiereAdresseAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtDerniereAdresseAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtAdresseBroadcastAffiche_TextChanged(object sender, EventArgs e) { }
        private void txtNombreIPDispoAffiche_TextChanged(object sender, EventArgs e) { }
        //

        private void txtAdresseIPCIDR_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresseIPCIDR.Text))
            {
                txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
                txtAdresseIPCIDR.ForeColor = SystemColors.GrayText; // Changer la couleur du texte en gris
            }
        }

        private void txtMasque_Enter(object sender, EventArgs e)
        {
            if (txtMasque.Text == "Masque")
            {
                txtMasque.Text = "";
                txtMasque.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtMasque_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasque.Text))
            {
                txtMasque.Text = "Masque";
                txtMasque.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
