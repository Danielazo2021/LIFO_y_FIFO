namespace Ejercicio2_1_Pilas
{
    partial class FormPilas
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
            this.txtObject = new System.Windows.Forms.TextBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.lblExtrae = new System.Windows.Forms.Label();
            this.lblComprobar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvObjetos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProximoASalir = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFormColas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximoASalir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(181, 168);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(205, 20);
            this.txtObject.TabIndex = 1;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblObject.Location = new System.Drawing.Point(12, 166);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(132, 20);
            this.lblObject.TabIndex = 2;
            this.lblObject.Text = "Ingrese el objeto";
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(340, 25);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(226, 78);
            this.btnEstado.TabIndex = 3;
            this.btnEstado.Text = "Comprobar Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(436, 140);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(130, 74);
            this.btnAñadir.TabIndex = 4;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(447, 238);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(119, 74);
            this.btnExtraer.TabIndex = 5;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // lblExtrae
            // 
            this.lblExtrae.AutoSize = true;
            this.lblExtrae.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblExtrae.Location = new System.Drawing.Point(12, 266);
            this.lblExtrae.Name = "lblExtrae";
            this.lblExtrae.Size = new System.Drawing.Size(269, 17);
            this.lblExtrae.TabIndex = 6;
            this.lblExtrae.Text = "Elimina el ultimo elemento de la coleccion";
            // 
            // lblComprobar
            // 
            this.lblComprobar.AutoSize = true;
            this.lblComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblComprobar.Location = new System.Drawing.Point(12, 53);
            this.lblComprobar.Name = "lblComprobar";
            this.lblComprobar.Size = new System.Drawing.Size(245, 20);
            this.lblComprobar.TabIndex = 7;
            this.lblComprobar.Text = "Comprobar si la lista esta vacia";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(689, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 74);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvObjetos
            // 
            this.dgvObjetos.AllowUserToAddRows = false;
            this.dgvObjetos.AllowUserToDeleteRows = false;
            this.dgvObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetos.Location = new System.Drawing.Point(603, 53);
            this.dgvObjetos.Name = "dgvObjetos";
            this.dgvObjetos.ReadOnly = true;
            this.dgvObjetos.Size = new System.Drawing.Size(259, 77);
            this.dgvObjetos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(656, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Primer elemento";
            // 
            // dgvProximoASalir
            // 
            this.dgvProximoASalir.AllowUserToAddRows = false;
            this.dgvProximoASalir.AllowUserToDeleteRows = false;
            this.dgvProximoASalir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProximoASalir.Location = new System.Drawing.Point(603, 232);
            this.dgvProximoASalir.Name = "dgvProximoASalir";
            this.dgvProximoASalir.ReadOnly = true;
            this.dgvProximoASalir.Size = new System.Drawing.Size(259, 77);
            this.dgvProximoASalir.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(635, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Proximo elemento a salir";
            // 
            // btnFormColas
            // 
            this.btnFormColas.Location = new System.Drawing.Point(162, 326);
            this.btnFormColas.Name = "btnFormColas";
            this.btnFormColas.Size = new System.Drawing.Size(119, 74);
            this.btnFormColas.TabIndex = 15;
            this.btnFormColas.Text = "Ir al Form de Colas";
            this.btnFormColas.UseVisualStyleBackColor = true;
            this.btnFormColas.Click += new System.EventHandler(this.btnFormColas_Click);
            // 
            // FormPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 412);
            this.Controls.Add(this.btnFormColas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProximoASalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObjetos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblComprobar);
            this.Controls.Add(this.lblExtrae);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.txtObject);
            this.Name = "FormPilas";
            this.Text = "Metodo de Extraccion por Pila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximoASalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Label lblExtrae;
        private System.Windows.Forms.Label lblComprobar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvObjetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProximoASalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFormColas;
    }
}

