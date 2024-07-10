namespace TP01EF2024.Windows.Colours
{
    partial class frmColoursAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColoursAE));
            TextBoxGenreName = new TextBox();
            label1 = new Label();
            buttonCancel = new Button();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // TextBoxGenreName
            // 
            TextBoxGenreName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxGenreName.Location = new Point(134, 57);
            TextBoxGenreName.Margin = new Padding(3, 4, 3, 4);
            TextBoxGenreName.Name = "TextBoxGenreName";
            TextBoxGenreName.PlaceholderText = "Nombre del Color";
            TextBoxGenreName.Size = new Size(294, 34);
            TextBoxGenreName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 14;
            label1.Text = "Color:";
            // 
            // buttonCancel
            // 
            buttonCancel.Image = (Image)resources.GetObject("buttonCancel.Image");
            buttonCancel.Location = new Point(323, 129);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 74);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.TextAlign = ContentAlignment.BottomCenter;
            buttonCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Image = (Image)resources.GetObject("buttonGuardar.Image");
            buttonGuardar.Location = new Point(77, 129);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 74);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.TextAlign = ContentAlignment.BottomCenter;
            buttonGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // frmColoursAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 272);
            Controls.Add(TextBoxGenreName);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonGuardar);
            MaximumSize = new Size(527, 319);
            MinimumSize = new Size(527, 319);
            Name = "frmColoursAE";
            Text = "frmColoursAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxGenreName;
        private Label label1;
        private Button buttonCancel;
        private Button buttonGuardar;
    }
}