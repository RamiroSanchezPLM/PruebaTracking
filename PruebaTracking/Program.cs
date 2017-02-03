using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTracking
{
    public class Program
    {
        static void Main(string[] args)
        {
            //insertaTrackingPLMClients();
            //insertaTrackingMedinetSinHijos();
            //insertaTrackingAtributos();
            //insertaTrackingMedinetConHijos();
            //insertaTrackingMedinetConHijosRecargado();

            ////////////NUEVOS MÉTODOS

            insertaNuevoTrackingSinHijos();
            //insertaNuevoTrackingAtributos();
            //insertaNuevoTrackingConHijos();
            //insertaNuevoTrackingConHijosRecargado();

        }

        public static void insertaTrackingPLMClients()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.Info_TrackingListInfo> entidades = new List<PLMLogsEngine.Info_TrackingListInfo>();

            PLMLogsEngine.Info_TrackingListInfo entidad;

            entidad = new PLMLogsEngine.Info_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EntityId = 10;
            entidad.JSONFormat = "Farmacia=San Pablo";
            entidad.ParentId = null;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "BranchId=5199";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 5;

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.Info_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EntityId = 10;
            entidad.JSONFormat = "Farmacia=Benavides";
            entidad.ParentId = null;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "BranchId=1234";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 5;

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.Info_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EntityId = 10;
            entidad.JSONFormat = "Farmacia=Farmacias del Ahorro";
            entidad.ParentId = null;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "BranchId=1234";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 5;

            entidades.Add(entidad);

            pslogsInstance.addTrackingActivities(entidades);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();

        }

        public static void insertaTrackingMedinetSinHijos()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.PSE_TrackingListInfo> entidades = new List<PLMLogsEngine.PSE_TrackingListInfo>();
            PLMLogsEngine.PSE_TrackingListInfo entidad;

            entidad = new PLMLogsEngine.PSE_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EditionId = 55;
            entidad.EntityId = 30;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "texto=fiebremuyalta";
            entidad.SearchTypeId = 2;
            entidad.SourceId = 4;
            entidad.JsonFormat = "texto=fiebremuyalta";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.PSE_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EditionId = 55;
            entidad.EntityId = 30;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "texto=fiebreNoTanAlta";
            entidad.SearchTypeId = 2;
            entidad.SourceId = 4;
            entidad.JsonFormat = "texto=fiebreNoTanAlta";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.PSE_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EditionId = 55;
            entidad.EntityId = 30;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "texto=FiebreMedianamenteAlta";
            entidad.SearchTypeId = 2;
            entidad.SourceId = 4;
            entidad.JsonFormat = "texto=FiebreMedianamenteAlta";

            entidades.Add(entidad);

            pslogsInstance.logsAddActivities(entidades);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();
        }

        public static void insertaTrackingAtributos()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.PSE_TrackingListInfo> entidades = new List<PLMLogsEngine.PSE_TrackingListInfo>();

            PLMLogsEngine.PSE_TrackingListInfo entidad;

            entidad = new PLMLogsEngine.PSE_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EditionId = 55;
            entidad.EntityId = 27;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 4;
            entidad.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";
            entidad.Attributes = "1";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.PSE_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EditionId = 55;
            entidad.EntityId = 27;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 4;
            entidad.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";
            entidad.Attributes = "2";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.PSE_TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.EditionId = 55;
            entidad.EntityId = 27;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 4;
            entidad.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";
            entidad.Attributes = "14";

            entidades.Add(entidad);

            pslogsInstance.logsAddActivities(entidades);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();
            
        }

        public static void insertaTrackingMedinetConHijos()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            PLMLogsEngine.PSE_TrackingParentInfo entidadPadre;

            entidadPadre = new PLMLogsEngine.PSE_TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.EditionId = 55;
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=dolo";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=dolo";
            
            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.PSE_TrackingListInfo>();
            PLMLogsEngine.PSE_TrackingListInfo trackingHijo;

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.PSE_TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.EditionId = 55;
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            pslogsInstance.addLogParentActivity(entidadPadre);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();
        }

        public static void insertaTrackingMedinetConHijosRecargado()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.PSE_TrackingParentInfo> entidadesPadres = new List<PLMLogsEngine.PSE_TrackingParentInfo>();

            PLMLogsEngine.PSE_TrackingParentInfo entidadPadre;
            PLMLogsEngine.PSE_TrackingListInfo trackingHijo;

            //BUSQUEDA 1

            entidadPadre = new PLMLogsEngine.PSE_TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.EditionId = 55;
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_1";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_1";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.PSE_TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.PSE_TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.EditionId = 55;
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 2

            entidadPadre = new PLMLogsEngine.PSE_TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.EditionId = 55;
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_2";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_2";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.PSE_TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.PSE_TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.EditionId = 55;
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 3

            entidadPadre = new PLMLogsEngine.PSE_TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.EditionId = 55;
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_3";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_3";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.PSE_TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.PSE_TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.EditionId = 55;
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 4

            entidadPadre = new PLMLogsEngine.PSE_TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.EditionId = 55;
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_4";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_4";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.PSE_TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.PSE_TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.EditionId = 55;
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 5

            entidadPadre = new PLMLogsEngine.PSE_TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.EditionId = 55;
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_5";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_5";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.PSE_TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.PSE_TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.EditionId = 55;
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //FINALMENTE SE INSERTA EL TRACKING
            pslogsInstance.logsAddParentActivities(entidadesPadres);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();

        }

        //////NUEVOS MÉTODOS

        public static void insertaNuevoTrackingSinHijos()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.TrackingListInfo> entidades = new List<PLMLogsEngine.TrackingListInfo>();
            PLMLogsEngine.TrackingListInfo entidad;

            entidad = new PLMLogsEngine.TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.ISBN = "978-607-7767-87-9";
            entidad.EntityId = 30;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "texto=fiebremuyalta";
            entidad.SearchTypeId = 2;
            entidad.SourceId = 4;
            entidad.JsonFormat = "texto=fiebremuyalta";
            
            entidades.Add(entidad);

            entidad = new PLMLogsEngine.TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.ISBN = "978-607-7767-87-9";
            entidad.EntityId = 30;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "texto=fiebreNoTanAlta";
            entidad.SearchTypeId = 2;
            entidad.SourceId = 4;
            entidad.JsonFormat = "texto=fiebreNoTanAlta";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.ISBN = "978-607-7767-87-9";
            entidad.EntityId = 30;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "texto=FiebreMedianamenteAlta";
            entidad.SearchTypeId = 2;
            entidad.SourceId = 4;
            entidad.JsonFormat = "texto=FiebreMedianamenteAlta";

            entidades.Add(entidad);

            pslogsInstance.addPLMTrackingActivities(entidades);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();
        }

        public static void insertaNuevoTrackingAtributos()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.TrackingListInfo> entidades = new List<PLMLogsEngine.TrackingListInfo>();

            PLMLogsEngine.TrackingListInfo entidad;

            entidad = new PLMLogsEngine.TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.ISBN = "978-607-7767-87-9";
            entidad.EntityId = 27;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 4;
            entidad.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";
            entidad.AttributeGroupKey = "DIN001";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.ISBN = "978-607-7767-87-9";
            entidad.EntityId = 27;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 4;
            entidad.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";
            entidad.AttributeGroupKey = "LAC002";

            entidades.Add(entidad);

            entidad = new PLMLogsEngine.TrackingListInfo();
            entidad.CodeString = "Zuniga Jessica";
            entidad.ISBN = "978-607-7767-87-9";
            entidad.EntityId = 27;
            entidad.Replicate = false;
            entidad.SearchDate = null;
            entidad.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
            entidad.SearchTypeId = 1;
            entidad.SourceId = 4;
            entidad.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";
            entidad.AttributeGroupKey = "BIB003";

            entidades.Add(entidad);

            pslogsInstance.addPLMTrackingActivities(entidades);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();

        }

        public static void insertaNuevoTrackingConHijos()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            PLMLogsEngine.TrackingParentInfo entidadPadre;

            entidadPadre = new PLMLogsEngine.TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.ISBN = "978-607-7767-87-9";
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=dolo";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=dolo";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.TrackingListInfo>();
            PLMLogsEngine.TrackingListInfo trackingHijo;

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.ISBN = "978-607-7767-87-9";
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            pslogsInstance.addPLMTrackingParentActivity(entidadPadre);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();
        }

        public static void insertaNuevoTrackingConHijosRecargado()
        {
            PLMLogsEngine.PLMLogsClient pslogsInstance = new PLMLogsEngine.PLMLogsClient();

            List<PLMLogsEngine.TrackingParentInfo> entidadesPadres = new List<PLMLogsEngine.TrackingParentInfo>();

            PLMLogsEngine.TrackingParentInfo entidadPadre;
            PLMLogsEngine.TrackingListInfo trackingHijo;

            //BUSQUEDA 1

            entidadPadre = new PLMLogsEngine.TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.ISBN = "978-607-7767-87-9";
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_1";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_1";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.ISBN = "978-607-7767-87-9";
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 2

            entidadPadre = new PLMLogsEngine.TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.ISBN = "978-607-7767-87-9";
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_2";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_2";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.ISBN = "978-607-7767-87-9";
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 3

            entidadPadre = new PLMLogsEngine.TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.ISBN = "978-607-7767-87-9";
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_3";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_3";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.ISBN = "978-607-7767-87-9";
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 4

            entidadPadre = new PLMLogsEngine.TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.ISBN = "978-607-7767-87-9";
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_4";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_4";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.ISBN = "978-607-7767-87-9";
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //BUSQUEDA 5

            entidadPadre = new PLMLogsEngine.TrackingParentInfo();
            entidadPadre.CodeString = "Zuniga Jessica";
            entidadPadre.ISBN = "978-607-7767-87-9";
            entidadPadre.EntityId = 30;
            entidadPadre.Replicate = false;
            entidadPadre.SearchDate = null;
            entidadPadre.SearchParameters = "texto=BusquedaPapa_5";
            entidadPadre.SearchTypeId = 1;
            entidadPadre.SourceId = 4;
            entidadPadre.JsonFormat = "texto=BusquedaPapa_5";

            //se crea la lista de busquedas hijas de la primera busqueda padre
            entidadPadre.ChildrenTrackingInfo = new List<PLMLogsEngine.TrackingListInfo>();

            for (int i = 0; i <= 20; i++)
            {
                System.Console.Out.WriteLine("registro " + i.ToString());

                trackingHijo = new PLMLogsEngine.TrackingListInfo();
                trackingHijo.CodeString = "Zuniga Jessica";
                trackingHijo.ISBN = "978-607-7767-87-9";
                trackingHijo.EntityId = 3;
                trackingHijo.Replicate = false;
                trackingHijo.SearchDate = null;
                trackingHijo.SearchParameters = "DivisionId=15;CategoryId=101;ProductId=8937;PharmaFormId=210";
                trackingHijo.SearchTypeId = 1;
                trackingHijo.SourceId = 4;
                trackingHijo.JsonFormat = "{ \"Laboratorio\" : \"ASTRAZENECA, S.A. DE C.V.\",\"Categoria\":\"PRODUCTOS\",\"Producto\":\"NOLVADEX\",\"Forma Farmaceutica\":\"Tabletas\"}";

                entidadPadre.ChildrenTrackingInfo.Add(trackingHijo);
            }

            entidadesPadres.Add(entidadPadre);

            //FINALMENTE SE INSERTA EL TRACKING
            pslogsInstance.addPLMTrackingParentActivities(entidadesPadres);

            System.Console.Out.WriteLine("Se insertó el tracking: ");
            System.Console.ReadLine();

        }

    }
}
