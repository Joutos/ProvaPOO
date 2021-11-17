using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3A1JoãoPaulo203etp.Code.DTO;
using _3A1JoãoPaulo203etp.Code.DAL;
namespace _3A1JoãoPaulo203etp.Code.BLL
{
    class cadProdBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "chillibeansprod";
        public void Insert(cadProdDTO prodDTO)
        {
            string inserir = $"INSERT INTO `chillibeansprod` VALUES(NULL, '{prodDTO.Produto}', '{prodDTO.Preco}')";
            conexao.ExecutarComando(inserir);

        }

        public DataTable Listar()
        {
            string sql = "SELECT * FROM `chillibeansprod` order by id";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(cadProdDTO prodDTO)
        {
            string alterar = $"UPDATE `chillibeansprod` SET `produto` = '{prodDTO.Produto}', `preco` = '{prodDTO.Preco}' WHERE `chillibeansprod`.`id` = {prodDTO.Id};";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(cadProdDTO prodDTO)
        {
            string excluir = $"DELETE from `chillibeansprod`where id= '{prodDTO.Id}'; ";
            conexao.ExecutarComando(excluir);
        }
    }
}
