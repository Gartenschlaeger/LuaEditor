namespace LuaEditor.Dialogs.Controls
{
    partial class EditorTabsControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new PureSoft.Controls.VisualStudio.Vs2010TabControl();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.HotTrack = true;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 26);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(402, 238);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabTextAlignment = System.Drawing.StringAlignment.Center;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseMove);
            this.tabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseUp);
            // 
            // EditorTabsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "EditorTabsControl";
            this.Size = new System.Drawing.Size(402, 238);
            this.ResumeLayout(false);

        }

        #endregion

        private PureSoft.Controls.VisualStudio.Vs2010TabControl tabControl;
    }
}
