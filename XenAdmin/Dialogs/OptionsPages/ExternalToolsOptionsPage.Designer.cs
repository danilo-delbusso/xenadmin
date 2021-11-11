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
            this.titleLabel = new System.Windows.Forms.Label();
            this.sshClientGroupBox = new XenAdmin.Controls.DecentGroupBox();
            this.sshClientLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sshClientInfoLabel = new System.Windows.Forms.Label();
            this.sshClientDefaultLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.sshClientCustomLocationRadioButton = new System.Windows.Forms.RadioButton();
            this.sshClientBrowseButton = new System.Windows.Forms.Button();
            this.sshClientLocationTextBox = new System.Windows.Forms.TextBox();
            this.externalToolsLayoutPanel.SuspendLayout();
            this.sshClientGroupBox.SuspendLayout();
            this.sshClientLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // externalToolsLayoutPanel
            // 
            resources.ApplyResources(this.externalToolsLayoutPanel, "externalToolsLayoutPanel");
            this.externalToolsLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.externalToolsLayoutPanel.Controls.Add(this.sshClientGroupBox, 0, 2);
            this.externalToolsLayoutPanel.Name = "externalToolsLayoutPanel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
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
            this.sshClientLayoutPanel.Controls.Add(this.sshClientDefaultLocationRadioButton, 1, 2);
            this.sshClientLayoutPanel.Controls.Add(this.sshClientCustomLocationRadioButton, 1, 3);
            this.sshClientLayoutPanel.Controls.Add(this.sshClientBrowseButton, 2, 4);
            this.sshClientLayoutPanel.Controls.Add(this.sshClientLocationTextBox, 1, 4);
            this.sshClientLayoutPanel.Name = "sshClientLayoutPanel";
            // 
            // sshClientInfoLabel
            // 
            resources.ApplyResources(this.sshClientInfoLabel, "sshClientInfoLabel");
            this.sshClientLayoutPanel.SetColumnSpan(this.sshClientInfoLabel, 3);
            this.sshClientInfoLabel.Name = "sshClientInfoLabel";
            // 
            // sshClientDefaultLocationRadioButton
            // 
            resources.ApplyResources(this.sshClientDefaultLocationRadioButton, "sshClientDefaultLocationRadioButton");
            this.sshClientDefaultLocationRadioButton.Name = "sshClientDefaultLocationRadioButton";
            this.sshClientDefaultLocationRadioButton.TabStop = true;
            this.sshClientDefaultLocationRadioButton.UseVisualStyleBackColor = true;
            this.sshClientDefaultLocationRadioButton.CheckedChanged += new System.EventHandler(this.ToggleCheckBoxes);
            // 
            // sshClientCustomLocationRadioButton
            // 
            resources.ApplyResources(this.sshClientCustomLocationRadioButton, "sshClientCustomLocationRadioButton");
            this.sshClientCustomLocationRadioButton.Name = "sshClientCustomLocationRadioButton";
            this.sshClientCustomLocationRadioButton.TabStop = true;
            this.sshClientCustomLocationRadioButton.UseVisualStyleBackColor = true;
            this.sshClientCustomLocationRadioButton.CheckedChanged += new System.EventHandler(this.ToggleCheckBoxes);
            // 
            // sshClientBrowseButton
            // 
            resources.ApplyResources(this.sshClientBrowseButton, "sshClientBrowseButton");
            this.sshClientBrowseButton.Name = "sshClientBrowseButton";
            this.sshClientBrowseButton.UseVisualStyleBackColor = true;
            // 
            // sshClientLocationTextBox
            // 
            resources.ApplyResources(this.sshClientLocationTextBox, "sshClientLocationTextBox");
            this.sshClientLocationTextBox.Name = "sshClientLocationTextBox";
            this.sshClientLocationTextBox.ShortcutsEnabled = false;
            // 
            // ExternalToolsOptionsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.externalToolsLayoutPanel);
            this.Name = "ExternalToolsOptionsPage";
            this.externalToolsLayoutPanel.ResumeLayout(false);
            this.externalToolsLayoutPanel.PerformLayout();
            this.sshClientGroupBox.ResumeLayout(false);
            this.sshClientLayoutPanel.ResumeLayout(false);
            this.sshClientLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel externalToolsLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
        private XenAdmin.Controls.DecentGroupBox sshClientGroupBox;
        private System.Windows.Forms.Label sshClientInfoLabel;
        private System.Windows.Forms.TextBox sshClientLocationTextBox;
        protected System.Windows.Forms.TableLayoutPanel sshClientLayoutPanel;
        private System.Windows.Forms.Button sshClientBrowseButton;
        private System.Windows.Forms.RadioButton sshClientCustomLocationRadioButton;
        private System.Windows.Forms.RadioButton sshClientDefaultLocationRadioButton;
    }
}
