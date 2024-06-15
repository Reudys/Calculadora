
namespace Calculadora
{
    partial class frmCalculadora
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

        private void InitializeComponent()
        {
            this.txtRespuesta = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgDivi = new System.Windows.Forms.PictureBox();
            this.imgMulti = new System.Windows.Forms.PictureBox();
            this.imgResta = new System.Windows.Forms.PictureBox();
            this.imgSuma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDivi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMulti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.AutoSize = true;
            this.txtRespuesta.Location = new System.Drawing.Point(202, 112);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(16, 17);
            this.txtRespuesta.TabIndex = 15;
            this.txtRespuesta.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(10, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 46);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(205, 64);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(5);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(149, 34);
            this.txtNum2.TabIndex = 12;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(10, 64);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(5);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(149, 34);
            this.txtNum1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Respuesta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero 1";
            // 
            // imgDivi
            // 
            this.imgDivi.Image = global::Calculadora.Properties.Resources.diviIcon;
            this.imgDivi.Location = new System.Drawing.Point(292, 198);
            this.imgDivi.Name = "imgDivi";
            this.imgDivi.Size = new System.Drawing.Size(54, 50);
            this.imgDivi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDivi.TabIndex = 22;
            this.imgDivi.TabStop = false;
            this.imgDivi.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // imgMulti
            // 
            this.imgMulti.Image = global::Calculadora.Properties.Resources.multiIcon;
            this.imgMulti.Location = new System.Drawing.Point(231, 196);
            this.imgMulti.Name = "imgMulti";
            this.imgMulti.Size = new System.Drawing.Size(55, 50);
            this.imgMulti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMulti.TabIndex = 21;
            this.imgMulti.TabStop = false;
            this.imgMulti.Click += new System.EventHandler(this.imgMulti_Click);
            // 
            // imgResta
            // 
            this.imgResta.Image = global::Calculadora.Properties.Resources.restaIcon;
            this.imgResta.Location = new System.Drawing.Point(292, 140);
            this.imgResta.Name = "imgResta";
            this.imgResta.Size = new System.Drawing.Size(54, 50);
            this.imgResta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgResta.TabIndex = 20;
            this.imgResta.TabStop = false;
            this.imgResta.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgSuma
            // 
            this.imgSuma.Image = global::Calculadora.Properties.Resources.sumaIcon;
            this.imgSuma.Location = new System.Drawing.Point(231, 140);
            this.imgSuma.Name = "imgSuma";
            this.imgSuma.Size = new System.Drawing.Size(55, 50);
            this.imgSuma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSuma.TabIndex = 19;
            this.imgSuma.TabStop = false;
            this.imgSuma.Click += new System.EventHandler(this.imgSuma_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 254);
            this.Controls.Add(this.imgDivi);
            this.Controls.Add(this.imgMulti);
            this.Controls.Add(this.imgResta);
            this.Controls.Add(this.imgSuma);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDivi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMulti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSuma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private System.Windows.Forms.Label txtRespuesta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgSuma;
        private System.Windows.Forms.PictureBox imgResta;
        private System.Windows.Forms.PictureBox imgMulti;
        private System.Windows.Forms.PictureBox imgDivi;
    }
}