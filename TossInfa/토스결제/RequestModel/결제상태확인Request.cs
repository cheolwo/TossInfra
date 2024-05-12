using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossInfa.토스결제.RequestModel
{
    public class 결제상태확인Request
    {
        /// <summary>
        /// 상점의 API Key. 필수 항목입니다.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// 결제 생성 완료 후 받은 결제 고유번호. 필수 항목입니다.
        /// </summary>
        public string PayToken { get; set; }
    }
}
