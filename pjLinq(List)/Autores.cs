using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pjLinq_List_
{
    public class Autores
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        

        public void ListaAutores()
        {
            List<Autores> listaAutores = new List<Autores>();
            listaAutores.Add(new Autores { Id = 1, Nombres = "Miguel de Cervantes" });
            listaAutores.Add(new Autores { Id = 2, Nombres = "Charles Dickens" });
            listaAutores.Add(new Autores { Id = 3, Nombres = "J. R. R. Tolkien" });
            listaAutores.Add(new Autores { Id = 4, Nombres = "Antoine de Saint-Exupéry" });
            listaAutores.Add(new Autores { Id = 5, Nombres = "Cao Xueqin" });
            listaAutores.Add(new Autores { Id = 6, Nombres = "Lewis Car" });
            listaAutores.Add(new Autores { Id = 7, Nombres = "Agatha Christie" });
            listaAutores.Add(new Autores { Id = 8, Nombres = "C. S. Lewis" });
            listaAutores.Add(new Autores { Id = 9, Nombres = "Dan Brown" });
            listaAutores.Add(new Autores { Id = 10, Nombres = "J. D. Salinger" });

            aut.Id.ToString()
        }

        

    }
}
