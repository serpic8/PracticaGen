using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjList_Linq_Listview_
{
    public class Autores
    {
        public int Id { get; set; }
        public string Nombres { get; set; }

        public void ListaAutores()//Hacer la lista aqui no sirve pa nah, se tiene que hacer en el programa principal(No estoy seguro si se puede de otra forma)
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

            
        }

        
        


    }
}
