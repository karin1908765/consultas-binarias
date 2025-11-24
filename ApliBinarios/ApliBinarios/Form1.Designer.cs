namespace ApliBinarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dgvConsultas = new System.Windows.Forms.DataGridView();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.dgvConsultasI = new System.Windows.Forms.DataGridView();
			this.btnConsultaI = new System.Windows.Forms.Button();
			this.btnConsultaI2 = new System.Windows.Forms.Button();
			this.btnConsultaI3 = new System.Windows.Forms.Button();
			this.dgvConsultasD = new System.Windows.Forms.DataGridView();
			this.btnConsultaD = new System.Windows.Forms.Button();
			this.btnConsultaD2 = new System.Windows.Forms.Button();
			this.btnConsultaD3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultasI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultasD)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(9, 10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(788, 438);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btn3);
			this.tabPage1.Controls.Add(this.btn2);
			this.tabPage1.Controls.Add(this.btn1);
			this.tabPage1.Controls.Add(this.dgvConsultas);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(780, 409);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Union";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnConsultaI3);
			this.tabPage2.Controls.Add(this.btnConsultaI2);
			this.tabPage2.Controls.Add(this.btnConsultaI);
			this.tabPage2.Controls.Add(this.dgvConsultasI);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(780, 409);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Inserccion";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnConsultaD3);
			this.tabPage3.Controls.Add(this.btnConsultaD2);
			this.tabPage3.Controls.Add(this.btnConsultaD);
			this.tabPage3.Controls.Add(this.dgvConsultasD);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(780, 409);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Diferencia";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dgvConsultas
			// 
			this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsultas.Location = new System.Drawing.Point(7, 39);
			this.dgvConsultas.Name = "dgvConsultas";
			this.dgvConsultas.RowHeadersWidth = 51;
			this.dgvConsultas.RowTemplate.Height = 24;
			this.dgvConsultas.Size = new System.Drawing.Size(763, 369);
			this.dgvConsultas.TabIndex = 0;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(7, 6);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(98, 27);
			this.btn1.TabIndex = 1;
			this.btn1.Text = "Consulta 1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(111, 8);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(94, 23);
			this.btn2.TabIndex = 2;
			this.btn2.Text = "Consulta 2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(220, 8);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(105, 23);
			this.btn3.TabIndex = 3;
			this.btn3.Text = "Consulta 3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// dgvConsultasI
			// 
			this.dgvConsultasI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsultasI.Location = new System.Drawing.Point(15, 37);
			this.dgvConsultasI.Name = "dgvConsultasI";
			this.dgvConsultasI.RowHeadersWidth = 51;
			this.dgvConsultasI.RowTemplate.Height = 24;
			this.dgvConsultasI.Size = new System.Drawing.Size(752, 359);
			this.dgvConsultasI.TabIndex = 0;
			// 
			// btnConsultaI
			// 
			this.btnConsultaI.Location = new System.Drawing.Point(15, 8);
			this.btnConsultaI.Name = "btnConsultaI";
			this.btnConsultaI.Size = new System.Drawing.Size(110, 23);
			this.btnConsultaI.TabIndex = 1;
			this.btnConsultaI.Text = "Consulta 1";
			this.btnConsultaI.UseVisualStyleBackColor = true;
			this.btnConsultaI.Click += new System.EventHandler(this.btnConsultaI_Click);
			// 
			// btnConsultaI2
			// 
			this.btnConsultaI2.Location = new System.Drawing.Point(147, 8);
			this.btnConsultaI2.Name = "btnConsultaI2";
			this.btnConsultaI2.Size = new System.Drawing.Size(110, 23);
			this.btnConsultaI2.TabIndex = 2;
			this.btnConsultaI2.Text = "Consulta 2";
			this.btnConsultaI2.UseVisualStyleBackColor = true;
			this.btnConsultaI2.Click += new System.EventHandler(this.btnConsultaI2_Click);
			// 
			// btnConsultaI3
			// 
			this.btnConsultaI3.Location = new System.Drawing.Point(296, 6);
			this.btnConsultaI3.Name = "btnConsultaI3";
			this.btnConsultaI3.Size = new System.Drawing.Size(110, 23);
			this.btnConsultaI3.TabIndex = 3;
			this.btnConsultaI3.Text = "Consulta 3";
			this.btnConsultaI3.UseVisualStyleBackColor = true;
			this.btnConsultaI3.Click += new System.EventHandler(this.btnConsultaI3_Click);
			// 
			// dgvConsultasD
			// 
			this.dgvConsultasD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConsultasD.Location = new System.Drawing.Point(7, 52);
			this.dgvConsultasD.Name = "dgvConsultasD";
			this.dgvConsultasD.RowHeadersWidth = 51;
			this.dgvConsultasD.RowTemplate.Height = 24;
			this.dgvConsultasD.Size = new System.Drawing.Size(763, 356);
			this.dgvConsultasD.TabIndex = 0;
			// 
			// btnConsultaD
			// 
			this.btnConsultaD.Location = new System.Drawing.Point(18, 8);
			this.btnConsultaD.Name = "btnConsultaD";
			this.btnConsultaD.Size = new System.Drawing.Size(119, 26);
			this.btnConsultaD.TabIndex = 1;
			this.btnConsultaD.Text = "Consulta1";
			this.btnConsultaD.UseVisualStyleBackColor = true;
			this.btnConsultaD.Click += new System.EventHandler(this.btnConsultaD_Click);
			// 
			// btnConsultaD2
			// 
			this.btnConsultaD2.Location = new System.Drawing.Point(153, 8);
			this.btnConsultaD2.Name = "btnConsultaD2";
			this.btnConsultaD2.Size = new System.Drawing.Size(119, 26);
			this.btnConsultaD2.TabIndex = 2;
			this.btnConsultaD2.Text = "Consulta2";
			this.btnConsultaD2.UseVisualStyleBackColor = true;
			this.btnConsultaD2.Click += new System.EventHandler(this.btnConsultaD2_Click);
			// 
			// btnConsultaD3
			// 
			this.btnConsultaD3.Location = new System.Drawing.Point(316, 8);
			this.btnConsultaD3.Name = "btnConsultaD3";
			this.btnConsultaD3.Size = new System.Drawing.Size(119, 26);
			this.btnConsultaD3.TabIndex = 3;
			this.btnConsultaD3.Text = "Consulta3";
			this.btnConsultaD3.UseVisualStyleBackColor = true;
			this.btnConsultaD3.Click += new System.EventHandler(this.btnConsultaD3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultasI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvConsultasD)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dgvConsultasI;
        private System.Windows.Forms.Button btnConsultaI3;
        private System.Windows.Forms.Button btnConsultaI2;
        private System.Windows.Forms.Button btnConsultaI;
        private System.Windows.Forms.Button btnConsultaD3;
        private System.Windows.Forms.Button btnConsultaD2;
        private System.Windows.Forms.Button btnConsultaD;
        private System.Windows.Forms.DataGridView dgvConsultasD;
    }
}

