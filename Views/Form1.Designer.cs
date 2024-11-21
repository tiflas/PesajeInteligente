namespace PruebaTecnica_PasajeInteligente
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtCompanyEditor = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtCompanyList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(42)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.BtCompanyEditor);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtCompanyList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 639);
            this.panel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.panel7.Location = new System.Drawing.Point(0, 195);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(9, 39);
            this.panel7.TabIndex = 10;
            // 
            // BtCompanyEditor
            // 
            this.BtCompanyEditor.FlatAppearance.BorderSize = 0;
            this.BtCompanyEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.BtCompanyEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.BtCompanyEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCompanyEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCompanyEditor.ForeColor = System.Drawing.SystemColors.Control;
            this.BtCompanyEditor.Image = ((System.Drawing.Image)(resources.GetObject("BtCompanyEditor.Image")));
            this.BtCompanyEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCompanyEditor.Location = new System.Drawing.Point(8, 195);
            this.BtCompanyEditor.Name = "BtCompanyEditor";
            this.BtCompanyEditor.Size = new System.Drawing.Size(202, 39);
            this.BtCompanyEditor.TabIndex = 9;
            this.BtCompanyEditor.Text = " FormCompanyEditor";
            this.BtCompanyEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCompanyEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCompanyEditor.UseVisualStyleBackColor = true;
            this.BtCompanyEditor.Click += new System.EventHandler(this.BtCompanyEditor_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(29)))), ((int)(((byte)(76)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 117);
            this.panel6.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 39);
            this.panel2.TabIndex = 7;
            // 
            // BtCompanyList
            // 
            this.BtCompanyList.FlatAppearance.BorderSize = 0;
            this.BtCompanyList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.BtCompanyList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.BtCompanyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCompanyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCompanyList.ForeColor = System.Drawing.SystemColors.Control;
            this.BtCompanyList.Image = ((System.Drawing.Image)(resources.GetObject("BtCompanyList.Image")));
            this.BtCompanyList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCompanyList.Location = new System.Drawing.Point(8, 141);
            this.BtCompanyList.Name = "BtCompanyList";
            this.BtCompanyList.Size = new System.Drawing.Size(200, 39);
            this.BtCompanyList.TabIndex = 6;
            this.BtCompanyList.Text = " FormCompanyList";
            this.BtCompanyList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCompanyList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCompanyList.UseVisualStyleBackColor = true;
            this.BtCompanyList.Click += new System.EventHandler(this.BtCompanyList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deshboard";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelContenedor.Location = new System.Drawing.Point(210, 58);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(831, 581);
            this.PanelContenedor.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1041, 639);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtCompanyEditor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtCompanyList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}

