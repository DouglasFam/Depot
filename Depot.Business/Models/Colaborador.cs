using System.Collections.Generic;

namespace Depot.Business.Models
{
    public class Colaborador : Entity
    {
        
        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        /*EF Relations */

        public Perfil Perfil { get; set; }

        public IEnumerable<Historico> Historicos { get; set; }
    }
}
