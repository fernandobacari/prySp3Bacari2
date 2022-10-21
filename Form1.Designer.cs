
namespace prySp3Bacari
{
    partial class frmAutoTest
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
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.numAñoFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNumeroTurno = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblTutular = new System.Windows.Forms.Label();
            this.lblAñoFabricacion = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumerodeTurno = new System.Windows.Forms.Label();
            this.grbEstadistica = new System.Windows.Forms.GroupBox();
            this.txtCantidadDominio = new System.Windows.Forms.TextBox();
            this.txtAñoAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.lblCantidad6Caracteres = new System.Windows.Forms.Label();
            this.lblAñoAntiguo = new System.Windows.Forms.Label();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFabricacion)).BeginInit();
            this.grbEstadistica.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistro
            // 
            this.grbRegistro.Controls.Add(this.numAñoFabricacion);
            this.grbRegistro.Controls.Add(this.txtDominio);
            this.grbRegistro.Controls.Add(this.txtNumeroTurno);
            this.grbRegistro.Controls.Add(this.txtTitular);
            this.grbRegistro.Controls.Add(this.lblTutular);
            this.grbRegistro.Controls.Add(this.lblAñoFabricacion);
            this.grbRegistro.Controls.Add(this.lblDominio);
            this.grbRegistro.Controls.Add(this.lblNumerodeTurno);
            this.grbRegistro.Location = new System.Drawing.Point(2, 5);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Size = new System.Drawing.Size(376, 200);
            this.grbRegistro.TabIndex = 0;
            this.grbRegistro.TabStop = false;
            this.grbRegistro.Text = "Registro de Turno";
            // 
            // numAñoFabricacion
            // 
            this.numAñoFabricacion.Location = new System.Drawing.Point(201, 106);
            this.numAñoFabricacion.Name = "numAñoFabricacion";
            this.numAñoFabricacion.Size = new System.Drawing.Size(60, 20);
            this.numAñoFabricacion.TabIndex = 7;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(201, 61);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 6;
            // 
            // txtNumeroTurno
            // 
            this.txtNumeroTurno.Location = new System.Drawing.Point(201, 19);
            this.txtNumeroTurno.Name = "txtNumeroTurno";
            this.txtNumeroTurno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTurno.TabIndex = 5;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(201, 158);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 4;
            // 
            // lblTutular
            // 
            this.lblTutular.AutoSize = true;
            this.lblTutular.Location = new System.Drawing.Point(19, 165);
            this.lblTutular.Name = "lblTutular";
            this.lblTutular.Size = new System.Drawing.Size(36, 13);
            this.lblTutular.TabIndex = 3;
            this.lblTutular.Text = "Titular";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(19, 113);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(84, 13);
            this.lblAñoFabricacion.TabIndex = 2;
            this.lblAñoFabricacion.Text = "Año Fabricacion";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(19, 68);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumerodeTurno
            // 
            this.lblNumerodeTurno.AutoSize = true;
            this.lblNumerodeTurno.Location = new System.Drawing.Point(19, 26);
            this.lblNumerodeTurno.Name = "lblNumerodeTurno";
            this.lblNumerodeTurno.Size = new System.Drawing.Size(90, 13);
            this.lblNumerodeTurno.TabIndex = 0;
            this.lblNumerodeTurno.Text = "Numero de Turno";
            // 
            // grbEstadistica
            // 
            this.grbEstadistica.Controls.Add(this.txtCantidadDominio);
            this.grbEstadistica.Controls.Add(this.txtAñoAntiguo);
            this.grbEstadistica.Controls.Add(this.txtCantidadTurnos);
            this.grbEstadistica.Controls.Add(this.lblCantidad6Caracteres);
            this.grbEstadistica.Controls.Add(this.lblAñoAntiguo);
            this.grbEstadistica.Controls.Add(this.lblCantidadTurnos);
            this.grbEstadistica.Location = new System.Drawing.Point(2, 211);
            this.grbEstadistica.Name = "grbEstadistica";
            this.grbEstadistica.Size = new System.Drawing.Size(376, 227);
            this.grbEstadistica.TabIndex = 1;
            this.grbEstadistica.TabStop = false;
            this.grbEstadistica.Text = "Estadistica";
            // 
            // txtCantidadDominio
            // 
            this.txtCantidadDominio.Location = new System.Drawing.Point(201, 148);
            this.txtCantidadDominio.Name = "txtCantidadDominio";
            this.txtCantidadDominio.Size = new System.Drawing.Size(60, 20);
            this.txtCantidadDominio.TabIndex = 5;
            // 
            // txtAñoAntiguo
            // 
            this.txtAñoAntiguo.Location = new System.Drawing.Point(201, 87);
            this.txtAñoAntiguo.Name = "txtAñoAntiguo";
            this.txtAñoAntiguo.Size = new System.Drawing.Size(60, 20);
            this.txtAñoAntiguo.TabIndex = 4;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(201, 34);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.Size = new System.Drawing.Size(60, 20);
            this.txtCantidadTurnos.TabIndex = 3;
            // 
            // lblCantidad6Caracteres
            // 
            this.lblCantidad6Caracteres.AutoSize = true;
            this.lblCantidad6Caracteres.Location = new System.Drawing.Point(19, 151);
            this.lblCantidad6Caracteres.Name = "lblCantidad6Caracteres";
            this.lblCantidad6Caracteres.Size = new System.Drawing.Size(174, 13);
            this.lblCantidad6Caracteres.TabIndex = 2;
            this.lblCantidad6Caracteres.Text = "Cantidad con Dominio 6 Caracteres";
            // 
            // lblAñoAntiguo
            // 
            this.lblAñoAntiguo.AutoSize = true;
            this.lblAñoAntiguo.Location = new System.Drawing.Point(19, 94);
            this.lblAñoAntiguo.Name = "lblAñoAntiguo";
            this.lblAñoAntiguo.Size = new System.Drawing.Size(104, 13);
            this.lblAñoAntiguo.TabIndex = 1;
            this.lblAñoAntiguo.Text = "Año del mas Antiguo";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(19, 41);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(85, 13);
            this.lblCantidadTurnos.TabIndex = 0;
            this.lblCantidadTurnos.Text = "Cantidad Turnos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(453, 31);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(453, 108);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(453, 295);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consaultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grbEstadistica);
            this.Controls.Add(this.grbRegistro);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.grbRegistro.ResumeLayout(false);
            this.grbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFabricacion)).EndInit();
            this.grbEstadistica.ResumeLayout(false);
            this.grbEstadistica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.NumericUpDown numAñoFabricacion;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumeroTurno;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblTutular;
        private System.Windows.Forms.Label lblAñoFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumerodeTurno;
        private System.Windows.Forms.GroupBox grbEstadistica;
        private System.Windows.Forms.TextBox txtCantidadDominio;
        private System.Windows.Forms.TextBox txtAñoAntiguo;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.Label lblCantidad6Caracteres;
        private System.Windows.Forms.Label lblAñoAntiguo;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}

