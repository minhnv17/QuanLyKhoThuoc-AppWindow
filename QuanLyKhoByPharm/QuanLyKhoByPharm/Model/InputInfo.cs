//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoByPharm.Model
{
    using QuanLyKho.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class InputInfo : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InputInfo()
        {
            this.OutputInfoes = new HashSet<OutputInfo>();
        }

        private string _Id;
        public string Id { get => _Id; set { _Id = value; OnPropertyChanged(); } }
        private string _IdInput;
        public string IdInput { get => _IdInput; set { _IdInput = value; OnPropertyChanged(); } }
        private string _IdObject;
        public string IdObject { get => _IdObject; set { _IdObject = value; OnPropertyChanged(); } }
        private int _Cout;
        public int Cout { get => _Cout; set { _Cout = value; OnPropertyChanged(); } }
        private double _InputPrice;
        public double InputPrice { get => _InputPrice; set { _InputPrice = value; OnPropertyChanged(); } }
        private double _OutputPrice;
        public double OutputPrice { get => _OutputPrice; set { _OutputPrice = value; OnPropertyChanged(); } }
        public System.DateTime HanSD { get; set; }
        public string Status { get; set; }
    
        private Input _Input;
        public virtual Input Input { get => _Input; set { _Input = value; OnPropertyChanged(); } }
        private Object _Object;
        public virtual Object Object { get => _Object; set { _Object = value; OnPropertyChanged(); } }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutputInfo> OutputInfoes { get; set; }
    }
}
