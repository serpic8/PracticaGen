using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjList_Linq_Listview_
{
    public class Lista_Libros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int FechaPub { get; set; }
        public int Ventas { get; set; }

        public Lista_Libros(int id, string titulo, string autor, int fechaPub, int ventas)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            FechaPub = fechaPub;
            Ventas = ventas;
        }
    }
}
