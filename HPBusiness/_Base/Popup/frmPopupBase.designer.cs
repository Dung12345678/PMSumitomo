namespace HP
{
    partial class frmPopupBase
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
            this.components = new System.ComponentModel.Container();
            this.tmrForceActivate = new System.Windows.Forms.Timer(this.components);
            // 
            // tmrForceActivate
            // 
            this.tmrForceActivate.Tick += new System.EventHandler(this.tmrForceActivate_Tick);
            // 
            // frmFloatingBase
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(152, 144);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFloatingBase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmFloatingBase";
            this.Leave += new System.EventHandler(this.CheckToHide);
            this.Deactivate += new System.EventHandler(this.CheckToHide);

        }

        #endregion
    }
}