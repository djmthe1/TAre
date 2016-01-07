namespace Registro_De_Cuentas
{
    partial class Portada
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
            this.botonNuevo = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.labelCuentaId = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxCuentaId = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 217);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(71, 52);
            this.botonNuevo.TabIndex = 9;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(156, 217);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(71, 52);
            this.botonEditar.TabIndex = 1;
            this.botonEditar.Text = "Guardar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(309, 217);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(71, 52);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // labelCuentaId
            // 
            this.labelCuentaId.AutoSize = true;
            this.labelCuentaId.Location = new System.Drawing.Point(48, 41);
            this.labelCuentaId.Name = "labelCuentaId";
            this.labelCuentaId.Size = new System.Drawing.Size(50, 13);
            this.labelCuentaId.TabIndex = 3;
            this.labelCuentaId.Text = "CuentaId";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(48, 90);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(48, 137);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 5;
            this.labelBalance.Text = "Balance";
            // 
            // textBoxCuentaId
            // 
            this.textBoxCuentaId.Location = new System.Drawing.Point(127, 41);
            this.textBoxCuentaId.Name = "textBoxCuentaId";
            this.textBoxCuentaId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuentaId.TabIndex = 6;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(127, 87);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 7;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(127, 134);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxBalance.TabIndex = 8;
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 281);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxCuentaId);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelCuentaId);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonNuevo);
            this.Name = "Portada";
            this.Text = "Portada";
            this.Load += new System.EventHandler(this.Portada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonNuevo;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Label labelCuentaId;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxCuentaId;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxBalance;
    }
}

