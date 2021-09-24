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
            MessageBox.Show(contacto.getContactoId() + "  " + contacto.getNombre() + "  "+ contacto.getContactoCasa_Trabajo() + "  "+ contacto.getEmpresaT());

            //mediante propiedad autoimplementadacontacto.
            //SET
            //contacto._publishedEmpresaT= "Naciones Unidad";
            //GET
            //MessageBox.Show(book._publishedEmpresaT);
        }
    }
}
