﻿namespace RBot
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoReloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interceptorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aS3InjectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.packetsToolStripMenuItem,
            this.loadersToolStripMenuItem,
            this.bankToolStripMenuItem,
            this.skillsToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.logToolStripMenuItem,
            this.aS3InjectorToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.updatesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1036, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            this.scriptsToolStripMenuItem.Click += new System.EventHandler(this.scriptsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botOptionsToolStripMenuItem,
            this.scriptOptionsToolStripMenuItem,
            this.autoReloginToolStripMenuItem,
            this.applicationOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // botOptionsToolStripMenuItem
            // 
            this.botOptionsToolStripMenuItem.Name = "botOptionsToolStripMenuItem";
            this.botOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.botOptionsToolStripMenuItem.Text = "Bot Options";
            this.botOptionsToolStripMenuItem.Click += new System.EventHandler(this.botOptionsToolStripMenuItem_Click);
            // 
            // scriptOptionsToolStripMenuItem
            // 
            this.scriptOptionsToolStripMenuItem.Name = "scriptOptionsToolStripMenuItem";
            this.scriptOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scriptOptionsToolStripMenuItem.Text = "Script Options";
            this.scriptOptionsToolStripMenuItem.Click += new System.EventHandler(this.scriptOptionsToolStripMenuItem_Click);
            // 
            // autoReloginToolStripMenuItem
            // 
            this.autoReloginToolStripMenuItem.Name = "autoReloginToolStripMenuItem";
            this.autoReloginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoReloginToolStripMenuItem.Text = "Auto Relogin";
            this.autoReloginToolStripMenuItem.Click += new System.EventHandler(this.autoReloginToolStripMenuItem_Click);
            // 
            // applicationOptionsToolStripMenuItem
            // 
            this.applicationOptionsToolStripMenuItem.Name = "applicationOptionsToolStripMenuItem";
            this.applicationOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applicationOptionsToolStripMenuItem.Text = "Application Options";
            this.applicationOptionsToolStripMenuItem.Click += new System.EventHandler(this.applicationOptionsToolStripMenuItem_Click);
            // 
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.skillsToolStripMenuItem.Text = "Skills";
            this.skillsToolStripMenuItem.Click += new System.EventHandler(this.skillsToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logToolStripMenuItem.Text = "Logs";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadFlashToolStripMenuItem,
            this.setNameToolStripMenuItem,
            this.hidePlayersToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // reloadFlashToolStripMenuItem
            // 
            this.reloadFlashToolStripMenuItem.Name = "reloadFlashToolStripMenuItem";
            this.reloadFlashToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.reloadFlashToolStripMenuItem.Text = "Reload Flash";
            this.reloadFlashToolStripMenuItem.Click += new System.EventHandler(this.reloadFlashToolStripMenuItem_Click);
            // 
            // setNameToolStripMenuItem
            // 
            this.setNameToolStripMenuItem.Name = "setNameToolStripMenuItem";
            this.setNameToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.setNameToolStripMenuItem.Text = "Set Name";
            this.setNameToolStripMenuItem.Click += new System.EventHandler(this.setNameToolStripMenuItem_Click);
            // 
            // hidePlayersToolStripMenuItem
            // 
            this.hidePlayersToolStripMenuItem.Name = "hidePlayersToolStripMenuItem";
            this.hidePlayersToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hidePlayersToolStripMenuItem.Text = "Hide Players";
            this.hidePlayersToolStripMenuItem.Click += new System.EventHandler(this.hidePlayersToolStripMenuItem_Click);
            // 
            // packetsToolStripMenuItem
            // 
            this.packetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spammerToolStripMenuItem,
            this.loggerToolStripMenuItem,
            this.interceptorToolStripMenuItem});
            this.packetsToolStripMenuItem.Name = "packetsToolStripMenuItem";
            this.packetsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.packetsToolStripMenuItem.Text = "Packets";
            // 
            // spammerToolStripMenuItem
            // 
            this.spammerToolStripMenuItem.Name = "spammerToolStripMenuItem";
            this.spammerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spammerToolStripMenuItem.Text = "Spammer";
            this.spammerToolStripMenuItem.Click += new System.EventHandler(this.spammerToolStripMenuItem_Click);
            // 
            // loggerToolStripMenuItem
            // 
            this.loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            this.loggerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loggerToolStripMenuItem.Text = "Logger";
            this.loggerToolStripMenuItem.Click += new System.EventHandler(this.loggerToolStripMenuItem_Click);
            // 
            // interceptorToolStripMenuItem
            // 
            this.interceptorToolStripMenuItem.Name = "interceptorToolStripMenuItem";
            this.interceptorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.interceptorToolStripMenuItem.Text = "Interceptor";
            this.interceptorToolStripMenuItem.Click += new System.EventHandler(this.interceptorToolStripMenuItem_Click);
            // 
            // loadersToolStripMenuItem
            // 
            this.loadersToolStripMenuItem.Name = "loadersToolStripMenuItem";
            this.loadersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.loadersToolStripMenuItem.Text = "Loaders";
            this.loadersToolStripMenuItem.Click += new System.EventHandler(this.loadersToolStripMenuItem_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bankToolStripMenuItem.Text = "Bank";
            this.bankToolStripMenuItem.Click += new System.EventHandler(this.bankToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            this.jumpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.jumpToolStripMenuItem.Text = "Jump";
            this.jumpToolStripMenuItem.Click += new System.EventHandler(this.jumpToolStripMenuItem_Click);
            // 
            // aS3InjectorToolStripMenuItem
            // 
            this.aS3InjectorToolStripMenuItem.Name = "aS3InjectorToolStripMenuItem";
            this.aS3InjectorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aS3InjectorToolStripMenuItem.Text = "AS3 Injector";
            this.aS3InjectorToolStripMenuItem.Click += new System.EventHandler(this.aS3InjectorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.discordToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.discordToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            this.pluginsToolStripMenuItem.Click += new System.EventHandler(this.pluginsToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 649);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "RBot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoReloginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interceptorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aS3InjectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
    }
}

