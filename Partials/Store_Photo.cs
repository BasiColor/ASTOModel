using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(StorePhotoMD))]
    public partial class Store_Photo
    {
        public class StorePhotoMD
        {
            [DisplayName("店面ID")]
            public int ST_ID { get; set; }
            [DisplayName("照片ID")]
            public string Pic_ID { get; set; }
            [DisplayName("檔案型別")]
            public string Pic_Type { get; set; }
            [DisplayName("照片類別")]
            public string Category { get; set; }

            public virtual Store_This Store_This { get; set; }
        }
    }
}
