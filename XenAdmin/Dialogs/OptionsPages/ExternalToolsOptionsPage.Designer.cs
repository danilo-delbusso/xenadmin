namespace XenAdmin.Dialogs.OptionsPages
{
    partial class ExternalToolsOptionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalToolsOptionsPage));
            this.externalToolsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sshClientGroupBox = new XenAdmin.Controls.DecentGroupBox();
            this.sshClientLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sshClientInfoLabel = new System.Windows.Forms.Label();
            this.radioButtonPutty = new System.Windows.Forms.RadioButton();
            this.radioButtonOpenSsh = new System.Windows.Forms.RadioButton();
            this.buttonBrowseSsh = new System.Windows.Forms.Button();
            this.textBoxOpenSsh = new System.Windows.Forms.TextBox();
            this.textBoxPutty = new System.Windows.Forms.TextBox();
            this.buttonBrowsePutty = new System.Windows.Forms.Button();
            this.externalToolsLayoutPanel.SuspendLayout();
            this.sshClientGroupBox.SuspendLayout();
            this.sshClientLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // externalToolsLayoutPanel
            // 
            resources.ApplyResources(this.externalToolsLayoutPanel, "externalToolsLayoutPanel");
            this.externalToolsLayoutPanel.Controls.Add(this.sshClientGroupBox, 0, 1);
            this.externalToolsLayoutPanel.Name = "externalToolsLayoutPanel";
            // 
            // sshClientGroupBox
            // 
            resources.ApplyResources(this.sshClientGroupBox, "sshClientGroupBox");
            this.sshClientGroupBox.Controls.Add(this.sshClientLayoutPanel);
            this.sshClientGroupBox.Name = "sshClientGroupBox";
            this.sshClientGroupBox.TabStop = false;
            // 
            // sshClientLayoutPanel
            // 
            resources.ApplyResources(this.sshClientLayoutPanel, "sshClientLayoutPanel");
            this.sshClientLayoutPanel.Controls.Add(this.sshClientInfoLabel, 0, 0);
            this.sshClientLayoutPanel.Controls.Add(this.radioButtonPutty, 0, 1);
            this.sshClientLayoutPanel.Controls.Add(this.radioButtonOpenSsh, 0, 3);
            this.sshClientLayoutPanel.Controls.Add(this.buttonBrowseSsh, 1, 4);
            this.sshClientLayoutPanel.Controls.Add(this.textBoxOpenSsh, 0, 4);
            this.sshClientLayoutPanel.Controls.Add(this.textBoxPutty, 0, 2);
            this.sshClientLayoutPanel.Controls.Add(this.buttonBrowsePutty, 1, 2);
            this.sshClientLayoutPanel.Name = "sshClientLayoutPanel";
            // 
            // sshClientInfoLabel
            // 
            resources.ApplyResources(this.sshClientInfoLabel, "sshClientInfoLabel");
            this.sshClientLayoutPanel.SetColumnSpan(this.sshClientInfoLabel, 2);
            this.sshClientInfoLabel.Name = "sshClientInfoLabel";
            // 
            // radioButtonPutty
            // 
            resources.ApplyResources(this.radioButtonPutty, "radioButtonPutty");
            this.radioButtonPutty.Name = "radioButtonPutty";
            this.radioButtonPutty.TabStop = true;
            this.radioButtonPutty.UseVisualStyleBackColor = true;
            this.radioButtonPutty.CheckedChanged += new System.EventHandler(this.ToggleCheckBoxes);
            // 
            // radioButtonOpenSsh
            // 
            resources.ApplyResources(this.radioButtonOpenSsh, "radioButtonOpenSsh");
            this.radioButtonOpenSsh.Name = "radioButtonOpenSsh";
            this.radioButtonOpenSsh.TabStop = true;
            this.radioButtonOpenSsh.UseVisualStyleBackColor = true;
            this.radioButtonOpenSsh.CheckedChanged += new System.EventHandler(this.ToggleCheckBoxes);
            // 
            // buttonBrowseSsh
            // 
            resources.ApplyResources(this.buttonBrowseSsh, "buttonBrowseSsh");
            this.buttonBrowseSsh.Name = "buttonBrowseSsh";
            this.buttonBrowseSsh.UseVisualStyleBackColor = true;
            // 
            // textBoxOpenSsh
            // 
            resources.ApplyResources(this.textBoxOpenSsh, "textBoxOpenSsh");
            this.textBoxOpenSsh.Name = "textBoxOpenSsh";
            this.textBoxOpenSsh.ShortcutsEnabled = false;
            // 
            // textBoxPutty
            // 
            resources.ApplyResources(this.textBoxPutty, "textBoxPutty");
            this.textBoxPutty.Name = "textBoxPutty";
            // 
            // buttonBrowsePutty
            // 
            resources.ApplyResources(this.buttonBrowsePutty, "buttonBrowsePutty");
            this.buttonBrowsePutty.Name = "buttonBrowsePutty";
            this.buttonBrowsePutty.UseVisualStyleBackColor = true;
            // 
            // ExternalToolsOptionsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.externalToolsLayoutPanel);
            this.Name = "ExternalToolsOptionsPage";
            this.externalToolsLayoutPanel.ResumeLayout(false);
            this.sshClientGroupBox.ResumeLayout(false);
            this.sshClientLayoutPanel.ResumeLayout(false);
            this.sshClientLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel externalToolsLayoutPanel;
        private XenAdmin.Controls.DecentGroupBox sshClientGroupBox;
        private System.Windows.Forms.TextBox textBoxOpenSsh;
        protected System.Windows.Forms.TableLayoutPanel sshClientLayoutPanel;
        private System.Windows.Forms.Button buttonBrowseSsh;
        private System.Windows.Forms.RadioButton radioButtonOpenSsh;
        private System.Windows.Forms.RadioButton radioButtonPutty;
        private System.Windows.Forms.Label sshClientInfoLabel;
        private System.Windows.Forms.TextBox textBoxPutty;
        private System.Windows.Forms.Button buttonBrowsePutty;
    }
}
