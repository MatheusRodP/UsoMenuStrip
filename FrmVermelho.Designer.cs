namespace AppExMenu
{
    partial class FrmVermelho
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fomrAzulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forrmPretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formVermelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(289, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fomrAzulToolStripMenuItem,
            this.forrmPretoToolStripMenuItem,
            this.formVermelhoToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // fomrAzulToolStripMenuItem
            // 
            this.fomrAzulToolStripMenuItem.Name = "fomrAzulToolStripMenuItem";
            this.fomrAzulToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fomrAzulToolStripMenuItem.Text = "Form Azul";
            // 
            // forrmPretoToolStripMenuItem
            // 
            this.forrmPretoToolStripMenuItem.Name = "forrmPretoToolStripMenuItem";
            this.forrmPretoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.forrmPretoToolStripMenuItem.Text = "Forrm Preto";
            // 
            // formVermelhoToolStripMenuItem
            // 
            this.formVermelhoToolStripMenuItem.Name = "formVermelhoToolStripMenuItem";
            this.formVermelhoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formVermelhoToolStripMenuItem.Text = "Form Vermelho";
            // 
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(289, 329);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmVermelho";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fomrAzulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forrmPretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formVermelhoToolStripMenuItem;
    }
}