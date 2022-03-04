﻿using System;

namespace ReboundLogParser2 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadLogsButton = new System.Windows.Forms.Button();
            this.LogFileName = new System.Windows.Forms.TextBox();
            this.homeDataGrid = new System.Windows.Forms.DataGridView();
            this.HomeTeam = new System.Windows.Forms.Label();
            this.awayDataGrid = new System.Windows.Forms.DataGridView();
            this.AwayTeam = new System.Windows.Forms.Label();
            this.HomeOT = new System.Windows.Forms.Label();
            this.AwayOT = new System.Windows.Forms.Label();
            this.MultipleFiles = new System.Windows.Forms.Label();
            this.periodTextLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.cefPanel1 = new System.Windows.Forms.Panel();
            this.loadHomePlayersButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.loadAwayPlayersButton = new System.Windows.Forms.Button();
            this.SendHomeStatsButton = new System.Windows.Forms.Button();
            this.SendAwayStatsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadLogsButton
            // 
            this.LoadLogsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadLogsButton.Location = new System.Drawing.Point(834, 42);
            this.LoadLogsButton.Name = "LoadLogsButton";
            this.LoadLogsButton.Size = new System.Drawing.Size(102, 42);
            this.LoadLogsButton.TabIndex = 0;
            this.LoadLogsButton.Text = "Load Logs";
            this.LoadLogsButton.UseVisualStyleBackColor = true;
            this.LoadLogsButton.Click += new System.EventHandler(this.LoadLogsButton_Click);
            // 
            // LogFileName
            // 
            this.LogFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFileName.Location = new System.Drawing.Point(129, 14);
            this.LogFileName.Name = "LogFileName";
            this.LogFileName.ReadOnly = true;
            this.LogFileName.Size = new System.Drawing.Size(283, 20);
            this.LogFileName.TabIndex = 1;
            // 
            // homeDataGrid
            // 
            this.homeDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.homeDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.homeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGrid.Location = new System.Drawing.Point(129, 87);
            this.homeDataGrid.Name = "homeDataGrid";
            this.homeDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.homeDataGrid.Size = new System.Drawing.Size(807, 164);
            this.homeDataGrid.TabIndex = 2;
            // 
            // HomeTeam
            // 
            this.HomeTeam.AutoSize = true;
            this.HomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTeam.Location = new System.Drawing.Point(122, 41);
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.Size = new System.Drawing.Size(222, 42);
            this.HomeTeam.TabIndex = 5;
            this.HomeTeam.Text = "Home Team";
            // 
            // awayDataGrid
            // 
            this.awayDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.awayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.awayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayDataGrid.Location = new System.Drawing.Point(128, 317);
            this.awayDataGrid.Name = "awayDataGrid";
            this.awayDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.awayDataGrid.Size = new System.Drawing.Size(807, 164);
            this.awayDataGrid.TabIndex = 7;
            // 
            // AwayTeam
            // 
            this.AwayTeam.AutoSize = true;
            this.AwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayTeam.Location = new System.Drawing.Point(125, 269);
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.Size = new System.Drawing.Size(215, 42);
            this.AwayTeam.TabIndex = 8;
            this.AwayTeam.Text = "Away Team";
            // 
            // HomeOT
            // 
            this.HomeOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeOT.AutoSize = true;
            this.HomeOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeOT.ForeColor = System.Drawing.Color.Red;
            this.HomeOT.Location = new System.Drawing.Point(486, 42);
            this.HomeOT.Name = "HomeOT";
            this.HomeOT.Size = new System.Drawing.Size(293, 42);
            this.HomeOT.TabIndex = 9;
            this.HomeOT.Text = "OVERTIME WIN";
            this.HomeOT.Visible = false;
            // 
            // AwayOT
            // 
            this.AwayOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayOT.AutoSize = true;
            this.AwayOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayOT.ForeColor = System.Drawing.Color.Red;
            this.AwayOT.Location = new System.Drawing.Point(486, 270);
            this.AwayOT.Name = "AwayOT";
            this.AwayOT.Size = new System.Drawing.Size(293, 42);
            this.AwayOT.TabIndex = 10;
            this.AwayOT.Text = "OVERTIME WIN";
            this.AwayOT.Visible = false;
            // 
            // MultipleFiles
            // 
            this.MultipleFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MultipleFiles.AutoSize = true;
            this.MultipleFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleFiles.ForeColor = System.Drawing.Color.Red;
            this.MultipleFiles.Location = new System.Drawing.Point(417, 13);
            this.MultipleFiles.Name = "MultipleFiles";
            this.MultipleFiles.Size = new System.Drawing.Size(285, 25);
            this.MultipleFiles.TabIndex = 11;
            this.MultipleFiles.Text = "Multiple log files in log folder";
            this.MultipleFiles.Visible = false;
            // 
            // periodTextLabel
            // 
            this.periodTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodTextLabel.AutoSize = true;
            this.periodTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodTextLabel.Location = new System.Drawing.Point(833, 14);
            this.periodTextLabel.Name = "periodTextLabel";
            this.periodTextLabel.Size = new System.Drawing.Size(74, 25);
            this.periodTextLabel.TabIndex = 12;
            this.periodTextLabel.Text = "Period:";
            // 
            // periodLabel
            // 
            this.periodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodLabel.Location = new System.Drawing.Point(913, 14);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(23, 25);
            this.periodLabel.TabIndex = 13;
            this.periodLabel.Text = "3";
            // 
            // cefPanel1
            // 
            this.cefPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cefPanel1.Location = new System.Drawing.Point(4, 487);
            this.cefPanel1.Name = "cefPanel1";
            this.cefPanel1.Size = new System.Drawing.Size(933, 165);
            this.cefPanel1.TabIndex = 14;
            // 
            // loadHomePlayersButton
            // 
            this.loadHomePlayersButton.Location = new System.Drawing.Point(4, 42);
            this.loadHomePlayersButton.Name = "loadHomePlayersButton";
            this.loadHomePlayersButton.Size = new System.Drawing.Size(119, 34);
            this.loadHomePlayersButton.TabIndex = 15;
            this.loadHomePlayersButton.Text = "Load Home Players";
            this.loadHomePlayersButton.UseVisualStyleBackColor = true;
            this.loadHomePlayersButton.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(4, 136);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 21);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox3.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(4, 163);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(119, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox4.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(4, 190);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(119, 21);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox5.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(4, 310);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(119, 21);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox6.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(4, 337);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(119, 21);
            this.comboBox7.TabIndex = 16;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox7.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(4, 364);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(119, 21);
            this.comboBox8.TabIndex = 16;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox8.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(3, 391);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(119, 21);
            this.comboBox9.TabIndex = 16;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox9.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(3, 418);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(119, 21);
            this.comboBox10.TabIndex = 16;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            this.comboBox10.TextChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // loadAwayPlayersButton
            // 
            this.loadAwayPlayersButton.Location = new System.Drawing.Point(4, 270);
            this.loadAwayPlayersButton.Name = "loadAwayPlayersButton";
            this.loadAwayPlayersButton.Size = new System.Drawing.Size(119, 34);
            this.loadAwayPlayersButton.TabIndex = 15;
            this.loadAwayPlayersButton.Text = "Load Away Players";
            this.loadAwayPlayersButton.UseVisualStyleBackColor = true;
            this.loadAwayPlayersButton.Click += new System.EventHandler(this.TeamPlayersLoadButton_Click);
            // 
            // SendHomeStatsButton
            // 
            this.SendHomeStatsButton.Location = new System.Drawing.Point(4, 217);
            this.SendHomeStatsButton.Name = "SendHomeStatsButton";
            this.SendHomeStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendHomeStatsButton.TabIndex = 17;
            this.SendHomeStatsButton.Text = "Send Home Stats";
            this.SendHomeStatsButton.UseVisualStyleBackColor = true;
            this.SendHomeStatsButton.Click += new System.EventHandler(this.SendStatsButton_Click);
            // 
            // SendAwayStatsButton
            // 
            this.SendAwayStatsButton.Location = new System.Drawing.Point(4, 445);
            this.SendAwayStatsButton.Name = "SendAwayStatsButton";
            this.SendAwayStatsButton.Size = new System.Drawing.Size(119, 35);
            this.SendAwayStatsButton.TabIndex = 17;
            this.SendAwayStatsButton.Text = "Send Away Stats";
            this.SendAwayStatsButton.UseVisualStyleBackColor = true;
            this.SendAwayStatsButton.Click += new System.EventHandler(this.SendStatsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 656);
            this.Controls.Add(this.SendAwayStatsButton);
            this.Controls.Add(this.SendHomeStatsButton);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.loadAwayPlayersButton);
            this.Controls.Add(this.loadHomePlayersButton);
            this.Controls.Add(this.cefPanel1);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.periodTextLabel);
            this.Controls.Add(this.MultipleFiles);
            this.Controls.Add(this.AwayOT);
            this.Controls.Add(this.HomeOT);
            this.Controls.Add(this.AwayTeam);
            this.Controls.Add(this.awayDataGrid);
            this.Controls.Add(this.HomeTeam);
            this.Controls.Add(this.homeDataGrid);
            this.Controls.Add(this.LogFileName);
            this.Controls.Add(this.LoadLogsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 695);
            this.Name = "Form1";
            this.Text = "Rebound Log Parser 6.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awayDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button LoadLogsButton;
    private System.Windows.Forms.TextBox LogFileName;
    private System.Windows.Forms.DataGridView homeDataGrid;
    private System.Windows.Forms.Label HomeTeam;
    private System.Windows.Forms.DataGridView awayDataGrid;
    private System.Windows.Forms.Label AwayTeam;
    private System.Windows.Forms.Label HomeOT;
    private System.Windows.Forms.Label AwayOT;
    private System.Windows.Forms.Label MultipleFiles;
    private System.Windows.Forms.Label periodTextLabel;
    private System.Windows.Forms.Label periodLabel;
    private System.Windows.Forms.Panel cefPanel1;
    private System.Windows.Forms.Button loadHomePlayersButton;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.ComboBox comboBox5;
    private System.Windows.Forms.ComboBox comboBox6;
    private System.Windows.Forms.ComboBox comboBox7;
    private System.Windows.Forms.ComboBox comboBox8;
    private System.Windows.Forms.ComboBox comboBox9;
    private System.Windows.Forms.ComboBox comboBox10;
    private System.Windows.Forms.Button loadAwayPlayersButton;
    private System.Windows.Forms.Button SendHomeStatsButton;
    private System.Windows.Forms.Button SendAwayStatsButton;
  }
}

