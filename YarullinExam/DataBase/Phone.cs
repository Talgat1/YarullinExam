//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YarullinExam.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phone
    {
        public Phone()
        {
            this.Act = new HashSet<Act>();
            this.Deal = new HashSet<Deal>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> IdType { get; set; }
    
        public virtual ICollection<Act> Act { get; set; }
        public virtual ICollection<Deal> Deal { get; set; }
        public virtual TypePhone TypePhone { get; set; }
    }
}
