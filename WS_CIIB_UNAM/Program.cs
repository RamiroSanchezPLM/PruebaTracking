using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WS_CIIB_UNAM
{
    public class Program
    {
        static void Main(string[] args)
        {
            wsUNAM.CiibServicioClient _wsUnam = new wsUNAM.CiibServicioClient();
            List<wsUNAM.Articulo> articuloList = new List<wsUNAM.Articulo>();

            articuloList = _wsUnam.getArticle(null, "acido", 1);

            foreach (wsUNAM.Articulo item in articuloList)
            {
                System.Console.WriteLine("Afiliación: " + item.Afiliacion);
                System.Console.WriteLine("Autor: " + item.Autor);
                System.Console.WriteLine("Pmid: " + item.Pmid);
                System.Console.WriteLine("Resumen: " + item.Resumen);
                System.Console.WriteLine("Revista: " + item.Revista);
                System.Console.WriteLine("Titulo: " + item.Titulo);

                System.Console.WriteLine("--------*********************--------");
            }
            System.Console.ReadLine();
        }
    }
}
