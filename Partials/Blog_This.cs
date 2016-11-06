using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(BlogMD))]
    public partial class Blog_This
    {
        public class BlogMD
        {
            [DisplayName("文章ID")]
            public int BL_ID { get; set; }

            [Required(ErrorMessage = "此欄位為必填!")]
            [StringLength(20, ErrorMessage = "請勿超過20個字元!")]
            [DisplayName("文章標題")]
            public string BL_Title { get; set; }

            [Required(ErrorMessage = "此欄位為必填!")]
            [DisplayName("文章日期")]
            public DateTime DateTime { get; set; }

            [DisplayName("文章內容")]
            public string Context { get; set; }

            [DisplayName("附件")]
            public string Attachment { get; set; }
        }
    }
}
