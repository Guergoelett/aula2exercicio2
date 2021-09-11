
namespace aula2exercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campo01 = new System.Windows.Forms.TextBox();
            this.campo02 = new System.Windows.Forms.TextBox();
            this.botao1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.campoResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // campo01
            // 
            this.campo01.Location = new System.Drawing.Point(14, 22);
            this.campo01.Name = "campo01";
            this.campo01.Size = new System.Drawing.Size(105, 23);
            this.campo01.TabIndex = 0;
            this.campo01.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // campo02
            // 
            this.campo02.Location = new System.Drawing.Point(178, 22);
            this.campo02.Name = "campo02";
            this.campo02.Size = new System.Drawing.Size(105, 23);
            this.campo02.TabIndex = 1;
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(24, 73);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(94, 27);
            this.botao1.TabIndex = 2;
            this.botao1.Text = "soma";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // campoResultado
            // 
            this.campoResultado.Location = new System.Drawing.Point(74, 285);
            this.campoResultado.Name = "campoResultado";
            this.campoResultado.Size = new System.Drawing.Size(105, 23);
            this.campoResultado.TabIndex = 6;
            this.campoResultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 495);
            this.Controls.Add(this.campoResultado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.campo02);
            this.Controls.Add(this.campo01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campo01;
        private System.Windows.Forms.TextBox campo02;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox campoResultado;
    }
}

