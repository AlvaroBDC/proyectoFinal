namespace proyectoFinal
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuNuevoUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuPagos = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCuentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuReporte = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNuevoUsuario,
            this.MenuPagos,
            this.MenuCuentas,
            this.menuReporte});
            this.menu.Location = new System.Drawing.Point(0, 53);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(779, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuNuevoUsuario
            // 
            this.menuNuevoUsuario.AutoSize = false;
            this.menuNuevoUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuNuevoUsuario.IconColor = System.Drawing.Color.Black;
            this.menuNuevoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuNuevoUsuario.IconSize = 50;
            this.menuNuevoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuNuevoUsuario.Name = "menuNuevoUsuario";
            this.menuNuevoUsuario.Size = new System.Drawing.Size(122, 69);
            this.menuNuevoUsuario.Text = "Nuevos Usuarios";
            this.menuNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuNuevoUsuario.Click += new System.EventHandler(this.menuNuevoUsuario_Click);
            // 
            // MenuPagos
            // 
            this.MenuPagos.AutoSize = false;
            this.MenuPagos.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.MenuPagos.IconColor = System.Drawing.Color.Black;
            this.MenuPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuPagos.IconSize = 50;
            this.MenuPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuPagos.Name = "MenuPagos";
            this.MenuPagos.Size = new System.Drawing.Size(122, 69);
            this.MenuPagos.Text = "Pagos";
            this.MenuPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuPagos.Click += new System.EventHandler(this.MenuPagos_Click);
            // 
            // MenuCuentas
            // 
            this.MenuCuentas.AutoSize = false;
            this.MenuCuentas.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuCuentas.IconColor = System.Drawing.Color.Black;
            this.MenuCuentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCuentas.IconSize = 50;
            this.MenuCuentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCuentas.Name = "MenuCuentas";
            this.MenuCuentas.Size = new System.Drawing.Size(122, 69);
            this.MenuCuentas.Text = "Cuentas";
            this.MenuCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuCuentas.Click += new System.EventHandler(this.MenuCuentas_Click);
            // 
            // menuReporte
            // 
            this.menuReporte.AutoSize = false;
            this.menuReporte.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReporte.IconColor = System.Drawing.Color.Black;
            this.menuReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReporte.IconSize = 50;
            this.menuReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReporte.Name = "menuReporte";
            this.menuReporte.Size = new System.Drawing.Size(122, 69);
            this.menuReporte.Text = "Reporte";
            this.menuReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReporte.Click += new System.EventHandler(this.menuReporte_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(779, 53);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema Institucion Educativa";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 126);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(779, 407);
            this.contenedor.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(676, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 37);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(779, 533);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuReporte;
        private FontAwesome.Sharp.IconMenuItem menuNuevoUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuPagos;
        private FontAwesome.Sharp.IconMenuItem MenuCuentas;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}

