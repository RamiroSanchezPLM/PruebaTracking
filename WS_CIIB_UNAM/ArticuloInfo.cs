using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WS_CIIB_UNAM
{
    [DataContract]
    public class ArticuloInfo
    {

        #region Constructors

        public ArticuloInfo() { }

        #endregion

        #region Properties

        [DataMember]
        public string Afiliacion
        {
            get
            {
                return this._afiliacion;
            }
            set
            {
                this._afiliacion = value;
            }
        }

        [DataMember]
        public string Autor
        {
            get
            {
                return this._autor;
            }
            set
            {
                this._autor = value;
            }
        }

        [DataMember]
        public string Pmid
        {
            get
            {
                return this._pmid;
            }
            set
            {
                this._pmid = value;
            }
        }

        [DataMember]
        public string Resumen
        {
            get
            {
                return this._resumen;
            }
            set
            {
                this._resumen = value;
            }
        }

        [DataMember]
        public string Revista
        {
            get
            {
                return this._revista;
            }
            set
            {
                this._revista = value;
            }
        }

        [DataMember]
        public string Titulo
        {
            get
            {
                return this._titulo;
            }
            set
            {
                this._titulo = value;
            }
        }

        #endregion

        private string _afiliacion;
        private string _autor;
        private string _pmid;
        private string _resumen;
        private string _revista;
        private string _titulo;

    }
}
