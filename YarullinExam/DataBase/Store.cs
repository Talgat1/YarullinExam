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
    
    public partial class Store
    {
        public int Id { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> IdComsumables { get; set; }
    
        public virtual Comsumables Comsumables { get; set; }
    }
}