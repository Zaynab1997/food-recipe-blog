namespace SQLProjectForms1
{
    partial class FormRatingsProductsFollow
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
            this.dataGridView_all = new System.Windows.Forms.DataGridView();
            this.label_view = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_all
            // 
            this.dataGridView_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_all.Location = new System.Drawing.Point(12, 52);
            this.dataGridView_all.Name = "dataGridView_all";
            this.dataGridView_all.RowTemplate.Height = 24;
            this.dataGridView_all.Size = new System.Drawing.Size(776, 386);
            this.dataGridView_all.TabIndex = 0;
            this.dataGridView_all.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_all_CellClick);
            // 
            // label_view
            // 
            this.label_view.AutoSize = true;
            this.label_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_view.Location = new System.Drawing.Point(12, 9);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(56, 24);
            this.label_view.TabIndex = 37;
            this.label_view.Text = "View";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "Delete this Item";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FormRatingsProductsFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_view);
            this.Controls.Add(this.dataGridView_all);
            this.Name = "FormRatingsProductsFollow";
            this.Text = "FormRatingsProductsFollow";
            this.Load += new System.EventHandler(this.FormRatingsProductsFollow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_all;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}