namespace biblioteca
{
    partial class Reports
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
            label1 = new Label();
            dgvReports = new DataGridView();
            btnActualState = new Button();
            btnExpirateBooks = new Button();
            btnMoreBorrowings = new Button();
            btnForTitle = new Button();
            label2 = new Label();
            btnOut = new Button();
            btnForAuthor = new Button();
            btnForGender = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 12;
            label1.Text = "Reportes";
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(24, 154);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(970, 181);
            dgvReports.TabIndex = 13;
            // 
            // btnActualState
            // 
            btnActualState.Location = new Point(14, 99);
            btnActualState.Name = "btnActualState";
            btnActualState.Size = new Size(248, 29);
            btnActualState.TabIndex = 14;
            btnActualState.Text = "Estado actual de la biblioteca";
            btnActualState.UseVisualStyleBackColor = true;
            btnActualState.Click += btnActualState_Click;
            // 
            // btnExpirateBooks
            // 
            btnExpirateBooks.Location = new Point(607, 99);
            btnExpirateBooks.Name = "btnExpirateBooks";
            btnExpirateBooks.Size = new Size(248, 29);
            btnExpirateBooks.TabIndex = 15;
            btnExpirateBooks.Text = "Libros vencidos";
            btnExpirateBooks.UseVisualStyleBackColor = true;
            btnExpirateBooks.Click += btnExpirateBooks_Click;
            // 
            // btnMoreBorrowings
            // 
            btnMoreBorrowings.Location = new Point(302, 99);
            btnMoreBorrowings.Name = "btnMoreBorrowings";
            btnMoreBorrowings.Size = new Size(248, 29);
            btnMoreBorrowings.TabIndex = 16;
            btnMoreBorrowings.Text = "Libros mas prestados";
            btnMoreBorrowings.UseVisualStyleBackColor = true;
            btnMoreBorrowings.Click += button2_Click;
            // 
            // btnForTitle
            // 
            btnForTitle.Location = new Point(293, 504);
            btnForTitle.Name = "btnForTitle";
            btnForTitle.Size = new Size(81, 29);
            btnForTitle.TabIndex = 20;
            btnForTitle.Text = "Por Titulo";
            btnForTitle.UseVisualStyleBackColor = true;
            btnForTitle.Click += btnGender_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 418);
            label2.Name = "label2";
            label2.Size = new Size(217, 31);
            label2.TabIndex = 17;
            label2.Text = "Consultas de libros";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(883, 28);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(91, 29);
            btnOut.TabIndex = 28;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnForAuthor
            // 
            btnForAuthor.Location = new Point(429, 504);
            btnForAuthor.Name = "btnForAuthor";
            btnForAuthor.Size = new Size(81, 29);
            btnForAuthor.TabIndex = 29;
            btnForAuthor.Text = "Por Autor";
            btnForAuthor.UseVisualStyleBackColor = true;
            btnForAuthor.Click += btnAuthor_Click_1;
            // 
            // btnForGender
            // 
            btnForGender.Location = new Point(542, 504);
            btnForGender.Name = "btnForGender";
            btnForGender.Size = new Size(106, 29);
            btnForGender.TabIndex = 30;
            btnForGender.Text = "Por Genero";
            btnForGender.UseVisualStyleBackColor = true;
            btnForGender.Click += btnGender_Click_1;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 728);
            Controls.Add(btnForGender);
            Controls.Add(btnForAuthor);
            Controls.Add(btnOut);
            Controls.Add(btnForTitle);
            Controls.Add(label2);
            Controls.Add(btnMoreBorrowings);
            Controls.Add(btnExpirateBooks);
            Controls.Add(btnActualState);
            Controls.Add(dgvReports);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvReports;
        private Button btnActualState;
        private Button btnExpirateBooks;
        private Button btnMoreBorrowings;
        private Button btnForTitle;
        private Label label2;
        private Button btnOut;
        private Button btnForAuthor;
        private Button btnForGender;
    }
}