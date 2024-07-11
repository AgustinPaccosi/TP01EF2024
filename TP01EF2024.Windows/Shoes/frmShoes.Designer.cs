namespace TP01EF2024.Windows.Shoes
{
    partial class frmShoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoes));
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            ColumnaBrand = new DataGridViewTextBoxColumn();
            ColumnaGenre = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaSport = new DataGridViewTextBoxColumn();
            ColumnaPrice = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label3 = new Label();
            ComboBoxPaginas = new ComboBox();
            ButtonUltimo = new Button();
            ButtonSiguiente = new Button();
            ButtonAnterior = new Button();
            ButtonPrimero = new Button();
            TxbCantRegistros = new TextBox();
            label2 = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            ToolButtonNuevo = new ToolStripButton();
            TsButtonBorrar = new ToolStripButton();
            TsButtonEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsButtonFiltrar = new ToolStripButton();
            TsButtonActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            DropDownButtonOrdenar = new ToolStripDropDownButton();
            toolStripButton1 = new ToolStripButton();
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
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(ComboBoxPaginas);
            splitContainer1.Panel2.Controls.Add(ButtonUltimo);
            splitContainer1.Panel2.Controls.Add(ButtonSiguiente);
            splitContainer1.Panel2.Controls.Add(ButtonAnterior);
            splitContainer1.Panel2.Controls.Add(ButtonPrimero);
            splitContainer1.Panel2.Controls.Add(TxbCantRegistros);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 383);
            splitContainer1.SplitterDistance = 271;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 3;
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
            dgvDatos.Size = new Size(800, 271);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnaBrand
            // 
            ColumnaBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaBrand.HeaderText = "Brands";
            ColumnaBrand.MinimumWidth = 6;
            ColumnaBrand.Name = "ColumnaBrand";
            ColumnaBrand.ReadOnly = true;
            // 
            // ColumnaGenre
            // 
            ColumnaGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaGenre.HeaderText = "Genres";
            ColumnaGenre.MinimumWidth = 6;
            ColumnaGenre.Name = "ColumnaGenre";
            ColumnaGenre.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            ColumnaColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaColor.HeaderText = "Colors";
            ColumnaColor.MinimumWidth = 6;
            ColumnaColor.Name = "ColumnaColor";
            ColumnaColor.ReadOnly = true;
            // 
            // ColumnaSport
            // 
            ColumnaSport.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaSport.HeaderText = "Sports";
            ColumnaSport.MinimumWidth = 6;
            ColumnaSport.Name = "ColumnaSport";
            ColumnaSport.ReadOnly = true;
            // 
            // ColumnaPrice
            // 
            ColumnaPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaPrice.HeaderText = "Prices";
            ColumnaPrice.MinimumWidth = 6;
            ColumnaPrice.Name = "ColumnaPrice";
            ColumnaPrice.ReadOnly = true;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(103, 65);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(17, 20);
            lblRegistros.TabIndex = 15;
            lblRegistros.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 14;
            label3.Text = "Registros: ";
            // 
            // ComboBoxPaginas
            // 
            ComboBoxPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPaginas.FormattingEnabled = true;
            ComboBoxPaginas.Location = new Point(92, 20);
            ComboBoxPaginas.Margin = new Padding(3, 4, 3, 4);
            ComboBoxPaginas.Name = "ComboBoxPaginas";
            ComboBoxPaginas.Size = new Size(63, 28);
            ComboBoxPaginas.TabIndex = 13;
            // 
            // ButtonUltimo
            // 
            ButtonUltimo.Image = (Image)resources.GetObject("ButtonUltimo.Image");
            ButtonUltimo.Location = new Point(662, 27);
            ButtonUltimo.Margin = new Padding(3, 4, 3, 4);
            ButtonUltimo.Name = "ButtonUltimo";
            ButtonUltimo.Size = new Size(77, 59);
            ButtonUltimo.TabIndex = 2;
            ButtonUltimo.UseVisualStyleBackColor = true;
            ButtonUltimo.Click += ButtonUltimo_Click;
            // 
            // ButtonSiguiente
            // 
            ButtonSiguiente.Image = (Image)resources.GetObject("ButtonSiguiente.Image");
            ButtonSiguiente.Location = new Point(578, 27);
            ButtonSiguiente.Margin = new Padding(3, 4, 3, 4);
            ButtonSiguiente.Name = "ButtonSiguiente";
            ButtonSiguiente.Size = new Size(77, 59);
            ButtonSiguiente.TabIndex = 2;
            ButtonSiguiente.UseVisualStyleBackColor = true;
            ButtonSiguiente.Click += ButtonSiguiente_Click;
            // 
            // ButtonAnterior
            // 
            ButtonAnterior.Image = (Image)resources.GetObject("ButtonAnterior.Image");
            ButtonAnterior.Location = new Point(446, 27);
            ButtonAnterior.Margin = new Padding(3, 4, 3, 4);
            ButtonAnterior.Name = "ButtonAnterior";
            ButtonAnterior.Size = new Size(77, 59);
            ButtonAnterior.TabIndex = 2;
            ButtonAnterior.UseVisualStyleBackColor = true;
            ButtonAnterior.Click += ButtonAnterior_Click;
            // 
            // ButtonPrimero
            // 
            ButtonPrimero.Image = (Image)resources.GetObject("ButtonPrimero.Image");
            ButtonPrimero.Location = new Point(362, 27);
            ButtonPrimero.Margin = new Padding(3, 4, 3, 4);
            ButtonPrimero.Name = "ButtonPrimero";
            ButtonPrimero.Size = new Size(77, 59);
            ButtonPrimero.TabIndex = 2;
            ButtonPrimero.UseVisualStyleBackColor = true;
            ButtonPrimero.Click += ButtonPrimero_Click;
            // 
            // TxbCantRegistros
            // 
            TxbCantRegistros.Enabled = false;
            TxbCantRegistros.Location = new Point(201, 20);
            TxbCantRegistros.Margin = new Padding(3, 4, 3, 4);
            TxbCantRegistros.Name = "TxbCantRegistros";
            TxbCantRegistros.Size = new Size(53, 27);
            TxbCantRegistros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 21);
            label2.Name = "label2";
            label2.Size = new Size(30, 23);
            label2.TabIndex = 0;
            label2.Text = "de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "Pagina: ";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolButtonNuevo, TsButtonBorrar, TsButtonEditar, toolStripSeparator1, TsButtonFiltrar, TsButtonActualizar, toolStripSeparator2, DropDownButtonOrdenar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 67);
            toolStrip1.TabIndex = 2;
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
            ToolButtonNuevo.Click += ToolButtonNuevo_Click;
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
            TsButtonBorrar.Click += TsButtonBorrar_Click;
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
            TsButtonEditar.Click += TsButtonEditar_Click;
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
            TsButtonFiltrar.Size = new Size(51, 64);
            TsButtonFiltrar.Text = "Filtrar";
            TsButtonFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonFiltrar.Click += TsButtonFiltrar_Click;
            // 
            // TsButtonActualizar
            // 
            TsButtonActualizar.Image = (Image)resources.GetObject("TsButtonActualizar.Image");
            TsButtonActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsButtonActualizar.ImageTransparentColor = Color.Magenta;
            TsButtonActualizar.Name = "TsButtonActualizar";
            TsButtonActualizar.Size = new Size(79, 64);
            TsButtonActualizar.Text = "Actualizar";
            TsButtonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsButtonActualizar.Click += TsButtonActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 67);
            // 
            // DropDownButtonOrdenar
            // 
            DropDownButtonOrdenar.Image = (Image)resources.GetObject("DropDownButtonOrdenar.Image");
            DropDownButtonOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            DropDownButtonOrdenar.ImageTransparentColor = Color.Magenta;
            DropDownButtonOrdenar.Name = "DropDownButtonOrdenar";
            DropDownButtonOrdenar.Size = new Size(77, 64);
            DropDownButtonOrdenar.Text = "Ordenar";
            DropDownButtonOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(44, 64);
            toolStripButton1.Text = "Salir";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // frmShoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmShoes";
            Text = "Zapatillas";
            Load += frmShoes_Load;
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
        private DataGridViewTextBoxColumn ColumnaBrand;
        private DataGridViewTextBoxColumn ColumnaGenre;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaSport;
        private DataGridViewTextBoxColumn ColumnaPrice;
        private ComboBox ComboBoxPaginas;
        private Button ButtonUltimo;
        private Button ButtonSiguiente;
        private Button ButtonAnterior;
        private Button ButtonPrimero;
        private TextBox TxbCantRegistros;
        private Label label2;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton ToolButtonNuevo;
        private ToolStripButton TsButtonBorrar;
        private ToolStripButton TsButtonEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsButtonFiltrar;
        private ToolStripButton TsButtonActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton DropDownButtonOrdenar;
        private Label lblRegistros;
        private Label label3;
        private ToolStripButton toolStripButton1;
    }
}