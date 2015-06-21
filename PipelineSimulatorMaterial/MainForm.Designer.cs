using System.Drawing;
using MaterialSkin;

namespace PipelineSimulatorMaterial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabNavbar = new MaterialSkin.Controls.MaterialTabControl();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.BtnOpenBinaryFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnOpenInstrFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tpCode = new System.Windows.Forms.TabPage();
            this.pnlUnderLine = new System.Windows.Forms.Panel();
            this.searchText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEnableBreakpoint = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvCode = new MaterialSkin.Controls.MaterialListView();
            this.chBreakpoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBinary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInstr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.mnuitEnableBreakpoint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitDisableBreakpoint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tpProcess = new System.Windows.Forms.TabPage();
            this.btnReset = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabRegister = new MaterialSkin.Controls.MaterialTabControl();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.edi = new MaterialSkin.Controls.MaterialFlatButton();
            this.esi = new MaterialSkin.Controls.MaterialFlatButton();
            this.ebp = new MaterialSkin.Controls.MaterialFlatButton();
            this.esp = new MaterialSkin.Controls.MaterialFlatButton();
            this.ebx = new MaterialSkin.Controls.MaterialFlatButton();
            this.edx = new MaterialSkin.Controls.MaterialFlatButton();
            this.ecx = new MaterialSkin.Controls.MaterialFlatButton();
            this.eax = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.tabsProcess = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabProcess = new MaterialSkin.Controls.MaterialTabControl();
            this.tpFetch = new System.Windows.Forms.TabPage();
            this.fstall = new MaterialSkin.Controls.MaterialFlatButton();
            this.fcircle = new MaterialSkin.Controls.MaterialFlatButton();
            this.fpredPC = new MaterialSkin.Controls.MaterialFlatButton();
            this.tpDecode = new System.Windows.Forms.TabPage();
            this.drb = new MaterialSkin.Controls.MaterialFlatButton();
            this.difun = new MaterialSkin.Controls.MaterialFlatButton();
            this.dra = new MaterialSkin.Controls.MaterialFlatButton();
            this.dvalp = new MaterialSkin.Controls.MaterialFlatButton();
            this.dvalc = new MaterialSkin.Controls.MaterialFlatButton();
            this.dstall = new MaterialSkin.Controls.MaterialFlatButton();
            this.dstat = new MaterialSkin.Controls.MaterialFlatButton();
            this.dicode = new MaterialSkin.Controls.MaterialFlatButton();
            this.dinstr = new MaterialSkin.Controls.MaterialFlatButton();
            this.tpExecute = new System.Windows.Forms.TabPage();
            this.edstm = new MaterialSkin.Controls.MaterialFlatButton();
            this.edste = new MaterialSkin.Controls.MaterialFlatButton();
            this.esrcb = new MaterialSkin.Controls.MaterialFlatButton();
            this.esrca = new MaterialSkin.Controls.MaterialFlatButton();
            this.evalb = new MaterialSkin.Controls.MaterialFlatButton();
            this.eifun = new MaterialSkin.Controls.MaterialFlatButton();
            this.evala = new MaterialSkin.Controls.MaterialFlatButton();
            this.evalc = new MaterialSkin.Controls.MaterialFlatButton();
            this.estall = new MaterialSkin.Controls.MaterialFlatButton();
            this.estat = new MaterialSkin.Controls.MaterialFlatButton();
            this.eicode = new MaterialSkin.Controls.MaterialFlatButton();
            this.einstr = new MaterialSkin.Controls.MaterialFlatButton();
            this.tpMemoryVisit = new System.Windows.Forms.TabPage();
            this.mdstm = new MaterialSkin.Controls.MaterialFlatButton();
            this.mdste = new MaterialSkin.Controls.MaterialFlatButton();
            this.mvala = new MaterialSkin.Controls.MaterialFlatButton();
            this.mifun = new MaterialSkin.Controls.MaterialFlatButton();
            this.mvale = new MaterialSkin.Controls.MaterialFlatButton();
            this.mcc = new MaterialSkin.Controls.MaterialFlatButton();
            this.mstall = new MaterialSkin.Controls.MaterialFlatButton();
            this.mstat = new MaterialSkin.Controls.MaterialFlatButton();
            this.micode = new MaterialSkin.Controls.MaterialFlatButton();
            this.minstr = new MaterialSkin.Controls.MaterialFlatButton();
            this.tpWriteBack = new System.Windows.Forms.TabPage();
            this.wdstm = new MaterialSkin.Controls.MaterialFlatButton();
            this.wdste = new MaterialSkin.Controls.MaterialFlatButton();
            this.wvalm = new MaterialSkin.Controls.MaterialFlatButton();
            this.wvale = new MaterialSkin.Controls.MaterialFlatButton();
            this.wstall = new MaterialSkin.Controls.MaterialFlatButton();
            this.wstat = new MaterialSkin.Controls.MaterialFlatButton();
            this.wicode = new MaterialSkin.Controls.MaterialFlatButton();
            this.winstr = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPlay = new MaterialSkin.Controls.MaterialFlatButton();
            this.rbtn1Hz = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnProcessOptions = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNextBreakpoint = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNextStep = new MaterialSkin.Controls.MaterialFlatButton();
            this.rbtn50Hz = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn10Hz = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn5Hz = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnConfirmSpeed = new MaterialSkin.Controls.MaterialFlatButton();
            this.tpMemory = new System.Windows.Forms.TabPage();
            this.btnMemoryOption = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvMemory = new MaterialSkin.Controls.MaterialListView();
            this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.lblABout = new MaterialSkin.Controls.MaterialLabel();
            this.labelMdstm = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.labelMdste = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.label5 = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.label25 = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.labelcc = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.labelMvala = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.labelMvale = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.label22 = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.label11 = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.label12 = new MaterialSkin.Controls.MaterialSecondaryLabel();
            this.tabsNavbar = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnDisableBreakpoint = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabNavbar.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.tpCode.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.tpProcess.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tpRegister.SuspendLayout();
            this.pnlProcess.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.tpFetch.SuspendLayout();
            this.tpDecode.SuspendLayout();
            this.tpExecute.SuspendLayout();
            this.tpMemoryVisit.SuspendLayout();
            this.tpWriteBack.SuspendLayout();
            this.tpMemory.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNavbar
            // 
            this.tabNavbar.Controls.Add(this.tpFile);
            this.tabNavbar.Controls.Add(this.tpCode);
            this.tabNavbar.Controls.Add(this.tpProcess);
            this.tabNavbar.Controls.Add(this.tpMemory);
            this.tabNavbar.Controls.Add(this.tpAbout);
            this.tabNavbar.Depth = 0;
            this.tabNavbar.ItemSize = new System.Drawing.Size(54, 20);
            this.tabNavbar.Location = new System.Drawing.Point(12, 115);
            this.tabNavbar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabNavbar.Name = "tabNavbar";
            this.tabNavbar.SelectedIndex = 0;
            this.tabNavbar.Size = new System.Drawing.Size(999, 469);
            this.tabNavbar.TabIndex = 1;
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.BtnOpenBinaryFile);
            this.tpFile.Controls.Add(this.BtnOpenInstrFile);
            this.tpFile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFile.Location = new System.Drawing.Point(4, 24);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(991, 441);
            this.tpFile.TabIndex = 0;
            this.tpFile.Text = "File";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // BtnOpenBinaryFile
            // 
            this.BtnOpenBinaryFile.Depth = 0;
            this.BtnOpenBinaryFile.Location = new System.Drawing.Point(411, 201);
            this.BtnOpenBinaryFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenBinaryFile.Name = "BtnOpenBinaryFile";
            this.BtnOpenBinaryFile.Primary = true;
            this.BtnOpenBinaryFile.Size = new System.Drawing.Size(172, 44);
            this.BtnOpenBinaryFile.TabIndex = 3;
            this.BtnOpenBinaryFile.Text = "Open Binary File";
            this.BtnOpenBinaryFile.UseVisualStyleBackColor = true;
            this.BtnOpenBinaryFile.Click += new System.EventHandler(this.BtnOpenBinaryFile_Click);
            // 
            // BtnOpenInstrFile
            // 
            this.BtnOpenInstrFile.Depth = 0;
            this.BtnOpenInstrFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnOpenInstrFile.Location = new System.Drawing.Point(411, 126);
            this.BtnOpenInstrFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnOpenInstrFile.Name = "BtnOpenInstrFile";
            this.BtnOpenInstrFile.Primary = true;
            this.BtnOpenInstrFile.Size = new System.Drawing.Size(172, 44);
            this.BtnOpenInstrFile.TabIndex = 2;
            this.BtnOpenInstrFile.Text = "Open Instruction File";
            this.BtnOpenInstrFile.UseVisualStyleBackColor = true;
            this.BtnOpenInstrFile.Click += new System.EventHandler(this.BtnOpenInstrFile_Click);
            // 
            // tpCode
            // 
            this.tpCode.BackColor = System.Drawing.Color.White;
            this.tpCode.Controls.Add(this.btnDisableBreakpoint);
            this.tpCode.Controls.Add(this.pnlUnderLine);
            this.tpCode.Controls.Add(this.searchText);
            this.tpCode.Controls.Add(this.btnEnableBreakpoint);
            this.tpCode.Controls.Add(this.lvCode);
            this.tpCode.Location = new System.Drawing.Point(4, 24);
            this.tpCode.Name = "tpCode";
            this.tpCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpCode.Size = new System.Drawing.Size(991, 441);
            this.tpCode.TabIndex = 1;
            this.tpCode.Text = "Code";
            // 
            // pnlUnderLine
            // 
            this.pnlUnderLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUnderLine.BackgroundImage")));
            this.pnlUnderLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUnderLine.Location = new System.Drawing.Point(5, 85);
            this.pnlUnderLine.Name = "pnlUnderLine";
            this.pnlUnderLine.Size = new System.Drawing.Size(560, 2);
            this.pnlUnderLine.TabIndex = 5;
            this.pnlUnderLine.Visible = false;
            // 
            // searchText
            // 
            this.searchText.Depth = 0;
            this.searchText.Hint = "Search";
            this.searchText.Location = new System.Drawing.Point(770, 313);
            this.searchText.MaxLength = 32767;
            this.searchText.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.SelectedText = "";
            this.searchText.SelectionLength = 0;
            this.searchText.SelectionStart = 0;
            this.searchText.Size = new System.Drawing.Size(178, 23);
            this.searchText.TabIndex = 4;
            this.searchText.TabStop = false;
            this.searchText.UseSystemPasswordChar = false;
            //this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchText_KeyPress);
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler( this.searchText_Keydown );
            this.searchText.LostFocus += new System.EventHandler(this.searchText_LostFocus);
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // btnEnableBreakpoint
            // 
            this.btnEnableBreakpoint.AutoSize = true;
            this.btnEnableBreakpoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnableBreakpoint.Depth = 0;
            this.btnEnableBreakpoint.Location = new System.Drawing.Point(799, 345);
            this.btnEnableBreakpoint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnableBreakpoint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnableBreakpoint.Name = "btnEnableBreakpoint";
            this.btnEnableBreakpoint.Primary = true;
            this.btnEnableBreakpoint.Size = new System.Drawing.Size(149, 36);
            this.btnEnableBreakpoint.TabIndex = 3;
            this.btnEnableBreakpoint.Text = "Enable Breakpoint";
            this.btnEnableBreakpoint.UseVisualStyleBackColor = true;
            this.btnEnableBreakpoint.Click += new System.EventHandler(this.btnCodeOptions_Click);
            // 
            // lvCode
            // 
            this.lvCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCode.CheckBoxes = true;
            this.lvCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBreakpoint,
            this.chLineNumber,
            this.chAddr,
            this.chBinary,
            this.chInstr});
            this.lvCode.ContextMenuStrip = this.materialContextMenuStrip1;
            this.lvCode.Depth = 0;
            this.lvCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCode.Font = new System.Drawing.Font("Roboto", 24F);
            this.lvCode.FullRowSelect = true;
            this.lvCode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCode.Location = new System.Drawing.Point(3, 3);
            this.lvCode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvCode.MouseState = MaterialSkin.MouseState.OUT;
            this.lvCode.MultiSelect = false;
            this.lvCode.Name = "lvCode";
            this.lvCode.OwnerDraw = true;
            this.lvCode.Size = new System.Drawing.Size(985, 435);
            this.lvCode.TabIndex = 1;
            this.lvCode.UseCompatibleStateImageBehavior = false;
            this.lvCode.View = System.Windows.Forms.View.Details;
            // 
            // chBreakpoint
            // 
            this.chBreakpoint.Text = "";
            this.chBreakpoint.Width = 30;
            // 
            // chLineNumber
            // 
            this.chLineNumber.Text = "";
            this.chLineNumber.Width = 45;
            // 
            // chAddr
            // 
            this.chAddr.Text = "Address";
            this.chAddr.Width = 150;
            // 
            // chBinary
            // 
            this.chBinary.Text = "Binary Code";
            this.chBinary.Width = 150;
            // 
            // chInstr
            // 
            this.chInstr.Text = "Instruction";
            this.chInstr.Width = 600;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitEnableBreakpoint,
            this.mnuitDisableBreakpoint,
            this.mnuitSearch});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // mnuitEnableBreakpoint
            // 
            this.mnuitEnableBreakpoint.Name = "mnuitEnableBreakpoint";
            this.mnuitEnableBreakpoint.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mnuitEnableBreakpoint.ShowShortcutKeys = false;
            this.mnuitEnableBreakpoint.Size = new System.Drawing.Size(165, 22);
            this.mnuitEnableBreakpoint.Text = "Enable BreakPoint";
            this.mnuitEnableBreakpoint.Click += new System.EventHandler(this.EnableBreakpoint_Click);
            // 
            // mnuitDisableBreakpoint
            // 
            this.mnuitDisableBreakpoint.Name = "mnuitDisableBreakpoint";
            this.mnuitDisableBreakpoint.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mnuitDisableBreakpoint.ShowShortcutKeys = false;
            this.mnuitDisableBreakpoint.Size = new System.Drawing.Size(165, 22);
            this.mnuitDisableBreakpoint.Text = "Disable BreakPoint";
            this.mnuitDisableBreakpoint.Click += new System.EventHandler(this.DisableBreakpoint_Click);
            // 
            // mnuitSearch
            // 
            this.mnuitSearch.Name = "mnuitSearch";
            this.mnuitSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuitSearch.ShowShortcutKeys = false;
            this.mnuitSearch.Size = new System.Drawing.Size(165, 22);
            this.mnuitSearch.Text = "Search";
            this.mnuitSearch.Click += new System.EventHandler(this.mnuitSearch_Click);
            // 
            // tpProcess
            // 
            this.tpProcess.BackColor = System.Drawing.Color.White;
            this.tpProcess.Controls.Add(this.btnReset);
            this.tpProcess.Controls.Add(this.panel1);
            this.tpProcess.Controls.Add(this.pnlProcess);
            this.tpProcess.Controls.Add(this.btnPlay);
            this.tpProcess.Controls.Add(this.rbtn1Hz);
            this.tpProcess.Controls.Add(this.btnProcessOptions);
            this.tpProcess.Controls.Add(this.btnNextBreakpoint);
            this.tpProcess.Controls.Add(this.btnStop);
            this.tpProcess.Controls.Add(this.btnNextStep);
            this.tpProcess.Controls.Add(this.rbtn50Hz);
            this.tpProcess.Controls.Add(this.rbtn10Hz);
            this.tpProcess.Controls.Add(this.rbtn5Hz);
            this.tpProcess.Controls.Add(this.btnConfirmSpeed);
            this.tpProcess.Location = new System.Drawing.Point(4, 24);
            this.tpProcess.Name = "tpProcess";
            this.tpProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcess.Size = new System.Drawing.Size(991, 441);
            this.tpProcess.TabIndex = 2;
            this.tpProcess.Text = "Process";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(17, 191);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = false;
            this.btnReset.Size = new System.Drawing.Size(53, 36);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.materialTabSelector2);
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Controls.Add(this.tabRegister);
            this.panel1.Location = new System.Drawing.Point(750, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 390);
            this.panel1.TabIndex = 11;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.tabRegister;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(33, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(131, 50);
            this.materialTabSelector2.TabIndex = 2;
            this.materialTabSelector2.Text = "Register";
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.tpRegister);
            this.tabRegister.Depth = 0;
            this.tabRegister.Location = new System.Drawing.Point(13, 55);
            this.tabRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.SelectedIndex = 0;
            this.tabRegister.Size = new System.Drawing.Size(169, 328);
            this.tabRegister.TabIndex = 0;
            // 
            // tpRegister
            // 
            this.tpRegister.BackColor = System.Drawing.Color.White;
            this.tpRegister.Controls.Add(this.edi);
            this.tpRegister.Controls.Add(this.esi);
            this.tpRegister.Controls.Add(this.ebp);
            this.tpRegister.Controls.Add(this.esp);
            this.tpRegister.Controls.Add(this.ebx);
            this.tpRegister.Controls.Add(this.edx);
            this.tpRegister.Controls.Add(this.ecx);
            this.tpRegister.Controls.Add(this.eax);
            this.tpRegister.Location = new System.Drawing.Point(4, 22);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(161, 302);
            this.tpRegister.TabIndex = 0;
            this.tpRegister.Text = "Register";
            // 
            // edi
            // 
            this.edi.AutoSize = true;
            this.edi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edi.Depth = 0;
            this.edi.Location = new System.Drawing.Point(19, 269);
            this.edi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edi.MouseState = MaterialSkin.MouseState.HOVER;
            this.edi.Name = "edi";
            this.edi.Primary = false;
            this.edi.Size = new System.Drawing.Size(137, 36);
            this.edi.TabIndex = 7;
            this.edi.Text = "%eax   0x00000000";
            this.edi.UseVisualStyleBackColor = true;
            // 
            // esi
            // 
            this.esi.AutoSize = true;
            this.esi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.esi.Depth = 0;
            this.esi.Location = new System.Drawing.Point(19, 231);
            this.esi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.esi.MouseState = MaterialSkin.MouseState.HOVER;
            this.esi.Name = "esi";
            this.esi.Primary = false;
            this.esi.Size = new System.Drawing.Size(135, 36);
            this.esi.TabIndex = 6;
            this.esi.Text = "%esi    0x00000000";
            this.esi.UseVisualStyleBackColor = true;
            // 
            // ebp
            // 
            this.ebp.AutoSize = true;
            this.ebp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ebp.Depth = 0;
            this.ebp.Location = new System.Drawing.Point(19, 194);
            this.ebp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ebp.MouseState = MaterialSkin.MouseState.HOVER;
            this.ebp.Name = "ebp";
            this.ebp.Primary = false;
            this.ebp.Size = new System.Drawing.Size(140, 36);
            this.ebp.TabIndex = 5;
            this.ebp.Text = "%ebp    0x00000000";
            this.ebp.UseVisualStyleBackColor = true;
            // 
            // esp
            // 
            this.esp.AutoSize = true;
            this.esp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.esp.Depth = 0;
            this.esp.Location = new System.Drawing.Point(19, 157);
            this.esp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.esp.MouseState = MaterialSkin.MouseState.HOVER;
            this.esp.Name = "esp";
            this.esp.Primary = false;
            this.esp.Size = new System.Drawing.Size(139, 36);
            this.esp.TabIndex = 4;
            this.esp.Text = "%esp    0x00000000";
            this.esp.UseVisualStyleBackColor = true;
            // 
            // ebx
            // 
            this.ebx.AutoSize = true;
            this.ebx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ebx.Depth = 0;
            this.ebx.Location = new System.Drawing.Point(19, 121);
            this.ebx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ebx.MouseState = MaterialSkin.MouseState.HOVER;
            this.ebx.Name = "ebx";
            this.ebx.Primary = false;
            this.ebx.Size = new System.Drawing.Size(140, 36);
            this.ebx.TabIndex = 3;
            this.ebx.Text = "%ebx    0x00000000";
            this.ebx.UseVisualStyleBackColor = true;
            // 
            // edx
            // 
            this.edx.AutoSize = true;
            this.edx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edx.Depth = 0;
            this.edx.Location = new System.Drawing.Point(19, 84);
            this.edx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edx.MouseState = MaterialSkin.MouseState.HOVER;
            this.edx.Name = "edx";
            this.edx.Primary = false;
            this.edx.Size = new System.Drawing.Size(140, 36);
            this.edx.TabIndex = 2;
            this.edx.Text = "%edx    0x00000000";
            this.edx.UseVisualStyleBackColor = true;
            // 
            // ecx
            // 
            this.ecx.AutoSize = true;
            this.ecx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ecx.Depth = 0;
            this.ecx.Location = new System.Drawing.Point(19, 47);
            this.ecx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ecx.MouseState = MaterialSkin.MouseState.HOVER;
            this.ecx.Name = "ecx";
            this.ecx.Primary = false;
            this.ecx.Size = new System.Drawing.Size(140, 36);
            this.ecx.TabIndex = 1;
            this.ecx.Text = "%ecx    0x00000000";
            this.ecx.UseVisualStyleBackColor = true;
            // 
            // eax
            // 
            this.eax.AutoSize = true;
            this.eax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eax.Depth = 0;
            this.eax.Location = new System.Drawing.Point(19, 10);
            this.eax.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eax.MouseState = MaterialSkin.MouseState.HOVER;
            this.eax.Name = "eax";
            this.eax.Primary = false;
            this.eax.Size = new System.Drawing.Size(140, 36);
            this.eax.TabIndex = 0;
            this.eax.Text = "%eax    0x00000000";
            this.eax.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(2, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(192, 50);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "Register";
            // 
            // pnlProcess
            // 
            this.pnlProcess.BackColor = System.Drawing.Color.Transparent;
            this.pnlProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProcess.BackgroundImage")));
            this.pnlProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProcess.Controls.Add(this.tabsProcess);
            this.pnlProcess.Controls.Add(this.tabProcess);
            this.pnlProcess.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlProcess.Location = new System.Drawing.Point(178, 43);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(533, 350);
            this.pnlProcess.TabIndex = 10;
            // 
            // tabsProcess
            // 
            this.tabsProcess.BaseTabControl = this.tabProcess;
            this.tabsProcess.Depth = 0;
            this.tabsProcess.Location = new System.Drawing.Point(2, 3);
            this.tabsProcess.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabsProcess.Name = "tabsProcess";
            this.tabsProcess.Size = new System.Drawing.Size(525, 50);
            this.tabsProcess.TabIndex = 1;
            this.tabsProcess.Text = "materialTabSelector1";
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.tpFetch);
            this.tabProcess.Controls.Add(this.tpDecode);
            this.tabProcess.Controls.Add(this.tpExecute);
            this.tabProcess.Controls.Add(this.tpMemoryVisit);
            this.tabProcess.Controls.Add(this.tpWriteBack);
            this.tabProcess.Depth = 0;
            this.tabProcess.Location = new System.Drawing.Point(13, 53);
            this.tabProcess.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.SelectedIndex = 0;
            this.tabProcess.Size = new System.Drawing.Size(494, 279);
            this.tabProcess.TabIndex = 0;
            // 
            // tpFetch
            // 
            this.tpFetch.BackColor = System.Drawing.Color.White;
            this.tpFetch.Controls.Add(this.fstall);
            this.tpFetch.Controls.Add(this.fcircle);
            this.tpFetch.Controls.Add(this.fpredPC);
            this.tpFetch.Location = new System.Drawing.Point(4, 22);
            this.tpFetch.Name = "tpFetch";
            this.tpFetch.Padding = new System.Windows.Forms.Padding(3);
            this.tpFetch.Size = new System.Drawing.Size(486, 253);
            this.tpFetch.TabIndex = 0;
            this.tpFetch.Text = "Fetch";
            // 
            // fstall
            // 
            this.fstall.AutoSize = true;
            this.fstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fstall.Depth = 0;
            this.fstall.Location = new System.Drawing.Point(112, 28);
            this.fstall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.fstall.Name = "fstall";
            this.fstall.Primary = true;
            this.fstall.Size = new System.Drawing.Size(60, 36);
            this.fstall.TabIndex = 2;
            this.fstall.Text = "Fstall";
            this.fstall.UseVisualStyleBackColor = true;
            // 
            // fcircle
            // 
            this.fcircle.AutoSize = true;
            this.fcircle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fcircle.Depth = 0;
            this.fcircle.Location = new System.Drawing.Point(22, 28);
            this.fcircle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fcircle.MouseState = MaterialSkin.MouseState.HOVER;
            this.fcircle.Name = "fcircle";
            this.fcircle.Primary = false;
            this.fcircle.Size = new System.Drawing.Size(72, 36);
            this.fcircle.TabIndex = 1;
            this.fcircle.Text = "Circle  0";
            this.fcircle.UseVisualStyleBackColor = true;
            // 
            // fpredPC
            // 
            this.fpredPC.AutoSize = true;
            this.fpredPC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fpredPC.Depth = 0;
            this.fpredPC.Location = new System.Drawing.Point(22, 76);
            this.fpredPC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fpredPC.MouseState = MaterialSkin.MouseState.HOVER;
            this.fpredPC.Name = "fpredPC";
            this.fpredPC.Primary = false;
            this.fpredPC.Size = new System.Drawing.Size(150, 36);
            this.fpredPC.TabIndex = 0;
            this.fpredPC.Text = "PredPc  0x00000000";
            this.fpredPC.UseVisualStyleBackColor = true;
            // 
            // tpDecode
            // 
            this.tpDecode.Controls.Add(this.drb);
            this.tpDecode.Controls.Add(this.difun);
            this.tpDecode.Controls.Add(this.dra);
            this.tpDecode.Controls.Add(this.dvalp);
            this.tpDecode.Controls.Add(this.dvalc);
            this.tpDecode.Controls.Add(this.dstall);
            this.tpDecode.Controls.Add(this.dstat);
            this.tpDecode.Controls.Add(this.dicode);
            this.tpDecode.Controls.Add(this.dinstr);
            this.tpDecode.Location = new System.Drawing.Point(4, 22);
            this.tpDecode.Name = "tpDecode";
            this.tpDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecode.Size = new System.Drawing.Size(486, 253);
            this.tpDecode.TabIndex = 1;
            this.tpDecode.Text = "Decode";
            this.tpDecode.UseVisualStyleBackColor = true;
            // 
            // drb
            // 
            this.drb.AutoSize = true;
            this.drb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drb.Depth = 0;
            this.drb.Location = new System.Drawing.Point(354, 26);
            this.drb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.drb.MouseState = MaterialSkin.MouseState.HOVER;
            this.drb.Name = "drb";
            this.drb.Primary = false;
            this.drb.Size = new System.Drawing.Size(51, 36);
            this.drb.TabIndex = 8;
            this.drb.Text = "rb    0";
            this.drb.UseVisualStyleBackColor = true;
            // 
            // difun
            // 
            this.difun.AutoSize = true;
            this.difun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.difun.Depth = 0;
            this.difun.Location = new System.Drawing.Point(140, 76);
            this.difun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.difun.MouseState = MaterialSkin.MouseState.HOVER;
            this.difun.Name = "difun";
            this.difun.Primary = false;
            this.difun.Size = new System.Drawing.Size(57, 36);
            this.difun.TabIndex = 7;
            this.difun.Text = "ifun  0";
            this.difun.UseVisualStyleBackColor = true;
            // 
            // dra
            // 
            this.dra.AutoSize = true;
            this.dra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dra.Depth = 0;
            this.dra.Location = new System.Drawing.Point(275, 26);
            this.dra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dra.MouseState = MaterialSkin.MouseState.HOVER;
            this.dra.Name = "dra";
            this.dra.Primary = false;
            this.dra.Size = new System.Drawing.Size(51, 36);
            this.dra.TabIndex = 6;
            this.dra.Text = "ra    0";
            this.dra.UseVisualStyleBackColor = true;
            // 
            // dvalp
            // 
            this.dvalp.AutoSize = true;
            this.dvalp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dvalp.Depth = 0;
            this.dvalp.Location = new System.Drawing.Point(275, 122);
            this.dvalp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dvalp.MouseState = MaterialSkin.MouseState.HOVER;
            this.dvalp.Name = "dvalp";
            this.dvalp.Primary = false;
            this.dvalp.Size = new System.Drawing.Size(132, 36);
            this.dvalp.TabIndex = 5;
            this.dvalp.Text = "valp  0x00000000";
            this.dvalp.UseVisualStyleBackColor = true;
            // 
            // dvalc
            // 
            this.dvalc.AutoSize = true;
            this.dvalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dvalc.Depth = 0;
            this.dvalc.Location = new System.Drawing.Point(275, 76);
            this.dvalc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dvalc.MouseState = MaterialSkin.MouseState.HOVER;
            this.dvalc.Name = "dvalc";
            this.dvalc.Primary = false;
            this.dvalc.Size = new System.Drawing.Size(132, 36);
            this.dvalc.TabIndex = 4;
            this.dvalc.Text = "valc  0x00000000";
            this.dvalc.UseVisualStyleBackColor = true;
            // 
            // dstall
            // 
            this.dstall.AutoSize = true;
            this.dstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dstall.Depth = 0;
            this.dstall.Location = new System.Drawing.Point(140, 122);
            this.dstall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.dstall.Name = "dstall";
            this.dstall.Primary = true;
            this.dstall.Size = new System.Drawing.Size(60, 36);
            this.dstall.TabIndex = 3;
            this.dstall.Text = "Fstall";
            this.dstall.UseVisualStyleBackColor = true;
            // 
            // dstat
            // 
            this.dstat.AutoSize = true;
            this.dstat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dstat.Depth = 0;
            this.dstat.Location = new System.Drawing.Point(21, 124);
            this.dstat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dstat.MouseState = MaterialSkin.MouseState.HOVER;
            this.dstat.Name = "dstat";
            this.dstat.Primary = false;
            this.dstat.Size = new System.Drawing.Size(111, 36);
            this.dstat.TabIndex = 2;
            this.dstat.Text = "state  Dstate";
            this.dstat.UseVisualStyleBackColor = true;
            // 
            // dicode
            // 
            this.dicode.AutoSize = true;
            this.dicode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dicode.Depth = 0;
            this.dicode.Location = new System.Drawing.Point(21, 76);
            this.dicode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dicode.MouseState = MaterialSkin.MouseState.HOVER;
            this.dicode.Name = "dicode";
            this.dicode.Primary = false;
            this.dicode.Size = new System.Drawing.Size(66, 36);
            this.dicode.TabIndex = 1;
            this.dicode.Text = "icode  0";
            this.dicode.UseVisualStyleBackColor = true;
            this.dicode.Click += new System.EventHandler(this.materialFlatButton5_Click_1);
            // 
            // dinstr
            // 
            this.dinstr.AutoSize = true;
            this.dinstr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dinstr.Depth = 0;
            this.dinstr.Location = new System.Drawing.Point(21, 26);
            this.dinstr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dinstr.MouseState = MaterialSkin.MouseState.HOVER;
            this.dinstr.Name = "dinstr";
            this.dinstr.Primary = false;
            this.dinstr.Size = new System.Drawing.Size(51, 36);
            this.dinstr.TabIndex = 0;
            this.dinstr.Text = "Instr";
            this.dinstr.UseVisualStyleBackColor = true;
            // 
            // tpExecute
            // 
            this.tpExecute.Controls.Add(this.edstm);
            this.tpExecute.Controls.Add(this.edste);
            this.tpExecute.Controls.Add(this.esrcb);
            this.tpExecute.Controls.Add(this.esrca);
            this.tpExecute.Controls.Add(this.evalb);
            this.tpExecute.Controls.Add(this.eifun);
            this.tpExecute.Controls.Add(this.evala);
            this.tpExecute.Controls.Add(this.evalc);
            this.tpExecute.Controls.Add(this.estall);
            this.tpExecute.Controls.Add(this.estat);
            this.tpExecute.Controls.Add(this.eicode);
            this.tpExecute.Controls.Add(this.einstr);
            this.tpExecute.Location = new System.Drawing.Point(4, 22);
            this.tpExecute.Name = "tpExecute";
            this.tpExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tpExecute.Size = new System.Drawing.Size(486, 253);
            this.tpExecute.TabIndex = 2;
            this.tpExecute.Text = "Execute";
            this.tpExecute.UseVisualStyleBackColor = true;
            // 
            // edstm
            // 
            this.edstm.AutoSize = true;
            this.edstm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edstm.Depth = 0;
            this.edstm.Location = new System.Drawing.Point(172, 221);
            this.edstm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edstm.MouseState = MaterialSkin.MouseState.HOVER;
            this.edstm.Name = "edstm";
            this.edstm.Primary = false;
            this.edstm.Size = new System.Drawing.Size(135, 36);
            this.edstm.TabIndex = 21;
            this.edstm.Text = "dstm  0x00000000";
            this.edstm.UseVisualStyleBackColor = true;
            // 
            // edste
            // 
            this.edste.AutoSize = true;
            this.edste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edste.Depth = 0;
            this.edste.Location = new System.Drawing.Point(21, 221);
            this.edste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edste.MouseState = MaterialSkin.MouseState.HOVER;
            this.edste.Name = "edste";
            this.edste.Primary = false;
            this.edste.Size = new System.Drawing.Size(131, 36);
            this.edste.TabIndex = 20;
            this.edste.Text = "dste  0x00000000";
            this.edste.UseVisualStyleBackColor = true;
            // 
            // esrcb
            // 
            this.esrcb.AutoSize = true;
            this.esrcb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.esrcb.Depth = 0;
            this.esrcb.Location = new System.Drawing.Point(175, 178);
            this.esrcb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.esrcb.MouseState = MaterialSkin.MouseState.HOVER;
            this.esrcb.Name = "esrcb";
            this.esrcb.Primary = false;
            this.esrcb.Size = new System.Drawing.Size(132, 36);
            this.esrcb.TabIndex = 19;
            this.esrcb.Text = "srcb  0x00000000";
            this.esrcb.UseVisualStyleBackColor = true;
            // 
            // esrca
            // 
            this.esrca.AutoSize = true;
            this.esrca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.esrca.Depth = 0;
            this.esrca.Location = new System.Drawing.Point(20, 178);
            this.esrca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.esrca.MouseState = MaterialSkin.MouseState.HOVER;
            this.esrca.Name = "esrca";
            this.esrca.Primary = false;
            this.esrca.Size = new System.Drawing.Size(133, 36);
            this.esrca.TabIndex = 18;
            this.esrca.Text = "srca  0x00000000";
            this.esrca.UseVisualStyleBackColor = true;
            // 
            // evalb
            // 
            this.evalb.AutoSize = true;
            this.evalb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.evalb.Depth = 0;
            this.evalb.Location = new System.Drawing.Point(274, 122);
            this.evalb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.evalb.MouseState = MaterialSkin.MouseState.HOVER;
            this.evalb.Name = "evalb";
            this.evalb.Primary = false;
            this.evalb.Size = new System.Drawing.Size(132, 36);
            this.evalb.TabIndex = 17;
            this.evalb.Text = "valb  0x00000000";
            this.evalb.UseVisualStyleBackColor = true;
            // 
            // eifun
            // 
            this.eifun.AutoSize = true;
            this.eifun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eifun.Depth = 0;
            this.eifun.Location = new System.Drawing.Point(141, 72);
            this.eifun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eifun.MouseState = MaterialSkin.MouseState.HOVER;
            this.eifun.Name = "eifun";
            this.eifun.Primary = false;
            this.eifun.Size = new System.Drawing.Size(57, 36);
            this.eifun.TabIndex = 16;
            this.eifun.Text = "ifun  0";
            this.eifun.UseVisualStyleBackColor = true;
            // 
            // evala
            // 
            this.evala.AutoSize = true;
            this.evala.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.evala.Depth = 0;
            this.evala.Location = new System.Drawing.Point(274, 73);
            this.evala.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.evala.MouseState = MaterialSkin.MouseState.HOVER;
            this.evala.Name = "evala";
            this.evala.Primary = false;
            this.evala.Size = new System.Drawing.Size(132, 36);
            this.evala.TabIndex = 14;
            this.evala.Text = "vala  0x00000000";
            this.evala.UseVisualStyleBackColor = true;
            // 
            // evalc
            // 
            this.evalc.AutoSize = true;
            this.evalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.evalc.Depth = 0;
            this.evalc.Location = new System.Drawing.Point(274, 22);
            this.evalc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.evalc.MouseState = MaterialSkin.MouseState.HOVER;
            this.evalc.Name = "evalc";
            this.evalc.Primary = false;
            this.evalc.Size = new System.Drawing.Size(132, 36);
            this.evalc.TabIndex = 13;
            this.evalc.Text = "valc  0x00000000";
            this.evalc.UseVisualStyleBackColor = true;
            // 
            // estall
            // 
            this.estall.AutoSize = true;
            this.estall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.estall.Depth = 0;
            this.estall.Location = new System.Drawing.Point(139, 118);
            this.estall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.estall.MouseState = MaterialSkin.MouseState.HOVER;
            this.estall.Name = "estall";
            this.estall.Primary = true;
            this.estall.Size = new System.Drawing.Size(62, 36);
            this.estall.TabIndex = 12;
            this.estall.Text = "Dstall";
            this.estall.UseVisualStyleBackColor = true;
            // 
            // estat
            // 
            this.estat.AutoSize = true;
            this.estat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.estat.Depth = 0;
            this.estat.Location = new System.Drawing.Point(20, 120);
            this.estat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.estat.MouseState = MaterialSkin.MouseState.HOVER;
            this.estat.Name = "estat";
            this.estat.Primary = false;
            this.estat.Size = new System.Drawing.Size(111, 36);
            this.estat.TabIndex = 11;
            this.estat.Text = "state  Dstate";
            this.estat.UseVisualStyleBackColor = true;
            // 
            // eicode
            // 
            this.eicode.AutoSize = true;
            this.eicode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eicode.Depth = 0;
            this.eicode.Location = new System.Drawing.Point(20, 72);
            this.eicode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eicode.MouseState = MaterialSkin.MouseState.HOVER;
            this.eicode.Name = "eicode";
            this.eicode.Primary = false;
            this.eicode.Size = new System.Drawing.Size(66, 36);
            this.eicode.TabIndex = 10;
            this.eicode.Text = "icode  0";
            this.eicode.UseVisualStyleBackColor = true;
            // 
            // einstr
            // 
            this.einstr.AutoSize = true;
            this.einstr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.einstr.Depth = 0;
            this.einstr.Location = new System.Drawing.Point(20, 22);
            this.einstr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.einstr.MouseState = MaterialSkin.MouseState.HOVER;
            this.einstr.Name = "einstr";
            this.einstr.Primary = false;
            this.einstr.Size = new System.Drawing.Size(51, 36);
            this.einstr.TabIndex = 9;
            this.einstr.Text = "Instr";
            this.einstr.UseVisualStyleBackColor = true;
            // 
            // tpMemoryVisit
            // 
            this.tpMemoryVisit.Controls.Add(this.mdstm);
            this.tpMemoryVisit.Controls.Add(this.mdste);
            this.tpMemoryVisit.Controls.Add(this.mvala);
            this.tpMemoryVisit.Controls.Add(this.mifun);
            this.tpMemoryVisit.Controls.Add(this.mvale);
            this.tpMemoryVisit.Controls.Add(this.mcc);
            this.tpMemoryVisit.Controls.Add(this.mstall);
            this.tpMemoryVisit.Controls.Add(this.mstat);
            this.tpMemoryVisit.Controls.Add(this.micode);
            this.tpMemoryVisit.Controls.Add(this.minstr);
            this.tpMemoryVisit.Location = new System.Drawing.Point(4, 22);
            this.tpMemoryVisit.Name = "tpMemoryVisit";
            this.tpMemoryVisit.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemoryVisit.Size = new System.Drawing.Size(486, 253);
            this.tpMemoryVisit.TabIndex = 3;
            this.tpMemoryVisit.Text = "Memoey";
            this.tpMemoryVisit.UseVisualStyleBackColor = true;
            // 
            // mdstm
            // 
            this.mdstm.AutoSize = true;
            this.mdstm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mdstm.Depth = 0;
            this.mdstm.Location = new System.Drawing.Point(175, 176);
            this.mdstm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mdstm.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdstm.Name = "mdstm";
            this.mdstm.Primary = false;
            this.mdstm.Size = new System.Drawing.Size(135, 36);
            this.mdstm.TabIndex = 33;
            this.mdstm.Text = "dstm  0x00000000";
            this.mdstm.UseVisualStyleBackColor = true;
            // 
            // mdste
            // 
            this.mdste.AutoSize = true;
            this.mdste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mdste.Depth = 0;
            this.mdste.Location = new System.Drawing.Point(20, 174);
            this.mdste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mdste.MouseState = MaterialSkin.MouseState.HOVER;
            this.mdste.Name = "mdste";
            this.mdste.Primary = false;
            this.mdste.Size = new System.Drawing.Size(131, 36);
            this.mdste.TabIndex = 32;
            this.mdste.Text = "dste  0x00000000";
            this.mdste.UseVisualStyleBackColor = true;
            // 
            // mvala
            // 
            this.mvala.AutoSize = true;
            this.mvala.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mvala.Depth = 0;
            this.mvala.Location = new System.Drawing.Point(274, 123);
            this.mvala.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mvala.MouseState = MaterialSkin.MouseState.HOVER;
            this.mvala.Name = "mvala";
            this.mvala.Primary = false;
            this.mvala.Size = new System.Drawing.Size(132, 36);
            this.mvala.TabIndex = 29;
            this.mvala.Text = "vala  0x00000000";
            this.mvala.UseVisualStyleBackColor = true;
            // 
            // mifun
            // 
            this.mifun.AutoSize = true;
            this.mifun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mifun.Depth = 0;
            this.mifun.Location = new System.Drawing.Point(149, 73);
            this.mifun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mifun.MouseState = MaterialSkin.MouseState.HOVER;
            this.mifun.Name = "mifun";
            this.mifun.Primary = false;
            this.mifun.Size = new System.Drawing.Size(51, 36);
            this.mifun.TabIndex = 28;
            this.mifun.Text = "cnd 0";
            this.mifun.UseVisualStyleBackColor = true;
            // 
            // mvale
            // 
            this.mvale.AutoSize = true;
            this.mvale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mvale.Depth = 0;
            this.mvale.Location = new System.Drawing.Point(274, 74);
            this.mvale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mvale.MouseState = MaterialSkin.MouseState.HOVER;
            this.mvale.Name = "mvale";
            this.mvale.Primary = false;
            this.mvale.Size = new System.Drawing.Size(131, 36);
            this.mvale.TabIndex = 27;
            this.mvale.Text = "vale  0x00000000";
            this.mvale.UseVisualStyleBackColor = true;
            // 
            // mcc
            // 
            this.mcc.AutoSize = true;
            this.mcc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mcc.Depth = 0;
            this.mcc.Location = new System.Drawing.Point(274, 23);
            this.mcc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mcc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcc.Name = "mcc";
            this.mcc.Primary = false;
            this.mcc.Size = new System.Drawing.Size(51, 36);
            this.mcc.TabIndex = 26;
            this.mcc.Text = "cc    0";
            this.mcc.UseVisualStyleBackColor = true;
            // 
            // mstall
            // 
            this.mstall.AutoSize = true;
            this.mstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mstall.Depth = 0;
            this.mstall.Location = new System.Drawing.Point(139, 119);
            this.mstall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.mstall.Name = "mstall";
            this.mstall.Primary = true;
            this.mstall.Size = new System.Drawing.Size(65, 36);
            this.mstall.TabIndex = 25;
            this.mstall.Text = "Mstall";
            this.mstall.UseVisualStyleBackColor = true;
            // 
            // mstat
            // 
            this.mstat.AutoSize = true;
            this.mstat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mstat.Depth = 0;
            this.mstat.Location = new System.Drawing.Point(20, 121);
            this.mstat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mstat.MouseState = MaterialSkin.MouseState.HOVER;
            this.mstat.Name = "mstat";
            this.mstat.Primary = false;
            this.mstat.Size = new System.Drawing.Size(115, 36);
            this.mstat.TabIndex = 24;
            this.mstat.Text = "state  Mstate";
            this.mstat.UseVisualStyleBackColor = true;
            // 
            // micode
            // 
            this.micode.AutoSize = true;
            this.micode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.micode.Depth = 0;
            this.micode.Location = new System.Drawing.Point(20, 73);
            this.micode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.micode.MouseState = MaterialSkin.MouseState.HOVER;
            this.micode.Name = "micode";
            this.micode.Primary = false;
            this.micode.Size = new System.Drawing.Size(66, 36);
            this.micode.TabIndex = 23;
            this.micode.Text = "icode  0";
            this.micode.UseVisualStyleBackColor = true;
            // 
            // minstr
            // 
            this.minstr.AutoSize = true;
            this.minstr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minstr.Depth = 0;
            this.minstr.Location = new System.Drawing.Point(20, 23);
            this.minstr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.minstr.MouseState = MaterialSkin.MouseState.HOVER;
            this.minstr.Name = "minstr";
            this.minstr.Primary = false;
            this.minstr.Size = new System.Drawing.Size(51, 36);
            this.minstr.TabIndex = 22;
            this.minstr.Text = "Instr";
            this.minstr.UseVisualStyleBackColor = true;
            // 
            // tpWriteBack
            // 
            this.tpWriteBack.Controls.Add(this.wdstm);
            this.tpWriteBack.Controls.Add(this.wdste);
            this.tpWriteBack.Controls.Add(this.wvalm);
            this.tpWriteBack.Controls.Add(this.wvale);
            this.tpWriteBack.Controls.Add(this.wstall);
            this.tpWriteBack.Controls.Add(this.wstat);
            this.tpWriteBack.Controls.Add(this.wicode);
            this.tpWriteBack.Controls.Add(this.winstr);
            this.tpWriteBack.Location = new System.Drawing.Point(4, 22);
            this.tpWriteBack.Name = "tpWriteBack";
            this.tpWriteBack.Padding = new System.Windows.Forms.Padding(3);
            this.tpWriteBack.Size = new System.Drawing.Size(486, 253);
            this.tpWriteBack.TabIndex = 4;
            this.tpWriteBack.Text = "WriteBack";
            this.tpWriteBack.UseVisualStyleBackColor = true;
            // 
            // wdstm
            // 
            this.wdstm.AutoSize = true;
            this.wdstm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wdstm.Depth = 0;
            this.wdstm.Location = new System.Drawing.Point(205, 185);
            this.wdstm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wdstm.MouseState = MaterialSkin.MouseState.HOVER;
            this.wdstm.Name = "wdstm";
            this.wdstm.Primary = false;
            this.wdstm.Size = new System.Drawing.Size(135, 36);
            this.wdstm.TabIndex = 43;
            this.wdstm.Text = "dstm  0x00000000";
            this.wdstm.UseVisualStyleBackColor = true;
            // 
            // wdste
            // 
            this.wdste.AutoSize = true;
            this.wdste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wdste.Depth = 0;
            this.wdste.Location = new System.Drawing.Point(50, 183);
            this.wdste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wdste.MouseState = MaterialSkin.MouseState.HOVER;
            this.wdste.Name = "wdste";
            this.wdste.Primary = false;
            this.wdste.Size = new System.Drawing.Size(131, 36);
            this.wdste.TabIndex = 42;
            this.wdste.Text = "dste  0x00000000";
            this.wdste.UseVisualStyleBackColor = true;
            // 
            // wvalm
            // 
            this.wvalm.AutoSize = true;
            this.wvalm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wvalm.Depth = 0;
            this.wvalm.Location = new System.Drawing.Point(304, 132);
            this.wvalm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wvalm.MouseState = MaterialSkin.MouseState.HOVER;
            this.wvalm.Name = "wvalm";
            this.wvalm.Primary = false;
            this.wvalm.Size = new System.Drawing.Size(132, 36);
            this.wvalm.TabIndex = 41;
            this.wvalm.Text = "valb  0x00000000";
            this.wvalm.UseVisualStyleBackColor = true;
            // 
            // wvale
            // 
            this.wvale.AutoSize = true;
            this.wvale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wvale.Depth = 0;
            this.wvale.Location = new System.Drawing.Point(304, 83);
            this.wvale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wvale.MouseState = MaterialSkin.MouseState.HOVER;
            this.wvale.Name = "wvale";
            this.wvale.Primary = false;
            this.wvale.Size = new System.Drawing.Size(132, 36);
            this.wvale.TabIndex = 39;
            this.wvale.Text = "vala  0x00000000";
            this.wvale.UseVisualStyleBackColor = true;
            // 
            // wstall
            // 
            this.wstall.AutoSize = true;
            this.wstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wstall.Depth = 0;
            this.wstall.Location = new System.Drawing.Point(169, 128);
            this.wstall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.wstall.Name = "wstall";
            this.wstall.Primary = true;
            this.wstall.Size = new System.Drawing.Size(65, 36);
            this.wstall.TabIndex = 37;
            this.wstall.Text = "Wstall";
            this.wstall.UseVisualStyleBackColor = true;
            // 
            // wstat
            // 
            this.wstat.AutoSize = true;
            this.wstat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wstat.Depth = 0;
            this.wstat.Location = new System.Drawing.Point(50, 130);
            this.wstat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wstat.MouseState = MaterialSkin.MouseState.HOVER;
            this.wstat.Name = "wstat";
            this.wstat.Primary = false;
            this.wstat.Size = new System.Drawing.Size(111, 36);
            this.wstat.TabIndex = 36;
            this.wstat.Text = "state  Dstate";
            this.wstat.UseVisualStyleBackColor = true;
            // 
            // wicode
            // 
            this.wicode.AutoSize = true;
            this.wicode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wicode.Depth = 0;
            this.wicode.Location = new System.Drawing.Point(50, 82);
            this.wicode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.wicode.MouseState = MaterialSkin.MouseState.HOVER;
            this.wicode.Name = "wicode";
            this.wicode.Primary = false;
            this.wicode.Size = new System.Drawing.Size(66, 36);
            this.wicode.TabIndex = 35;
            this.wicode.Text = "icode  0";
            this.wicode.UseVisualStyleBackColor = true;
            // 
            // winstr
            // 
            this.winstr.AutoSize = true;
            this.winstr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.winstr.Depth = 0;
            this.winstr.Location = new System.Drawing.Point(50, 32);
            this.winstr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.winstr.MouseState = MaterialSkin.MouseState.HOVER;
            this.winstr.Name = "winstr";
            this.winstr.Primary = false;
            this.winstr.Size = new System.Drawing.Size(51, 36);
            this.winstr.TabIndex = 34;
            this.winstr.Text = "Instr";
            this.winstr.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.Depth = 0;
            this.btnPlay.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(16, 48);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Primary = true;
            this.btnPlay.Size = new System.Drawing.Size(46, 36);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rbtn1Hz
            // 
            this.rbtn1Hz.AutoSize = true;
            this.rbtn1Hz.Depth = 0;
            this.rbtn1Hz.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn1Hz.Location = new System.Drawing.Point(16, 50);
            this.rbtn1Hz.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn1Hz.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn1Hz.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn1Hz.Name = "rbtn1Hz";
            this.rbtn1Hz.Ripple = true;
            this.rbtn1Hz.Size = new System.Drawing.Size(53, 30);
            this.rbtn1Hz.TabIndex = 1;
            this.rbtn1Hz.TabStop = true;
            this.rbtn1Hz.Text = "1Hz";
            this.rbtn1Hz.UseVisualStyleBackColor = true;
            this.rbtn1Hz.Visible = false;
            // 
            // btnProcessOptions
            // 
            this.btnProcessOptions.AutoSize = true;
            this.btnProcessOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcessOptions.Depth = 0;
            this.btnProcessOptions.Location = new System.Drawing.Point(17, 241);
            this.btnProcessOptions.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcessOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcessOptions.Name = "btnProcessOptions";
            this.btnProcessOptions.Primary = false;
            this.btnProcessOptions.Size = new System.Drawing.Size(70, 36);
            this.btnProcessOptions.TabIndex = 9;
            this.btnProcessOptions.Text = "Options";
            this.btnProcessOptions.UseVisualStyleBackColor = true;
            this.btnProcessOptions.Click += new System.EventHandler(this.btnProcessOption_Click);
            // 
            // btnNextBreakpoint
            // 
            this.btnNextBreakpoint.AutoSize = true;
            this.btnNextBreakpoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextBreakpoint.Depth = 0;
            this.btnNextBreakpoint.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBreakpoint.Location = new System.Drawing.Point(16, 145);
            this.btnNextBreakpoint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextBreakpoint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextBreakpoint.Name = "btnNextBreakpoint";
            this.btnNextBreakpoint.Primary = false;
            this.btnNextBreakpoint.Size = new System.Drawing.Size(133, 36);
            this.btnNextBreakpoint.TabIndex = 5;
            this.btnNextBreakpoint.Text = "Next Breakpoint";
            this.btnNextBreakpoint.UseVisualStyleBackColor = true;
            this.btnNextBreakpoint.Click += new System.EventHandler(this.btnNextBreakpoint_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Depth = 0;
            this.btnStop.Location = new System.Drawing.Point(16, 48);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.Primary = false;
            this.btnStop.Size = new System.Drawing.Size(47, 36);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.AutoSize = true;
            this.btnNextStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextStep.Depth = 0;
            this.btnNextStep.Location = new System.Drawing.Point(16, 96);
            this.btnNextStep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Primary = false;
            this.btnNextStep.Size = new System.Drawing.Size(83, 36);
            this.btnNextStep.TabIndex = 7;
            this.btnNextStep.Text = "Next Step";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // rbtn50Hz
            // 
            this.rbtn50Hz.AutoSize = true;
            this.rbtn50Hz.Depth = 0;
            this.rbtn50Hz.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn50Hz.Location = new System.Drawing.Point(17, 194);
            this.rbtn50Hz.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn50Hz.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn50Hz.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn50Hz.Name = "rbtn50Hz";
            this.rbtn50Hz.Ripple = true;
            this.rbtn50Hz.Size = new System.Drawing.Size(61, 30);
            this.rbtn50Hz.TabIndex = 4;
            this.rbtn50Hz.TabStop = true;
            this.rbtn50Hz.Text = "50Hz";
            this.rbtn50Hz.UseVisualStyleBackColor = true;
            this.rbtn50Hz.Visible = false;
            // 
            // rbtn10Hz
            // 
            this.rbtn10Hz.AutoSize = true;
            this.rbtn10Hz.Depth = 0;
            this.rbtn10Hz.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn10Hz.Location = new System.Drawing.Point(17, 146);
            this.rbtn10Hz.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn10Hz.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn10Hz.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn10Hz.Name = "rbtn10Hz";
            this.rbtn10Hz.Ripple = true;
            this.rbtn10Hz.Size = new System.Drawing.Size(61, 30);
            this.rbtn10Hz.TabIndex = 3;
            this.rbtn10Hz.TabStop = true;
            this.rbtn10Hz.Text = "10Hz";
            this.rbtn10Hz.UseVisualStyleBackColor = true;
            this.rbtn10Hz.Visible = false;
            // 
            // rbtn5Hz
            // 
            this.rbtn5Hz.AutoSize = true;
            this.rbtn5Hz.Depth = 0;
            this.rbtn5Hz.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn5Hz.Location = new System.Drawing.Point(17, 99);
            this.rbtn5Hz.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn5Hz.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn5Hz.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn5Hz.Name = "rbtn5Hz";
            this.rbtn5Hz.Ripple = true;
            this.rbtn5Hz.Size = new System.Drawing.Size(53, 30);
            this.rbtn5Hz.TabIndex = 2;
            this.rbtn5Hz.TabStop = true;
            this.rbtn5Hz.Text = "5Hz";
            this.rbtn5Hz.UseVisualStyleBackColor = true;
            this.rbtn5Hz.Visible = false;
            this.rbtn5Hz.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // btnConfirmSpeed
            // 
            this.btnConfirmSpeed.AutoSize = true;
            this.btnConfirmSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmSpeed.Depth = 0;
            this.btnConfirmSpeed.Location = new System.Drawing.Point(16, 240);
            this.btnConfirmSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmSpeed.Name = "btnConfirmSpeed";
            this.btnConfirmSpeed.Primary = false;
            this.btnConfirmSpeed.Size = new System.Drawing.Size(72, 36);
            this.btnConfirmSpeed.TabIndex = 0;
            this.btnConfirmSpeed.Text = "Confirm";
            this.btnConfirmSpeed.UseVisualStyleBackColor = true;
            this.btnConfirmSpeed.Visible = false;
            this.btnConfirmSpeed.Click += new System.EventHandler(this.btnConfirmSpeed_Click);
            // 
            // tpMemory
            // 
            this.tpMemory.Controls.Add(this.btnMemoryOption);
            this.tpMemory.Controls.Add(this.lvMemory);
            this.tpMemory.Location = new System.Drawing.Point(4, 24);
            this.tpMemory.Name = "tpMemory";
            this.tpMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemory.Size = new System.Drawing.Size(991, 441);
            this.tpMemory.TabIndex = 3;
            this.tpMemory.Text = "Memory";
            this.tpMemory.UseVisualStyleBackColor = true;
            // 
            // btnMemoryOption
            // 
            this.btnMemoryOption.AutoSize = true;
            this.btnMemoryOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMemoryOption.Depth = 0;
            this.btnMemoryOption.Location = new System.Drawing.Point(812, 342);
            this.btnMemoryOption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMemoryOption.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMemoryOption.Name = "btnMemoryOption";
            this.btnMemoryOption.Primary = true;
            this.btnMemoryOption.Size = new System.Drawing.Size(70, 36);
            this.btnMemoryOption.TabIndex = 5;
            this.btnMemoryOption.Text = "Options";
            this.btnMemoryOption.UseVisualStyleBackColor = true;
            // 
            // lvMemory
            // 
            this.lvMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAddress,
            this.chData});
            this.lvMemory.Depth = 0;
            this.lvMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMemory.Font = new System.Drawing.Font("Roboto", 24F);
            this.lvMemory.FullRowSelect = true;
            this.lvMemory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMemory.Location = new System.Drawing.Point(3, 3);
            this.lvMemory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvMemory.MouseState = MaterialSkin.MouseState.OUT;
            this.lvMemory.Name = "lvMemory";
            this.lvMemory.OwnerDraw = true;
            this.lvMemory.Size = new System.Drawing.Size(985, 435);
            this.lvMemory.TabIndex = 4;
            this.lvMemory.UseCompatibleStateImageBehavior = false;
            this.lvMemory.View = System.Windows.Forms.View.Details;
            // 
            // chAddress
            // 
            this.chAddress.Text = "Address";
            this.chAddress.Width = 150;
            // 
            // chData
            // 
            this.chData.Text = "Data";
            this.chData.Width = 278;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.lblABout);
            this.tpAbout.Location = new System.Drawing.Point(4, 24);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(991, 441);
            this.tpAbout.TabIndex = 4;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // lblABout
            // 
            this.lblABout.AutoSize = true;
            this.lblABout.Depth = 0;
            this.lblABout.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblABout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblABout.Location = new System.Drawing.Point(248, 72);
            this.lblABout.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblABout.Name = "lblABout";
            this.lblABout.Size = new System.Drawing.Size(48, 18);
            this.lblABout.TabIndex = 0;
            this.lblABout.Text = "About";
            this.lblABout.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // labelMdstm
            // 
            this.labelMdstm.AutoSize = true;
            this.labelMdstm.Depth = 0;
            this.labelMdstm.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelMdstm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMdstm.Location = new System.Drawing.Point(65, 33);
            this.labelMdstm.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMdstm.Name = "labelMdstm";
            this.labelMdstm.Size = new System.Drawing.Size(87, 17);
            this.labelMdstm.TabIndex = 10;
            this.labelMdstm.Text = "0x00000000";
            // 
            // labelMdste
            // 
            this.labelMdste.AutoSize = true;
            this.labelMdste.Depth = 0;
            this.labelMdste.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelMdste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMdste.Location = new System.Drawing.Point(65, 13);
            this.labelMdste.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMdste.Name = "labelMdste";
            this.labelMdste.Size = new System.Drawing.Size(87, 17);
            this.labelMdste.TabIndex = 9;
            this.labelMdste.Text = "0x00000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "dstM:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Depth = 0;
            this.label25.Font = new System.Drawing.Font("Roboto", 10F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(12, 13);
            this.label25.MouseState = MaterialSkin.MouseState.HOVER;
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 17);
            this.label25.TabIndex = 2;
            this.label25.Text = "dstE:";
            // 
            // labelcc
            // 
            this.labelcc.AutoSize = true;
            this.labelcc.Depth = 0;
            this.labelcc.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelcc.Location = new System.Drawing.Point(60, 53);
            this.labelcc.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelcc.Name = "labelcc";
            this.labelcc.Size = new System.Drawing.Size(16, 17);
            this.labelcc.TabIndex = 7;
            this.labelcc.Text = "0";
            // 
            // labelMvala
            // 
            this.labelMvala.AutoSize = true;
            this.labelMvala.Depth = 0;
            this.labelMvala.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelMvala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMvala.Location = new System.Drawing.Point(60, 33);
            this.labelMvala.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMvala.Name = "labelMvala";
            this.labelMvala.Size = new System.Drawing.Size(87, 17);
            this.labelMvala.TabIndex = 6;
            this.labelMvala.Text = "0x00000000";
            // 
            // labelMvale
            // 
            this.labelMvale.AutoSize = true;
            this.labelMvale.Depth = 0;
            this.labelMvale.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelMvale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMvale.Location = new System.Drawing.Point(60, 13);
            this.labelMvale.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMvale.Name = "labelMvale";
            this.labelMvale.Size = new System.Drawing.Size(87, 17);
            this.labelMvale.TabIndex = 5;
            this.labelMvale.Text = "0x00000000";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Depth = 0;
            this.label22.Font = new System.Drawing.Font("Roboto", 10F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(14, 53);
            this.label22.MouseState = MaterialSkin.MouseState.HOVER;
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 17);
            this.label22.TabIndex = 4;
            this.label22.Text = "CC  :    ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(14, 33);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "valA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Depth = 0;
            this.label12.Font = new System.Drawing.Font("Roboto", 10F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(14, 13);
            this.label12.MouseState = MaterialSkin.MouseState.HOVER;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "valE:";
            // 
            // tabsNavbar
            // 
            this.tabsNavbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsNavbar.BaseTabControl = this.tabNavbar;
            this.tabsNavbar.Depth = 0;
            this.tabsNavbar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsNavbar.Location = new System.Drawing.Point(-3, 64);
            this.tabsNavbar.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabsNavbar.Name = "tabsNavbar";
            this.tabsNavbar.Size = new System.Drawing.Size(1027, 50);
            this.tabsNavbar.TabIndex = 19;
            this.tabsNavbar.Text = "materialTabSelector2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnDisableBreakpoint
            // 
            this.btnDisableBreakpoint.AutoSize = true;
            this.btnDisableBreakpoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisableBreakpoint.Depth = 0;
            this.btnDisableBreakpoint.Location = new System.Drawing.Point(795, 386);
            this.btnDisableBreakpoint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisableBreakpoint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisableBreakpoint.Name = "btnDisableBreakpoint";
            this.btnDisableBreakpoint.Primary = true;
            this.btnDisableBreakpoint.Size = new System.Drawing.Size(153, 36);
            this.btnDisableBreakpoint.TabIndex = 6;
            this.btnDisableBreakpoint.Text = "Disable Breakpoint";
            this.btnDisableBreakpoint.UseVisualStyleBackColor = true;
            this.btnDisableBreakpoint.Click += new System.EventHandler(this.btnDisableBreakpoint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 576);
            this.Controls.Add(this.tabsNavbar);
            this.Controls.Add(this.tabNavbar);
            this.Name = "MainForm";
            this.Text = "Pipeline Simulator";
            this.tabNavbar.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.tpCode.ResumeLayout(false);
            this.tpCode.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.tpProcess.ResumeLayout(false);
            this.tpProcess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            this.pnlProcess.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tpFetch.ResumeLayout(false);
            this.tpFetch.PerformLayout();
            this.tpDecode.ResumeLayout(false);
            this.tpDecode.PerformLayout();
            this.tpExecute.ResumeLayout(false);
            this.tpExecute.PerformLayout();
            this.tpMemoryVisit.ResumeLayout(false);
            this.tpMemoryVisit.PerformLayout();
            this.tpWriteBack.ResumeLayout(false);
            this.tpWriteBack.PerformLayout();
            this.tpMemory.ResumeLayout(false);
            this.tpMemory.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialTabControl tabNavbar;
        private MaterialSkin.Controls.MaterialTabSelector tabsNavbar;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpCode;
        private System.Windows.Forms.TabPage tpProcess;
        private System.Windows.Forms.TabPage tpAbout;

        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenInstrFile;
        private MaterialSkin.Controls.MaterialRaisedButton BtnOpenBinaryFile;

        private MaterialSkin.Controls.MaterialListView lvCode;
        private System.Windows.Forms.ColumnHeader chAddr;
        private System.Windows.Forms.ColumnHeader chBinary;
        private System.Windows.Forms.ColumnHeader chInstr;
        private MaterialSkin.Controls.MaterialFlatButton btnEnableBreakpoint;

        private MaterialSkin.Controls.MaterialRadioButton rbtn50Hz;
        private MaterialSkin.Controls.MaterialRadioButton rbtn10Hz;
        private MaterialSkin.Controls.MaterialRadioButton rbtn5Hz;
        private MaterialSkin.Controls.MaterialRadioButton rbtn1Hz;
        private MaterialSkin.Controls.MaterialFlatButton btnConfirmSpeed;

        private MaterialSkin.Controls.MaterialFlatButton btnProcessOptions;
        private MaterialSkin.Controls.MaterialFlatButton btnNextBreakpoint;
        private MaterialSkin.Controls.MaterialFlatButton btnStop;
        private MaterialSkin.Controls.MaterialFlatButton btnNextStep;
        private MaterialSkin.Controls.MaterialFlatButton btnPlay;
        private MaterialSkin.Controls.MaterialSecondaryLabel labelMdstm;
        private MaterialSkin.Controls.MaterialSecondaryLabel labelMdste;
        private MaterialSkin.Controls.MaterialSecondaryLabel label5;
        private MaterialSkin.Controls.MaterialSecondaryLabel label25;

        private MaterialSkin.Controls.MaterialSecondaryLabel labelcc;
        private MaterialSkin.Controls.MaterialSecondaryLabel labelMvala;
        private MaterialSkin.Controls.MaterialSecondaryLabel labelMvale;
        private MaterialSkin.Controls.MaterialSecondaryLabel label22;
        private MaterialSkin.Controls.MaterialSecondaryLabel label11;
        private MaterialSkin.Controls.MaterialSecondaryLabel label12;
        private System.Windows.Forms.Panel pnlProcess;
        private MaterialSkin.Controls.MaterialTabSelector tabsProcess;
        private MaterialSkin.Controls.MaterialTabControl tabProcess;
        private System.Windows.Forms.TabPage tpFetch;
        private System.Windows.Forms.TabPage tpDecode;
        private System.Windows.Forms.TabPage tpExecute;
        private System.Windows.Forms.TabPage tpMemoryVisit;
        private System.Windows.Forms.TabPage tpWriteBack;
        private System.Windows.Forms.TabPage tpMemory;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl tabRegister;
        private System.Windows.Forms.TabPage tpRegister;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton btnMemoryOption;
        private MaterialSkin.Controls.MaterialListView lvMemory;
        private System.Windows.Forms.ColumnHeader chAddress;
        private System.Windows.Forms.ColumnHeader chData;
        private MaterialSkin.Controls.MaterialLabel lblABout;
        public MaterialSkin.Controls.MaterialFlatButton eax;
        public MaterialSkin.Controls.MaterialFlatButton edi;
        public MaterialSkin.Controls.MaterialFlatButton esi;
        public MaterialSkin.Controls.MaterialFlatButton ebp;
        public MaterialSkin.Controls.MaterialFlatButton esp;
        public MaterialSkin.Controls.MaterialFlatButton ebx;
        public MaterialSkin.Controls.MaterialFlatButton edx;
        public MaterialSkin.Controls.MaterialFlatButton ecx;

        public MaterialSkin.Controls.MaterialFlatButton fpredPC;
        public MaterialSkin.Controls.MaterialFlatButton fstall;
        public MaterialSkin.Controls.MaterialFlatButton fcircle;
        public MaterialSkin.Controls.MaterialFlatButton dstall;
        public MaterialSkin.Controls.MaterialFlatButton dstat;
        public MaterialSkin.Controls.MaterialFlatButton dicode;
        public MaterialSkin.Controls.MaterialFlatButton dinstr;
        public MaterialSkin.Controls.MaterialFlatButton dra;
        public MaterialSkin.Controls.MaterialFlatButton dvalp;
        public MaterialSkin.Controls.MaterialFlatButton dvalc;
        public MaterialSkin.Controls.MaterialFlatButton difun;
        public MaterialSkin.Controls.MaterialFlatButton drb;
        public MaterialSkin.Controls.MaterialFlatButton edstm;
        public MaterialSkin.Controls.MaterialFlatButton edste;
        public MaterialSkin.Controls.MaterialFlatButton esrcb;
        public MaterialSkin.Controls.MaterialFlatButton esrca;
        public MaterialSkin.Controls.MaterialFlatButton evalb;
        public MaterialSkin.Controls.MaterialFlatButton eifun;
        public MaterialSkin.Controls.MaterialFlatButton evala;
        public MaterialSkin.Controls.MaterialFlatButton evalc;
        public MaterialSkin.Controls.MaterialFlatButton estall;
        public MaterialSkin.Controls.MaterialFlatButton estat;
        public MaterialSkin.Controls.MaterialFlatButton eicode;
        public MaterialSkin.Controls.MaterialFlatButton einstr;
        public MaterialSkin.Controls.MaterialFlatButton mdstm;
        public MaterialSkin.Controls.MaterialFlatButton mdste;
        public MaterialSkin.Controls.MaterialFlatButton mvala;
        public MaterialSkin.Controls.MaterialFlatButton mifun;
        public MaterialSkin.Controls.MaterialFlatButton mvale;
        public MaterialSkin.Controls.MaterialFlatButton mcc;
        public MaterialSkin.Controls.MaterialFlatButton mstall;
        public MaterialSkin.Controls.MaterialFlatButton mstat;
        public MaterialSkin.Controls.MaterialFlatButton micode;
        public MaterialSkin.Controls.MaterialFlatButton minstr;
        public MaterialSkin.Controls.MaterialFlatButton wdstm;
        public MaterialSkin.Controls.MaterialFlatButton wdste;
        public MaterialSkin.Controls.MaterialFlatButton wvalm;
        public MaterialSkin.Controls.MaterialFlatButton wvale;
        public MaterialSkin.Controls.MaterialFlatButton wstall;
        public MaterialSkin.Controls.MaterialFlatButton wstat;
        public MaterialSkin.Controls.MaterialFlatButton wicode;
        public MaterialSkin.Controls.MaterialFlatButton winstr;

        private MaterialSkin.Controls.MaterialFlatButton btnReset;
        public System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchText;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuitEnableBreakpoint;
        private System.Windows.Forms.ToolStripMenuItem mnuitDisableBreakpoint;
        private System.Windows.Forms.ToolStripMenuItem mnuitSearch;
        private System.Windows.Forms.ColumnHeader chBreakpoint;
        private System.Windows.Forms.ColumnHeader chLineNumber;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnlUnderLine;
        private MaterialSkin.Controls.MaterialFlatButton btnDisableBreakpoint;




    }
}

