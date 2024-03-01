namespace AppAlgoritmosPseudoaleatorios
{
    partial class Form1
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.cuadraticoRButton = new System.Windows.Forms.RadioButton();
            this.linealRButton = new System.Windows.Forms.RadioButton();
            this.mediosRButton = new System.Windows.Forms.RadioButton();
            this.bTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.AlgoritmosGroupBox = new System.Windows.Forms.GroupBox();
            this.aTextBox = new System.Windows.Forms.MaskedTextBox();
            this.xTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mTextBox = new System.Windows.Forms.MaskedTextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.AlgoritmosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(293, 359);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(88, 32);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(476, 50);
            this.rTextBox.Multiline = true;
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.ReadOnly = true;
            this.rTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rTextBox.Size = new System.Drawing.Size(324, 280);
            this.rTextBox.TabIndex = 10;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(473, 367);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(210, 16);
            this.cantidadLabel.TabIndex = 11;
            this.cantidadLabel.Text = "Cantidad de números generados: ";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(689, 364);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.ReadOnly = true;
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.cantidadTextBox.TabIndex = 12;
            // 
            // cuadraticoRButton
            // 
            this.cuadraticoRButton.AutoSize = true;
            this.cuadraticoRButton.Location = new System.Drawing.Point(7, 105);
            this.cuadraticoRButton.Name = "cuadraticoRButton";
            this.cuadraticoRButton.Size = new System.Drawing.Size(93, 20);
            this.cuadraticoRButton.TabIndex = 2;
            this.cuadraticoRButton.Text = "Cuadrático";
            this.cuadraticoRButton.UseVisualStyleBackColor = true;
            this.cuadraticoRButton.CheckedChanged += new System.EventHandler(this.cuadraticoRButton_CheckedChanged);
            // 
            // linealRButton
            // 
            this.linealRButton.AutoSize = true;
            this.linealRButton.Location = new System.Drawing.Point(7, 71);
            this.linealRButton.Name = "linealRButton";
            this.linealRButton.Size = new System.Drawing.Size(64, 20);
            this.linealRButton.TabIndex = 1;
            this.linealRButton.TabStop = true;
            this.linealRButton.Text = "Lineal";
            this.linealRButton.UseVisualStyleBackColor = true;
            this.linealRButton.CheckedChanged += new System.EventHandler(this.linealRButton_CheckedChanged);
            // 
            // mediosRButton
            // 
            this.mediosRButton.AutoSize = true;
            this.mediosRButton.Checked = true;
            this.mediosRButton.Location = new System.Drawing.Point(7, 36);
            this.mediosRButton.Name = "mediosRButton";
            this.mediosRButton.Size = new System.Drawing.Size(143, 20);
            this.mediosRButton.TabIndex = 0;
            this.mediosRButton.TabStop = true;
            this.mediosRButton.Text = "Cuadrados medios";
            this.mediosRButton.UseVisualStyleBackColor = true;
            this.mediosRButton.CheckedChanged += new System.EventHandler(this.mediosRButton_CheckedChanged);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(293, 185);
            this.bTextBox.Mask = "999999999999";
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 22);
            this.bTextBox.TabIndex = 15;
            this.bTextBox.Visible = false;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(259, 191);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(15, 16);
            this.bLabel.TabIndex = 14;
            this.bLabel.Text = "b";
            this.bLabel.Visible = false;
            // 
            // AlgoritmosGroupBox
            // 
            this.AlgoritmosGroupBox.Controls.Add(this.cuadraticoRButton);
            this.AlgoritmosGroupBox.Controls.Add(this.linealRButton);
            this.AlgoritmosGroupBox.Controls.Add(this.mediosRButton);
            this.AlgoritmosGroupBox.Location = new System.Drawing.Point(12, 50);
            this.AlgoritmosGroupBox.Name = "AlgoritmosGroupBox";
            this.AlgoritmosGroupBox.Size = new System.Drawing.Size(200, 130);
            this.AlgoritmosGroupBox.TabIndex = 13;
            this.AlgoritmosGroupBox.TabStop = false;
            this.AlgoritmosGroupBox.Text = "Algoritmos";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(293, 140);
            this.aTextBox.Mask = "999999999999";
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 22);
            this.aTextBox.TabIndex = 16;
            this.aTextBox.Visible = false;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(293, 102);
            this.xTextBox.Mask = "9999999999999";
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 17;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(293, 235);
            this.cTextBox.Mask = "999999999999";
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 22);
            this.cTextBox.TabIndex = 18;
            this.cTextBox.Visible = false;
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(293, 285);
            this.mTextBox.Mask = "999999999999";
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(100, 22);
            this.mTextBox.TabIndex = 19;
            this.mTextBox.Visible = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(259, 108);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(13, 16);
            this.xLabel.TabIndex = 20;
            this.xLabel.Text = "x";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(259, 150);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(15, 16);
            this.aLabel.TabIndex = 21;
            this.aLabel.Text = "a";
            this.aLabel.Visible = false;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(259, 239);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(14, 16);
            this.cLabel.TabIndex = 22;
            this.cLabel.Text = "c";
            this.cLabel.Visible = false;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(259, 291);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(18, 16);
            this.mLabel.TabIndex = 23;
            this.mLabel.Text = "m";
            this.mLabel.Visible = false;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(725, 415);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 24;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.AlgoritmosGroupBox);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Form1";
            this.Text = "Algoritmos de Números Pseudoaleatorios";
            this.AlgoritmosGroupBox.ResumeLayout(false);
            this.AlgoritmosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.GroupBox AlgoritmosGroupBox;
        private System.Windows.Forms.RadioButton cuadraticoRButton;
        private System.Windows.Forms.RadioButton linealRButton;
        private System.Windows.Forms.RadioButton mediosRButton;
        private System.Windows.Forms.MaskedTextBox bTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox aTextBox;
        private System.Windows.Forms.MaskedTextBox xTextBox;
        private System.Windows.Forms.MaskedTextBox cTextBox;
        private System.Windows.Forms.MaskedTextBox mTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Button LimpiarButton;
    }
}

