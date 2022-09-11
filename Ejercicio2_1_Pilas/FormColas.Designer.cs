namespace Ejercicio2_1_Pilas
{
    partial class FormColas
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProximoASalir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvObjetos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblComprobar = new System.Windows.Forms.Label();
            this.lblExtrae = new System.Windows.Forms.Label();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.lblObject = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.btnFormPilas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximoASalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(646, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Proximo elemento a salir";
            // 
            // dgvProximoASalir
            // 
            this.dgvProximoASalir.AllowUserToAddRows = false;
            this.dgvProximoASalir.AllowUserToDeleteRows = false;
            this.dgvProximoASalir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProximoASalir.Location = new System.Drawing.Point(614, 252);
            this.dgvProximoASalir.Name = "dgvProximoASalir";
            this.dgvProximoASalir.ReadOnly = true;
            this.dgvProximoASalir.Size = new System.Drawing.Size(259, 77);
            this.dgvProximoASalir.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(667, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Primer elemento";
            // 
            // dgvObjetos
            // 
            this.dgvObjetos.AllowUserToAddRows = false;
            this.dgvObjetos.AllowUserToDeleteRows = false;
            this.dgvObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetos.Location = new System.Drawing.Point(614, 73);
            this.dgvObjetos.Name = "dgvObjetos";
            this.dgvObjetos.ReadOnly = true;
            this.dgvObjetos.Size = new System.Drawing.Size(259, 77);
            this.dgvObjetos.TabIndex = 23;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(707, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 74);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblComprobar
            // 
            this.lblComprobar.AutoSize = true;
            this.lblComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblComprobar.Location = new System.Drawing.Point(23, 73);
            this.lblComprobar.Name = "lblComprobar";
            this.lblComprobar.Size = new System.Drawing.Size(245, 20);
            this.lblComprobar.TabIndex = 21;
            this.lblComprobar.Text = "Comprobar si la lista esta vacia";
            // 
            // lblExtrae
            // 
            this.lblExtrae.AutoSize = true;
            this.lblExtrae.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblExtrae.Location = new System.Drawing.Point(23, 286);
            this.lblExtrae.Name = "lblExtrae";
            this.lblExtrae.Size = new System.Drawing.Size(277, 17);
            this.lblExtrae.TabIndex = 20;
            this.lblExtrae.Text = "Eliminar el primer elemento de la colección";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(458, 258);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(119, 74);
            this.btnExtraer.TabIndex = 19;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(447, 160);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(130, 74);
            this.btnAñadir.TabIndex = 18;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(351, 45);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(226, 78);
            this.btnEstado.TabIndex = 17;
            this.btnEstado.Text = "Comprobar Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblObject.Location = new System.Drawing.Point(23, 186);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(132, 20);
            this.lblObject.TabIndex = 16;
            this.lblObject.Text = "Ingrese el objeto";
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(192, 188);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(205, 20);
            this.txtObject.TabIndex = 15;
            // 
            // btnFormPilas
            // 
            this.btnFormPilas.Location = new System.Drawing.Point(181, 352);
            this.btnFormPilas.Name = "btnFormPilas";
            this.btnFormPilas.Size = new System.Drawing.Size(119, 74);
            this.btnFormPilas.TabIndex = 27;
            this.btnFormPilas.Text = "Ir a Form de Pilas";
            this.btnFormPilas.UseVisualStyleBackColor = true;
            this.btnFormPilas.Click += new System.EventHandler(this.btnFormPilas_Click);
            // 
            // FormColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnFormPilas);
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
            this.Name = "FormColas";
            this.Text = "Metodo de Extraccion por Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximoASalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProximoASalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvObjetos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblComprobar;
        private System.Windows.Forms.Label lblExtrae;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Button btnFormPilas;
    }
}