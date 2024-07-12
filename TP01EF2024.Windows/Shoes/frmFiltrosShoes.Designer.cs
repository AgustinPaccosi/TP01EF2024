namespace TP01EF2024.Windows.Shoes
{
    partial class frmFiltrosShoes
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
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            ColumnaBrand = new DataGridViewTextBoxColumn();
            ColumnaGenre = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaSport = new DataGridViewTextBoxColumn();
            ColumnaPrice = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblRegistros);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(830, 456);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaBrand, ColumnaGenre, ColumnaColor, ColumnaSport, ColumnaPrice });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(830, 350);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnaBrand
            // 
            ColumnaBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaBrand.HeaderText = "Marca";
            ColumnaBrand.MinimumWidth = 6;
            ColumnaBrand.Name = "ColumnaBrand";
            ColumnaBrand.ReadOnly = true;
            // 
            // ColumnaGenre
            // 
            ColumnaGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaGenre.HeaderText = "Genero";
            ColumnaGenre.MinimumWidth = 6;
            ColumnaGenre.Name = "ColumnaGenre";
            ColumnaGenre.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            ColumnaColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaColor.HeaderText = "Colores";
            ColumnaColor.MinimumWidth = 6;
            ColumnaColor.Name = "ColumnaColor";
            ColumnaColor.ReadOnly = true;
            // 
            // ColumnaSport
            // 
            ColumnaSport.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaSport.HeaderText = "Deporte";
            ColumnaSport.MinimumWidth = 6;
            ColumnaSport.Name = "ColumnaSport";
            ColumnaSport.ReadOnly = true;
            // 
            // ColumnaPrice
            // 
            ColumnaPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaPrice.HeaderText = "Precio";
            ColumnaPrice.MinimumWidth = 6;
            ColumnaPrice.Name = "ColumnaPrice";
            ColumnaPrice.ReadOnly = true;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(102, 45);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(17, 20);
            lblRegistros.TabIndex = 15;
            lblRegistros.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 14;
            label3.Text = "Registros: ";
            // 
            // frmFiltrosShoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 456);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(848, 503);
            MinimumSize = new Size(848, 503);
            Name = "frmFiltrosShoes";
            Text = "Flitrados";
            Load += frmFiltrosShoes_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColumnaBrand;
        private DataGridViewTextBoxColumn ColumnaGenre;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaSport;
        private DataGridViewTextBoxColumn ColumnaPrice;
        private Label lblRegistros;
        private Label label3;
    }
}