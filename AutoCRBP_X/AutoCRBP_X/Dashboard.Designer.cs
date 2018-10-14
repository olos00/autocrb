namespace AutoCRBP_X
{
    partial class Dashboard
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
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autocrbDataSet = new AutoCRBP_X.autocrbDataSet();
            this.courseTableAdapter = new AutoCRBP_X.autocrbDataSetTableAdapters.courseTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocrbDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.autocrbDataSet;
            // 
            // autocrbDataSet
            // 
            this.autocrbDataSet.DataSetName = "autocrbDataSet";
            this.autocrbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursesToolStripMenuItem,
            this.staffToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffDetailsToolStripMenuItem,
            this.examDetailsToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // staffDetailsToolStripMenuItem
            // 
            this.staffDetailsToolStripMenuItem.Name = "staffDetailsToolStripMenuItem";
            this.staffDetailsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.staffDetailsToolStripMenuItem.Text = "Staff";
            this.staffDetailsToolStripMenuItem.Click += new System.EventHandler(this.staffDetailsToolStripMenuItem_Click);
            // 
            // examDetailsToolStripMenuItem
            // 
            this.examDetailsToolStripMenuItem.Name = "examDetailsToolStripMenuItem";
            this.examDetailsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.examDetailsToolStripMenuItem.Text = "Exam";
            this.examDetailsToolStripMenuItem.Click += new System.EventHandler(this.examDetailsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffReportsToolStripMenuItem,
            this.examReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // staffReportsToolStripMenuItem
            // 
            this.staffReportsToolStripMenuItem.Name = "staffReportsToolStripMenuItem";
            this.staffReportsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.staffReportsToolStripMenuItem.Text = "Staff";
            this.staffReportsToolStripMenuItem.Click += new System.EventHandler(this.staffReportsToolStripMenuItem_Click);
            // 
            // examReportsToolStripMenuItem
            // 
            this.examReportsToolStripMenuItem.Name = "examReportsToolStripMenuItem";
            this.examReportsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.examReportsToolStripMenuItem.Text = "Exam";
            this.examReportsToolStripMenuItem.Click += new System.EventHandler(this.examReportsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Automatic Remuneration Bills";
            // 
            // lblDbStatus
            // 
            this.lblDbStatus.AutoSize = true;
            this.lblDbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbStatus.Location = new System.Drawing.Point(11, 281);
            this.lblDbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDbStatus.Name = "lblDbStatus";
            this.lblDbStatus.Size = new System.Drawing.Size(79, 25);
            this.lblDbStatus.TabIndex = 18;
            this.lblDbStatus.Text = "Status: ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 315);
            this.Controls.Add(this.lblDbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autocrbDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private autocrbDataSet autocrbDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private autocrbDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examReportsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDbStatus;
    }
}