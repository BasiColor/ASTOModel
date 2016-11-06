using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(StoreMD))]
    public partial class Store_This
    {
        public class StoreMD
        {
            [DisplayName("店面ID")]
            public string ST_ID { get; set; }

            [Required(ErrorMessage = "此欄位為必填!")]
            [StringLength(20, ErrorMessage = "請勿超過20個字元!")]
            [DisplayName("店面名稱")]
            public string ST_Name { get; set; }

            [DisplayName("店面介紹")]
            public string Introduct { get; set; }
        }

    }
}
