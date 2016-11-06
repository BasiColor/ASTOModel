using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asto.Models
{
    [MetadataType(typeof(BannerMD))]
    public partial class Banner_This
    {
        public class BannerMD
        {
            [DisplayName("BannerID")]
            public string BN_ID { get; set; }
            [DisplayName("連結")]
            public string Url { get; set; }
            [DisplayName("標題")]
            public string Title { get; set; }
            [DisplayName("啟用")]
            public Nullable<bool> Eanble { get; set; }            
        }
    }
}
