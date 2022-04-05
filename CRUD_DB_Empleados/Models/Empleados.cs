using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DB_Empleados.Models
{

//en esta clase tendremos almacenados los atributos de las entidades
//en este caso tomando los mismos datos de la tabla empleados
    internal class Empleados
    {

        //atributos
        private string document;
        private string names;
        private string surname;
        private int age;
        private string direction;
        private string dateofbirth;

        
        
        //Atributos inicializados
        public Empleados()
        {
            this.document = "";
            this.names = "";
            this.surname = "";
            this.age = 0;
            this.direction = "";
            this.dateofbirth = "";
        }

        //Setters y Getters
        public string Document { get => document; set => document = value; }
        public string Names { get => names; set => names = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Direction { get => direction; set => direction = value; }
        public string Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
    }
}
