namespace TP01EF2024.Windows.Shoes
{
    partial class frmShoesDetalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoesDetalles));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TexboxDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonCancel = new Button();
            buttonOK = new Button();
            dataGridView1 = new DataGridView();
            ColTalle = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            AgregarTalleBtn = new Button();
            EditarTalleBtn = new Button();
            EliminarTalleBtn = new Button();
            PagAnteriorBtn = new Button();
            PagSiguienteBtn = new Button();
            panel1 = new Panel();
            MarcaLbl = new Label();
            panel2 = new Panel();
            GeneroLbl = new Label();
            panel3 = new Panel();
            DeporteLbl = new Label();
            panel4 = new Panel();
            ModeloLbl = new Label();
            panel5 = new Panel();
            ColorLbl = new Label();
            panel6 = new Panel();
            PrecioLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 49);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 36;
            label7.Text = "Marca:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(411, 49);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 35;
            label6.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(411, 128);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 34;
            label5.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(411, 479);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 32;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 128);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 31;
            label3.Text = "Deporte:";
            // 
            // TexboxDescripcion
            // 
            TexboxDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TexboxDescripcion.Location = new Point(115, 283);
            TexboxDescripcion.Margin = new Padding(3, 4, 3, 4);
            TexboxDescripcion.MaxLength = 50;
            TexboxDescripcion.Multiline = true;
            TexboxDescripcion.Name = "TexboxDescripcion";
            TexboxDescripcion.PlaceholderText = "Ingrese una Descripcion";
            TexboxDescripcion.Size = new Size(267, 109);
            TexboxDescripcion.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 283);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 29;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 205);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 27;
            label1.Text = "Modelo:";
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(257, 436);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 74);
            buttonCancel.TabIndex = 26;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = ContentAlignment.BottomCenter;
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Image = (Image)resources.GetObject("buttonOK.Image");
            buttonOK.Location = new Point(96, 436);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 74);
            buttonOK.TabIndex = 25;
            buttonOK.Text = "OK";
            buttonOK.TextAlign = ContentAlignment.BottomCenter;
            buttonOK.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColTalle, colStock });
            dataGridView1.Location = new Point(411, 177);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 15;
            dataGridView1.Size = new Size(380, 267);
            dataGridView1.TabIndex = 41;
            // 
            // ColTalle
            // 
            ColTalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTalle.HeaderText = "Talle";
            ColTalle.MinimumWidth = 6;
            ColTalle.Name = "ColTalle";
            ColTalle.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // AgregarTalleBtn
            // 
            AgregarTalleBtn.Location = new Point(797, 207);
            AgregarTalleBtn.Name = "AgregarTalleBtn";
            AgregarTalleBtn.Size = new Size(138, 29);
            AgregarTalleBtn.TabIndex = 42;
            AgregarTalleBtn.Text = "Agregar Talle";
            AgregarTalleBtn.UseVisualStyleBackColor = true;
            // 
            // EditarTalleBtn
            // 
            EditarTalleBtn.Location = new Point(797, 258);
            EditarTalleBtn.Name = "EditarTalleBtn";
            EditarTalleBtn.Size = new Size(138, 29);
            EditarTalleBtn.TabIndex = 43;
            EditarTalleBtn.Text = "Actualizar Stock";
            EditarTalleBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarTalleBtn
            // 
            EliminarTalleBtn.Location = new Point(797, 310);
            EliminarTalleBtn.Name = "EliminarTalleBtn";
            EliminarTalleBtn.Size = new Size(138, 29);
            EliminarTalleBtn.TabIndex = 44;
            EliminarTalleBtn.Text = "Eliminar Talle";
            EliminarTalleBtn.UseVisualStyleBackColor = true;
            // 
            // PagAnteriorBtn
            // 
            PagAnteriorBtn.Image = (Image)resources.GetObject("PagAnteriorBtn.Image");
            PagAnteriorBtn.Location = new Point(797, 363);
            PagAnteriorBtn.Name = "PagAnteriorBtn";
            PagAnteriorBtn.Size = new Size(55, 46);
            PagAnteriorBtn.TabIndex = 45;
            PagAnteriorBtn.UseVisualStyleBackColor = true;
            // 
            // PagSiguienteBtn
            // 
            PagSiguienteBtn.Image = (Image)resources.GetObject("PagSiguienteBtn.Image");
            PagSiguienteBtn.Location = new Point(880, 363);
            PagSiguienteBtn.Name = "PagSiguienteBtn";
            PagSiguienteBtn.Size = new Size(55, 46);
            PagSiguienteBtn.TabIndex = 46;
            PagSiguienteBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(MarcaLbl);
            panel1.Location = new Point(96, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 34);
            panel1.TabIndex = 47;
            // 
            // MarcaLbl
            // 
            MarcaLbl.AutoSize = true;
            MarcaLbl.Location = new Point(0, 7);
            MarcaLbl.Name = "MarcaLbl";
            MarcaLbl.Size = new Size(50, 20);
            MarcaLbl.TabIndex = 0;
            MarcaLbl.Text = "label8";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(GeneroLbl);
            panel2.Location = new Point(505, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 34);
            panel2.TabIndex = 48;
            // 
            // GeneroLbl
            // 
            GeneroLbl.AutoSize = true;
            GeneroLbl.Location = new Point(0, 7);
            GeneroLbl.Name = "GeneroLbl";
            GeneroLbl.Size = new Size(50, 20);
            GeneroLbl.TabIndex = 0;
            GeneroLbl.Text = "label8";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(DeporteLbl);
            panel3.Location = new Point(96, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 34);
            panel3.TabIndex = 48;
            // 
            // DeporteLbl
            // 
            DeporteLbl.AutoSize = true;
            DeporteLbl.Location = new Point(0, 7);
            DeporteLbl.Name = "DeporteLbl";
            DeporteLbl.Size = new Size(50, 20);
            DeporteLbl.TabIndex = 0;
            DeporteLbl.Text = "label8";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Controls.Add(ModeloLbl);
            panel4.Location = new Point(96, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(286, 34);
            panel4.TabIndex = 48;
            // 
            // ModeloLbl
            // 
            ModeloLbl.AutoSize = true;
            ModeloLbl.Location = new Point(0, 7);
            ModeloLbl.Name = "ModeloLbl";
            ModeloLbl.Size = new Size(50, 20);
            ModeloLbl.TabIndex = 0;
            ModeloLbl.Text = "label8";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(ColorLbl);
            panel5.Location = new Point(505, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 34);
            panel5.TabIndex = 49;
            // 
            // ColorLbl
            // 
            ColorLbl.AutoSize = true;
            ColorLbl.Location = new Point(0, 7);
            ColorLbl.Name = "ColorLbl";
            ColorLbl.Size = new Size(50, 20);
            ColorLbl.TabIndex = 0;
            ColorLbl.Text = "label8";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.AppWorkspace;
            panel6.Controls.Add(PrecioLbl);
            panel6.Location = new Point(505, 473);
            panel6.Name = "panel6";
            panel6.Size = new Size(286, 34);
            panel6.TabIndex = 49;
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Location = new Point(0, 7);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(50, 20);
            PrecioLbl.TabIndex = 0;
            PrecioLbl.Text = "label8";
            // 
            // frmShoesDetalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 544);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PagSiguienteBtn);
            Controls.Add(PagAnteriorBtn);
            Controls.Add(EliminarTalleBtn);
            Controls.Add(EditarTalleBtn);
            Controls.Add(AgregarTalleBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TexboxDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Name = "frmShoesDetalles";
            Text = "frmShoesDetalles";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboboxColor;
        private ComboBox ComboboxSport;
        private ComboBox ComboboxGenre;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TexboxPrice;
        private Label label4;
        private Label label3;
        private TextBox TexboxDescripcion;
        private Label label2;
        private TextBox TexboxModel;
        private Label label1;
        private Button buttonCancel;
        private Button buttonOK;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColTalle;
        private DataGridViewTextBoxColumn colStock;
        private Button AgregarTalleBtn;
        private Button EditarTalleBtn;
        private Button EliminarTalleBtn;
        private Button PagAnteriorBtn;
        private Button PagSiguienteBtn;
        private Panel panel1;
        private Label MarcaLbl;
        private Panel panel2;
        private Label GeneroLbl;
        private Panel panel3;
        private Label DeporteLbl;
        private Panel panel4;
        private Label ModeloLbl;
        private Panel panel5;
        private Label ColorLbl;
        private Panel panel6;
        private Label PrecioLbl;
    }
}