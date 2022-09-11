using Ejercicio2_1_Pilas.Datos.Inplementacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_1_Pilas
{
    public partial class FormColas : Form
    {
        Dao dao = new Dao();
        public FormColas()
        {
            InitializeComponent();
        }
        private void ActualizarDGV()
        {
            dgvObjetos.DataSource = dao.primerElemento("pa_vistaColasTop1Asc");
            dgvProximoASalir.DataSource = dao.ElementoSaliente("pa_vistaColasTop1Asc");
        }
             

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (dao.estaVacia("pa_vistaColasTop1Asc") == true)
            {
                MessageBox.Show("La cola se encuentra vacia");
            }
            else
            {
                MessageBox.Show("Ya existen elementos en la cola");
            }
            ActualizarDGV();

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string objeto = txtObject.Text;
            if (txtObject.Text == "")
            {
                MessageBox.Show("Debe ingresar un objeto!!");
                return;

            }

            if (dao.añadir(objeto, "pa_insertaCola") == true)
            {
                MessageBox.Show("Objeto agregado a la cola!!");
            }
            else
            {
                MessageBox.Show("Error alagregar el Objetoa la cola!!");
            }
            txtObject.Text = "";
            ActualizarDGV();


        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el primer objeto de la cola",
               "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dao.extrae("pa_eliminaTipoCola") == true)
                {
                    MessageBox.Show("Se borro el Elemento de la cola");
                }
                else
                {
                    MessageBox.Show("No se borró el Elemento de la cola, compruebe que haya elementos que borrar");
                }
            }

            ActualizarDGV();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();

        }

        private void btnFormPilas_Click(object sender, EventArgs e)
        {
            new FormPilas().Show();
          
        }
    }
}
