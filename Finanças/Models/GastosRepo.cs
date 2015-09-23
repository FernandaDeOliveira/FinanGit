using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finanças.Models
{
    public class GastosRepo
    {
        Conexao conn = new Conexao();

        public IEnumerable<Gastos> getAll()
        {
            string sql = "SELECT * FROM gastos ORDER BY data desc LIMIT 7";
            MySqlDataReader dr = conn.executarConsulta(sql);

            List<Gastos> Ultimosgastos = new List<Gastos>();
            while (dr.Read())
            {///parse do banco para oo
                Ultimosgastos.Add(new Gastos((int)dr["id"], (string)dr["ondeGastei"], (string)dr["tipo"], (int)dr["valor"], (string)dr["data"]));
            }
            return Ultimosgastos;
        }

        public Gastos getOne(int pId)
        {
            string sql = "SELECT * FROM gastos WHERE id=" + pId;
            MySqlDataReader dr = conn.executarConsulta(sql);

            dr.Read();
            Gastos gastosEdit = (new Gastos((int)dr["id"], (string)dr["ondeGastei"], (string)dr["tipo"], (int)dr["valor"],(string)dr["data"]));
            return gastosEdit;
        }

        public void create(Gastos pGastos)
        {
            string insert = "INSERT INTO gastos values('";
            insert += pGastos.id + "','" + pGastos.onde + "','" +pGastos.tipo+ "','" + pGastos.valor+ "','"  +pGastos.data+ "')";
            conn.executarComando(insert); 
        }

        public void update(Gastos pGastos)
        {
            string update = "UPDATE gastos set ondeGastei='" + pGastos.onde + "' WHERE id=" + pGastos.id;
            conn.executarComando(update);
        }
        public void delete(int pId)
        {
            string delete = "DELETE  FROM gastos WHERE id=" + pId;
            conn.executarComando(delete);
        }

        public void pesquisar(string pData)
        {
            string pesquisa = "SELECT FROM gastos WHERE data=" + pData;
            conn.executarComando(pesquisa);
        }
    }
}
