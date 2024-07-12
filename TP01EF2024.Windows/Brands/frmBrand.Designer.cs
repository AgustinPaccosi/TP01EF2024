namespace TP01EF2024.Windows.Brands
{
    partial class frmBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrand));
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            ColumnaMarca = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label1 = new Label();
            LabelRegistros = new Label();
            toolStrip1 = new ToolStrip();
            ToolButtonNuevo = new ToolStripButton();
            TsButtonBorrar = new ToolStripButton();
            TsButtonEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsButtonFiltrar = new ToolStripButton();
            TsButtonSalir = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
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
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(LabelRegistros);
            splitContainer1.Size = new Size(800, 383);
            splitContainer1.SplitterDistance = 276;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 4;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaMarca });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 276);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnaMarca
            // 
            ColumnaMarca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaMarca.HeaderText = "Marca";
            ColumnaMarca.MinimumWidth = 6;
            ColumnaMarca.Name = "ColumnaMarca";
            ColumnaMarca.ReadOnly = true;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(140, 35);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(17, 20);
            lblRegistros.TabIndex = 9;
            lblRegistros.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 7;
            label1.Text = "Registros: ";
            // 
            // LabelRegistros
            // 
            LabelRegistros.AutoSize = true;
            LabelRegistros.Location = new Point(151, 33);
            LabelRegistros.Name = "LabelRegistros";
            LabelRegistros.Size = new Size(0, 20);
            LabelRegistros.TabIndex = 8;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolButtonNuevo, TsButtonBorrar, TsButtonEditar, toolStripSeparator1, TsButtonFiltrar, TsButtonSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 67);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // ToolButtonNuevo
            // 
            ToolButtonNuevo.Image = (Image)resources.GetObject("ToolButtonNuevo.Image");
            ToolButtonNuevo.ImageScaling = ToolStripItemImageScaling.None;
            ToolButtonNuevo.ImageTransparentColor = Color.Magenta;
            ToolButtonNuevo.Name = "ToolButtonNuevo";
            ToolButtonNuevo.Size = new Size(56, 64);
            ToolButtonNuevo.Text = "Nuevo";
            ToolButtonNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            ToolButtonNuevo.Click += ToolButtonNuevo_Click_1;
            // 
            // TsButtonBorrar
            // 
            TsButtonBorrar.Image = (Image)resources.GetObject("TsButtonBorrar.Image");
            TsButtonBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonBorrar.ImageTransparentColor = Color.Magenta;
            TsButtonBorrar.Name = "TsButtonBorrar";
            TsButtonBorrar.Size = new Size(54, 64);
            TsButtonBorrar.Text = "Borrar";
            TsButtonBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonBorrar.Click += TsButtonBorrar_Click_1;
            // 
            // TsButtonEditar
            // 
            TsButtonEditar.Image = (Image)resources.GetObject("TsButtonEditar.Image");
            TsButtonEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonEditar.ImageTransparentColor = Color.Magenta;
            TsButtonEditar.Name = "TsButtonEditar";
            TsButtonEditar.Size = new Size(52, 64);
            TsButtonEditar.Text = "Editar";
            TsButtonEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonEditar.Click += TsButtonEditar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // TsButtonFiltrar
            // 
            TsButtonFiltrar.Image = (Image)resources.GetObject("TsButtonFiltrar.Image");
            TsButtonFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonFiltrar.ImageTransparentColor = Color.Magenta;
            TsButtonFiltrar.Name = "TsButtonFiltrar";
            TsButtonFiltrar.Size = new Size(117, 64);
            TsButtonFiltrar.Text = "Filtro Por Marca";
            TsButtonFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonFiltrar.Click += TsButtonFiltrar_Click_1;
            // 
            // TsButtonSalir
            // 
            TsButtonSalir.Image = (Image)resources.GetObject("TsButtonSalir.Image");
            TsButtonSalir.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonSalir.ImageTransparentColor = Color.Magenta;
            TsButtonSalir.Name = "TsButtonSalir";
            TsButtonSalir.Size = new Size(44, 64);
            TsButtonSalir.Text = "Salir";
            TsButtonSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonSalir.Click += TsButtonSalir_Click_1;
            // 
            // frmBrand
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmBrand";
            Text = "Marcas";
            Load += frmBrand_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColumnaMarca;
        private ToolStrip toolStrip1;
        private ToolStripButton ToolButtonNuevo;
        private ToolStripButton TsButtonBorrar;
        private ToolStripButton TsButtonEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsButtonFiltrar;
        private ToolStripButton TsButtonSalir;
        private ToolStripMenuItem zAToolStripMenuItem;
        private ToolStripMenuItem aZToolStripMenuItem;
        private ToolStripDropDownButton tsbOrden;
        private ToolStripButton tsbActualizar;
        private ToolStripButton tsbFiltrar;
        private ToolStripSeparator toolStripSeparator3;
        private Label lblRegistros;
        private Label label1;
        private Label LabelRegistros;
    }
}