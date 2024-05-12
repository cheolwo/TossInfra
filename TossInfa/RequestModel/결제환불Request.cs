using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossInfa.RequestModel
{
    public class 결제환불Request
    {
        /// <summary>
        /// 결제를 생성한 상점의 API key. 필수 항목입니다.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// 결제 생성 완료 후 받은 결제 고유번호. 필수 항목입니다.
        /// </summary>
        public string PayToken { get; set; }

        /// <summary>
        /// 환불할 금액. 이 값이 설정되지 않으면 결제 금액 전액을 환불합니다. 필수 항목입니다.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 환불할 금액 중 비과세 금액. 필수 항목입니다.
        /// </summary>
        public int AmountTaxFree { get; set; }

        /// <summary>
        /// 환불할 금액 중 과세금액. 복합과세 결제 환불 처리에 사용됩니다.
        /// </summary>
        public int AmountTaxable { get; set; }

        /// <summary>
        /// 환불할 금액 중 부가세. 복합과세 결제 환불 처리에 사용됩니다.
        /// </summary>
        public int AmountVat { get; set; }

        /// <summary>
        /// 환불할 금액 중 봉사료. 복합과세 결제 환불 처리에 사용됩니다.
        /// </summary>
        public int AmountServiceFee { get; set; }

        /// <summary>
        /// 결제 환불 사유. 최대 255자까지 남길 수 있습니다. 선택적으로 사용 가능합니다.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 환불 요청 시, 각 세부 금액들의 총합은 반드시 전체 환불 금액(amount)과 동일해야 합니다.
        /// 환불 요청하는 금액은 '남은 결제 금액'보다 작거나 같아야 하며, 다를 시 에러가 발생합니다.
        /// </summary>
    }


}
