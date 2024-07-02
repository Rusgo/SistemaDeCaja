namespace GestionNegocio.Ventanas
{
    partial class Productos
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_marca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cargam = new System.Windows.Forms.Button();
            this.btn_cargac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_precioc = new System.Windows.Forms.TextBox();
            this.txt_preciov = new System.Windows.Forms.TextBox();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_filtro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(88, 104);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(223, 20);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(88, 143);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(223, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Items.AddRange(new object[] {
            "GALLETITAS Y GOLOSINAS",
            "SIN CLASIFICAR",
            "PASTAS Y PIZZAS",
            "ALMACEN",
            "BEBIDAS CON ALCOHOL",
            "ROPA",
            "KIOSCO",
            "MASCOTAS",
            "BEBIDAS SIN ALCOHOL",
            "LIMPIEZA",
            "OTROS RUBROS",
            "BAZAR",
            "FIAMBRERÍA",
            "MAMÁS Y BEBÉS",
            "PERFUMERÍA",
            "ALIMENTOS CONGELADOS",
            "FERRETERÍA",
            "LÁCTEOS",
            "LACTEOS",
            "MEDICAMENTOS",
            "BEBIDAS",
            "PASTAS FRESCAS",
            "PANADERÍA",
            "FARMACIA",
            "VARIOS",
            "BLANCO Y MANTELERÍA",
            "BALANCEADOS",
            "CARNICERIA",
            "JUGUETERÍA",
            "AUTOMOTOR",
            "PANIFICACION",
            "CAMPING",
            "LIBRERÍA",
            "HELADOS",
            "ELECTRODOMÉTICOS",
            "PESCADERIA",
            "JARDINERÍA",
            "PESCADOS Y MARISCOS"});
            this.cbo_categoria.Location = new System.Drawing.Point(88, 304);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(223, 21);
            this.cbo_categoria.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(1, 415);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(82, 415);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(163, 415);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(244, 415);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(105, 23);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filtrar por:";
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Items.AddRange(new object[] {
            "codigo",
            "descripcion",
            "marca",
            "categoria"});
            this.cbo_filtro.Location = new System.Drawing.Point(425, 12);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(344, 21);
            this.cbo_filtro.TabIndex = 14;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.preciov,
            this.precioc,
            this.marca,
            this.categoria});
            this.dgv_productos.Location = new System.Drawing.Point(369, 95);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.Size = new System.Drawing.Size(419, 313);
            this.dgv_productos.TabIndex = 16;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            this.dgv_productos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellValueChanged);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "descripcion";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // preciov
            // 
            this.preciov.DataPropertyName = "precio_v";
            this.preciov.HeaderText = "Precio de venta";
            this.preciov.Name = "preciov";
            this.preciov.ReadOnly = true;
            // 
            // precioc
            // 
            this.precioc.DataPropertyName = "precio_c";
            this.precioc.HeaderText = "Precio de Compra";
            this.precioc.Name = "precioc";
            this.precioc.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // cbo_marca
            // 
            this.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_marca.FormattingEnabled = true;
            this.cbo_marca.Location = new System.Drawing.Point(88, 181);
            this.cbo_marca.Name = "cbo_marca";
            this.cbo_marca.Size = new System.Drawing.Size(223, 21);
            this.cbo_marca.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio compra:";
            // 
            // btn_cargam
            // 
            this.btn_cargam.Location = new System.Drawing.Point(6, 341);
            this.btn_cargam.Name = "btn_cargam";
            this.btn_cargam.Size = new System.Drawing.Size(84, 23);
            this.btn_cargam.TabIndex = 20;
            this.btn_cargam.Text = "Cargar Marca";
            this.btn_cargam.UseVisualStyleBackColor = true;
            this.btn_cargam.Click += new System.EventHandler(this.btn_cargam_Click);
            // 
            // btn_cargac
            // 
            this.btn_cargac.Location = new System.Drawing.Point(115, 341);
            this.btn_cargac.Name = "btn_cargac";
            this.btn_cargac.Size = new System.Drawing.Size(98, 23);
            this.btn_cargac.TabIndex = 21;
            this.btn_cargac.Text = "Cargar Categoria";
            this.btn_cargac.UseVisualStyleBackColor = true;
            this.btn_cargac.Click += new System.EventHandler(this.btn_cargac_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_precioc
            // 
            this.txt_precioc.Location = new System.Drawing.Point(88, 221);
            this.txt_precioc.Name = "txt_precioc";
            this.txt_precioc.Size = new System.Drawing.Size(223, 20);
            this.txt_precioc.TabIndex = 23;
            // 
            // txt_preciov
            // 
            this.txt_preciov.Location = new System.Drawing.Point(88, 261);
            this.txt_preciov.Name = "txt_preciov";
            this.txt_preciov.Size = new System.Drawing.Size(223, 20);
            this.txt_preciov.TabIndex = 24;
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(369, 52);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(319, 20);
            this.txt_filtro.TabIndex = 25;
            this.txt_filtro.TextChanged += new System.EventHandler(this.txt_filtro_TextChanged);
            // 
            // btn_filtro
            // 
            this.btn_filtro.Location = new System.Drawing.Point(694, 49);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(75, 23);
            this.btn_filtro.TabIndex = 26;
            this.btn_filtro.Text = "Filtrar";
            this.btn_filtro.UseVisualStyleBackColor = true;
            this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.txt_preciov);
            this.Controls.Add(this.txt_precioc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cargac);
            this.Controls.Add(this.btn_cargam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_marca);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_filtro);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.MaximizeBox = false;
            this.Name = "Productos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.ComboBox cbo_marca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciov;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioc;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.Button btn_cargam;
        private System.Windows.Forms.Button btn_cargac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_precioc;
        private System.Windows.Forms.TextBox txt_preciov;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_filtro;
    }
}