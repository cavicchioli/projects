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
    
    public partial class Funcionario
    {
        public Funcionario()
        {
            this.Atividade = new HashSet<Atividade>();
        }
    
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataContratacao { get; set; }
        public Nullable<System.DateTime> DataDemissao { get; set; }
        public string Ativo { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
    
        public virtual ICollection<Atividade> Atividade { get; set; }
    }
}
