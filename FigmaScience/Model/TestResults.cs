//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FigmaScience.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestResults
    {
        public TestResults()
        {
            this.FigmaScience = new HashSet<FigmaScience>();
        }
    
        public int ID { get; set; }
        public int User { get; set; }
        public int Test { get; set; }
        public System.DateTime DateOfCompleting { get; set; }
        public int Scores { get; set; }
        public int Mark { get; set; }
    
        public virtual ICollection<FigmaScience> FigmaScience { get; set; }
        public virtual Tests Tests { get; set; }
        public virtual Users Users { get; set; }
    }
}
