namespace PruebaTecnica_PasajeInteligente.Views
{
    partial class FormCompanyList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompanyList));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListaEmpresa = new System.Windows.Forms.TabPage();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtsAgreEmpre = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BuscarEmpre = new System.Windows.Forms.Button();
            this.TxtBuscarEmpre = new System.Windows.Forms.TextBox();
            this.TablaEmpresa = new System.Windows.Forms.DataGridView();
            this.tabPageDetalleEmpresa = new System.Windows.Forms.TabPage();
            this.CbPais = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtoEditar = new System.Windows.Forms.Button();
            this.CbDeparta = new System.Windows.Forms.ComboBox();
            this.CbCiudad = new System.Windows.Forms.ComboBox();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtGuar = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtNombreEmp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigoEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ImagenLoad = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageListaEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpresa)).BeginInit();
            this.tabPageDetalleEmpresa.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListaEmpresa);
            this.tabControl1.Controls.Add(this.tabPageDetalleEmpresa);
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 541);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPageListaEmpresa
            // 
            this.tabPageListaEmpresa.BackColor = System.Drawing.Color.White;
            this.tabPageListaEmpresa.Controls.Add(this.BtEliminar);
            this.tabPageListaEmpresa.Controls.Add(this.BtEditar);
            this.tabPageListaEmpresa.Controls.Add(this.BtsAgreEmpre);
            this.tabPageListaEmpresa.Controls.Add(this.label8);
            this.tabPageListaEmpresa.Controls.Add(this.BuscarEmpre);
            this.tabPageListaEmpresa.Controls.Add(this.TxtBuscarEmpre);
            this.tabPageListaEmpresa.Controls.Add(this.TablaEmpresa);
            this.tabPageListaEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabPageListaEmpresa.Name = "tabPageListaEmpresa";
            this.tabPageListaEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaEmpresa.Size = new System.Drawing.Size(862, 515);
            this.tabPageListaEmpresa.TabIndex = 0;
            this.tabPageListaEmpresa.Text = "Lista Empresa";
            // 
            // BtEliminar
            // 
            this.BtEliminar.BackColor = System.Drawing.Color.Red;
            this.BtEliminar.FlatAppearance.BorderSize = 0;
            this.BtEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Location = new System.Drawing.Point(686, 150);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(115, 26);
            this.BtEliminar.TabIndex = 6;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtEditar.FlatAppearance.BorderSize = 0;
            this.BtEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BtEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditar.ForeColor = System.Drawing.Color.White;
            this.BtEditar.Location = new System.Drawing.Point(686, 109);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(115, 26);
            this.BtEditar.TabIndex = 5;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = false;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtsAgreEmpre
            // 
            this.BtsAgreEmpre.BackColor = System.Drawing.Color.ForestGreen;
            this.BtsAgreEmpre.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.BtsAgreEmpre.FlatAppearance.BorderSize = 0;
            this.BtsAgreEmpre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.BtsAgreEmpre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtsAgreEmpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtsAgreEmpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtsAgreEmpre.ForeColor = System.Drawing.Color.White;
            this.BtsAgreEmpre.Location = new System.Drawing.Point(686, 68);
            this.BtsAgreEmpre.Name = "BtsAgreEmpre";
            this.BtsAgreEmpre.Size = new System.Drawing.Size(115, 26);
            this.BtsAgreEmpre.TabIndex = 4;
            this.BtsAgreEmpre.Text = "Agregar";
            this.BtsAgreEmpre.UseVisualStyleBackColor = false;
            this.BtsAgreEmpre.Click += new System.EventHandler(this.BtsAgreEmpre_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lista de Empresas";
            // 
            // BuscarEmpre
            // 
            this.BuscarEmpre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(22)))));
            this.BuscarEmpre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(22)))));
            this.BuscarEmpre.FlatAppearance.BorderSize = 0;
            this.BuscarEmpre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(22)))));
            this.BuscarEmpre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.BuscarEmpre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarEmpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarEmpre.ForeColor = System.Drawing.Color.Black;
            this.BuscarEmpre.Location = new System.Drawing.Point(567, 36);
            this.BuscarEmpre.Name = "BuscarEmpre";
            this.BuscarEmpre.Size = new System.Drawing.Size(89, 26);
            this.BuscarEmpre.TabIndex = 2;
            this.BuscarEmpre.Text = "Buscar";
            this.BuscarEmpre.UseVisualStyleBackColor = false;
            this.BuscarEmpre.Click += new System.EventHandler(this.BuscarEmpre_Click);
            // 
            // TxtBuscarEmpre
            // 
            this.TxtBuscarEmpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarEmpre.Location = new System.Drawing.Point(29, 38);
            this.TxtBuscarEmpre.Name = "TxtBuscarEmpre";
            this.TxtBuscarEmpre.Size = new System.Drawing.Size(532, 24);
            this.TxtBuscarEmpre.TabIndex = 1;
            this.TxtBuscarEmpre.TextChanged += new System.EventHandler(this.TxtBuscarEmpre_TextChanged);
            // 
            // TablaEmpresa
            // 
            this.TablaEmpresa.AllowUserToAddRows = false;
            this.TablaEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaEmpresa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TablaEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaEmpresa.ColumnHeadersHeight = 28;
            this.TablaEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(42)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(42)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaEmpresa.EnableHeadersVisualStyles = false;
            this.TablaEmpresa.GridColor = System.Drawing.Color.DimGray;
            this.TablaEmpresa.Location = new System.Drawing.Point(29, 68);
            this.TablaEmpresa.Name = "TablaEmpresa";
            this.TablaEmpresa.ReadOnly = true;
            this.TablaEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaEmpresa.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.TablaEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaEmpresa.Size = new System.Drawing.Size(639, 435);
            this.TablaEmpresa.TabIndex = 0;
            this.TablaEmpresa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TablaEmpresa_MouseClick);
            // 
            // tabPageDetalleEmpresa
            // 
            this.tabPageDetalleEmpresa.BackColor = System.Drawing.Color.White;
            this.tabPageDetalleEmpresa.Controls.Add(this.CbPais);
            this.tabPageDetalleEmpresa.Controls.Add(this.label10);
            this.tabPageDetalleEmpresa.Controls.Add(this.TxtTelefono);
            this.tabPageDetalleEmpresa.Controls.Add(this.panel4);
            this.tabPageDetalleEmpresa.Controls.Add(this.label9);
            this.tabPageDetalleEmpresa.Controls.Add(this.BtoEditar);
            this.tabPageDetalleEmpresa.Controls.Add(this.CbDeparta);
            this.tabPageDetalleEmpresa.Controls.Add(this.CbCiudad);
            this.tabPageDetalleEmpresa.Controls.Add(this.BtCancelar);
            this.tabPageDetalleEmpresa.Controls.Add(this.BtGuar);
            this.tabPageDetalleEmpresa.Controls.Add(this.TxtDireccion);
            this.tabPageDetalleEmpresa.Controls.Add(this.panel3);
            this.tabPageDetalleEmpresa.Controls.Add(this.TxtNombreEmp);
            this.tabPageDetalleEmpresa.Controls.Add(this.panel2);
            this.tabPageDetalleEmpresa.Controls.Add(this.label5);
            this.tabPageDetalleEmpresa.Controls.Add(this.TxtCodigoEmp);
            this.tabPageDetalleEmpresa.Controls.Add(this.label4);
            this.tabPageDetalleEmpresa.Controls.Add(this.panel1);
            this.tabPageDetalleEmpresa.Controls.Add(this.label3);
            this.tabPageDetalleEmpresa.Controls.Add(this.label1);
            this.tabPageDetalleEmpresa.Controls.Add(this.label2);
            this.tabPageDetalleEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetalleEmpresa.Name = "tabPageDetalleEmpresa";
            this.tabPageDetalleEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetalleEmpresa.Size = new System.Drawing.Size(862, 515);
            this.tabPageDetalleEmpresa.TabIndex = 1;
            this.tabPageDetalleEmpresa.Text = "Detalle Empresa";
            // 
            // CbPais
            // 
            this.CbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPais.FormattingEnabled = true;
            this.CbPais.Items.AddRange(new object[] {
            "Colombia"});
            this.CbPais.Location = new System.Drawing.Point(140, 386);
            this.CbPais.Name = "CbPais";
            this.CbPais.Size = new System.Drawing.Size(198, 28);
            this.CbPais.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "País";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtTelefono.Location = new System.Drawing.Point(107, 215);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(269, 20);
            this.TxtTelefono.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(107, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 2);
            this.panel4.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Telefono";
            // 
            // BtoEditar
            // 
            this.BtoEditar.BackColor = System.Drawing.Color.Green;
            this.BtoEditar.FlatAppearance.BorderSize = 0;
            this.BtoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(42)))), ((int)(((byte)(107)))));
            this.BtoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.BtoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtoEditar.ForeColor = System.Drawing.Color.White;
            this.BtoEditar.Location = new System.Drawing.Point(107, 453);
            this.BtoEditar.Name = "BtoEditar";
            this.BtoEditar.Size = new System.Drawing.Size(118, 28);
            this.BtoEditar.TabIndex = 38;
            this.BtoEditar.Text = "Editar";
            this.BtoEditar.UseVisualStyleBackColor = false;
            this.BtoEditar.Click += new System.EventHandler(this.BtoEditar_Click);
            // 
            // CbDeparta
            // 
            this.CbDeparta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDeparta.FormattingEnabled = true;
            this.CbDeparta.Items.AddRange(new object[] {
            "Antioquia",
            "Bogota",
            "Cundinamarca",
            "Valle del cauca",
            "Atlantico",
            "Bolivar",
            "Manizales"});
            this.CbDeparta.Location = new System.Drawing.Point(140, 331);
            this.CbDeparta.Name = "CbDeparta";
            this.CbDeparta.Size = new System.Drawing.Size(198, 28);
            this.CbDeparta.TabIndex = 30;
            // 
            // CbCiudad
            // 
            this.CbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCiudad.FormattingEnabled = true;
            this.CbCiudad.Items.AddRange(new object[] {
            "Medellín",
            "Cali",
            "Bogota",
            "Bucaramanga",
            "Barranquilla",
            "Cartagena",
            "Caldas",
            "Pereira"});
            this.CbCiudad.Location = new System.Drawing.Point(140, 271);
            this.CbCiudad.Name = "CbCiudad";
            this.CbCiudad.Size = new System.Drawing.Size(198, 28);
            this.CbCiudad.TabIndex = 29;
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.Gray;
            this.BtCancelar.FlatAppearance.BorderSize = 0;
            this.BtCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.ForeColor = System.Drawing.Color.White;
            this.BtCancelar.Location = new System.Drawing.Point(258, 453);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(118, 28);
            this.BtCancelar.TabIndex = 27;
            this.BtCancelar.Text = "Cancelar ";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtGuar
            // 
            this.BtGuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(42)))), ((int)(((byte)(107)))));
            this.BtGuar.FlatAppearance.BorderSize = 0;
            this.BtGuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(42)))), ((int)(((byte)(107)))));
            this.BtGuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(42)))), ((int)(((byte)(216)))));
            this.BtGuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuar.ForeColor = System.Drawing.Color.White;
            this.BtGuar.Location = new System.Drawing.Point(107, 453);
            this.BtGuar.Name = "BtGuar";
            this.BtGuar.Size = new System.Drawing.Size(118, 28);
            this.BtGuar.TabIndex = 26;
            this.BtGuar.Text = "Guardar";
            this.BtGuar.UseVisualStyleBackColor = false;
            this.BtGuar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.ForeColor = System.Drawing.Color.Black;
            this.TxtDireccion.Location = new System.Drawing.Point(107, 162);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(269, 20);
            this.TxtDireccion.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(107, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 2);
            this.panel3.TabIndex = 25;
            // 
            // TxtNombreEmp
            // 
            this.TxtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmp.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreEmp.Location = new System.Drawing.Point(107, 108);
            this.TxtNombreEmp.Name = "TxtNombreEmp";
            this.TxtNombreEmp.Size = new System.Drawing.Size(269, 20);
            this.TxtNombreEmp.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(107, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 2);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Departamento";
            // 
            // TxtCodigoEmp
            // 
            this.TxtCodigoEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigoEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoEmp.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoEmp.Location = new System.Drawing.Point(107, 50);
            this.TxtCodigoEmp.Name = "TxtCodigoEmp";
            this.TxtCodigoEmp.Size = new System.Drawing.Size(269, 20);
            this.TxtCodigoEmp.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ciudad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(107, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 2);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(870, 38);
            this.panel5.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Form Company List";
            // 
            // ImagenLoad
            // 
            this.ImagenLoad.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLoad.Image")));
            this.ImagenLoad.Location = new System.Drawing.Point(2, 0);
            this.ImagenLoad.Name = "ImagenLoad";
            this.ImagenLoad.Size = new System.Drawing.Size(868, 621);
            this.ImagenLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenLoad.TabIndex = 20;
            this.ImagenLoad.TabStop = false;
            // 
            // FormCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(870, 579);
            this.Controls.Add(this.ImagenLoad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompanyList";
            this.Text = "FormCompanyList";
            this.Load += new System.EventHandler(this.FormCompanyList_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListaEmpresa.ResumeLayout(false);
            this.tabPageListaEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpresa)).EndInit();
            this.tabPageDetalleEmpresa.ResumeLayout(false);
            this.tabPageDetalleEmpresa.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListaEmpresa;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtsAgreEmpre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BuscarEmpre;
        private System.Windows.Forms.TextBox TxtBuscarEmpre;
        private System.Windows.Forms.DataGridView TablaEmpresa;
        private System.Windows.Forms.TabPage tabPageDetalleEmpresa;
        private System.Windows.Forms.Button BtoEditar;
        private System.Windows.Forms.ComboBox CbDeparta;
        private System.Windows.Forms.ComboBox CbCiudad;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtGuar;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtNombreEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigoEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbPais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox ImagenLoad;
    }
}