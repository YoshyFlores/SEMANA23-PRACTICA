using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA23_PRACTICA
{

    class Contacto
    {
        //Definir miembros de la clase
        //propiedades|atributos| datos.

        //normalmente las propiedades se definen en public

        //cuando sea de un elemento de herencia o padre se establecera como privado

        private int _contactoId;
        private string _nombre;
        private int _contactoCasa_Trabajo;
        private string _empresaT;

        //metodos de propiedad
        //get--obtinene el valor almacenado en la propiedad
        //set-- asigna un valor a la variable de propiedad

        //contactoId
        public void setContactoId(int contactoId)
        {
            _contactoId = contactoId;

        }
        public int getContactoId()
        {
            return _contactoId;
        }
        public void setnombre(string nombre)
        {
            _nombre = nombre;
        }
        public string getNombre()
        {
            return _nombre;
        }

        public void setContactoCasa_Trabajo(int contactoCasa_Trabajo)
        {
            _contactoCasa_Trabajo = contactoCasa_Trabajo;
        }

        public int getContactoCasa_Trabajo()
        {
            return _contactoCasa_Trabajo;
        }
        public void setEmpresaT(string empresaT)
        {
            _empresaT = empresaT;
        }
        public string getEmpresaT()
        {
            return _empresaT;
        }
    }
}
