using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finanças.Models
{
    public class Gastos
    {
        private int v1;
        private string v2;
        #region Dominio
        public int id { get; set; }
        public string onde { get; set; }
        public string tipo { get; set; }
        public int valor { get; set; }
        public string data { get; set; }
        #endregion


        #region Construtor
        public Gastos()
        {

        }

        public Gastos(int pId,string pOnde, string pTipo,int pValor,string pData)
        {
            id = pId;
            onde = pOnde;
            tipo = pTipo;
            valor = pValor;
            data = pData;
        }

        

        #endregion
    }
}
