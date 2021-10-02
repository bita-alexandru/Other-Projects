﻿
namespace MP3_Player
{
    partial class MP3_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3_Player));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAjutor = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPlaylisturi = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPlaylist = new System.Windows.Forms.TextBox();
            this.buttonCreeaza = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAmesteca = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStergeMelodie = new System.Windows.Forms.Button();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonJos = new System.Windows.Forms.Button();
            this.buttonSus = new System.Windows.Forms.Button();
            this.buttonAdaugaMelodie = new System.Windows.Forms.Button();
            this.listBoxMelodii = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRepeta = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonInainte = new System.Windows.Forms.Button();
            this.buttonRedare = new System.Windows.Forms.Button();
            this.buttonOprire = new System.Windows.Forms.Button();
            this.buttonPauza = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxMelodie = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDuratie = new System.Windows.Forms.TextBox();
            this.labelMelodie = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMelodie)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSalveaza,
            this.menuItemAjutor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemSalveaza
            // 
            this.menuItemSalveaza.Name = "menuItemSalveaza";
            this.menuItemSalveaza.Size = new System.Drawing.Size(81, 24);
            this.menuItemSalveaza.Text = "Salvează";
            this.menuItemSalveaza.Click += new System.EventHandler(this.menuItemSalveaza_Click);
            // 
            // menuItemAjutor
            // 
            this.menuItemAjutor.Name = "menuItemAjutor";
            this.menuItemAjutor.Size = new System.Drawing.Size(64, 24);
            this.menuItemAjutor.Text = "Ajutor";
            this.menuItemAjutor.Click += new System.EventHandler(this.menuItemAjutor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist-uri personale";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.listBoxPlaylisturi, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 371);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // listBoxPlaylisturi
            // 
            this.listBoxPlaylisturi.FormattingEnabled = true;
            this.listBoxPlaylisturi.ItemHeight = 16;
            this.listBoxPlaylisturi.Location = new System.Drawing.Point(3, 40);
            this.listBoxPlaylisturi.Name = "listBoxPlaylisturi";
            this.listBoxPlaylisturi.Size = new System.Drawing.Size(244, 276);
            this.listBoxPlaylisturi.TabIndex = 8;
            this.listBoxPlaylisturi.SelectedValueChanged += new System.EventHandler(this.listBoxPlaylisturi_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPlaylist);
            this.panel1.Controls.Add(this.buttonCreeaza);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 31);
            this.panel1.TabIndex = 10;
            // 
            // textBoxPlaylist
            // 
            this.textBoxPlaylist.Location = new System.Drawing.Point(3, 6);
            this.textBoxPlaylist.Name = "textBoxPlaylist";
            this.textBoxPlaylist.Size = new System.Drawing.Size(148, 22);
            this.textBoxPlaylist.TabIndex = 4;
            // 
            // buttonCreeaza
            // 
            this.buttonCreeaza.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreeaza.Location = new System.Drawing.Point(157, 6);
            this.buttonCreeaza.Name = "buttonCreeaza";
            this.buttonCreeaza.Size = new System.Drawing.Size(84, 22);
            this.buttonCreeaza.TabIndex = 5;
            this.buttonCreeaza.Text = "Creează";
            this.buttonCreeaza.UseVisualStyleBackColor = true;
            this.buttonCreeaza.Click += new System.EventHandler(this.buttonCreeaza_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.buttonAmesteca, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.buttonSterge, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(244, 32);
            this.tableLayoutPanel10.TabIndex = 11;
            // 
            // buttonAmesteca
            // 
            this.buttonAmesteca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAmesteca.Location = new System.Drawing.Point(125, 3);
            this.buttonAmesteca.Name = "buttonAmesteca";
            this.buttonAmesteca.Size = new System.Drawing.Size(116, 26);
            this.buttonAmesteca.TabIndex = 11;
            this.buttonAmesteca.Text = "Amestecă";
            this.buttonAmesteca.UseVisualStyleBackColor = true;
            this.buttonAmesteca.Click += new System.EventHandler(this.buttonAmesteca_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSterge.Location = new System.Drawing.Point(3, 3);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(116, 26);
            this.buttonSterge.TabIndex = 10;
            this.buttonSterge.Text = "Șterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(630, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 398);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist curent";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxCautare, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.listBoxMelodii, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 371);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCautare.Location = new System.Drawing.Point(3, 3);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(245, 22);
            this.textBoxCautare.TabIndex = 16;
            this.textBoxCautare.Text = "Căutare...";
            this.textBoxCautare.TextChanged += new System.EventHandler(this.textBoxCautare_TextChanged);
            this.textBoxCautare.Enter += new System.EventHandler(this.textBoxCautare_Enter);
            this.textBoxCautare.Leave += new System.EventHandler(this.textBoxCautare_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel9);
            this.panel2.Location = new System.Drawing.Point(3, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 69);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel9.Controls.Add(this.buttonStergeMelodie, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.buttonAdaugaMelodie, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(239, 60);
            this.tableLayoutPanel9.TabIndex = 8;
            // 
            // buttonStergeMelodie
            // 
            this.buttonStergeMelodie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStergeMelodie.Location = new System.Drawing.Point(157, 3);
            this.buttonStergeMelodie.Name = "buttonStergeMelodie";
            this.buttonStergeMelodie.Size = new System.Drawing.Size(79, 54);
            this.buttonStergeMelodie.TabIndex = 8;
            this.buttonStergeMelodie.Text = "Șterge";
            this.buttonStergeMelodie.UseVisualStyleBackColor = true;
            this.buttonStergeMelodie.Click += new System.EventHandler(this.buttonStergeMelodie_Click);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.buttonJos, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.buttonSus, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(86, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(65, 54);
            this.tableLayoutPanel12.TabIndex = 9;
            // 
            // buttonJos
            // 
            this.buttonJos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonJos.Location = new System.Drawing.Point(3, 30);
            this.buttonJos.Name = "buttonJos";
            this.buttonJos.Size = new System.Drawing.Size(59, 21);
            this.buttonJos.TabIndex = 11;
            this.buttonJos.Text = "↓";
            this.buttonJos.UseVisualStyleBackColor = true;
            this.buttonJos.Click += new System.EventHandler(this.buttonJos_Click);
            // 
            // buttonSus
            // 
            this.buttonSus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSus.Location = new System.Drawing.Point(3, 3);
            this.buttonSus.Name = "buttonSus";
            this.buttonSus.Size = new System.Drawing.Size(59, 21);
            this.buttonSus.TabIndex = 9;
            this.buttonSus.Text = "↑";
            this.buttonSus.UseVisualStyleBackColor = true;
            this.buttonSus.Click += new System.EventHandler(this.buttonSus_Click);
            // 
            // buttonAdaugaMelodie
            // 
            this.buttonAdaugaMelodie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdaugaMelodie.Location = new System.Drawing.Point(3, 3);
            this.buttonAdaugaMelodie.Name = "buttonAdaugaMelodie";
            this.buttonAdaugaMelodie.Size = new System.Drawing.Size(77, 54);
            this.buttonAdaugaMelodie.TabIndex = 5;
            this.buttonAdaugaMelodie.Text = "Adaugă";
            this.buttonAdaugaMelodie.UseVisualStyleBackColor = true;
            this.buttonAdaugaMelodie.Click += new System.EventHandler(this.buttonAdaugaMelodie_Click);
            // 
            // listBoxMelodii
            // 
            this.listBoxMelodii.FormattingEnabled = true;
            this.listBoxMelodii.ItemHeight = 16;
            this.listBoxMelodii.Location = new System.Drawing.Point(3, 40);
            this.listBoxMelodii.Name = "listBoxMelodii";
            this.listBoxMelodii.Size = new System.Drawing.Size(245, 244);
            this.listBoxMelodii.TabIndex = 7;
            this.listBoxMelodii.SelectedIndexChanged += new System.EventHandler(this.listBoxMelodii_SelectedIndexChanged);
            this.listBoxMelodii.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMelodii_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(272, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 398);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Melodia curentă";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 370);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Location = new System.Drawing.Point(3, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 142);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonOprire, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonPauza, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(324, 133);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.buttonRepeta, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonRedare, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(111, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(101, 127);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // buttonRepeta
            // 
            this.buttonRepeta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRepeta.Location = new System.Drawing.Point(3, 85);
            this.buttonRepeta.Name = "buttonRepeta";
            this.buttonRepeta.Size = new System.Drawing.Size(95, 38);
            this.buttonRepeta.TabIndex = 3;
            this.buttonRepeta.Text = "Repetă";
            this.buttonRepeta.UseVisualStyleBackColor = true;
            this.buttonRepeta.Click += new System.EventHandler(this.buttonRepeta_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.buttonInapoi, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.buttonInainte, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(95, 32);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInapoi.Location = new System.Drawing.Point(3, 3);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(41, 26);
            this.buttonInapoi.TabIndex = 0;
            this.buttonInapoi.Text = "<";
            this.buttonInapoi.UseVisualStyleBackColor = true;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // buttonInainte
            // 
            this.buttonInainte.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInainte.Location = new System.Drawing.Point(50, 3);
            this.buttonInainte.Name = "buttonInainte";
            this.buttonInainte.Size = new System.Drawing.Size(42, 26);
            this.buttonInainte.TabIndex = 1;
            this.buttonInainte.Text = ">";
            this.buttonInainte.UseVisualStyleBackColor = true;
            this.buttonInainte.Click += new System.EventHandler(this.buttonInainte_Click);
            // 
            // buttonRedare
            // 
            this.buttonRedare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRedare.Location = new System.Drawing.Point(3, 3);
            this.buttonRedare.Name = "buttonRedare";
            this.buttonRedare.Size = new System.Drawing.Size(95, 38);
            this.buttonRedare.TabIndex = 2;
            this.buttonRedare.Text = "Redare";
            this.buttonRedare.UseVisualStyleBackColor = true;
            this.buttonRedare.Click += new System.EventHandler(this.buttonRedare_Click);
            // 
            // buttonOprire
            // 
            this.buttonOprire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOprire.Location = new System.Drawing.Point(219, 3);
            this.buttonOprire.Name = "buttonOprire";
            this.buttonOprire.Size = new System.Drawing.Size(102, 127);
            this.buttonOprire.TabIndex = 2;
            this.buttonOprire.Text = "Oprire";
            this.buttonOprire.UseVisualStyleBackColor = true;
            this.buttonOprire.Click += new System.EventHandler(this.buttonOprire_Click);
            // 
            // buttonPauza
            // 
            this.buttonPauza.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPauza.Location = new System.Drawing.Point(3, 3);
            this.buttonPauza.Name = "buttonPauza";
            this.buttonPauza.Size = new System.Drawing.Size(101, 127);
            this.buttonPauza.TabIndex = 1;
            this.buttonPauza.Text = "Pauză";
            this.buttonPauza.UseVisualStyleBackColor = true;
            this.buttonPauza.Click += new System.EventHandler(this.buttonPauza_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxMelodie, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(330, 216);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // pictureBoxMelodie
            // 
            this.pictureBoxMelodie.Image = global::MP3_Player.Properties.Resources.musical_note;
            this.pictureBoxMelodie.Location = new System.Drawing.Point(3, 35);
            this.pictureBoxMelodie.Name = "pictureBoxMelodie";
            this.pictureBoxMelodie.Size = new System.Drawing.Size(324, 178);
            this.pictureBoxMelodie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMelodie.TabIndex = 1;
            this.pictureBoxMelodie.TabStop = false;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel11.Controls.Add(this.labelDuratie, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.labelMelodie, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(324, 26);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // labelDuratie
            // 
            this.labelDuratie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDuratie.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelDuratie.Location = new System.Drawing.Point(229, 3);
            this.labelDuratie.Name = "labelDuratie";
            this.labelDuratie.ReadOnly = true;
            this.labelDuratie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.labelDuratie.Size = new System.Drawing.Size(92, 15);
            this.labelDuratie.TabIndex = 18;
            this.labelDuratie.Text = "00:30";
            this.labelDuratie.WordWrap = false;
            // 
            // labelMelodie
            // 
            this.labelMelodie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelMelodie.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelMelodie.Location = new System.Drawing.Point(3, 3);
            this.labelMelodie.Name = "labelMelodie";
            this.labelMelodie.ReadOnly = true;
            this.labelMelodie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.labelMelodie.Size = new System.Drawing.Size(220, 15);
            this.labelMelodie.TabIndex = 17;
            this.labelMelodie.Text = "Nume Artist - Nume Melodie";
            this.labelMelodie.WordWrap = false;
            this.labelMelodie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelMelodie_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 404);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(414, 2);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(152, 23);
            this.windowsMediaPlayer.TabIndex = 10;
            this.windowsMediaPlayer.Visible = false;
            this.windowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.windowsMediaPlayer_PlayStateChange);
            // 
            // MP3_Player
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 447);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MP3_Player";
            this.Text = "MP3 Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MP3_Player_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MP3_Player_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MP3_Player_DragEnter);
            this.DragLeave += new System.EventHandler(this.MP3_Player_DragLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMelodie)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemAjutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxPlaylisturi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdaugaMelodie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBoxMelodie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonInainte;
        private System.Windows.Forms.Button buttonPauza;
        private System.Windows.Forms.Button buttonOprire;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.ListBox listBoxMelodii;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPlaylist;
        private System.Windows.Forms.Button buttonCreeaza;
        private System.Windows.Forms.ToolStripMenuItem menuItemSalveaza;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button buttonAmesteca;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox labelMelodie;
        private System.Windows.Forms.TextBox labelDuratie;
        private System.Windows.Forms.Button buttonStergeMelodie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button buttonSus;
        private System.Windows.Forms.Button buttonJos;
        private System.Windows.Forms.Button buttonRedare;
        private System.Windows.Forms.Button buttonRepeta;
    }
}

