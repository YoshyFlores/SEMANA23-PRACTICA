using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA23_PRACTICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instacia de la clase contacto
            //cuando creo una instacia debo hace referencia ala clase

            Contacto contacto = new Contacto();

            //mediante metodos de propiedad
            //creamos un objeto contacto
            contacto.setContactoId(60020601);
            contacto.setnombre("Juan Enrique");
            contacto.setContactoCasa_Trabajo(25250025);
            contacto.setEmpresaT("Naciones Unidas");


            //mostrar datos de contacto
            MessageBox.Show(contacto.getContactoId() + "  " + contacto.getNombre() + "  " + contacto.getContactoCasa_Trabajo() + "  " + contacto.getEmpresaT());

            //mediante propiedad autoimplementadacontacto.
            //SET
            //contacto._publishedEmpresaT= "Naciones Unidad";
            //GET
            //MessageBox.Show(book._publishedEmpresaT);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("ContactoId", "NÚMERO");
            dgData.Columns.Add("nombre", "NOMBRE");
            dgData.Columns.Add("ContactoCasa_Trabajo", "TELÉFONO DE CASA");
            dgData.Columns.Add("EmpresaT", "NOMBRE DE LA EMPRESA");

            //CREANDO INSTACIA
            Contacto contacto = new Contacto();
            contacto.setContactoId(int.Parse(txtContactoId.Text));
            contacto.setnombre(txtNombre.Text);
            contacto.setContactoCasa_Trabajo(int.Parse(txtTelefonocasa.Text));
            contacto.setEmpresaT(txtEmpresaT.Text);
            dgData.Rows.Add(contacto.getContactoId(), contacto.getNombre(), contacto.getContactoCasa_Trabajo(), contacto.getEmpresaT());
            
            //LIMPIANDO
            txtContactoId.Text = "";
            txtNombre.Text = "";
            txtTelefonocasa.Text = "";
            txtEmpresaT.Text = "";
            txtContactoId.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
