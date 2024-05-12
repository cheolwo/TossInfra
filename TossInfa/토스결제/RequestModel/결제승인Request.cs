using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossInfa.토스결제.RequestModel
{
    public class 결제승인Request
    {
        /// <summary>
        /// 상점의 API Key. 테스트 및 실제 결제에 필요한 키입니다.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// 결제 고유 번호. 결제 요청 시 반환받은 payToken입니다.
        /// </summary>
        public string PayToken { get; set; }
    }

}
