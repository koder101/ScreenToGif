﻿using System.Windows.Forms;
using ScreenToGif.Properties;

namespace ScreenToGif.Pages
{
    partial class AppSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbModernStyle = new System.Windows.Forms.CheckBox();
            this.comboStartPauseKey = new System.Windows.Forms.ComboBox();
            this.comboStopKey = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStartPause = new System.Windows.Forms.Label();
            this.cbSaveDirectly = new System.Windows.Forms.CheckBox();
            this.cbAllowEdit = new System.Windows.Forms.CheckBox();
            this.cbShowCursor = new System.Windows.Forms.CheckBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.gbQuickSettings = new System.Windows.Forms.GroupBox();
            this.gbHotkeys = new System.Windows.Forms.GroupBox();
            this.gbQuickSettings.SuspendLayout();
            this.gbHotkeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbModernStyle
            // 
            this.cbModernStyle.AutoSize = true;
            this.cbModernStyle.Location = new System.Drawing.Point(6, 90);
            this.cbModernStyle.Name = "cbModernStyle";
            this.cbModernStyle.Size = new System.Drawing.Size(245, 19);
            this.cbModernStyle.TabIndex = 24;
            this.cbModernStyle.Text = global::ScreenToGif.Properties.Resources.CB_ModernStyle;
            this.toolTipHelp.SetToolTip(this.cbModernStyle, "To use the Modern style window, close and open this program");
            this.cbModernStyle.UseVisualStyleBackColor = true;
            this.cbModernStyle.CheckedChanged += new System.EventHandler(this.cbModernStyle_CheckedChanged);
            // 
            // comboStartPauseKey
            // 
            this.comboStartPauseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStartPauseKey.FormattingEnabled = true;
            this.comboStartPauseKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboStartPauseKey.Location = new System.Drawing.Point(6, 22);
            this.comboStartPauseKey.Name = "comboStartPauseKey";
            this.comboStartPauseKey.Size = new System.Drawing.Size(61, 23);
            this.comboStartPauseKey.TabIndex = 23;
            this.comboStartPauseKey.SelectedValueChanged += new System.EventHandler(this.comboStartPauseKey_SelectedValueChanged);
            // 
            // comboStopKey
            // 
            this.comboStopKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStopKey.FormattingEnabled = true;
            this.comboStopKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboStopKey.Location = new System.Drawing.Point(6, 51);
            this.comboStopKey.Name = "comboStopKey";
            this.comboStopKey.Size = new System.Drawing.Size(61, 23);
            this.comboStopKey.TabIndex = 22;
            this.comboStopKey.SelectedValueChanged += new System.EventHandler(this.comboStopKey_SelectedValueChanged);
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(73, 54);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(31, 15);
            this.lblStop.TabIndex = 20;
            this.lblStop.Text = Resources.Label_Stop;
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartPause
            // 
            this.lblStartPause.AutoSize = true;
            this.lblStartPause.Location = new System.Drawing.Point(73, 25);
            this.lblStartPause.Name = "lblStartPause";
            this.lblStartPause.Size = new System.Drawing.Size(80, 15);
            this.lblStartPause.TabIndex = 19;
            this.lblStartPause.Text = Resources.Label_RecordPause;
            this.lblStartPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSaveDirectly
            // 
            this.cbSaveDirectly.AutoSize = true;
            this.cbSaveDirectly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSaveDirectly.Location = new System.Drawing.Point(6, 65);
            this.cbSaveDirectly.Name = "cbSaveDirectly";
            this.cbSaveDirectly.Size = new System.Drawing.Size(172, 19);
            this.cbSaveDirectly.TabIndex = 18;
            this.cbSaveDirectly.Text = global::ScreenToGif.Properties.Resources.CB_SaveDesktop;
            this.toolTipHelp.SetToolTip(this.cbSaveDirectly, "Saves the Gif file automatically to the Desktop");
            this.cbSaveDirectly.UseVisualStyleBackColor = true;
            this.cbSaveDirectly.CheckedChanged += new System.EventHandler(this.cbSaveDirectly_CheckedChanged);
            // 
            // cbAllowEdit
            // 
            this.cbAllowEdit.AutoSize = true;
            this.cbAllowEdit.Checked = true;
            this.cbAllowEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllowEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbAllowEdit.Location = new System.Drawing.Point(6, 40);
            this.cbAllowEdit.Name = "cbAllowEdit";
            this.cbAllowEdit.Size = new System.Drawing.Size(166, 19);
            this.cbAllowEdit.TabIndex = 17;
            this.cbAllowEdit.Text = global::ScreenToGif.Properties.Resources.CB_AllowEdit;
            this.toolTipHelp.SetToolTip(this.cbAllowEdit, "Opens the Frame Editor after recording");
            this.cbAllowEdit.UseVisualStyleBackColor = true;
            this.cbAllowEdit.CheckedChanged += new System.EventHandler(this.cbAllowEdit_CheckedChanged);
            // 
            // cbShowCursor
            // 
            this.cbShowCursor.AutoSize = true;
            this.cbShowCursor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbShowCursor.Location = new System.Drawing.Point(6, 17);
            this.cbShowCursor.Name = "cbShowCursor";
            this.cbShowCursor.Size = new System.Drawing.Size(91, 19);
            this.cbShowCursor.TabIndex = 15;
            this.cbShowCursor.Text = global::ScreenToGif.Properties.Resources.CB_ShowCursor;
            this.toolTipHelp.SetToolTip(this.cbShowCursor, "Tracks and shows the cursor of the system");
            this.cbShowCursor.UseVisualStyleBackColor = true;
            this.cbShowCursor.CheckedChanged += new System.EventHandler(this.cbShowCursor_CheckedChanged);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp.ToolTipTitle = global::ScreenToGif.Properties.Resources.Tooltip_Title;
            // 
            // gbQuickSettings
            // 
            this.gbQuickSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuickSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbQuickSettings.Controls.Add(this.cbShowCursor);
            this.gbQuickSettings.Controls.Add(this.cbModernStyle);
            this.gbQuickSettings.Controls.Add(this.cbAllowEdit);
            this.gbQuickSettings.Controls.Add(this.cbSaveDirectly);
            this.gbQuickSettings.Location = new System.Drawing.Point(3, 3);
            this.gbQuickSettings.Name = "gbQuickSettings";
            this.gbQuickSettings.Size = new System.Drawing.Size(523, 114);
            this.gbQuickSettings.TabIndex = 26;
            this.gbQuickSettings.TabStop = false;
            this.gbQuickSettings.Text = Resources.Label_Title_AppSettings;
            this.toolTipHelp.SetToolTip(this.gbQuickSettings, Resources.Tooltip_AppSettings);
            // 
            // gbHotkeys
            // 
            this.gbHotkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHotkeys.Controls.Add(this.lblStartPause);
            this.gbHotkeys.Controls.Add(this.lblStop);
            this.gbHotkeys.Controls.Add(this.comboStartPauseKey);
            this.gbHotkeys.Controls.Add(this.comboStopKey);
            this.gbHotkeys.Location = new System.Drawing.Point(3, 123);
            this.gbHotkeys.Name = "gbHotkeys";
            this.gbHotkeys.Size = new System.Drawing.Size(523, 90);
            this.gbHotkeys.TabIndex = 27;
            this.gbHotkeys.TabStop = false;
            this.gbHotkeys.Text = Resources.Label_Hotkeys;
            this.toolTipHelp.SetToolTip(this.gbHotkeys, "Global Hotkeys to make your life easier.");
            // 
            // AppSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.gbHotkeys);
            this.Controls.Add(this.gbQuickSettings);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AppSettings";
            this.Size = new System.Drawing.Size(532, 247);
            this.Tag = "Page";
            this.toolTipHelp.SetToolTip(this, "To close this page, click again in the Gears button");
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.gbQuickSettings.ResumeLayout(false);
            this.gbQuickSettings.PerformLayout();
            this.gbHotkeys.ResumeLayout(false);
            this.gbHotkeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbModernStyle;
        private System.Windows.Forms.ComboBox comboStartPauseKey;
        private System.Windows.Forms.ComboBox comboStopKey;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblStartPause;
        private System.Windows.Forms.CheckBox cbSaveDirectly;
        private System.Windows.Forms.CheckBox cbAllowEdit;
        private System.Windows.Forms.CheckBox cbShowCursor;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private GroupBox gbQuickSettings;
        private GroupBox gbHotkeys;
    }
}
