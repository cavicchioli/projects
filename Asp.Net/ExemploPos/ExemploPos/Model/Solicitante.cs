//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExemploPos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitante
    {
        public Solicitante()
        {
            this.Atividade = new HashSet<Atividade>();
        }
    
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
    
        public virtual ICollection<Atividade> Atividade { get; set; }
    }
}
