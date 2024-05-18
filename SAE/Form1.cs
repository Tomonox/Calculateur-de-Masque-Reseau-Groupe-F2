using System.Net;

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
        private void btnCalculer2_Click(object sender, EventArgs e)
        {
            // Récupérer l'adresse IP CIDR de txtAdresseIPCIDR
            string ipAddressCIDR = txtAdresseIPCIDR.Text;

            // Séparer l'adresse IP de la partie CIDR
            string[] parts = ipAddressCIDR.Split('/');
            if (parts.Length == 2)
            {
                // Récupérer le CIDR
                int cidr = int.Parse(parts[1]);

                // Afficher le CIDR dans txtCIDRAffiche
                txtCIDRAffiche.Text = "CIDR : " + cidr;

                // Calculer et afficher la classe de l'adresse IP
                string[] octets = parts[0].Split('.');
                if (octets.Length == 4)
                {
                    // Convertir le premier octet en entier
                    int firstOctet = int.Parse(octets[0]);

                    // Déterminer la classe de l'adresse IP en fonction de la plage d'adresses IP pour chaque classe
                    string ipClass = "";
                    if (firstOctet >= 1 && firstOctet <= 126)
                    {
                        ipClass = "A";
                    }
                    else if (firstOctet >= 128 && firstOctet <= 191)
                    {
                        ipClass = "B";
                    }
                    else if (firstOctet >= 192 && firstOctet <= 223)
                    {
                        ipClass = "C";
                    }
                    else if (firstOctet >= 224 && firstOctet <= 239)
                    {
                        ipClass = "D";
                    }
                    else if (firstOctet >= 240 && firstOctet <= 255)
                    {
                        ipClass = "E";
                    }

                    // Afficher la classe de l'adresse IP dans txtClasseIPAffiche
                    txtClasseIPAffiche.Text = "Classe IP : " + ipClass;
                }
                else
                {
                    // Gérer les erreurs si l'adresse IP n'est pas correctement formatée
                    MessageBox.Show("Adresse IP non valide");
                    return;
                }

                // Calculer le masque de réseau à partir du CIDR
                uint subnetMask = ~(uint.MaxValue >> cidr);

                // Convertir le masque de réseau en format d'adresse IP
                byte[] bytes = BitConverter.GetBytes(subnetMask);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(bytes);
                }
                IPAddress subnetMaskIP = new IPAddress(bytes);
                string subnetMaskString = subnetMaskIP.ToString();

                // Afficher le masque de réseau dans txtMasqueReseauAffiche
                txtMasqueReseauAffiche.Text = "Masque de réseau : " + subnetMaskString;

                // Calculer et afficher le masque inverse
                uint inverseSubnetMask = ~subnetMask;
                byte[] inverseBytes = BitConverter.GetBytes(inverseSubnetMask);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(inverseBytes);
                }
                IPAddress inverseSubnetMaskIP = new IPAddress(inverseBytes);
                string inverseSubnetMaskString = inverseSubnetMaskIP.ToString();

                // Afficher le masque inverse dans txtMasqueInverseAffiche
                txtMasqueInverseAffiche.Text = "Masque inverse : " + inverseSubnetMaskString;

                // Calculer l'adresse du réseau
                string[] ipParts = parts[0].Split('.');
                byte[] ipBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    ipBytes[i] = byte.Parse(ipParts[i]);
                }
                byte[] networkBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    networkBytes[i] = (byte)(ipBytes[i] & bytes[i]);
                }

                // Convertir l'adresse du réseau en une chaîne d'adresse IP
                IPAddress networkAddress = new IPAddress(networkBytes);
                string networkAddressString = networkAddress.ToString();

                // Afficher l'adresse du réseau dans txtAdresseReseauAffiche
                txtAdresseReseauAffiche.Text = "Adresse du réseau : " + networkAddressString;

                // Calculer et afficher la première adresse utilisable
                byte[] firstUsableBytes = (byte[])networkBytes.Clone();
                firstUsableBytes[3] += 1;
                IPAddress firstUsableAddress = new IPAddress(firstUsableBytes);
                string firstUsableAddressString = firstUsableAddress.ToString();
                txtPremiereAdresseAffiche.Text = "Première adresse : " + firstUsableAddressString;
                txtPremiereMachineAffiche.Text = "Première Machine : " + firstUsableAddressString;

                // Calculer et afficher la dernière adresse utilisable
                byte[] broadcastBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    broadcastBytes[i] = (byte)(networkBytes[i] | ~bytes[i]);
                }
                byte[] lastUsableBytes = (byte[])broadcastBytes.Clone();
                lastUsableBytes[3] -= 1;
                IPAddress lastUsableAddress = new IPAddress(lastUsableBytes);
                string lastUsableAddressString = lastUsableAddress.ToString();
                txtDerniereAdresseAffiche.Text = "Dernière adresse : " + lastUsableAddressString;
                txtDerniereMachineAffiche.Text = "Dernière Machine : " + lastUsableAddressString;

                // Afficher l'adresse de broadcast
                IPAddress broadcastAddress = new IPAddress(broadcastBytes);
                string broadcastAddressString = broadcastAddress.ToString();
                txtAdresseBroadcastAffiche.Text = "Adresse de broadcast : " + broadcastAddressString;

                // Calculer et afficher le nombre d'adresses IP disponibles
                uint totalAddresses = (uint)(1 << (32 - cidr));
                uint usableAddresses = cidr >= 31 ? 0 : totalAddresses - 2; // Si CIDR est 31 ou 32, 0 adresses utilisables
                txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : " + usableAddresses;
            }
            else
            {
                // Gérer les erreurs si l'adresse IP CIDR n'est pas correctement formatée
                MessageBox.Show("Adresse IP CIDR non valide");
            }
        }
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

        private void txtPremiereMachineAffiche_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResetALL2_Click(object sender, EventArgs e)
        {
            txtClasseIPAffiche.Text = "Classe IP : ";
            txtCIDRAffiche.Text = "CIDR : ";
            txtMasqueReseauAffiche.Text = "Masque de réseau : ";
            txtMasqueInverseAffiche.Text = "Masque inverse : ";
            txtAdresseReseauAffiche.Text = "Adresse du réseau : ";
            txtPremiereAdresseAffiche.Text = "Première adresse : ";
            txtDerniereAdresseAffiche.Text = "Dernière adresse : ";
            txtAdresseBroadcastAffiche.Text = "Adresse de broadcast : ";
            txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : ";
            txtPremiereMachineAffiche.Text = "Première Machine : ";
            txtDerniereMachineAffiche.Text = "Dernière Machine : ";
        }
    }
}
