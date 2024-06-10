using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Net;
using System.Text;



namespace SAE
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        private uint subnetMask;
        public Form1()
        {
            InitializeComponent();
            SetTextBoxesReadOnly(pnlAffiche, true); // Rendre tous les TextBox dans pnlAffiche en lecture seule
            InitializePlaceholder();

        }

        private void SetTextBoxesReadOnly(Control parentControl, bool readOnly)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = readOnly;
                }
                else if (control.HasChildren)
                {
                    SetTextBoxesReadOnly(control, readOnly);
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

        private bool IsValidSubnetMask(byte[] maskBytes)
        {
            // Convertir le masque en une cha�ne de bits
            StringBuilder binaryMask = new StringBuilder();
            foreach (byte b in maskBytes)
            {
                binaryMask.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            // V�rifier si la cha�ne de bits est continue
            bool foundZero = false;
            for (int i = 0; i < binaryMask.Length; i++)
            {
                if (binaryMask[i] == '0')
                {
                    foundZero = true;
                }
                else if (foundZero)
                {
                    // S'il y a un z�ro apr�s qu'on ait trouv� un z�ro pr�c�demment,
                    // le masque n'est pas valide
                    return false;
                }
            }

            return true;
        }

        private bool IsValidIPv4(string ipString)
        {
            if (string.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;
            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private bool IsSpecialIPAddress(IPAddress ipAddress, out string message)
        {
            var specialIPRanges = new Dictionary<string, string>
    {
        { "0.0.0.0/8", "Plage d'adresses \"This Network\" non autoris�e. Mais peut etre calcul�e." },
        { "10.0.0.0/8", "Plage d'adresses \"Private-Use Networks\" non autoris�e. Mais peut etre calcul�e." },
        { "127.0.0.0/8", "Plage d'adresses \"Loopback\" non autoris�e. Mais peut etre calcul�e." },
        { "169.254.0.0/16", "Plage d'adresses \"Link Local\" non autoris�e. Mais peut etre calcul�e." },
        { "172.16.0.0/12", "Plage d'adresses \"Private-Use Networks\" non autoris�e. Mais peut etre calcul�e." },
        { "192.0.0.0/24", "Plage d'adresses \"IETF Protocol Assignments\" non autoris�e. Mais peut etre calcul�e." },
        { "192.0.2.0/24", "Plage d'adresses \"TEST-NET-1\" non autoris�e. Mais peut etre calcul�e." },
        { "192.88.99.0/24", "Plage d'adresses \"6to4 Relay Anycast\" non autoris�e. Mais peut etre calcul�e." },
        { "192.168.0.0/16", "Plage d'adresses \"Private-Use Networks\" non autoris�e. Mais peut etre calcul�e." },
        { "198.18.0.0/15", "Plage d'adresses \"Network Interconnect\" non autoris�e. Mais peut etre calcul�e." },
        { "198.51.100.0/24", "Plage d'adresses \"TEST-NET-2\" non autoris�e. Mais peut etre calcul�e." },
        { "203.0.113.0/24", "Plage d'adresses \"TEST-NET-3\" non autoris�e. Mais peut etre calcul�e." },
        { "224.0.0.0/4", "Plage d'adresses \"Multicast\" non autoris�e. Mais peut etre calcul�e." },
        { "240.0.0.0/4", "Plage d'adresses \"Reserved for Future Use\" non autoris�e. Mais peut etre calcul�e." },
        { "255.255.255.255/32", "Plage d'adresses \"Limited Broadcast\" non autoris�e. Mais peut etre calcul�e." }
    };

            foreach (var range in specialIPRanges)
            {
                string[] parts = range.Key.Split('/');
                IPAddress networkAddress = IPAddress.Parse(parts[0]);
                int cidr = int.Parse(parts[1]);

                byte[] ipBytes = ipAddress.GetAddressBytes();
                byte[] networkBytes = networkAddress.GetAddressBytes();

                bool match = true;
                for (int i = 0; i < cidr / 8; i++)
                {
                    if (ipBytes[i] != networkBytes[i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    int remainingBits = cidr % 8;
                    if (remainingBits > 0)
                    {
                        byte mask = (byte)(0xFF00 >> remainingBits);
                        if ((ipBytes[cidr / 8] & mask) != (networkBytes[cidr / 8] & mask))
                        {
                            match = false;
                        }
                    }
                }

                if (match)
                {
                    message = range.Value;
                    return true;
                }
            }

            message = null;
            return false;
        }


        private void btnQuitter_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void pnlBarre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void pnlBarre_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point endPoint = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            }
        }

        private void pnlBarre_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // R�initialiser le point de d�part
                startPoint = Point.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.White, 2);
            Rectangle rect = new Rectangle(0, 0, panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);

            e.Graphics.DrawRectangle(p, rect);
        }

        private void btnCalculer2_Click_1(object sender, EventArgs e)
        {
            // R�cup�rer l'adresse IP CIDR de txtAdresseIPCIDR
            string ipAddressCIDR = txtAdresseIPCIDR.Text;

            // V�rifier si rien n'est saisi dans le champ de l'adresse IP CIDR
            if (ipAddressCIDR == "Adresse IPV4 / CIDR")
            {
                MessageBox.Show("Veuillez saisir une adresse IPV4/CIDR.");
                return;
            }

            // S�parer l'adresse IP de la partie CIDR
            string[] parts = ipAddressCIDR.Split('/');
            if (parts.Length == 2)
            {
                // R�cup�rer le CIDR
                if (!int.TryParse(parts[1], out int cidr) || cidr < 0 || cidr > 32)
                {
                    // Afficher une erreur si le CIDR est sup�rieur � 32 ou non valide
                    MessageBox.Show("CIDR invalide. Veuillez entrer une valeur entre 0 et 32.");
                    return;
                }

                // S�parer l'adresse IP en octets
                string[] octets = parts[0].Split('.');
                if (octets.Length == 4)
                {
                    // V�rifier que chaque octet est un entier valide entre 0 et 255
                    bool isValidIP = true;
                    foreach (string octet in octets)
                    {
                        if (!int.TryParse(octet, out int value) || value < 0 || value > 255)
                        {
                            isValidIP = false;
                            break;
                        }

                        // Ajouter une v�rification pour emp�cher les octets commen�ant par 0 sauf "0"
                        if (octet.Length > 1 && octet.StartsWith("0"))
                        {
                            isValidIP = false;
                            break;
                        }
                    }

                    if (!isValidIP)
                    {
                        // G�rer les erreurs si l'adresse IP n'est pas correctement format�e
                        MessageBox.Show("Adresse IP invalide. Veuillez entrer une valeur entre 0.0.0.0 et 255.255.255.255 sans octets commen�ant par z�ro.");
                        return;
                    }

                    // Convertir l'adresse IP en une cha�ne binaire
                    string binaryIP = string.Join(".", octets.Select(octet => Convert.ToString(int.Parse(octet), 2).PadLeft(8, '0')));

                    // Convertir le masque en fonction du CIDR
                    uint subnetMask = 0xFFFFFFFF << (32 - cidr);

                    // Convertir le masque en une cha�ne binaire
                    byte[] maskBytes = BitConverter.GetBytes(subnetMask);
                    if (BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(maskBytes);
                    }

                    // Convertir le premier octet en entier
                    int firstOctet = int.Parse(octets[0]);

                    // D�terminer la classe de l'adresse IP en fonction de la plage d'adresses IP pour chaque classe
                    string ipClass = "";
                    int minCIDR = 0; // Minimum CIDR pour la classe
                    if (firstOctet >= 1 && firstOctet <= 126)
                    {
                        ipClass = "A";
                        minCIDR = 8;
                    }
                    else if (firstOctet >= 128 && firstOctet <= 191)
                    {
                        ipClass = "B";
                        minCIDR = 16;
                    }
                    else if (firstOctet >= 192 && firstOctet <= 223)
                    {
                        ipClass = "C";
                        minCIDR = 24;
                    }
                    else if (firstOctet >= 224 && firstOctet <= 239)
                    {
                        ipClass = "D";
                        minCIDR = 24; // Classe D (Multicast) n'a pas de masque CIDR standard, mais on peut le consid�rer comme classe C pour cet exemple
                    }
                    else if (firstOctet >= 240 && firstOctet <= 255)
                    {
                        ipClass = "E";
                        minCIDR = 24; // Classe E (Exp�rimentale) n'a pas de masque CIDR standard, mais on peut le consid�rer comme classe C pour cet exemple
                    }
                    else if (firstOctet == 0)
                    {
                        ipClass = "A"; // Si le premier octet est 0, il appartient �galement � la classe A
                        minCIDR = 8;
                    }

                    // V�rifier si le CIDR est trop petit pour la classe
                    if (cidr < minCIDR)
                    {
                        MessageBox.Show($"Le CIDR est trop petit pour la classe {ipClass}. Le CIDR minimum pour la classe {ipClass} est {minCIDR}.");
                        return; // Sortir imm�diatement de la m�thode pour �viter l'affichage des r�sultats
                    }

                    // Afficher le CIDR seulement si tout est valide
                    txtCIDRAffiche.Text = "CIDR : " + cidr;

                    // Afficher l'adresse IP en binaire dans txtAdresseBinaire
                    txtAdresseBinaire.Text = "Adresse IP en Binaire : " + binaryIP;

                    // Calculer et afficher le masque en binaire dans txtMasqueBinaire
                    string binaryMask = string.Join(".", maskBytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
                    txtMasqueBinaire.Text = "Masque en Binaire : " + binaryMask;

                    // Afficher la classe de l'adresse IP dans txtClasseIPAffiche
                    txtClasseIPAffiche.Text = "Classe IP : " + ipClass;

                    // Mettre � jour le champ txtAdresseIP
                    txtAdresseIP.Text = parts[0];
                    txtAdresseIP.ForeColor = SystemColors.ControlText;
                }
                else
                {
                    // G�rer les erreurs si l'adresse IP n'est pas correctement format�e
                    MessageBox.Show("Adresse IPV4/CIDR invalide.");
                    return;
                }

                // Calculer le masque de r�seau � partir du CIDR
                subnetMask = 0xffffffff << (32 - cidr);

                // Convertir le masque de r�seau en format d'adresse IP
                byte[] bytes = BitConverter.GetBytes(subnetMask);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(bytes);
                }
                IPAddress subnetMaskIP = new IPAddress(bytes);
                string subnetMaskString = subnetMaskIP.ToString();

                // Afficher le masque de r�seau dans txtMasqueReseauAffiche
                txtMasqueReseauAffiche.Text = "Masque de r�seau : " + subnetMaskString;

                // Mettre � jour le champ txtMasque
                txtMasque.Text = subnetMaskString;
                txtMasque.ForeColor = SystemColors.ControlText;

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

                // Calculer l'adresse de r�seau
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

                // Convertir l'adresse du r�seau en une cha�ne d'adresse IP
                IPAddress networkAddress = new IPAddress(networkBytes);
                string networkAddressString = networkAddress.ToString();

                // Afficher l'adresse du r�seau dans txtAdresseReseauAffiche
                txtAdresseReseauAffiche.Text = "Adresse de r�seau : " + networkAddressString;

                // Calculer et afficher la premi�re adresse utilisable
                byte[] firstUsableBytes = (byte[])networkBytes.Clone();
                firstUsableBytes[3] += 1;
                IPAddress firstUsableAddress = new IPAddress(firstUsableBytes);
                string firstUsableAddressString = firstUsableAddress.ToString();
                txtPremiereAdresseAffiche.Text = "Premi�re adresse : " + firstUsableAddressString;

                // Calculer et afficher la derni�re adresse utilisable
                byte[] broadcastBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    broadcastBytes[i] = (byte)(networkBytes[i] | ~bytes[i]);
                }
                byte[] lastUsableBytes = (byte[])broadcastBytes.Clone();
                lastUsableBytes[3] -= 1;
                IPAddress lastUsableAddress = new IPAddress(lastUsableBytes);
                string lastUsableAddressString = lastUsableAddress.ToString();
                txtDerniereAdresseAffiche.Text = "Derni�re adresse : " + lastUsableAddressString;

                // Afficher l'adresse de broadcast
                IPAddress broadcastAddress = new IPAddress(broadcastBytes);
                string broadcastAddressString = broadcastAddress.ToString();
                txtAdresseBroadcastAffiche.Text = "Adresse de broadcast : " + broadcastAddressString;

                // Calculer et afficher le nombre d'adresses IP disponibles
                uint totalAddresses = (uint)(1 << (32 - cidr));
                uint usableAddresses = cidr >= 31 ? 0 : totalAddresses; // Si CIDR est 31 ou 32, 0 adresses utilisables
                txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : " + usableAddresses;

                // Calculer et afficher le nombre de machines disponibles
                uint machines = usableAddresses == 0 ? 0 : usableAddresses - 2; // Soustraire 2 pour l'adresse r�seau et de diffusion
                txtNombreMachineDispoAffiche.Text = "Nombre de machines disponibles : " + machines;

                // V�rifier si l'adresse IP appartient � une plage d'adresses IP sp�ciales
                IPAddress ipAddress = IPAddress.Parse(parts[0]);
                if (IsSpecialIPAddress(ipAddress, out string message))
                {
                    MessageBox.Show(message);
                    return;
                }

            }
            else
            {
                // G�rer les erreurs si l'adresse IP CIDR n'est pas correctement format�e
                MessageBox.Show("Adresse IPV4/CIDR invalide.");
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            string ipAddress = txtAdresseIP.Text.Trim();
            string subnetMask = txtMasque.Text.Trim();

            // V�rifier si les champs contiennent les valeurs par d�faut
            if (ipAddress == "Adresse IPV4" || subnetMask == "Masque")
            {
                MessageBox.Show("Veuillez saisir une adresse IP et un masque de r�seau.");
                return;
            }

            // V�rifier que l'adresse IP est correctement format�e
            if (!IsValidIPv4(ipAddress))
            {
                MessageBox.Show("Adresse IP invalide. Veuillez entrer une valeur entre 0.0.0.0 et 255.255.255.255.");
                return;
            }

            // V�rifier que le masque de r�seau est correctement format�
            if (!IsValidIPv4(subnetMask))
            {
                MessageBox.Show("Masque de r�seau invalide. Veuillez entrer une valeur entre 0.0.0.0 et 255.255.255.255.");
                return;
            }

            // Parse IP after validation
            IPAddress ip = IPAddress.Parse(ipAddress);

            // Parse subnet mask after validation
            IPAddress mask = IPAddress.Parse(subnetMask);
            byte[] maskBytes = mask.GetAddressBytes();

            // V�rifier le masque pour s'assurer qu'il est valide
            if (!IsValidSubnetMask(maskBytes))
            {
                MessageBox.Show("Masque de r�seau invalide. Veuillez entrer un masque valide.");
                return;
            }

            byte[] ipBytes = ip.GetAddressBytes();

            // V�rifier que les octets de l'adresse IP ne commencent pas par 0 sauf "0" lui-m�me
            foreach (string octet in ipAddress.Split('.'))
            {
                if (octet.Length > 1 && octet.StartsWith("0"))
                {
                    MessageBox.Show("Adresse IP invalide. Veuillez entrer une valeur entre 0.0.0.0 et 255.255.255.255 sans octets commen�ant par z�ro.");
                    return;
                }
            }

            // V�rifier si l'adresse IP appartient � une plage d'adresses IP sp�ciales
            if (IsSpecialIPAddress(ip, out string message))
            {
                MessageBox.Show(message);
                // Ne pas retourner ici pour continuer les calculs
            }

            // Compter le nombre de bits � 1 dans le masque de r�seau
            int cidr = 0;
            for (int i = 0; i < maskBytes.Length; i++)
            {
                byte b = maskBytes[i];
                while (b > 0)
                {
                    if ((b & 1) == 1)
                        cidr++;
                    b >>= 1;
                }
            }

            // Afficher le CIDR dans txtCIDRAffiche
            txtCIDRAffiche.Text = "CIDR : " + cidr;

            // Calculer et afficher la classe de l'adresse IP
            string ipClass = "";
            if ((ipBytes[0] & 0x80) == 0)
            {
                ipClass = "A";
            }
            else if ((ipBytes[0] & 0xC0) == 0x80)
            {
                ipClass = "B";
            }
            else if ((ipBytes[0] & 0xE0) == 0xC0)
            {
                ipClass = "C";
            }
            else if ((ipBytes[0] & 0xF0) == 0xE0)
            {
                ipClass = "D";
            }
            else if ((ipBytes[0] & 0xF0) == 0xF0)
            {
                ipClass = "E";
            }

            // Afficher la classe de l'adresse IP dans txtClasseIPAffiche
            txtClasseIPAffiche.Text = "Classe IP : " + ipClass;

            // Calculer le masque de r�seau minimum pour la classe
            int minCIDR = 0; // Minimum CIDR pour la classe
            if (ipClass == "A")
            {
                minCIDR = 8;
            }
            else if (ipClass == "B")
            {
                minCIDR = 16;
            }
            else if (ipClass == "C")
            {
                minCIDR = 24;
            }
            else if (ipClass == "D" || ipClass == "E")
            {
                minCIDR = 24; // Pour les classes D et E, consid�rer 24 comme le minimum pour cet exemple
            }

            // V�rifier si le CIDR est trop petit pour la classe
            if (cidr < minCIDR)
            {
                MessageBox.Show($"Le Masque est trop petit pour la classe {ipClass}. ");
                return;
            }

            // Calculer le masque de r�seau en format d'adresse IP
            IPAddress subnetMaskIP = new IPAddress(maskBytes);
            string subnetMaskString = subnetMaskIP.ToString();

            // Afficher le masque de r�seau dans txtMasqueReseauAffiche
            txtMasqueReseauAffiche.Text = "Masque de r�seau : " + subnetMaskString;

            // Calculer et afficher le masque inverse
            byte[] inverseMaskBytes = new byte[maskBytes.Length];
            for (int i = 0; i < maskBytes.Length; i++)
            {
                inverseMaskBytes[i] = (byte)~maskBytes[i];
            }
            IPAddress inverseSubnetMaskIP = new IPAddress(inverseMaskBytes);
            string inverseSubnetMaskString = inverseSubnetMaskIP.ToString();

            // Afficher le masque inverse dans txtMasqueInverseAffiche
            txtMasqueInverseAffiche.Text = "Masque inverse : " + inverseSubnetMaskString;

            // Convertir l'adresse IP en une cha�ne binaire
            string binaryIP = string.Join(".", ipBytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

            // Afficher l'adresse IP en binaire dans txtAdresseBinaire
            txtAdresseBinaire.Text = "Adresse IP en Binaire : " + binaryIP;

            // Calculer l'adresse du r�seau
            byte[] networkBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                networkBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
            }
            IPAddress networkAddress = new IPAddress(networkBytes);
            string networkAddressString = networkAddress.ToString();

            // Afficher l'adresse du r�seau dans txtAdresseReseauAffiche
            txtAdresseReseauAffiche.Text = "Adresse de r�seau : " + networkAddressString;

            // Calculer et afficher la premi�re adresse utilisable
            byte[] firstUsableBytes = (byte[])networkBytes.Clone();
            firstUsableBytes[3] += 1;
            IPAddress firstUsableAddress = new IPAddress(firstUsableBytes);
            string firstUsableAddressString = firstUsableAddress.ToString();
            txtPremiereAdresseAffiche.Text = "Premi�re adresse : " + firstUsableAddressString;

            // Calculer et afficher la derni�re adresse utilisable
            byte[] broadcastBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                broadcastBytes[i] = (byte)(networkBytes[i] | ~maskBytes[i]);
            }
            byte[] lastUsableBytes = (byte[])broadcastBytes.Clone();
            lastUsableBytes[3] -= 1;
            IPAddress lastUsableAddress = new IPAddress(lastUsableBytes);
            string lastUsableAddressString = lastUsableAddress.ToString();
            txtDerniereAdresseAffiche.Text = "Derni�re adresse : " + lastUsableAddressString;

            // Afficher l'adresse de broadcast
            IPAddress broadcastAddress = new IPAddress(broadcastBytes);
            string broadcastAddressString = broadcastAddress.ToString();
            txtAdresseBroadcastAffiche.Text = "Adresse de broadcast : " + broadcastAddressString;

            // Calculer et afficher le nombre d'adresses IP disponibles
            uint totalAddresses = (uint)(1 << (32 - cidr));
            uint usableAddresses = cidr >= 31 ? 0 : totalAddresses; // Si CIDR est 31 ou 32, 0 adresses utilisables
            txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : " + usableAddresses;

            // Mettre � jour txtAdresseIPCIDR avec l'adresse IP et le CIDR
            txtAdresseIPCIDR.Text = $"{ipAddress}/{cidr}";
            txtAdresseIPCIDR.ForeColor = SystemColors.ControlText; // D�finir la couleur du texte en noir

            // Calculer et afficher le nombre de machines disponibles
            uint usableMachines = cidr >= 31 ? 0 : totalAddresses - 2; // Si CIDR est 31 ou 32, 0 adresses utilisables
            txtNombreMachineDispoAffiche.Text = "Nombre de machines disponibles : " + usableMachines;

            // Afficher le masque en binaire dans txtMasqueBinaire
            string binaryMask = string.Join(".", maskBytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
            txtMasqueBinaire.Text = "Masque en Binaire : " + binaryMask;
        }
        private string MaskBinaire(string mask)
        {
            // V�rifier si le masque n'est pas vide et n'est pas le message par d�faut
            if (!string.IsNullOrWhiteSpace(mask) && mask != "Masque")
            {
                // S�parer le masque en octets
                string[] octets = mask.Split('.');

                // Convertir chaque octet en binaire et les joindre avec des points
                string binaryMask = string.Join(".", octets.Select(octet => Convert.ToString(int.Parse(octet), 2).PadLeft(8, '0')));

                return binaryMask;
            }

            return "";
        }

        private void txtAdresseIPCIDR_Enter(object sender, EventArgs e)
        {
            if (txtAdresseIPCIDR.Text == "Adresse IPV4 / CIDR")
            {
                txtAdresseIPCIDR.Text = "";
                txtAdresseIPCIDR.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtAdresseIPCIDR_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresseIPCIDR.Text))
            {
                txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
                txtAdresseIPCIDR.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtAdresseIP_Enter(object sender, EventArgs e)
        {
            if (txtAdresseIP.Text == "Adresse IPV4")
            {
                txtAdresseIP.Text = "";
                txtAdresseIP.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtAdresseIP_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAdresseIP.Text))
            {
                txtAdresseIP.Text = "Adresse IPV4";
                txtAdresseIP.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtMasque_Enter_1(object sender, EventArgs e)
        {
            if (txtMasque.Text == "Masque")
            {
                txtMasque.Text = "";
                txtMasque.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtMasque_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasque.Text))
            {
                txtMasque.Text = "Masque";
                txtMasque.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnResetALL2_Click_1(object sender, EventArgs e)
        {
            txtClasseIPAffiche.Text = "Classe IP : ";
            txtCIDRAffiche.Text = "CIDR : ";
            txtMasqueReseauAffiche.Text = "Masque de r�seau : ";
            txtMasqueInverseAffiche.Text = "Masque inverse : ";
            txtAdresseBinaire.Text = "Adresse IP en Binaire :";
            txtMasqueBinaire.Text = "Masque en Binaire :";
            txtAdresseReseauAffiche.Text = "Adresse de r�seau : ";
            txtPremiereAdresseAffiche.Text = "Premi�re adresse : ";
            txtDerniereAdresseAffiche.Text = "Derni�re adresse : ";
            txtAdresseBroadcastAffiche.Text = "Adresse de broadcast : ";
            txtNombreIPDispoAffiche.Text = "Nombre d'adresses IP disponibles : ";
            txtNombreMachineDispoAffiche.Text = "Nombre de machines disponibles :";
            txtAdresseIPCIDR.Text = "Adresse IPV4 / CIDR";
            txtAdresseIPCIDR.ForeColor = SystemColors.GrayText;
            txtAdresseIP.Text = "Adresse IPV4";
            txtAdresseIP.ForeColor = SystemColors.GrayText;
            txtMasque.Text = "Masque";
            txtMasque.ForeColor = SystemColors.GrayText;
        }

        private void pnlAffiche_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.White, 2);
            Rectangle rect = new Rectangle(0, 0, pnlAffiche.ClientRectangle.Width, pnlAffiche.ClientRectangle.Height);

            e.Graphics.DrawRectangle(p, rect);
        }

        private void txtAdresseIPCIDR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




