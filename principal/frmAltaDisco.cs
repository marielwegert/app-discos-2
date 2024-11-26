using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace principal
{
    public partial class frmAltaDisco : Form
    {
        //ATRIBUTOS
        private Disco disco = null;
        private OpenFileDialog archivo = null;

        //CONSTRUCTOR
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        //SOBRECARGA CONSTRUCTOR
        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            lblDisco.Text = "Modificar Disco";
        }

        //METODOS -> permiten mover el formulario con mouse    
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //EVENTO para mover el formulario con el mouse
        private void frmAltaDisco_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (validarBtnAceptar())
                    return;

                if (disco == null)
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value.Date;
                disco.CantidadCanciones = int.Parse(txtCantCanciones.Text);
                disco.UrlImagenTapa = txtUrlImagen.Text;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;
                disco.TipoEdicion = (TipoEdicion)cboTipoEdicion.SelectedItem;

                if (disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Disco modificado exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Disco agregado exitosamente");
                }

                //Guardo imagen si la levanto localmente
                if (archivo != null && !(txtUrlImagen.Text.ToLower().Contains("http")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Disco-app"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        ////METODO para validar que los campos obligatorios no esten vacios cuando se apreta click en Aceptar
        private bool validarBtnAceptar()
        {

            if (txtTitulo.Text == "")
            {
                txtTitulo.BackColor = Color.Red;
                lblErrorTitulo.Text = "Escriba el título del Album";
                return true;
            }
            else
            {
                txtTitulo.BackColor = System.Drawing.SystemColors.Control;
                lblErrorTitulo.Text = "";
            }

            if (dtpFechaLanzamiento.Checked == false)
            {
                //dtpFechaLanzamiento.CalendarMonthBackground = Color.Red;
                lblErrorFechaLanzamiento.Text = "Seleccione una fecha de lanzamiento";
                return true;
            }
            else
            {
                //dtpFechaLanzamiento.CalendarMonthBackground = System.Drawing.SystemColors.Control;
                lblErrorFechaLanzamiento.Text = "";
                dtpFechaLanzamiento.Checked = true;
            }

            if (txtCantCanciones.Text == "")
            {
                txtCantCanciones.BackColor = Color.Red;
                lblErrorCantCanciones.Text = "Escriba el número de canciones del Album";
                return true;
            }
            else
            {
                txtCantCanciones.BackColor = System.Drawing.SystemColors.Control;
                lblErrorCantCanciones.Text = "";
            }

            if (!(soloNumeros(txtCantCanciones.Text)))
            {
                txtCantCanciones.BackColor = Color.Red;
                lblErrorCantCanciones.Text = "El campo acepta solo números";
                return true;
            }
            else
            {
                txtCantCanciones.BackColor = System.Drawing.SystemColors.Control;
                lblErrorCantCanciones.Text = "";
            }

            if (cboEstilo.SelectedIndex < 0)
            {
                lblErrorEstilo.Text = "Seleccione el estilo";
                return true;
            }
            else
            {
                lblErrorEstilo.Text = "";
            }

            if (cboTipoEdicion.SelectedIndex < 0)
            {
                lblErrorTipoEdicion.Text = "Seleccione el tipo de edición";
                return true;
            }
            else
            {
                lblErrorTipoEdicion.Text = "";
            }
            return false;
        }

        //METODO para que una caja de texto reciba solo números
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        //EVENTO cuando se carga la ventana Alta Disco
        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoEdicionNegocio = new TipoEdicionNegocio();
            try
            {
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";

                cboTipoEdicion.DataSource = tipoEdicionNegocio.listar();
                cboTipoEdicion.ValueMember = "Id";
                cboTipoEdicion.DisplayMember = "Descripcion";

                //Esto es para que los desplegables no aparezcan preseleccionados:
                cboEstilo.SelectedIndex = -1;
                cboTipoEdicion.SelectedIndex = -1;

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Text = disco.FechaLanzamiento.ToString();
                    txtCantCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboTipoEdicion.SelectedValue = disco.TipoEdicion.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO para cargar la imagen cuando estoy agregando un nuevo Disco
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
