namespace biblioteca
{
    partial class SeeForAuthor
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
            label2 = new Label();
            label1 = new Label();
            btnOut = new Button();
            dgvReportAuthor = new DataGridView();
            btnSearch = new Button();
            txtAutor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportAuthor).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el autor a consultar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 54);
            label1.Name = "label1";
            label1.Size = new Size(223, 31);
            label1.TabIndex = 8;
            label1.Text = "Consultas por autor";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(595, 467);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(91, 29);
            btnOut.TabIndex = 29;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // dgvReportAuthor
            // 
            dgvReportAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportAuthor.Location = new Point(28, 166);
            dgvReportAuthor.Name = "dgvReportAuthor";
            dgvReportAuthor.RowHeadersWidth = 51;
            dgvReportAuthor.Size = new Size(658, 256);
            dgvReportAuthor.TabIndex = 30;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(509, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 29);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(240, 106);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(248, 27);
            txtAutor.TabIndex = 32;
            // 
            // SeeForAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 606);
            Controls.Add(txtAutor);
            Controls.Add(btnSearch);
            Controls.Add(dgvReportAuthor);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "SeeForAuthor";
            Text = "SeeForAuthor";
            Load += SeeForAuthor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnOut;
        private DataGridView dgvReportAuthor;
        private Button btnSearch;
        private TextBox txtAutor;
    }
}