using System;

namespace EntidadPublica
{
    public class EntidadPublica
    {
        private string direccion, nombre;
        private int nroFuncionarios;
        private string []funcionarios = new String[50];

        public EntidadPublica(string direccion, string nombre, int nroFuncionarios)
        {
            this.direccion = direccion;
            this.nombre = nombre;
            this.nroFuncionarios = nroFuncionarios;
        }

        public void mostar()
        {
            Console.WriteLine("---- Entidad Publica ----");
            Console.WriteLine("nombre: "+nombre"\ndireccion: "+ direccion+"\nnroFucionarios: "+nroFuncionarios);
        }


    }
    
    
}