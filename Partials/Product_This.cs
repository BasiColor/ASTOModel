using Asto.Models.Interface;
using Asto.Models.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(ProductMD))]
    public partial class Product_This
    {
        public class ProductMD
        {
            [DisplayName("產品ID")]
            public string PT_ID { get; set; }

            [Required(ErrorMessage = "此欄位為必填!")]  //---- 這裡要建立不可重複名稱 ----
            [StringLength(20, ErrorMessage = "請勿超過20個字元!")]
            [DisplayName("英文名稱")]
            public string PT_Index { get; set; }

            [Required(ErrorMessage = "此欄位為必填!")]
            [StringLength(20, ErrorMessage = "請勿超過20個字元!")]
            [DisplayName("中文名稱")]
            public string PT_Name { get; set; }

            [DisplayName("口味基底")]
            public string Category { get; set; }

            [DisplayName("口味介紹")]
            public string Introduction { get; set; }

            [DisplayName("故事")]
            public string Story { get; set; }

            [DisplayName("啟用")]
            public Nullable<bool> Enable { get; set; }
        }
    }
}
