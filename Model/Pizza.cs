using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pizza : Refeicao
    {
        public const String INSERT = "INSERT INTO TB_PIZZA ([descricao], [valor]) VALUES ('{0}', '{1}')";
        public const String UPDATE = "UPDATE TB_PIZZA SET descricao = '{0}', valor = '{1}' WHERE id = {2}";
        public const String DELETE = "DELETE FROM TB_PIZZA WHERE id = {0}";
        public const String SELECT = "SELECT id, descricao, valor FROM TB_PIZZA";
        public const String SELECTBYID = "SELECT id, descricao, valor FROM TB_PIZZA WHERE id = {0}";
    }
}
