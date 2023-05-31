using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReservaItemAcervo
{
    public class ReservaDAO
    {
        private SqlConnection Connection { get; }

        public ReservaDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public int VerificaRegistros(ItemAcervoModel itemAcervo, LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codItem) FROM mvtBibReserva WHERE codItem = @codItem AND codLeitor = @codLeitor");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                command.Parameters.AddWithValue("@codLeitor", leitor.CodLeitor);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public void Editar(ReservaModel reserva, ItemAcervoModel itemAcervo, LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibReserva SET statusItem = @statusItem, tipoMovimento = @tipoMovimento, prazoReserva = @prazoReserva" +
                        $" WHERE codItem = @codItem AND codLeitor = @codLeitor");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@statusItem", itemAcervo.StatusItem));
                    command.Parameters.Add(new SqlParameter("@tipoMovimento", reserva.TipoMovimento));
                    command.Parameters.Add(new SqlParameter("@prazoReserva", reserva.PrazoReserva));
                    command.Parameters.Add(new SqlParameter("@codItem", itemAcervo.CodItem));
                    command.Parameters.Add(new SqlParameter("@codLeitor", leitor.CodLeitor));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Salvar(ReservaModel reserva, ItemAcervoModel itemAcervo, LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibReserva(codItem, statusItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, ");
                    sql.AppendLine($"dataReserva, prazoReserva, tipoMovimento) ");
                    sql.AppendLine($"VALUES (@codItem, @statusItem, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor, ");
                    sql.AppendLine($"@dataReserva, @prazoReserva, @tipoMovimento) ");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codItem", itemAcervo.CodItem));
                    command.Parameters.Add(new SqlParameter("@statusItem", itemAcervo.StatusItem));
                    command.Parameters.Add(new SqlParameter("@nomeItem", itemAcervo.NomeItem));
                    command.Parameters.Add(new SqlParameter("@numExemplar", itemAcervo.NumExemplar));
                    command.Parameters.Add(new SqlParameter("@tipoItem", itemAcervo.TipoItem));
                    command.Parameters.Add(new SqlParameter("@localizacao", itemAcervo.Localizacao));
                    command.Parameters.Add(new SqlParameter("@codLeitor", leitor.CodLeitor));
                    command.Parameters.Add(new SqlParameter("@nomeLeitor", leitor.NomeLeitor));
                    command.Parameters.Add(new SqlParameter("@dataReserva", reserva.DataReserva));
                    command.Parameters.Add(new SqlParameter("@prazoReserva", reserva.PrazoReserva));
                    command.Parameters.Add(new SqlParameter("@tipoMovimento", reserva.TipoMovimento));

                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void AtualizaItemAcervo(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibItemAcervo SET statusItem = @statusItem WHERE codItem = @codItem");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@statusItem", itemAcervo.StatusItem));
                    command.Parameters.Add(new SqlParameter("@codItem", itemAcervo.CodItem));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public string GetNomeLeitor(LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeLeitor FROM mvtBibLeitor WHERE codLeitor = @codLeitor");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codLeitor", leitor.CodLeitor);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetNomeLeitorDevolucao(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeLeitor FROM mvtBibReserva WHERE statusItem = 'Reservado' OR statusItem = 'Emprestado' AND codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetCodLeitorDevolucao(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT codLeitor FROM mvtBibReserva WHERE statusItem = 'Reservado' OR statusItem = 'Emprestado' AND codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetNomeItem(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nome FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetNumExemplar(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT numExemplar FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetTipoItem(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT tipoItem FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public string GetLocalizacao(ItemAcervoModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeLocal FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        public bool VerificaEmprestimo(ItemAcervoModel itemAcervo, ReservaModel reserva)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {

                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"select statusItem from mvtBibItemAcervo where codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.CodItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result == "Reservado")
                {
                    if (result == "Reservado" && reserva.TipoMovimento == "Devolver")
                    {
                        return true;               
                    }
                    else
                    {
                        MessageBox.Show("O item do acervo já está reservado!");
                        return false;
                    }
                }
                else if (result == "Emprestado")
                {
                    if (result == "Emprestado" && reserva.TipoMovimento == "Devolver")
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O item do acervo já está emprestado!");
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        public bool VerificaCampos(ReservaModel reserva, ItemAcervoModel itemAcervo, LeitorModel leitor)
        {
            if (string.IsNullOrEmpty(itemAcervo.CodItem) || string.IsNullOrWhiteSpace(itemAcervo.CodItem))
            {
                MessageBox.Show("Informe o campo do Código do Item");
                return false;
            }
            else if (string.IsNullOrEmpty(itemAcervo.NomeItem) || string.IsNullOrWhiteSpace(itemAcervo.NomeItem))
            {
                MessageBox.Show("Informe o campo do Nome do item");
                return false;
            }
            else if (string.IsNullOrEmpty(itemAcervo.NumExemplar) || string.IsNullOrWhiteSpace(itemAcervo.NumExemplar))
            {
                MessageBox.Show("Informe o campo do Número exemplar");
                return false;
            }
            else if (string.IsNullOrEmpty(itemAcervo.TipoItem) || string.IsNullOrWhiteSpace(itemAcervo.TipoItem))
            {
                MessageBox.Show("Informe o campo do tipo do item");
                return false;
            }
            else if (string.IsNullOrEmpty(itemAcervo.Localizacao) || string.IsNullOrWhiteSpace(itemAcervo.Localizacao))
            {
                MessageBox.Show("Informe o campo de Localização");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.CodLeitor) || string.IsNullOrWhiteSpace(leitor.CodLeitor))
            {
                MessageBox.Show("Informe o campo do Código do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(leitor.NomeLeitor) || string.IsNullOrWhiteSpace(leitor.NomeLeitor))
            {
                MessageBox.Show("Informe o campo do Nome do leitor");
                return false;
            }
            else if (string.IsNullOrEmpty(reserva.DataReserva) || string.IsNullOrWhiteSpace(reserva.DataReserva))
            {
                MessageBox.Show("Informe o campo da data de reserva");
                return false;
            }
            else if (string.IsNullOrEmpty(reserva.PrazoReserva) || string.IsNullOrWhiteSpace(reserva.PrazoReserva))
            {
                MessageBox.Show("Informe o campo do prazo de devolução");
                return false;
            }

            DateTime dataReserva = Convert.ToDateTime(reserva.DataReserva);
            DateTime prazoReserva = Convert.ToDateTime(reserva.PrazoReserva);

            if(prazoReserva < dataReserva)
            {
                MessageBox.Show("O prazo de devolução é anterior ao de retirada.");
                return false;
            }

            return true;
        }

        public List<ReservaModel> GetReservas()
        {
            List<ReservaModel> reservas = new List<ReservaModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, statusItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, ");
                sql.AppendLine("nomeLeitor, dataReserva, prazoReserva, tipoMovimento FROM mvtBibReserva ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        reservas.Add(PopulateDrReserva(dr));
                    }
                }
            }
            return reservas;
        }

        public ReservaModel PopulateDrReserva(SqlDataReader dr)
        {
            string dataReserva = "";
            string prazoReserva = "";
            string tipoMovimento = "";
            LeitorModel leitor = null;
            ItemAcervoModel itemAcervo = null;

            if (DBNull.Value != dr["dataReserva"])
            {
                dataReserva = dr["dataReserva"] + "";
            }
            if (DBNull.Value != dr["prazoReserva"])
            {
                prazoReserva = dr["prazoReserva"] + "";
            }
            if (DBNull.Value != dr["tipoMovimento"])
            {
                tipoMovimento = dr["tipoMovimento"] + "";
            }
            if (DBNull.Value != dr["codLeitor"])
            {
                string leitorCod = dr["codLeitor"] + "";
                string leitorNome = dr["nomeLeitor"] + "";
                leitor = new LeitorModel()
                {
                    CodLeitor = leitorCod,
                    NomeLeitor = leitorNome
                };
            }
            if (DBNull.Value != dr["codItem"])
            {
                string itemAcervoCod = dr["codItem"] + "";
                string statusItem = dr["statusItem"] + "";
                string nomeItem = dr["nomeItem"] + "";
                string numExemplar = dr["numExemplar"] + "";
                string tipoItem = dr["tipoItem"] + "";
                string localizacao = dr["localizacao"] + "";
                itemAcervo = new ItemAcervoModel()
                {
                    CodItem = itemAcervoCod,
                    StatusItem = statusItem,
                    NomeItem = nomeItem,
                    NumExemplar = numExemplar,
                    TipoItem = tipoItem,
                    Localizacao = localizacao
                };
            }

            return new ReservaModel()
            {
                DataReserva = dataReserva,
                PrazoReserva = prazoReserva,
                TipoMovimento = tipoMovimento,
                LeitorModel = leitor,
                ItemAcervoModel = itemAcervo
            };
        }
    }
}
