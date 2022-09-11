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
    public partial class FormPilas : Form
    {
        Dao dao = new Dao();
        public FormPilas()
        {
            InitializeComponent();
           
        }

        private void ActualizarDGV()
        {
            dgvObjetos.DataSource = dao.primerElemento("pa_vistaListaTop1Asc");
            dgvProximoASalir.DataSource = dao.ElementoSaliente("pa_vistaListaTop1Desc");
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                   "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                    this.Close();
            
        }

       

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string objeto=  txtObject.Text;
            if (txtObject.Text == "")
            {
                MessageBox.Show("Debe ingresar un objeto!!");
                return;

            }

            if (dao.añadir(objeto, "pa_insertaPila") == true)
            {
                MessageBox.Show("Objeto agregado a la pila!!");
            }
            else
            {
                MessageBox.Show("Error alagregar el Objeto a la pila!!");
            }
            txtObject.Text = "";
            ActualizarDGV();

        }

        
        private void btnEstado_Click(object sender, EventArgs e)
        {
            if(dao.estaVacia("pa_vistaListaTop1Asc") == true)
            {
                MessageBox.Show("La pila se encuentra vacia");
            }
            else
            {
                MessageBox.Show("Ya existen elementos en la pila");
            }
            ActualizarDGV();
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el Ultimo objeto de la pila",
               "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dao.extrae("pa_eliminaTipoPila") == true)
                {
                    MessageBox.Show("Se borro el Elemento de la pila");
                }
                else
                {
                    MessageBox.Show("No se borró el Elemento de la pila, compruebe que haya elementos que borrar");
                }
            }

            ActualizarDGV();


        }

        private void btnFormColas_Click(object sender, EventArgs e)
        {
            new FormColas().Show();
          
        }
    }
}
