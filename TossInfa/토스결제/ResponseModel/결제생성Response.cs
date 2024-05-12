using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossInfa.토스결제.ResponseModel
{
    public class 결제생성Response
    {
        public int Code { get; set; }
        public string CheckoutPage { get; set; }
        public string PayToken { get; set; } // # 결제 고유 번호 
    }
}
