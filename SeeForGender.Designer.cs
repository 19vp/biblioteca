namespace biblioteca
{
    partial class SeeForGender
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
            dgvReportGender = new DataGridView();
            btnOut = new Button();
            label1 = new Label();
            label2 = new Label();
            txtGender = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportGender).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 29);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvReportGender
            // 
            dgvReportGender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportGender.Location = new Point(25, 135);
            dgvReportGender.Name = "dgvReportGender";
            dgvReportGender.RowHeadersWidth = 51;
            dgvReportGender.Size = new Size(658, 256);
            dgvReportGender.TabIndex = 36;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(592, 436);
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
            label1.Location = new Point(193, 23);
            label1.Name = "label1";
            label1.Size = new Size(240, 31);
            label1.TabIndex = 34;
            label1.Text = "Consultas por genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(256, 20);
            label2.TabIndex = 33;
            label2.Text = "Ingrese el genero literario a consultar";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(287, 79);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(203, 27);
            txtGender.TabIndex = 38;
            // 
            // SeeForGender
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 529);
            Controls.Add(txtGender);
            Controls.Add(btnSearch);
            Controls.Add(dgvReportGender);
            Controls.Add(btnOut);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "SeeForGender";
            Text = "SeeForGender";
            ((System.ComponentModel.ISupportInitialize)dgvReportGender).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvReportGender;
        private Button btnOut;
        private Label label1;
        private Label label2;
        private TextBox txtGender;
    }
}