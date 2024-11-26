using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Runtime.InteropServices; //Libreria permite usar
                                      //librerias nativas del sist operativo
using FontAwesome.Sharp; //Libreria de los iconos

namespace principal
{
    public partial class frmPrincipal : Form
    {
        //ATRIBUTO
        private List<Disco> listaDisco;
        private Disco seleccionado;

        //CONSTRUCTOR
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //METODOS
        //La libreria "user32" permite mover el formulario
        //a traves del evento del mouse
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //EVENTO
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //EVENTO
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

        //EVENTO
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //EVENTO
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        //EVENTO
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //EVENTO
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }

        ////METODO
        //public void abrirFormHija(object formHija)
        //{
        //    //Primero pregunto si existe algun control en el interior del panel
        //    //Si es verdad => lo eliminamos
        //    if (this.pnlContenedor.Controls.Count > 0)
        //        this.pnlContenedor.Controls.RemoveAt(0);

        //    //Creo un formulario con un el nombre "fh"
        //    //El frm "fh" es igual al objeto que recibe la funcion
        //    //y a este objeto lo convertimos a un formulario con la palabra "as".
        //    //Form fh = formHija as Form;
        //    Form fh = (Form)formHija;
        //    //Cambio las prop del formulario en "Top Level" a "falso",
        //    //con esto decimos que no es un formulario padre sino q secundario.
        //    fh.TopLevel = false;
        //    //Colocamos en su propiedad "dock" a "fill",
        //    //esto hace que el frm se acomple a todo el panel contenedor
        //    fh.Dock = DockStyle.Fill;
        //    //Agregamos el formulario al panel
        //    this.pnlContenedor.Controls.Add(fh);
        //    //Establecemos la instancia como contenedor de datos de nuestro panel 
        //    this.pnlContenedor.Tag = fh;
        //    //Mostramos el formulario
        //    fh.Show();
        //}

        //EVENTO para abrir el formulario con la grilla
        //private void btnDiscos_Click(object sender, EventArgs e)
        //{
        //    frmDisco listaDisco = new frmDisco();
        //    abrirFormHija(listaDisco);
        //}

        ////EVENTO para abrir el formulario de modificar disco
        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    Disco seleccionado;
        //    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

        //    frmAltaDisco modificar = new frmAltaDisco(seleccionado);
        //    abrirFormHija(modificar);
        //}

        //EVENTO para que la pestaña de opciones se achique
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
                pnlMenu.Width = 54;
            else
                pnlMenu.Width = 200;
        }

        //EVENTO DE CARGA DE FORMULARIO
        public void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Fecha de lanzamiento");
            cboCampo.Items.Add("Cantidad de canciones");
        }

        //EVENTO para cuando cambio la selección de la grilla,
        //cambia lo que cargo en la imagen
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
            //seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            //cargarImagen(seleccionado.UrlImagenTapa);
        }

        //METODO para invocar la lectura a DB y cargar la lista
        public void cargar()
        {
            //Invoco la lectura de la DB
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDisco = negocio.listar();
                dgvDiscos.DataSource = listaDisco;
                ocultarColumnas();
                cargarImagen(listaDisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        //METODO //Si falla el try xq no hay imagen
        //entonces va al catch y muestra la imagen por defecto.
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        //EVENTO para abrir el formulario de agregar disco
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
            //abrirFormHija(alta);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDiscos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un Disco para modificar");
                }
                else
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    frmAltaDisco modificar = new frmAltaDisco(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (dgvDiscos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un Disco para eliminar");
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro que queres eliminar el Disco?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                lblErrorCampo.Text = "Seleccione el campo a filtrar";
                return true;
            }
            else
            {
                lblErrorCampo.Text = "";
            }

            if (cboCriterio.SelectedIndex < 0)
            {
                lblErrorCriterio.Text = "Seleccione el criterio a filtrar";
                return true;
            }
            else
            {
                lblErrorCriterio.Text = "";
            }
            
            if (cboCampo.SelectedItem.ToString() == "Cantidad de canciones")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text)) || string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo acepta solo números para filtrar");
                    return true;
                }
            }
            if (cboCampo.SelectedItem.ToString() == "Fecha de lanzamiento")
            {
                if (string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo acepta solo fechas completas o un año para filtrar");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("El campo acepta solo fechas completas o un año para filtrar");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length == 2)
            {
                listaFiltrada = listaDisco.FindAll(x => x.Titulo.ToLower().Contains(filtro.ToLower()) || x.Estilo.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaDisco;
            }

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Título")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
        }
    }
}
