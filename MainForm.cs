using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace SwitchNetConfig
{
    /// <summary>
    /// Main Form displayed at startup
    /// </summary>
    public class NetworkAddressManagerForm : System.Windows.Forms.Form
    {
        #region Designer

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ComboBox cboProfiles;
        private System.Windows.Forms.Button btnCreateNewProfile;
        private System.Windows.Forms.ComboBox cboNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblSubnet;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDNS;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.GroupBox grpNIC;
        private System.Windows.Forms.GroupBox grpIEProxy;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.CheckBox chkByPassForLocal;
        private System.Windows.Forms.GroupBox grpProxy;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.GroupBox grpCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentDNS;
        private System.Windows.Forms.Label lblCurrentGateway;
        private System.Windows.Forms.Label lblCurrentSubnet;
        private System.Windows.Forms.Label lblCurrentIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentProxy;
        private System.Windows.Forms.CheckBox chkDHCP;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip sysTrayMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private IContainer components;

        public NetworkAddressManagerForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkAddressManagerForm));
            this.cboProfiles = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnCreateNewProfile = new System.Windows.Forms.Button();
            this.grpNIC = new System.Windows.Forms.GroupBox();
            this.chkDHCP = new System.Windows.Forms.CheckBox();
            this.txtDNS = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblDNS = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblSubnet = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNIC = new System.Windows.Forms.ComboBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpIEProxy = new System.Windows.Forms.GroupBox();
            this.grpProxy = new System.Windows.Forms.GroupBox();
            this.chkByPassForLocal = new System.Windows.Forms.CheckBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.grpCurrent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentDNS = new System.Windows.Forms.Label();
            this.lblCurrentGateway = new System.Windows.Forms.Label();
            this.lblCurrentSubnet = new System.Windows.Forms.Label();
            this.lblCurrentIP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentProxy = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpNIC.SuspendLayout();
            this.grpIEProxy.SuspendLayout();
            this.grpProxy.SuspendLayout();
            this.grpCurrent.SuspendLayout();
            this.sysTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProfiles
            // 
            this.cboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfiles.Location = new System.Drawing.Point(94, 11);
            this.cboProfiles.Name = "cboProfiles";
            this.cboProfiles.Size = new System.Drawing.Size(338, 24);
            this.cboProfiles.TabIndex = 2;
            this.cboProfiles.SelectedIndexChanged += new System.EventHandler(this.cboProfiles_SelectedIndexChanged);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(8, 15);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(80, 16);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Load &Profile:";
            // 
            // btnCreateNewProfile
            // 
            this.btnCreateNewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewProfile.Location = new System.Drawing.Point(439, 12);
            this.btnCreateNewProfile.Name = "btnCreateNewProfile";
            this.btnCreateNewProfile.Size = new System.Drawing.Size(132, 23);
            this.btnCreateNewProfile.TabIndex = 3;
            this.btnCreateNewProfile.Text = "Create &New Profile";
            this.btnCreateNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // grpNIC
            // 
            this.grpNIC.Controls.Add(this.chkDHCP);
            this.grpNIC.Controls.Add(this.txtDNS);
            this.grpNIC.Controls.Add(this.txtGateway);
            this.grpNIC.Controls.Add(this.txtSubnet);
            this.grpNIC.Controls.Add(this.txtIP);
            this.grpNIC.Controls.Add(this.lblDNS);
            this.grpNIC.Controls.Add(this.lblGateway);
            this.grpNIC.Controls.Add(this.lblSubnet);
            this.grpNIC.Controls.Add(this.lblIP);
            this.grpNIC.Controls.Add(this.label1);
            this.grpNIC.Controls.Add(this.cboNIC);
            this.grpNIC.Enabled = false;
            this.grpNIC.Location = new System.Drawing.Point(27, 41);
            this.grpNIC.Name = "grpNIC";
            this.grpNIC.Size = new System.Drawing.Size(544, 223);
            this.grpNIC.TabIndex = 3;
            this.grpNIC.TabStop = false;
            this.grpNIC.Text = "IP Configuration";
            // 
            // chkDHCP
            // 
            this.chkDHCP.Location = new System.Drawing.Point(8, 44);
            this.chkDHCP.Name = "chkDHCP";
            this.chkDHCP.Size = new System.Drawing.Size(161, 21);
            this.chkDHCP.TabIndex = 6;
            this.chkDHCP.Text = "Obtain IP from &DHCP";
            this.chkDHCP.CheckedChanged += new System.EventHandler(this.chkDHCP_CheckedChanged);
            // 
            // txtDNS
            // 
            this.txtDNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNS.Location = new System.Drawing.Point(86, 189);
            this.txtDNS.Name = "txtDNS";
            this.txtDNS.Size = new System.Drawing.Size(424, 23);
            this.txtDNS.TabIndex = 13;
            this.txtDNS.Leave += new System.EventHandler(this.txtDNS_Leave);
            // 
            // txtGateway
            // 
            this.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGateway.Location = new System.Drawing.Point(86, 148);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(424, 23);
            this.txtGateway.TabIndex = 11;
            this.txtGateway.Leave += new System.EventHandler(this.txtGateway_Leave);
            // 
            // txtSubnet
            // 
            this.txtSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubnet.Location = new System.Drawing.Point(86, 107);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(424, 23);
            this.txtSubnet.TabIndex = 9;
            this.txtSubnet.Leave += new System.EventHandler(this.txtSubnet_Leave);
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Location = new System.Drawing.Point(86, 71);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(424, 23);
            this.txtIP.TabIndex = 7;
            this.txtIP.Leave += new System.EventHandler(this.txtIP_Leave);
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(8, 189);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(37, 16);
            this.lblDNS.TabIndex = 12;
            this.lblDNS.Text = "&DNS:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(8, 148);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(62, 16);
            this.lblGateway.TabIndex = 10;
            this.lblGateway.Text = "&Gateway:";
            // 
            // lblSubnet
            // 
            this.lblSubnet.AutoSize = true;
            this.lblSubnet.Location = new System.Drawing.Point(8, 107);
            this.lblSubnet.Name = "lblSubnet";
            this.lblSubnet.Size = new System.Drawing.Size(53, 16);
            this.lblSubnet.TabIndex = 8;
            this.lblSubnet.Text = "&Subnet:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(8, 71);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(24, 16);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "&IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Network &Card:";
            // 
            // cboNIC
            // 
            this.cboNIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNIC.Location = new System.Drawing.Point(104, 16);
            this.cboNIC.Name = "cboNIC";
            this.cboNIC.Size = new System.Drawing.Size(392, 24);
            this.cboNIC.TabIndex = 5;
            this.cboNIC.SelectedIndexChanged += new System.EventHandler(this.cboNIC_SelectedIndexChanged);
            // 
            // btnActivate
            // 
            this.btnActivate.Enabled = false;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivate.Location = new System.Drawing.Point(156, 566);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(152, 34);
            this.btnActivate.TabIndex = 18;
            this.btnActivate.Text = "&Activate Profile...";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(333, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 34);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpIEProxy
            // 
            this.grpIEProxy.Controls.Add(this.grpProxy);
            this.grpIEProxy.Controls.Add(this.chkUseProxy);
            this.grpIEProxy.Enabled = false;
            this.grpIEProxy.Location = new System.Drawing.Point(27, 274);
            this.grpIEProxy.Name = "grpIEProxy";
            this.grpIEProxy.Size = new System.Drawing.Size(544, 137);
            this.grpIEProxy.TabIndex = 6;
            this.grpIEProxy.TabStop = false;
            this.grpIEProxy.Text = "Internet Explorer Proxy";
            // 
            // grpProxy
            // 
            this.grpProxy.Controls.Add(this.chkByPassForLocal);
            this.grpProxy.Controls.Add(this.txtProxy);
            this.grpProxy.Controls.Add(this.lblProxy);
            this.grpProxy.Location = new System.Drawing.Point(8, 44);
            this.grpProxy.Name = "grpProxy";
            this.grpProxy.Size = new System.Drawing.Size(530, 89);
            this.grpProxy.TabIndex = 12;
            this.grpProxy.TabStop = false;
            this.grpProxy.Text = "Proxy";
            // 
            // chkByPassForLocal
            // 
            this.chkByPassForLocal.Location = new System.Drawing.Point(66, 49);
            this.chkByPassForLocal.Name = "chkByPassForLocal";
            this.chkByPassForLocal.Size = new System.Drawing.Size(196, 29);
            this.chkByPassForLocal.TabIndex = 17;
            this.chkByPassForLocal.Text = "&Bypass for local address";
            this.chkByPassForLocal.CheckedChanged += new System.EventHandler(this.chkByPassForLocal_CheckedChanged);
            // 
            // txtProxy
            // 
            this.txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProxy.Location = new System.Drawing.Point(64, 24);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(408, 23);
            this.txtProxy.TabIndex = 16;
            this.txtProxy.Leave += new System.EventHandler(this.txtProxy_Leave);
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Location = new System.Drawing.Point(8, 24);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(44, 16);
            this.lblProxy.TabIndex = 15;
            this.lblProxy.Text = "Pro&xy:";
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.Location = new System.Drawing.Point(8, 24);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(91, 18);
            this.chkUseProxy.TabIndex = 14;
            this.chkUseProxy.Text = "&Use Proxy";
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // grpCurrent
            // 
            this.grpCurrent.Controls.Add(this.label2);
            this.grpCurrent.Controls.Add(this.label3);
            this.grpCurrent.Controls.Add(this.label4);
            this.grpCurrent.Controls.Add(this.label5);
            this.grpCurrent.Controls.Add(this.lblCurrentDNS);
            this.grpCurrent.Controls.Add(this.lblCurrentGateway);
            this.grpCurrent.Controls.Add(this.lblCurrentSubnet);
            this.grpCurrent.Controls.Add(this.lblCurrentIP);
            this.grpCurrent.Controls.Add(this.label6);
            this.grpCurrent.Controls.Add(this.lblCurrentProxy);
            this.grpCurrent.Location = new System.Drawing.Point(27, 432);
            this.grpCurrent.Name = "grpCurrent";
            this.grpCurrent.Size = new System.Drawing.Size(544, 128);
            this.grpCurrent.TabIndex = 7;
            this.grpCurrent.TabStop = false;
            this.grpCurrent.Text = "Current Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gateway:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subnet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP:";
            // 
            // lblCurrentDNS
            // 
            this.lblCurrentDNS.AutoSize = true;
            this.lblCurrentDNS.Location = new System.Drawing.Point(65, 96);
            this.lblCurrentDNS.Name = "lblCurrentDNS";
            this.lblCurrentDNS.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentDNS.TabIndex = 10;
            // 
            // lblCurrentGateway
            // 
            this.lblCurrentGateway.AutoSize = true;
            this.lblCurrentGateway.Location = new System.Drawing.Point(72, 72);
            this.lblCurrentGateway.Name = "lblCurrentGateway";
            this.lblCurrentGateway.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentGateway.TabIndex = 9;
            // 
            // lblCurrentSubnet
            // 
            this.lblCurrentSubnet.AutoSize = true;
            this.lblCurrentSubnet.Location = new System.Drawing.Point(68, 48);
            this.lblCurrentSubnet.Name = "lblCurrentSubnet";
            this.lblCurrentSubnet.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentSubnet.TabIndex = 8;
            // 
            // lblCurrentIP
            // 
            this.lblCurrentIP.AutoSize = true;
            this.lblCurrentIP.Location = new System.Drawing.Point(68, 24);
            this.lblCurrentIP.Name = "lblCurrentIP";
            this.lblCurrentIP.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentIP.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Proxy:";
            // 
            // lblCurrentProxy
            // 
            this.lblCurrentProxy.AutoSize = true;
            this.lblCurrentProxy.Location = new System.Drawing.Point(256, 48);
            this.lblCurrentProxy.Name = "lblCurrentProxy";
            this.lblCurrentProxy.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentProxy.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Network address changed...";
            this.notifyIcon1.BalloonTipTitle = "Network Address Manager";
            this.notifyIcon1.ContextMenuStrip = this.sysTrayMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Network Address Manager";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // sysTrayMenu
            // 
            this.sysTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.sysTrayMenu.Name = "sysTrayMenu";
            this.sysTrayMenu.Size = new System.Drawing.Size(153, 48);
            this.sysTrayMenu.Text = "E&xit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // NetworkAddressManagerForm
            // 
            this.AcceptButton = this.btnActivate;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(586, 612);
            this.Controls.Add(this.grpCurrent);
            this.Controls.Add(this.grpIEProxy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.grpNIC);
            this.Controls.Add(this.btnCreateNewProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.cboProfiles);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "NetworkAddressManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Address Manager";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.NetworkAddressManagerForm_Resize);
            this.grpNIC.ResumeLayout(false);
            this.grpNIC.PerformLayout();
            this.grpIEProxy.ResumeLayout(false);
            this.grpProxy.ResumeLayout(false);
            this.grpProxy.PerformLayout();
            this.grpCurrent.ResumeLayout(false);
            this.grpCurrent.PerformLayout();
            this.sysTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #endregion

        #region Private Variables and properties

        // stores all the profiles
        private ArrayList _Profiles = new ArrayList();

        /// <summary>
        /// Returns the currently selected profile object
        /// </summary>
        private Profile _CurrentProfile
        {
            get
            {
                // find the profile for the currently selected profile
                foreach (Profile profile in _Profiles)
                    if (profile.Name.Equals(_ProfileName))
                        return profile;

                return null;
            }
        }

        /// <summary>
        /// Returns the NICProfile object for the currently selected NIC Name
        /// </summary>
        private NICProfile _CurrentNICProfile
        {
            get
            {
                // find the NIC Profile for the currently selected NIC name
                foreach (NICProfile profile in _CurrentProfile.NICProfiles)
                    if (profile.Name.Equals(_NICName))
                        return profile;

                // not found, create a new NIC Profile
                NICProfile newProfile = new NICProfile(cboNIC.Text);
                _CurrentProfile.NICProfiles.Add(newProfile);

                return newProfile;
            }
        }

        /// <summary>
        /// Returns the current NICName
        /// </summary>
        private string _NICName
        {
            get
            {
                return cboNIC.SelectedItem as string;
            }
        }

        /// <summary>
        /// returns the current profile name
        /// </summary>
        private string _ProfileName
        {
            get
            {
                return cboProfiles.SelectedItem as string;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Load profile from configuration file
        /// </summary>
        private void loadProfiles()
        {
            _Profiles = ConfigurationHelper.LoadConfig();

            // populate the profile drop down list
            cboProfiles.Items.Clear();
            foreach (Profile profile in _Profiles)
            {
                cboProfiles.Items.Add(profile.Name);
            }
        }

        /// <summary>
        /// Load a particular profile
        /// </summary>
        /// <param name="profile"></param>
        private void loadProfile(Profile profile)
        {
            // load the NIC list
            loadNICs();

            // load proxy setting
            loadIEProxy();

            btnActivate.Enabled = true;
        }

        /// <summary>
        /// Load NIC names
        /// </summary>
        private void loadNICs()
        {
            // get the NIC names
            ArrayList nicNames = WMIHelper.GetNICNames();

            // populate the NIC list
            cboNIC.Items.Clear();
            foreach (string name in nicNames)
                cboNIC.Items.Add(name);

            // if NIC found, select the first one
            if (cboNIC.Items.Count > 0)
            {
                cboNIC.SelectedIndex = 0;
                grpNIC.Enabled = true;
            }
        }


        /// <summary>
        /// Show the IP, DNS, Gateway and Subnet mask for the NIC name
        /// </summary>
        /// <param name="nicName"></param>
        private void loadNICProfile(string nicName)
        {
            NICProfile nicProfile = _CurrentNICProfile;
            if (null == nicProfile) return;

            txtIP.Text = nicProfile.IP;
            txtSubnet.Text = nicProfile.Subnet;
            txtGateway.Text = nicProfile.Gateway;
            txtDNS.Text = nicProfile.DNS;
            chkDHCP.Checked = nicProfile.UseDHCP;
        }

        /// <summary>
        /// Loads IE Proxy settings
        /// </summary>
        private void loadIEProxy()
        {
            IEProfile profile = _CurrentProfile.IEProfile;

            chkUseProxy.Checked = profile.UseProxy;
            chkByPassForLocal.Checked = profile.BypassLocal;
            //txtLocal.Text = profile.BypassAddresses;
            txtProxy.Text = profile.ProxyName;

            grpIEProxy.Enabled = true;
        }

        private void saveProfiles()
        {
            ConfigurationHelper.SaveConfig(_Profiles);
        }

        private void createNewProfile()
        {
            using (NewProfileDialog newProfileDialog = new NewProfileDialog())
            {

                if (DialogResult.OK == newProfileDialog.ShowDialog(this))
                {
                    // create a new profile object
                    Profile newProfile = new Profile(newProfileDialog.NewProfileName);
                    _Profiles.Add(newProfile);

                    // show it in the drop down as selected
                    cboProfiles.SelectedIndex = cboProfiles.Items.Add(newProfile.Name);

                    // load the NIC list
                    loadNICs();
                }
            }

            BuildContextMenuWithProfiles();
        }

        /// <summary>
        /// Loads current network configuration for the specified NIC and show in 
        /// the current configuration block
        /// </summary>
        /// <param name="nicName"></param>
        private void loadCurrentSetting(string nicName)
        {

            string[] ipAddresses;
            string[] subnets;
            string[] gateways;
            string[] dnses;

            // Load current IP configuration for the selected NIC
            WMIHelper.GetIP(nicName, out ipAddresses, out subnets, out gateways, out dnses);

            // if network connection is disabled, no information will be available
            if (null == ipAddresses || null == subnets || null == gateways || null == dnses)
                return;

            // Show the setting
            lblCurrentIP.Text = string.Join(",", ipAddresses);
            lblCurrentSubnet.Text = string.Join(",", subnets);
            lblCurrentGateway.Text = string.Join(",", gateways);
            lblCurrentDNS.Text = string.Join(",", dnses);
        }

        /// <summary>
        /// Displayes current proxy setting for Internet Explorer
        /// </summary>
        private void loadCurrentProxySetting()
        {
            if (IEProxy.ProxyEnabled)
                lblCurrentProxy.Text = IEProxy.ProxyServer;
            else
                lblCurrentProxy.Text = "No Proxy";

            if (IEProxy.BypassProxyForLocal)
                lblCurrentProxy.Text += ". Bypass local";
            else
                lblCurrentProxy.Text += ". Do not bypass local";
        }

        /// <summary>
        /// Apply currently selected profile
        /// </summary>
        private void applyProfile()
        {
            ApplySettingDialog applyDialog = new ApplySettingDialog();
            applyDialog.Show();
            applyDialog.Refresh();

            // Start applying setting
            applyDialog.ApplySetting(_CurrentProfile);

            // show current configuration after applying
            loadCurrentSetting(_NICName);
            loadCurrentProxySetting();

        }

        private void close()
        {
            this.Close();
        }

        private void loadApp()
        {
            loadProfiles();
            BuildContextMenuWithProfiles();
            loadCurrentProxySetting();
        }

        private void BuildContextMenuWithProfiles()
        {
            if (_Profiles.Count == 0)
            {
                _Profiles = ConfigurationHelper.LoadConfig();
            }

            // populate the profile drop down list
            sysTrayMenu.Items.Clear();
            sysTrayMenu.Items.Add("Restore", null, RestoreApplication);
            sysTrayMenu.Items.Add("-");

            foreach (Profile profile in _Profiles)
            {
                sysTrayMenu.Items.Add(profile.Name, null, ChangeProfile);
            }
            sysTrayMenu.Items.Add("-");
            sysTrayMenu.Items.Add("E&xit", null, ExitApplication);
        }
        private void RestoreApplication(object sender, System.EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        private void ChangeProfile(object sender, System.EventArgs e)
        {
            var selectedProfileName = (sender as ToolStripMenuItem).Text;
            cboProfiles.SelectedItem = selectedProfileName;
            applyProfile();
        }

        private void ExitApplication(object sender, System.EventArgs args)
        {
            close();
        }
        #endregion

        #region Events

        private void chkUseProxy_CheckedChanged(object sender, System.EventArgs e)
        {
            _CurrentProfile.IEProfile.UseProxy = grpProxy.Enabled = chkUseProxy.Checked;
        }

        private void cboProfiles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadProfile(_CurrentProfile);
        }

        private void txtIP_Leave(object sender, System.EventArgs e)
        {
            _CurrentNICProfile.IP = txtIP.Text;
        }

        private void txtSubnet_Leave(object sender, System.EventArgs e)
        {
            _CurrentNICProfile.Subnet = txtSubnet.Text;
        }

        private void txtGateway_Leave(object sender, System.EventArgs e)
        {
            _CurrentNICProfile.Gateway = txtGateway.Text;
        }

        private void txtDNS_Leave(object sender, System.EventArgs e)
        {
            _CurrentNICProfile.DNS = txtDNS.Text;
        }

        private void txtProxy_Leave(object sender, System.EventArgs e)
        {
            _CurrentProfile.IEProfile.ProxyName = txtProxy.Text;
        }

        private void chkByPassForLocal_CheckedChanged(object sender, System.EventArgs e)
        {
            _CurrentProfile.IEProfile.BypassLocal = chkByPassForLocal.Checked;
        }

        private void txtLocal_Leave(object sender, System.EventArgs e)
        {
            //_CurrentProfile.IEProfile.BypassAddresses = txtLocal.Text;
        }

        private void btnNewProfile_Click(object sender, System.EventArgs e)
        {
            createNewProfile();
        }

        private void cboNIC_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadNICProfile(_NICName);
            loadCurrentSetting(_NICName);
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveProfiles();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            close();
        }

        private void btnActivate_Click(object sender, System.EventArgs e)
        {
            applyProfile();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            loadApp();
        }

        private void chkDHCP_CheckedChanged(object sender, System.EventArgs e)
        {
            bool allowIP = !chkDHCP.Checked;
            txtIP.Enabled = txtSubnet.Enabled = txtGateway.Enabled = txtDNS.Enabled = allowIP;
            _CurrentNICProfile.UseDHCP = chkDHCP.Checked;
        }

        #endregion

        private void NetworkAddressManagerForm_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
