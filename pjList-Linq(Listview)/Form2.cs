using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjList_Linq_Listview_
{
    public partial class Form2 : Form
    {   //Lista tipo objeto usando constructores
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
            new Lista_Libros(10,"El código Da Vinci", "J. D. Salinger",2003,80)
        };
        
        
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {   //Agrego lista en el listview (si uso Load se cargara apenas inicie el form)
            foreach (Lista_Libros item in ll)
            {
                ListViewItem fila = new ListViewItem(item.Id.ToString());
                fila.SubItems.Add(item.Titulo);
                fila.SubItems.Add(item.Autor);
                fila.SubItems.Add(item.FechaPub.ToString());
                fila.SubItems.Add(item.Ventas.ToString());
                lvLista_Libros.Items.Add(fila);
            }

            //Mayores ventas
            IEnumerable<Lista_Libros> mayorVentas = (from mayor in ll
                                                     orderby mayor.Ventas descending
                                                     select mayor).Take(3).ToList();

            foreach (Lista_Libros item in mayorVentas)
            {
                ListViewItem fila = new ListViewItem(item.Titulo);
                fila.SubItems.Add(item.Ventas.ToString());
                listView1.Items.Add(fila);
            }

            //Menores ventas
            IEnumerable<Lista_Libros> menorVentas = (from menor in ll
                                                     orderby menor.Ventas ascending
                                                     select menor).Take(3).ToList();

            foreach (Lista_Libros item in menorVentas)
            {
                ListViewItem fila = new ListViewItem(item.Titulo);
                fila.SubItems.Add(item.Ventas.ToString());
                listView2.Items.Add(fila);
            }

            
            //Autor con mas libros
            
                  


        }
    }
}
