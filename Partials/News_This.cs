using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(NewsMD))]
    public partial class News_This
    {
        public class NewsMD
        {
            [DisplayName("消息ID")]
            public string NT_ID { get; set; }

            [Required(ErrorMessage = "此欄位為必填!")]  
            [StringLength(20, ErrorMessage = "請勿超過20個字元!")]
            [DisplayName("消息標題")]
            public string Title { get; set; }

            [DisplayName("消息內容")]
            public string Context { get; set; }

            [DisplayName("日期")]
            public string Datetime { get; set; }

            [DisplayName("附件檔案")]
            public string Attachment { get; set; }
        }
    }
}
