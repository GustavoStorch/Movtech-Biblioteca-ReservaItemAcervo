using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaItemAcervo
{
    public class ItemAcervoDAO
    {
        private SqlConnection Connection { get; }

        public ItemAcervoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ItemAcervoModel> GetItensAcervosDevolver()
        {
            List<ItemAcervoModel> itensAcervos = new List<ItemAcervoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, numExemplar, tipoItem, localizacao, statusItem FROM mvtBibItemAcervo WHERE statusItem = 'Emprestado' ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itensAcervos.Add(PopulateDrItemAcervo(dr));
                    }
                }
            }
            return itensAcervos;
        }

        public List<ItemAcervoModel> GetItensAcervos()
        {
            List<ItemAcervoModel> itensAcervos = new List<ItemAcervoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, numExemplar, tipoItem, localizacao, statusItem FROM mvtBibItemAcervo WHERE statusItem = 'Disponível' ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itensAcervos.Add(PopulateDrItemAcervo(dr));
                    }
                }
            }
            return itensAcervos;
        }

        public ItemAcervoModel PopulateDrItemAcervo(SqlDataReader dr)
        {
            string codItem = "";
            string nome = "";
            string numExemplar = "";
            string tipoItem = "";
            string localizacao = "";
            string statusItem = "";

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }
            if (DBNull.Value != dr["numExemplar"])
            {
                numExemplar = dr["numExemplar"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["localizacao"])
            {
                localizacao = dr["localizacao"] + "";
            }
            if (DBNull.Value != dr["statusItem"])
            {
                statusItem = dr["statusItem"] + "";
            }

            return new ItemAcervoModel()
            {
                CodItem = codItem,
                NomeItem = nome,
                NumExemplar = numExemplar,
                TipoItem = tipoItem,
                Localizacao = localizacao,
                StatusItem = statusItem
            };
        }
    }
}
