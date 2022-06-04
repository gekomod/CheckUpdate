namespace CheckUpdate
{
    partial class Var
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Var));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sdcard_detect = new System.Windows.Forms.ToolStripStatusLabel();
            this.ver2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.selected_software = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjscieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSDid = new MaterialSkin.Controls.MaterialRadioButton();
            this.miejsca = new MaterialSkin.Controls.MaterialLabel();
            this.sdcard_size = new MaterialSkin.Controls.MaterialLabel();
            this.vers = new MaterialSkin.Controls.MaterialLabel();
            this.ver1 = new MaterialSkin.Controls.MaterialLabel();
            this.radiob2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiob1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radiob3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.next = new MaterialSkin.Controls.MaterialFlatButton();
            this.Select_function = new System.Windows.Forms.FlowLayoutPanel();
            this.sdcard_format = new MaterialSkin.Controls.MaterialCheckBox();
            this.what = new MaterialSkin.Controls.MaterialLabel();
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.progressInstall = new System.Windows.Forms.ProgressBar();
            this.downloadtextFile = new MaterialSkin.Controls.MaterialLabel();
            this.downloadInstall = new MaterialSkin.Controls.MaterialLabel();
            this.select_firmware = new System.Windows.Forms.ComboBox();
            this.sel_firm = new MaterialSkin.Controls.MaterialLabel();
            this.labelSpeed = new MaterialSkin.Controls.MaterialLabel();
            this.labelPerc = new MaterialSkin.Controls.MaterialLabel();
            this.labelDownloaded = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoFileName_label = new MaterialSkin.Controls.MaterialLabel();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Select_function.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdcard_detect,
            this.ver2,
            this.selected_software});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sdcard_detect
            // 
            this.sdcard_detect.Name = "sdcard_detect";
            this.sdcard_detect.Size = new System.Drawing.Size(225, 17);
            this.sdcard_detect.Text = "Sprawdzanie czy została włożona karta SD";
            // 
            // ver2
            // 
            this.ver2.Name = "ver2";
            this.ver2.Size = new System.Drawing.Size(22, 17);
            this.ver2.Text = "---";
            // 
            // selected_software
            // 
            this.selected_software.Name = "selected_software";
            this.selected_software.Size = new System.Drawing.Size(22, 17);
            this.selected_software.Text = "---";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.wyjscieToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 70);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // wyjscieToolStripMenuItem
            // 
            this.wyjscieToolStripMenuItem.Name = "wyjscieToolStripMenuItem";
            this.wyjscieToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.wyjscieToolStripMenuItem.Text = "Wyjscie";
            // 
            // checkSDid
            // 
            this.checkSDid.AutoCheck = false;
            this.checkSDid.AutoSize = true;
            this.checkSDid.BackColor = System.Drawing.SystemColors.Window;
            this.checkSDid.Depth = 0;
            this.checkSDid.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkSDid.Location = new System.Drawing.Point(9, 71);
            this.checkSDid.Margin = new System.Windows.Forms.Padding(0);
            this.checkSDid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSDid.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSDid.Name = "checkSDid";
            this.checkSDid.Ripple = true;
            this.checkSDid.Size = new System.Drawing.Size(83, 30);
            this.checkSDid.TabIndex = 2;
            this.checkSDid.TabStop = true;
            this.checkSDid.Text = "Karta SD";
            this.checkSDid.UseVisualStyleBackColor = false;
            // 
            // miejsca
            // 
            this.miejsca.AutoSize = true;
            this.miejsca.BackColor = System.Drawing.SystemColors.Window;
            this.miejsca.Depth = 0;
            this.miejsca.Font = new System.Drawing.Font("Roboto", 11F);
            this.miejsca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.miejsca.Location = new System.Drawing.Point(105, 76);
            this.miejsca.MouseState = MaterialSkin.MouseState.HOVER;
            this.miejsca.Name = "miejsca";
            this.miejsca.Size = new System.Drawing.Size(127, 19);
            this.miejsca.TabIndex = 3;
            this.miejsca.Text = "Miejsca na karcie";
            // 
            // sdcard_size
            // 
            this.sdcard_size.AutoSize = true;
            this.sdcard_size.BackColor = System.Drawing.SystemColors.Window;
            this.sdcard_size.Depth = 0;
            this.sdcard_size.Font = new System.Drawing.Font("Roboto", 11F);
            this.sdcard_size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sdcard_size.Location = new System.Drawing.Point(231, 76);
            this.sdcard_size.MouseState = MaterialSkin.MouseState.HOVER;
            this.sdcard_size.Name = "sdcard_size";
            this.sdcard_size.Size = new System.Drawing.Size(17, 19);
            this.sdcard_size.TabIndex = 4;
            this.sdcard_size.Text = "0";
            // 
            // vers
            // 
            this.vers.AutoSize = true;
            this.vers.BackColor = System.Drawing.SystemColors.Window;
            this.vers.Depth = 0;
            this.vers.Font = new System.Drawing.Font("Roboto", 11F);
            this.vers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vers.Location = new System.Drawing.Point(282, 76);
            this.vers.MouseState = MaterialSkin.MouseState.HOVER;
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(191, 19);
            this.vers.TabIndex = 5;
            this.vers.Text = "Aktualna Wersja Na Karcie:";
            // 
            // ver1
            // 
            this.ver1.AutoSize = true;
            this.ver1.BackColor = System.Drawing.SystemColors.Window;
            this.ver1.Depth = 0;
            this.ver1.Font = new System.Drawing.Font("Roboto", 11F);
            this.ver1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ver1.Location = new System.Drawing.Point(470, 76);
            this.ver1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ver1.Name = "ver1";
            this.ver1.Size = new System.Drawing.Size(108, 19);
            this.ver1.TabIndex = 6;
            this.ver1.Text = "materialLabel2";
            // 
            // radiob2
            // 
            this.radiob2.AutoSize = true;
            this.radiob2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiob2.Depth = 0;
            this.Select_function.SetFlowBreak(this.radiob2, true);
            this.radiob2.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiob2.Location = new System.Drawing.Point(0, 30);
            this.radiob2.Margin = new System.Windows.Forms.Padding(0);
            this.radiob2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiob2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiob2.Name = "radiob2";
            this.radiob2.Ripple = true;
            this.radiob2.Size = new System.Drawing.Size(165, 30);
            this.radiob2.TabIndex = 10;
            this.radiob2.Text = "Aktualizacja Firmware";
            this.radiob2.UseVisualStyleBackColor = true;
            this.radiob2.CheckedChanged += new System.EventHandler(this.menu_CheckedChanged);
            // 
            // radiob1
            // 
            this.radiob1.AutoSize = true;
            this.radiob1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiob1.Depth = 0;
            this.Select_function.SetFlowBreak(this.radiob1, true);
            this.radiob1.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiob1.Location = new System.Drawing.Point(0, 0);
            this.radiob1.Margin = new System.Windows.Forms.Padding(0);
            this.radiob1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiob1.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiob1.Name = "radiob1";
            this.radiob1.Ripple = true;
            this.radiob1.Size = new System.Drawing.Size(135, 30);
            this.radiob1.TabIndex = 11;
            this.radiob1.Text = "Aktualizacja Map";
            this.radiob1.UseVisualStyleBackColor = true;
            this.radiob1.CheckedChanged += new System.EventHandler(this.menu_CheckedChanged);
            // 
            // radiob3
            // 
            this.radiob3.AutoSize = true;
            this.radiob3.BackColor = System.Drawing.SystemColors.Window;
            this.radiob3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiob3.Depth = 0;
            this.Select_function.SetFlowBreak(this.radiob3, true);
            this.radiob3.Font = new System.Drawing.Font("Roboto", 10F);
            this.radiob3.Location = new System.Drawing.Point(0, 60);
            this.radiob3.Margin = new System.Windows.Forms.Padding(0);
            this.radiob3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radiob3.MouseState = MaterialSkin.MouseState.HOVER;
            this.radiob3.Name = "radiob3";
            this.radiob3.Ripple = true;
            this.radiob3.Size = new System.Drawing.Size(196, 30);
            this.radiob3.TabIndex = 12;
            this.radiob3.Text = "Wgraj Green Menu na kartę";
            this.radiob3.UseVisualStyleBackColor = false;
            this.radiob3.CheckedChanged += new System.EventHandler(this.menu_CheckedChanged);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next.AutoSize = true;
            this.next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.next.BackColor = System.Drawing.SystemColors.Highlight;
            this.next.Depth = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(834, 448);
            this.next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.next.MouseState = MaterialSkin.MouseState.HOVER;
            this.next.Name = "next";
            this.next.Primary = false;
            this.next.Size = new System.Drawing.Size(53, 36);
            this.next.TabIndex = 14;
            this.next.Text = "DALEJ";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Select_function
            // 
            this.Select_function.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Select_function.AutoSize = true;
            this.Select_function.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Select_function.BackColor = System.Drawing.SystemColors.Window;
            this.Select_function.CausesValidation = false;
            this.Select_function.Controls.Add(this.radiob1);
            this.Select_function.Controls.Add(this.radiob2);
            this.Select_function.Controls.Add(this.radiob3);
            this.Select_function.Controls.Add(this.sdcard_format);
            this.Select_function.Location = new System.Drawing.Point(4, 404);
            this.Select_function.Name = "Select_function";
            this.Select_function.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Select_function.Size = new System.Drawing.Size(361, 120);
            this.Select_function.TabIndex = 13;
            // 
            // sdcard_format
            // 
            this.sdcard_format.AutoSize = true;
            this.sdcard_format.BackColor = System.Drawing.SystemColors.Window;
            this.sdcard_format.Depth = 0;
            this.sdcard_format.Font = new System.Drawing.Font("Roboto", 10F);
            this.sdcard_format.Location = new System.Drawing.Point(0, 90);
            this.sdcard_format.Margin = new System.Windows.Forms.Padding(0);
            this.sdcard_format.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sdcard_format.MouseState = MaterialSkin.MouseState.HOVER;
            this.sdcard_format.Name = "sdcard_format";
            this.sdcard_format.Ripple = true;
            this.sdcard_format.Size = new System.Drawing.Size(165, 30);
            this.sdcard_format.TabIndex = 27;
            this.sdcard_format.Text = "Sformatować Kartę ??";
            this.sdcard_format.UseVisualStyleBackColor = false;
            // 
            // what
            // 
            this.what.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.what.AutoSize = true;
            this.what.BackColor = System.Drawing.SystemColors.Window;
            this.what.Depth = 0;
            this.what.Font = new System.Drawing.Font("Roboto", 11F);
            this.what.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.what.Location = new System.Drawing.Point(1, 385);
            this.what.MouseState = MaterialSkin.MouseState.HOVER;
            this.what.Name = "what";
            this.what.Size = new System.Drawing.Size(188, 19);
            this.what.TabIndex = 15;
            this.what.Text = "Wybierz Co Chcesz Zrobić:";
            // 
            // progressDownload
            // 
            this.progressDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressDownload.Location = new System.Drawing.Point(3, 27);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(878, 23);
            this.progressDownload.TabIndex = 16;
            // 
            // progressInstall
            // 
            this.progressInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressInstall.Location = new System.Drawing.Point(5, 83);
            this.progressInstall.Name = "progressInstall";
            this.progressInstall.Size = new System.Drawing.Size(878, 23);
            this.progressInstall.TabIndex = 17;
            // 
            // downloadtextFile
            // 
            this.downloadtextFile.AutoSize = true;
            this.downloadtextFile.BackColor = System.Drawing.SystemColors.Window;
            this.downloadtextFile.Depth = 0;
            this.downloadtextFile.Font = new System.Drawing.Font("Roboto", 11F);
            this.downloadtextFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadtextFile.Location = new System.Drawing.Point(-1, 1);
            this.downloadtextFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadtextFile.Name = "downloadtextFile";
            this.downloadtextFile.Size = new System.Drawing.Size(129, 19);
            this.downloadtextFile.TabIndex = 18;
            this.downloadtextFile.Text = "Pobieranie Plików";
            // 
            // downloadInstall
            // 
            this.downloadInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadInstall.AutoSize = true;
            this.downloadInstall.BackColor = System.Drawing.SystemColors.Window;
            this.downloadInstall.Depth = 0;
            this.downloadInstall.Font = new System.Drawing.Font("Roboto", 11F);
            this.downloadInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadInstall.Location = new System.Drawing.Point(3, 61);
            this.downloadInstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadInstall.Name = "downloadInstall";
            this.downloadInstall.Size = new System.Drawing.Size(106, 19);
            this.downloadInstall.TabIndex = 20;
            this.downloadInstall.Text = "Instalowanie...";
            // 
            // select_firmware
            // 
            this.select_firmware.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.select_firmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.select_firmware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_firmware.FormattingEnabled = true;
            this.select_firmware.Items.AddRange(new object[] {
            "----VW PQ---- ",
            "MST2_EU_VW_PQ_E0224T.zip",
            "MST2_EU_VW_PQ_E0224T_X224_unstripped.zip",
            "MST2_EU_VW_PQ_P0245T-0245.zip",
            "MST2_EU_VW_PQ_P0252T.zip",
            "MST2_EU_VW_PQ_P0253T.zip",
            "MST2_EU_VW_PQ_P0363T_0363.zip",
            "MST2_EU_VW_PQ_P0367T.zip",
            "MST2_EU_VW_PQ_P0468T.zip",
            "MST2_EU_VW_PQ_P0475T.zip",
            "MST2_EU_VW_PQ_P0478T.zip",
            "MST2_EU_VW_PQ_P0480T-3G0919360QT.zip",
            "----SKÓRKI----",
            "VW_PQ_gold_skin_0478_CP_removed.zip",
            "PQ_AlpineSkins_WithCP.zip",
            "----PATCH----",
            "VW_PQ_P0254T_FEC_ALL_CID_OFF_CP_OFF_FIXED.zip",
            "VW_PQ_P0254T_FEC_ALL_CID_OFF_FIXED.zip",
            "VW_PQ_P0480T_FEC_ALL_CID_OFF_FIXED.zip"});
            this.select_firmware.Location = new System.Drawing.Point(548, 470);
            this.select_firmware.Name = "select_firmware";
            this.select_firmware.Size = new System.Drawing.Size(235, 21);
            this.select_firmware.TabIndex = 21;
            // 
            // sel_firm
            // 
            this.sel_firm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sel_firm.AutoSize = true;
            this.sel_firm.BackColor = System.Drawing.SystemColors.Window;
            this.sel_firm.Depth = 0;
            this.sel_firm.Font = new System.Drawing.Font("Roboto", 11F);
            this.sel_firm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sel_firm.Location = new System.Drawing.Point(573, 448);
            this.sel_firm.MouseState = MaterialSkin.MouseState.HOVER;
            this.sel_firm.Name = "sel_firm";
            this.sel_firm.Size = new System.Drawing.Size(179, 19);
            this.sel_firm.TabIndex = 22;
            this.sel_firm.Text = "Wybierz Oprogramowanie";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.labelSpeed.Depth = 0;
            this.labelSpeed.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSpeed.Location = new System.Drawing.Point(489, 3);
            this.labelSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(71, 19);
            this.labelSpeed.TabIndex = 23;
            this.labelSpeed.Text = "predkosc";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.BackColor = System.Drawing.Color.Transparent;
            this.labelPerc.Depth = 0;
            this.labelPerc.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPerc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPerc.Location = new System.Drawing.Point(449, 3);
            this.labelPerc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(17, 19);
            this.labelPerc.TabIndex = 24;
            this.labelPerc.Text = "0";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.BackColor = System.Drawing.SystemColors.Window;
            this.labelDownloaded.Depth = 0;
            this.labelDownloaded.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDownloaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDownloaded.Location = new System.Drawing.Point(593, 2);
            this.labelDownloaded.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(185, 19);
            this.labelDownloaded.TabIndex = 25;
            this.labelDownloaded.Text = "file size";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.infoFileName_label);
            this.panel1.Controls.Add(this.progressDownload);
            this.panel1.Controls.Add(this.downloadtextFile);
            this.panel1.Controls.Add(this.labelDownloaded);
            this.panel1.Controls.Add(this.labelSpeed);
            this.panel1.Controls.Add(this.downloadInstall);
            this.panel1.Controls.Add(this.labelPerc);
            this.panel1.Controls.Add(this.progressInstall);
            this.panel1.Location = new System.Drawing.Point(5, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 227);
            this.panel1.TabIndex = 26;
            // 
            // infoFileName_label
            // 
            this.infoFileName_label.AutoSize = true;
            this.infoFileName_label.BackColor = System.Drawing.Color.Transparent;
            this.infoFileName_label.Depth = 0;
            this.infoFileName_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoFileName_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoFileName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoFileName_label.Location = new System.Drawing.Point(4, 109);
            this.infoFileName_label.Margin = new System.Windows.Forms.Padding(0);
            this.infoFileName_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoFileName_label.Name = "infoFileName_label";
            this.infoFileName_label.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.infoFileName_label.Size = new System.Drawing.Size(225, 19);
            this.infoFileName_label.TabIndex = 26;
            this.infoFileName_label.Text = "Nazwa pliku wypakowywanego";
            // 
            // Var
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sel_firm);
            this.Controls.Add(this.select_firmware);
            this.Controls.Add(this.what);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Select_function);
            this.Controls.Add(this.ver1);
            this.Controls.Add(this.vers);
            this.Controls.Add(this.sdcard_size);
            this.Controls.Add(this.miejsca);
            this.Controls.Add(this.checkSDid);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Var";
            this.Text = "Discovery Media - Maps - Firmware Update";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Select_function.ResumeLayout(false);
            this.Select_function.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sdcard_detect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjscieToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRadioButton checkSDid;
        private MaterialSkin.Controls.MaterialLabel miejsca;
        private MaterialSkin.Controls.MaterialLabel sdcard_size;
        private MaterialSkin.Controls.MaterialLabel vers;
        private MaterialSkin.Controls.MaterialLabel ver1;
        private System.Windows.Forms.ToolStripStatusLabel ver2;
        private MaterialSkin.Controls.MaterialRadioButton radiob2;
        private MaterialSkin.Controls.MaterialRadioButton radiob1;
        private MaterialSkin.Controls.MaterialRadioButton radiob3;
        private MaterialSkin.Controls.MaterialFlatButton next;
        private System.Windows.Forms.FlowLayoutPanel Select_function;
        private MaterialSkin.Controls.MaterialLabel what;
        private System.Windows.Forms.ProgressBar progressDownload;
        private MaterialSkin.Controls.MaterialLabel downloadtextFile;
        private MaterialSkin.Controls.MaterialLabel downloadInstall;
        private System.Windows.Forms.ComboBox select_firmware;
        private MaterialSkin.Controls.MaterialLabel sel_firm;
        private System.Windows.Forms.ToolStripStatusLabel selected_software;
        private MaterialSkin.Controls.MaterialLabel labelSpeed;
        private MaterialSkin.Controls.MaterialLabel labelPerc;
        private MaterialSkin.Controls.MaterialLabel labelDownloaded;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox sdcard_format;
        public System.Windows.Forms.ProgressBar progressInstall;
        private MaterialSkin.Controls.MaterialLabel infoFileName_label;
    }
}

