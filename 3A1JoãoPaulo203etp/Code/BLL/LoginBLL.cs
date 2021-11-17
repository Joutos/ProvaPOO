using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3A1JoãoPaulo203etp.Code.DTO;
using _3A1JoãoPaulo203etp.Code.DAL;

namespace _3A1JoãoPaulo203etp.Code.BLL
{
    class LoginBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"SELECT * FROM tbl_login WHERE email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0) return true; else return false;
        }


    }
}
