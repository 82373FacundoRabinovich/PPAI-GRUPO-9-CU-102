﻿
namespace Dashbord {
	partial class OpcionesRV {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesRV));
			this.panelRV = new System.Windows.Forms.Panel();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.lblResponsableVentas = new System.Windows.Forms.Label();
			this.pibUsuario = new System.Windows.Forms.PictureBox();
			this.lblMenuOpciones = new System.Windows.Forms.Label();
			this.btnCloseForm = new System.Windows.Forms.Button();
			this.btnRegistrarVenta = new System.Windows.Forms.Button();
			this.panelRV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRV
			// 
			this.panelRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(81)))));
			this.panelRV.Controls.Add(this.btnCerrarSesion);
			this.panelRV.Controls.Add(this.lblResponsableVentas);
			this.panelRV.Controls.Add(this.pibUsuario);
			this.panelRV.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRV.Location = new System.Drawing.Point(0, 0);
			this.panelRV.Name = "panelRV";
			this.panelRV.Size = new System.Drawing.Size(200, 542);
			this.panelRV.TabIndex = 0;
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
			this.btnCerrarSesion.TabIndex = 2;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			// 
			// lblResponsableVentas
			// 
			this.lblResponsableVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResponsableVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblResponsableVentas.Location = new System.Drawing.Point(3, 112);
			this.lblResponsableVentas.Name = "lblResponsableVentas";
			this.lblResponsableVentas.Size = new System.Drawing.Size(197, 61);
			this.lblResponsableVentas.TabIndex = 1;
			this.lblResponsableVentas.Text = "Responsable de Ventas";
			this.lblResponsableVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pibUsuario
			// 
			this.pibUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pibUsuario.Image")));
			this.pibUsuario.Location = new System.Drawing.Point(0, 12);
			this.pibUsuario.Name = "pibUsuario";
			this.pibUsuario.Size = new System.Drawing.Size(200, 97);
			this.pibUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pibUsuario.TabIndex = 0;
			this.pibUsuario.TabStop = false;
			// 
			// lblMenuOpciones
			// 
			this.lblMenuOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(104)))), ((int)(((byte)(166)))));
			this.lblMenuOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenuOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.lblMenuOpciones.Location = new System.Drawing.Point(295, 66);
			this.lblMenuOpciones.Name = "lblMenuOpciones";
			this.lblMenuOpciones.Size = new System.Drawing.Size(406, 72);
			this.lblMenuOpciones.TabIndex = 1;
			this.lblMenuOpciones.Text = "Menú de Opciones";
			this.lblMenuOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			this.btnCloseForm.Location = new System.Drawing.Point(751, 0);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(43, 40);
			this.btnCloseForm.TabIndex = 21;
			this.btnCloseForm.Text = "X";
			this.btnCloseForm.UseVisualStyleBackColor = false;
			this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
			// 
			// btnRegistrarVenta
			// 
			this.btnRegistrarVenta.Location = new System.Drawing.Point(302, 180);
			this.btnRegistrarVenta.Name = "btnRegistrarVenta";
			this.btnRegistrarVenta.Size = new System.Drawing.Size(302, 23);
			this.btnRegistrarVenta.TabIndex = 22;
			this.btnRegistrarVenta.Text = "Registrar Venta de Entradas";
			this.btnRegistrarVenta.UseVisualStyleBackColor = true;
			this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
			// 
			// OpcionesRV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(790, 542);
			this.Controls.Add(this.btnRegistrarVenta);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.lblMenuOpciones);
			this.Controls.Add(this.panelRV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OpcionesRV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panelRV.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pibUsuario)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelRV;
		private System.Windows.Forms.Label lblResponsableVentas;
		private System.Windows.Forms.PictureBox pibUsuario;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Label lblMenuOpciones;
		private System.Windows.Forms.Button btnCloseForm;
		private System.Windows.Forms.Button btnRegistrarVenta;
	}
}