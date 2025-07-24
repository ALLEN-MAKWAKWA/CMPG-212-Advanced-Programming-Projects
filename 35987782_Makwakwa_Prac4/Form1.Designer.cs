
namespace _35987782_Makwakwa_Prac4
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAndSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAndDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewProductsToolStripMenuItem,
            this.editProductsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAndSearchToolStripMenuItem});
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            // 
            // editProductsToolStripMenuItem
            // 
            this.editProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertAndDeleteToolStripMenuItem});
            this.editProductsToolStripMenuItem.Name = "editProductsToolStripMenuItem";
            this.editProductsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.editProductsToolStripMenuItem.Text = "Edit Products";
            // 
            // listAndSearchToolStripMenuItem
            // 
            this.listAndSearchToolStripMenuItem.Name = "listAndSearchToolStripMenuItem";
            this.listAndSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listAndSearchToolStripMenuItem.Text = "List and Search";
            this.listAndSearchToolStripMenuItem.Click += new System.EventHandler(this.listAndSearchToolStripMenuItem_Click);
            // 
            // insertAndDeleteToolStripMenuItem
            // 
            this.insertAndDeleteToolStripMenuItem.Name = "insertAndDeleteToolStripMenuItem";
            this.insertAndDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertAndDeleteToolStripMenuItem.Text = "Insert and Delete";
            this.insertAndDeleteToolStripMenuItem.Click += new System.EventHandler(this.insertAndDeleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Practical4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAndSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertAndDeleteToolStripMenuItem;
    }
}

