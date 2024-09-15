namespace biblioteca
{
    partial class Returns
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
            btnCancel = new Button();
            btnSave = new Button();
            label4 = new Label();
            dtReturn = new DateTimePicker();
            label1 = new Label();
            dgvBorrowings = new DataGridView();
            txtIdReader = new TextBox();
            txtIdBook = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(797, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(797, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 451);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 18;
            label4.Text = "Fecha devolución";
            // 
            // dtReturn
            // 
            dtReturn.Format = DateTimePickerFormat.Short;
            dtReturn.Location = new Point(201, 451);
            dtReturn.Name = "dtReturn";
            dtReturn.Size = new Size(250, 27);
            dtReturn.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 29);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 11;
            label1.Text = "Devolución de libros";
            // 
            // dgvBorrowings
            // 
            dgvBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowings.Location = new Point(51, 88);
            dgvBorrowings.Name = "dgvBorrowings";
            dgvBorrowings.ReadOnly = true;
            dgvBorrowings.RowHeadersWidth = 51;
            dgvBorrowings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowings.Size = new Size(840, 188);
            dgvBorrowings.TabIndex = 22;
            dgvBorrowings.CellClick += dgvBorrowings_CellClick;
            // 
            // txtIdReader
            // 
            txtIdReader.Location = new Point(201, 343);
            txtIdReader.Name = "txtIdReader";
            txtIdReader.Size = new Size(168, 27);
            txtIdReader.TabIndex = 24;
            // 
            // txtIdBook
            // 
            txtIdBook.Location = new Point(201, 395);
            txtIdBook.Name = "txtIdBook";
            txtIdBook.Size = new Size(168, 27);
            txtIdBook.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 402);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 28;
            label3.Text = "Id Libro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 350);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 29;
            label6.Text = "Id Lector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 302);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 30;
            label2.Text = "Codigo prestamo";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(201, 302);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(25, 20);
            lblCodigo.TabIndex = 31;
            lblCodigo.Text = "00";
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 525);
            Controls.Add(lblCodigo);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtIdBook);
            Controls.Add(txtIdReader);
            Controls.Add(dgvBorrowings);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(dtReturn);
            Controls.Add(label1);
            Name = "Returns";
            Text = "Returns";
            Load += Returns_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private DateTimePicker dtReturn;
        private Label label1;
        private DataGridView dgvBorrowings;
        private TextBox txtIdReader;
        private TextBox txtIdBook;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label lblCodigo;
    }
}