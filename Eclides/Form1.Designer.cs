namespace Eclides
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
            this.Txtm = new System.Windows.Forms.TextBox();
            this.Txtn = new System.Windows.Forms.TextBox();
            this.Btnsi = new System.Windows.Forms.Button();
            this.DGWres = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pasodta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ecuaciondata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGWres)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtm
            // 
            this.Txtm.Location = new System.Drawing.Point(155, 98);
            this.Txtm.Name = "Txtm";
            this.Txtm.Size = new System.Drawing.Size(100, 22);
            this.Txtm.TabIndex = 0;
            // 
            // Txtn
            // 
            this.Txtn.Location = new System.Drawing.Point(155, 173);
            this.Txtn.Name = "Txtn";
            this.Txtn.Size = new System.Drawing.Size(100, 22);
            this.Txtn.TabIndex = 1;
            // 
            // Btnsi
            // 
            this.Btnsi.Location = new System.Drawing.Point(353, 121);
            this.Btnsi.Name = "Btnsi";
            this.Btnsi.Size = new System.Drawing.Size(75, 23);
            this.Btnsi.TabIndex = 2;
            this.Btnsi.Text = "Calcular";
            this.Btnsi.UseVisualStyleBackColor = true;
            this.Btnsi.Click += new System.EventHandler(this.Btnsi_Click);
            // 
            // DGWres
            // 
            this.DGWres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGWres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGWres.ColumnHeadersHeight = 29;
            this.DGWres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGWres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pasodta,
            this.Operdata,
            this.Ecuaciondata});
            this.DGWres.Enabled = false;
            this.DGWres.Location = new System.Drawing.Point(12, 212);
            this.DGWres.Name = "DGWres";
            this.DGWres.RowHeadersWidth = 51;
            this.DGWres.RowTemplate.Height = 24;
            this.DGWres.Size = new System.Drawing.Size(785, 227);
            this.DGWres.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "1er Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "2do Numero";
            // 
            // Pasodta
            // 
            this.Pasodta.FillWeight = 40.10695F;
            this.Pasodta.HeaderText = "Paso";
            this.Pasodta.MinimumWidth = 6;
            this.Pasodta.Name = "Pasodta";
            // 
            // Operdata
            // 
            this.Operdata.FillWeight = 129.9465F;
            this.Operdata.HeaderText = "Operacion";
            this.Operdata.MinimumWidth = 6;
            this.Operdata.Name = "Operdata";
            // 
            // Ecuaciondata
            // 
            this.Ecuaciondata.FillWeight = 129.9465F;
            this.Ecuaciondata.HeaderText = "Ecuacion";
            this.Ecuaciondata.MinimumWidth = 6;
            this.Ecuaciondata.Name = "Ecuaciondata";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(465, 120);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fracciones Continuas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGWres);
            this.Controls.Add(this.Btnsi);
            this.Controls.Add(this.Txtn);
            this.Controls.Add(this.Txtm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fracciones continuas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtm;
        private System.Windows.Forms.TextBox Txtn;
        private System.Windows.Forms.Button Btnsi;
        private System.Windows.Forms.DataGridView DGWres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasodta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ecuaciondata;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label4;
    }
}

