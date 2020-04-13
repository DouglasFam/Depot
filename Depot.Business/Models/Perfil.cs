using System;

namespace Depot.Business.Models
{
    public class Perfil : Entity
    {
        public Guid ColaboradorId { get; set; }
        public string NomePerfil { get; set; }

        public Colaborador Colaborador { get; set; }
    }
}
