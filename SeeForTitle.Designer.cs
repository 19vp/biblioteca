namespace biblioteca
{
    partial class SeeForTitle
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
            btnSearch = new Button();
            dgvReportTitle = new DataGridView();
            btnOut = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportTitle).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 29);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvReportTitle
            // 
            dgvReportTitle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportTitle.Location = new Point(25, 132);
            dgvReportTitle.Name = "dgvReportTitle";
            dgvReportTitle.RowHeadersWidth = 51;
            dgvReportTitle.Size = new Size(658, 256);
            dgvReportTitle.TabIndex = 36;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(592, 433);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(91, 29);
            btnOut.TabIndex = 35;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 20);
            label1.Name = "label1";
            label1.Size = new Size(224, 31);
            label1.TabIndex = 34;
            label1.Text = "Consultas por titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 33;
            label2.Text = "Ingrese el titulo del libro";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(203, 70);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(306, 27);
            txtTitle.TabIndex = 38;
            // 
            // SeeForTitle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 539);
            Controls.Add(txtTitle);
            Controls.Add(btnSearch);
            Controls.Add(dgvReportTitle);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "SeeForTitle";
            Text = "SeeForTitle";
            Load += SeeForTitle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvReportTitle;
        private Button btnOut;
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
    }
}