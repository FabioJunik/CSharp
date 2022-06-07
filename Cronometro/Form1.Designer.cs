namespace Cronometro_0._1
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
            this.components = new System.ComponentModel.Container();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_zerar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_parar
            // 
            this.btn_parar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_parar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parar.Location = new System.Drawing.Point(16, 79);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(114, 47);
            this.btn_parar.TabIndex = 1;
            this.btn_parar.Text = "Stop";
            this.btn_parar.UseVisualStyleBackColor = false;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_zerar
            // 
            this.btn_zerar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_zerar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zerar.Location = new System.Drawing.Point(138, 79);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(114, 47);
            this.btn_zerar.TabIndex = 2;
            this.btn_zerar.Text = "Reset";
            this.btn_zerar.UseVisualStyleBackColor = false;
            this.btn_zerar.Click += new System.EventHandler(this.btn_zerar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_iniciar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(16, 132);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(236, 51);
            this.btn_iniciar.TabIndex = 3;
            this.btn_iniciar.Text = "Start";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(264, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.btn_zerar);
            this.Controls.Add(this.btn_parar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_zerar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

