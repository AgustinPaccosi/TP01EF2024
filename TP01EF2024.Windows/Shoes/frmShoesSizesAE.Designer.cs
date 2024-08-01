namespace TP01EF2024.Windows.Shoes
{
    partial class frmShoesSizesAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoesSizesAE));
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            GuardarBtn = new Button();
            CancelarBtn = new Button();
            ComboTalles = new ComboBox();
            StockTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 87);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Selecciona Un Talle:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 142);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Stock:";
            // 
            // GuardarBtn
            // 
            GuardarBtn.Image = (Image)resources.GetObject("GuardarBtn.Image");
            GuardarBtn.ImageAlign = ContentAlignment.BottomCenter;
            GuardarBtn.Location = new Point(103, 228);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(94, 82);
            GuardarBtn.TabIndex = 2;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Image = (Image)resources.GetObject("CancelarBtn.Image");
            CancelarBtn.ImageAlign = ContentAlignment.BottomCenter;
            CancelarBtn.Location = new Point(316, 228);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(94, 82);
            CancelarBtn.TabIndex = 3;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ComboTalles
            // 
            ComboTalles.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTalles.FormattingEnabled = true;
            ComboTalles.Location = new Point(203, 84);
            ComboTalles.Name = "ComboTalles";
            ComboTalles.Size = new Size(242, 28);
            ComboTalles.TabIndex = 4;
            ComboTalles.SelectedIndexChanged += ComboTalles_SelectedIndexChanged;
            // 
            // StockTxt
            // 
            StockTxt.Location = new Point(203, 135);
            StockTxt.Name = "StockTxt";
            StockTxt.Size = new Size(242, 27);
            StockTxt.TabIndex = 5;
            // 
            // frmShoesSizesAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 373);
            Controls.Add(StockTxt);
            Controls.Add(ComboTalles);
            Controls.Add(CancelarBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(570, 420);
            MinimumSize = new Size(570, 420);
            Name = "frmShoesSizesAE";
            Text = "Agregar Talle";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox StockTxt;
        private ComboBox ComboTalles;
        private Button CancelarBtn;
        private Button GuardarBtn;
        private Label label2;
        private Label label1;
    }
}