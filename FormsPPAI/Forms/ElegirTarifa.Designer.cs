
namespace Dashbord {
	partial class ElegirTarifa {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirTarifa));
			this.panelRV = new System.Windows.Forms.Panel();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.pibUsuario = new System.Windows.Forms.PictureBox();
			this.lblCargo = new System.Windows.Forms.Label();
			this.lblVentaEntradas = new System.Windows.Forms.Label();
			this.lblTipoVisita = new System.Windows.Forms.Label();
			this.lblTipoEntrada = new System.Windows.Forms.Label();
			this.cmbEntrada = new System.Windows.Forms.ComboBox();
			this.cmbVisita = new System.Windows.Forms.ComboBox();
			this.lblServicioGuia = new System.Windows.Forms.Label();
			this.rdoSi = new System.Windows.Forms.RadioButton();
			this.rdoNo = new System.Windows.Forms.RadioButton();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCloseForm = new System.Windows.Forms.Button();
			this.pnlServicioGuia = new System.Windows.Forms.Panel();
			this.panelRV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).BeginInit();
			this.pnlServicioGuia.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelRV
			// 
			this.panelRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
			this.panelRV.Controls.Add(this.btnCerrarSesion);
			this.panelRV.Controls.Add(this.pibUsuario);
			this.panelRV.Controls.Add(this.lblCargo);
			this.panelRV.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRV.Location = new System.Drawing.Point(0, 0);
			this.panelRV.Name = "panelRV";
			this.panelRV.Size = new System.Drawing.Size(200, 542);
			this.panelRV.TabIndex = 1;
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCerrarSesion.Location = new System.Drawing.Point(43, 428);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(114, 58);
			this.btnCerrarSesion.TabIndex = 4;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			// 
			// pibUsuario
			// 
			this.pibUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pibUsuario.Image")));
			this.pibUsuario.Location = new System.Drawing.Point(0, 12);
			this.pibUsuario.Name = "pibUsuario";
			this.pibUsuario.Size = new System.Drawing.Size(200, 97);
			this.pibUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibUsuario.TabIndex = 3;
			this.pibUsuario.TabStop = false;
			// 
			// lblCargo
			// 
			this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblCargo.Location = new System.Drawing.Point(3, 112);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(197, 61);
			this.lblCargo.TabIndex = 2;
			this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVentaEntradas
			// 
			this.lblVentaEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.lblVentaEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVentaEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblVentaEntradas.Location = new System.Drawing.Point(295, 66);
			this.lblVentaEntradas.Name = "lblVentaEntradas";
			this.lblVentaEntradas.Size = new System.Drawing.Size(406, 72);
			this.lblVentaEntradas.TabIndex = 2;
			this.lblVentaEntradas.Text = "Venta de Entradas";
			this.lblVentaEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTipoVisita
			// 
			this.lblTipoVisita.AutoSize = true;
			this.lblTipoVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoVisita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblTipoVisita.Location = new System.Drawing.Point(396, 235);
			this.lblTipoVisita.Name = "lblTipoVisita";
			this.lblTipoVisita.Size = new System.Drawing.Size(143, 25);
			this.lblTipoVisita.TabIndex = 5;
			this.lblTipoVisita.Text = "Tipo de Visita";
			this.lblTipoVisita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblTipoEntrada
			// 
			this.lblTipoEntrada.AutoSize = true;
			this.lblTipoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblTipoEntrada.Location = new System.Drawing.Point(396, 159);
			this.lblTipoEntrada.Name = "lblTipoEntrada";
			this.lblTipoEntrada.Size = new System.Drawing.Size(165, 25);
			this.lblTipoEntrada.TabIndex = 6;
			this.lblTipoEntrada.Text = "Tipo de Entrada";
			this.lblTipoEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmbEntrada
			// 
			this.cmbEntrada.AllowDrop = true;
			this.cmbEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
			this.cmbEntrada.DisplayMember = "\"id\"";
			this.cmbEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.cmbEntrada.FormattingEnabled = true;
			this.cmbEntrada.Location = new System.Drawing.Point(401, 190);
			this.cmbEntrada.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.cmbEntrada.Name = "cmbEntrada";
			this.cmbEntrada.Size = new System.Drawing.Size(189, 21);
			this.cmbEntrada.TabIndex = 7;
			this.cmbEntrada.ValueMember = "nombre";
			// 
			// cmbVisita
			// 
			this.cmbVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(141)))));
			this.cmbVisita.DisplayMember = "\"id\"";
			this.cmbVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVisita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmbVisita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.cmbVisita.FormattingEnabled = true;
			this.cmbVisita.Location = new System.Drawing.Point(402, 266);
			this.cmbVisita.Name = "cmbVisita";
			this.cmbVisita.Size = new System.Drawing.Size(189, 21);
			this.cmbVisita.TabIndex = 8;
			this.cmbVisita.ValueMember = "nombre";
			// 
			// lblServicioGuia
			// 
			this.lblServicioGuia.AutoSize = true;
			this.lblServicioGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServicioGuia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblServicioGuia.Location = new System.Drawing.Point(400, 324);
			this.lblServicioGuia.Name = "lblServicioGuia";
			this.lblServicioGuia.Size = new System.Drawing.Size(170, 25);
			this.lblServicioGuia.TabIndex = 9;
			this.lblServicioGuia.Text = "Servicio de Guía";
			this.lblServicioGuia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rdoSi
			// 
			this.rdoSi.AutoSize = true;
			this.rdoSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.rdoSi.Location = new System.Drawing.Point(23, 47);
			this.rdoSi.Name = "rdoSi";
			this.rdoSi.Size = new System.Drawing.Size(38, 20);
			this.rdoSi.TabIndex = 10;
			this.rdoSi.TabStop = true;
			this.rdoSi.Text = "Sí";
			this.rdoSi.UseVisualStyleBackColor = true;
			// 
			// rdoNo
			// 
			this.rdoNo.AutoSize = true;
			this.rdoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.rdoNo.Location = new System.Drawing.Point(523, 355);
			this.rdoNo.Name = "rdoNo";
			this.rdoNo.Size = new System.Drawing.Size(44, 20);
			this.rdoNo.TabIndex = 11;
			this.rdoNo.TabStop = true;
			this.rdoNo.Text = "No";
			this.rdoNo.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnAceptar.Location = new System.Drawing.Point(419, 418);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(151, 41);
			this.btnAceptar.TabIndex = 13;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCloseForm.Location = new System.Drawing.Point(749, 0);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(43, 40);
			this.btnCloseForm.TabIndex = 21;
			this.btnCloseForm.Text = "X";
			this.btnCloseForm.UseVisualStyleBackColor = false;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// pnlServicioGuia
			// 
			this.pnlServicioGuia.Controls.Add(this.rdoSi);
			this.pnlServicioGuia.Location = new System.Drawing.Point(382, 308);
			this.pnlServicioGuia.Name = "pnlServicioGuia";
			this.pnlServicioGuia.Size = new System.Drawing.Size(223, 84);
			this.pnlServicioGuia.TabIndex = 22;
			// 
			// ElegirTarifa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(790, 542);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.rdoNo);
			this.Controls.Add(this.lblServicioGuia);
			this.Controls.Add(this.cmbVisita);
			this.Controls.Add(this.cmbEntrada);
			this.Controls.Add(this.lblTipoEntrada);
			this.Controls.Add(this.lblTipoVisita);
			this.Controls.Add(this.lblVentaEntradas);
			this.Controls.Add(this.panelRV);
			this.Controls.Add(this.pnlServicioGuia);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ElegirTarifa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.ElegirTarifa_Load);
			this.panelRV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).EndInit();
			this.pnlServicioGuia.ResumeLayout(false);
			this.pnlServicioGuia.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelRV;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.PictureBox pibUsuario;
		private System.Windows.Forms.Label lblVentaEntradas;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Label lblTipoVisita;
		private System.Windows.Forms.Label lblTipoEntrada;
		private System.Windows.Forms.ComboBox cmbEntrada;
		private System.Windows.Forms.ComboBox cmbVisita;
		private System.Windows.Forms.Label lblServicioGuia;
		private System.Windows.Forms.RadioButton rdoSi;
		private System.Windows.Forms.RadioButton rdoNo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCloseForm;
		private System.Windows.Forms.Panel pnlServicioGuia;
	}
}