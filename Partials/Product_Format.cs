using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(FormatMD))]
    public partial class Product_Format
    {
        public class FormatMD
        {
            public string PF_ID { get; set; }
            public string PT_ID { get; set; }

            [DisplayName("規格名稱")]
            [Required(ErrorMessage = "此欄位為必填!")]
            public string Format { get; set; }

            [DisplayName("幸福價")]
            [Required(ErrorMessage = "此欄位為必填!")]
            public Nullable<decimal> Price { get; set; }

            [DisplayName("市價")]
            public Nullable<decimal> MPrice { get; set; }

            [DisplayName("可訂購")]
            public Nullable<bool> BeOrder { get; set; }

            [DisplayName("啟用")]
            public Nullable<bool> Enable { get; set; }            

        }
    }
}
