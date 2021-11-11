/* Copyright (c) Citrix Systems, Inc. 
 * All rights reserved. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System.Drawing;
using System.Windows.Forms;
using XenAdmin.Core;


namespace XenAdmin.Dialogs.OptionsPages
{
    public partial class ExternalToolsOptionsPage : UserControl, IOptionsPage
    {

        public ExternalToolsOptionsPage() 
        {
            InitializeComponent();
            sshClientInfoLabel.Text = string.Format(sshClientInfoLabel.Text, BrandManager.BrandConsole);

            radioButtonOpenSsh.Checked = false;
            radioButtonPutty.Checked = true;
        }

        #region IOptionsPage Members

        public void Build()
        {
        }

        public bool IsValidToSave()
        {
            return true;
        }

        public void ShowValidationMessages()
        {
        }

        public void HideValidationMessages()
        {
        }

        public void Save()
        {
        }

        #endregion

        #region IVerticalTab Members

        public override string Text => "External Tools";

        public string SubText => "Manage external tools";

        public Image Image => Images.StaticImages._001_Tools_h32bit_16;

        #endregion

        #region Event Handlers

        private void ToggleCheckBoxes(object sender, System.EventArgs e)
        {
            // disable event to avoid it calling itself
            radioButtonPutty.CheckedChanged -= ToggleCheckBoxes;

            var selectedCustomLocation = radioButtonOpenSsh.Checked;
            radioButtonPutty.Checked = !selectedCustomLocation;

            radioButtonPutty.CheckedChanged += ToggleCheckBoxes;

            buttonBrowseSsh.Enabled = textBoxOpenSsh.Enabled = selectedCustomLocation;
        }



        #endregion

        private void titleLabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
