using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public abstract class Refeicao
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public string Valor { get; set; }
	}
}
