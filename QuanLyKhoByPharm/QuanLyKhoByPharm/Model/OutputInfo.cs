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
    
    public partial class OutputInfo : BaseViewModel
    {
        private string _Id;
        public string Id { get => _Id; set { _Id = value; OnPropertyChanged(); } }
        private string _IdOutput;
        public string IdOutput { get => _IdOutput; set { _IdOutput = value; OnPropertyChanged(); } }
        private string _IdInputInfo;
        public string IdInputInfo { get => _IdInputInfo; set { _IdInputInfo = value; OnPropertyChanged(); } }
        private string _IdObject;
        public string IdObject { get => _IdObject; set { _IdObject = value; OnPropertyChanged(); } }
        private int _Cout;
        public int Cout { get => _Cout; set { _Cout = value; OnPropertyChanged(); } }
        public string Status { get; set; }
    
        private InputInfo _InputInfo;
        public virtual InputInfo InputInfo { get => _InputInfo; set { _InputInfo = value; OnPropertyChanged(); } }
        private Object _Object;
        public virtual Object Object { get => _Object; set { _Object = value; OnPropertyChanged(); } }
        private Output _Output;
        public virtual Output Output { get => _Output; set { _Output = value; OnPropertyChanged(); } }
    }
}
