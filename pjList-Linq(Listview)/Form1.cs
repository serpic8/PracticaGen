using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace pjList_Linq_Listview_
{
    public partial class Form1 : Form
    {

        //Autores Autores = new Autores();
        //List<Autores> au = new List<Autores>();

        int cantidad = 0;
        public List<Autores> au = new List<Autores>();//Puedes hacerlo de otra forma, mas tarde piensa sobre hacer un construtor y una lista en Load
        public Form1()
        {
            InitializeComponent();
            
        }
        private void lvAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            au.Add(new Autores { Id = 1, Nombres = "Miguel de Cervantes" });
            au.Add(new Autores { Id = 2, Nombres = "Charles Dickens" });
            au.Add(new Autores { Id = 3, Nombres = "J. R. R. Tolkien" });
            au.Add(new Autores { Id = 4, Nombres = "Antoine de Saint-Exupéry" });
            au.Add(new Autores { Id = 5, Nombres = "Cao Xueqin" });
            au.Add(new Autores { Id = 6, Nombres = "Lewis Car" });
            au.Add(new Autores { Id = 7, Nombres = "Agatha Christie" });
            au.Add(new Autores { Id = 8, Nombres = "C. S. Lewis" });
            au.Add(new Autores { Id = 9, Nombres = "Dan Brown" });
            au.Add(new Autores { Id = 10, Nombres = "J. D. Salinger" });
            foreach (Autores autores in au)
            {
                ListViewItem fila = new ListViewItem(autores.Id.ToString("0"));
                fila.SubItems.Add(autores.Nombres);
                lvAutores.Items.Add(fila);
            }


            //Primera prueba de linq con listview y label
            IEnumerable<Autores> list = from aut in au  //aut(valor que devuelve el linq), au(nombre de la lista)
                                        where aut.Id == 1
                                        select aut;
            foreach (Autores item in list)
            {

                label1.Text = item.Nombres;
            }

            foreach (Autores item in list)
            {
                ListViewItem fila = new ListViewItem(item.Nombres);
                listView1.Items.Add(fila);

            }
            //Segunda prueba linq
            IEnumerable<Autores> idPar = from par in au
                                         where par.Id % 2 == 0
                                         select par;
            foreach (Autores item in idPar)
            {
                ListViewItem fila = new ListViewItem(item.Id.ToString());
                fila.SubItems.Add(item.Nombres);
                listView2.Items.Add(fila);
            }


            //Aqui calculo la cantidad de autores
            var cAntidad = (from can in au
                            where can.Id > cantidad
                            select can).Count();

            lblCantidad.Text = cAntidad.ToString();

            //Puse esta lista aqui porq el join no se como usarlo si la lista no esta en la clase
            List<Lista_Libros> ll = new List<Lista_Libros>()
            {
                new Lista_Libros(1,"Don Quijote de la Mancha", "Miguel de Cervantes",1605,500),
                new Lista_Libros(2,"Historia de dos ciudades", "Charles Dickens",1859,200),
                new Lista_Libros(3,"El Señor de los Anillos", "J. R. R. Tolkien",1978,150),
                new Lista_Libros(4,"El principito", "Antoine de Saint-Exupéry",1951,140),
                new Lista_Libros(5,"El hobbit", "Cao Xueqin",1982,100),
                new Lista_Libros(6,"Sueño en el pabellón rojo", "Lewis Car",1792,100),
                new Lista_Libros(7,"Las aventuras de Alicia en el país de las maravillas", "Agatha Christie",1865,100),
                new Lista_Libros(8,"Diez negritos", "C. S. Lewis",1939,100),
                new Lista_Libros(9,"El león, la bruja y el armario", "Dan Brown",1950,85),
                new Lista_Libros(10,"El código Da Vinci", "J. D. Salinger",2003,80),
                new Lista_Libros(1,"Migue","Miguel de Cervantes",1650,200)
            };

            //Aqui identifico los libros que comienzan por el
            var el = from a in au
                     join
                     l in ll on a.Id equals
                     l.Id
                     where l.Titulo.StartsWith("El")
                     select (a.Nombres, l.Titulo);
            foreach (var item in el)
            {
                ListViewItem fila = new ListViewItem(item.Nombres);
                fila.SubItems.Add(item.Titulo);
                lvEl.Items.Add(fila);
            }
            //No puedo con lo del autor con mas libros
            var masL = (from a in au
                        join c in ll
                       on a.Id equals c.Id
                        group
                       a by a.Nombres into masLibros
                        orderby masLibros.Count() descending
                        select masLibros).Take(1).ToList();
            foreach (var grupo in masL)
            {
                foreach (var item in grupo)
                {
                    lblAutoresLibros.Text = item.Nombres;
                }
            }
            //Autor y la cantidad de libros(Se miran dobles porque en ambas listas tiene nombre del autor)
            var cantidadL = (from a in au
                             join c in ll
                             on a.Id equals c.Id
                             group
                             a by a.Nombres into cant
                             select cant).ToList();

            foreach (var grupo in cantidadL)
            {
                foreach (var item in grupo)
                {                                       
                    ListViewItem fila = new ListViewItem(item.Nombres); //grupo.key funciona igual
                    fila.SubItems.Add(grupo.Count().ToString());
                    lvCantidad.Items.Add(fila);
                }
            }

            
                        

            
                         
                          
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form frm = new Form2();
            frm.Show();

        }
    }
}
