namespace TP01EF2024.Windows.Brands
{
    partial class frmBrandAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrandAE));
            buttonGuardar = new Button();
            buttonCancel = new Button();
            TextBoxBrandName = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.Image = (Image)resources.GetObject("buttonGuardar.Image");
            buttonGuardar.Location = new Point(97, 140);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 74);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextAlign = ContentAlignment.BottomCenter;
            buttonGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(343, 140);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 74);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = ContentAlignment.BottomCenter;
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // TextBoxBrandName
            // 
            TextBoxBrandName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxBrandName.Location = new Point(143, 67);
            TextBoxBrandName.Margin = new Padding(3, 4, 3, 4);
            TextBoxBrandName.Name = "TextBoxBrandName";
            TextBoxBrandName.PlaceholderText = "Nombre de la Marca";
            TextBoxBrandName.Size = new Size(294, 34);
            TextBoxBrandName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 71);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 2;
            label1.Text = "Marca: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBrandAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 272);
            Controls.Add(TextBoxBrandName);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonGuardar);
            MaximumSize = new Size(527, 319);
            MinimumSize = new Size(527, 319);
            Name = "frmBrandAE";
            Text = "Marca";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardar;
        private Button buttonCancel;
        private TextBox TextBoxBrandName;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}