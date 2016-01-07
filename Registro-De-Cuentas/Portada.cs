using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Registro_De_Cuentas
{
    public partial class Portada : Form
    {
        Cuentas cuentas = new Cuentas();
        public Portada()
        {
            InitializeComponent();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = 0;
                int.TryParse(textBoxCuentaId.Text, out Id);
                cuentas.CuentaId = Id;
              
                    if (cuentas.Eliminar())
                    {
                        MessageBox.Show("Eliminado Correctamente");
                        textBoxCuentaId.Clear();
                        textBoxDescripcion.Clear();
                        textBoxBalance.Clear();
                    }
                    else
                    {
                    MessageBox.Show("Id No Existe");
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al Eliminar");
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                cuentas.Descripcion = textBoxDescripcion.Text;
                float IdB = 0;
                float.TryParse(textBoxBalance.Text, out IdB);
                cuentas.Balance = IdB;

                if (textBoxCuentaId.Text == "")
                {
                    if (textBoxDescripcion.Text != "" && textBoxBalance.Text != "")
                    {
                        if (cuentas.Insertar())
                        {
                            textBoxDescripcion.Clear();
                            textBoxBalance.Clear();
                            MessageBox.Show("Insertado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error Al Insertar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserte La Descripcion O El Balance");
                    }

                }
                else
                {
                    int id = 0;
                    int.TryParse(textBoxCuentaId.Text, out id);
                    cuentas.CuentaId = id;
                    if (textBoxDescripcion.Text != "" && textBoxBalance.Text != "")
                    {
                        if (cuentas.Editar())
                        {
                            textBoxDescripcion.Clear();
                            textBoxBalance.Clear();
                            textBoxCuentaId.Clear();
                            MessageBox.Show("Modificado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Error Al Modificar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserte La Descripcion O El Balance");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al Insertar O Modificar");
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            textBoxCuentaId.Clear();
            textBoxDescripcion.Clear();
            textBoxBalance.Clear();
        }
    }
}
