using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asto.Models
{
    [MetadataType(typeof(OrderMD))]
    public partial class Order_This
    {
        public class OrderMD
        {
            [DisplayName("訂單編號")]
            public string OT_ID { get; set; }

            [DisplayName("訂購人")]
            [Required(ErrorMessage = "此欄位為必填!")]
            public string Guest { get; set; }

            [DisplayName("聯絡電話")]
            [Required(ErrorMessage = "此欄位為必填!")]
            public string Phone { get; set; }
            
            [DisplayName("E-Mail")]
            [Required(ErrorMessage = "此欄位為必填!")]
            public string Mail { get; set; }

            [DisplayName("縣市")]
            public string City { get; set; }

            [DisplayName("鄉鎮")]
            public string District { get; set; }

            [DisplayName("郵遞區號")]
            public string PostaCode { get; set; }

            [DisplayName("配送地址")]
            [Required(ErrorMessage = "此欄位為必填!")]
            public string Address { get; set; }

            [DisplayName("發票抬頭")]
            public string InvoiceTitle { get; set; }

            [DisplayName("統一編號")]
            public string UniformNumbers { get; set; }

            [DisplayName("付款方式")]
            public string PayMethod { get; set; }

            [DisplayName("訂單時間")]
            public Nullable<System.DateTime> Datetime { get; set; }

            [DisplayName("優惠方案")]
            public string Preferential { get; set; }

            [DisplayName("總金額")]
            public Nullable<decimal> TotlePrice { get; set; }

            [DisplayName("帳號後五碼")]
            public string LastNumber { get; set; }

            [DisplayName("付款狀態")]
            public string Status { get; set; }

            [DisplayName("運費")]
            public Nullable<decimal> ShippingFee { get; set; }

            [DisplayName("貨運編號")]
            public string TrackingNumber { get; set; }

            [DisplayName("出貨狀態")]
            public string ShippingStatus { get; set; }

            [DisplayName("備註")]
            public string Remark { get; set; }

            public virtual ICollection<Order_Details> Order_Details { get; set; }
        }
    }
}
