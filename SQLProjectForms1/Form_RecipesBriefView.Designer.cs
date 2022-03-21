namespace SQLProjectForms1
{
    partial class Form_RecipesBriefView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown_pageNb = new System.Windows.Forms.NumericUpDown();
            this.label_pageNb = new System.Windows.Forms.Label();
            this.button_goToPage = new System.Windows.Forms.Button();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.button_previousPage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pageNb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 538);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown_pageNb);
            this.panel3.Controls.Add(this.label_pageNb);
            this.panel3.Controls.Add(this.button_goToPage);
            this.panel3.Controls.Add(this.button_nextPage);
            this.panel3.Controls.Add(this.button_previousPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 562);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 40);
            this.panel3.TabIndex = 4;
            // 
            // numericUpDown_pageNb
            // 
            this.numericUpDown_pageNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_pageNb.Location = new System.Drawing.Point(351, 12);
            this.numericUpDown_pageNb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_pageNb.Name = "numericUpDown_pageNb";
            this.numericUpDown_pageNb.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_pageNb.TabIndex = 4;
            this.numericUpDown_pageNb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_pageNb
            // 
            this.label_pageNb.AutoSize = true;
            this.label_pageNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pageNb.Location = new System.Drawing.Point(93, 14);
            this.label_pageNb.Name = "label_pageNb";
            this.label_pageNb.Size = new System.Drawing.Size(51, 13);
            this.label_pageNb.TabIndex = 3;
            this.label_pageNb.Text = "Page: 1";
            // 
            // button_goToPage
            // 
            this.button_goToPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_goToPage.Location = new System.Drawing.Point(258, 0);
            this.button_goToPage.Name = "button_goToPage";
            this.button_goToPage.Size = new System.Drawing.Size(87, 40);
            this.button_goToPage.TabIndex = 2;
            this.button_goToPage.Text = "Go to page:";
            this.button_goToPage.UseVisualStyleBackColor = true;
            this.button_goToPage.Click += new System.EventHandler(this.button_goToPage_Click);
            // 
            // button_nextPage
            // 
            this.button_nextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nextPage.Location = new System.Drawing.Point(165, 0);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(87, 40);
            this.button_nextPage.TabIndex = 1;
            this.button_nextPage.Text = "Next Page";
            this.button_nextPage.UseVisualStyleBackColor = true;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // button_previousPage
            // 
            this.button_previousPage.Enabled = false;
            this.button_previousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previousPage.Location = new System.Drawing.Point(0, 0);
            this.button_previousPage.Name = "button_previousPage";
            this.button_previousPage.Size = new System.Drawing.Size(87, 40);
            this.button_previousPage.TabIndex = 0;
            this.button_previousPage.Text = "Previous Page";
            this.button_previousPage.UseVisualStyleBackColor = true;
            this.button_previousPage.Click += new System.EventHandler(this.button_previousPage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // Form_RecipesBriefView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 602);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_RecipesBriefView";
            this.Text = "Form_MyRecipes";
            this.Load += new System.EventHandler(this.Form_MyRecipes_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pageNb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown_pageNb;
        private System.Windows.Forms.Label label_pageNb;
        private System.Windows.Forms.Button button_goToPage;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Button button_previousPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
    }
}