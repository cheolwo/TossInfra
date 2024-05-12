namespace TossInfa.RequestModel
{
    public class 결제생성Request
    {
        /// <summary>
        /// 상점 주문번호. 상점 주문 정보와 결제 정보를 매칭하기 위해 필요합니다.
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 결제 금액. 손님으로부터 받을 총 결제금액입니다.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 비과세 금액. 손님으로부터 받을 금액 중 비과세 금액입니다.
        /// </summary>
        public int AmountTaxFree { get; set; }

        /// <summary>
        /// 상품명. 결제할 상품에 대한 정보입니다.
        /// </summary>
        public string ProductDesc { get; set; }

        /// <summary>
        /// 자동 승인 설정. true를 사용하는 경우, 구매자 인증이 완료되면 토스가 알아서 승인을 진행합니다.
        /// </summary>
        public bool AutoExecute { get; set; }

        /// <summary>
        /// 결제 결과 Callback URL. 자동 승인 설정을 true로 설정할 경우에는 반드시 함께 보내주셔야 합니다.
        /// 토스 서버는 출금을 성공한 후 이곳에 입력한 가맹점 서버로 HTTP POST 방식으로 요청합니다.
        /// </summary>
        public string ResultCallback { get; set; }

        /// <summary>
        /// 인증 완료 후 연결할 URL. 구매자가 결제 인증을 완료하면 이곳에 입력한 URL로 연결해드립니다.
        /// 이 URL은 단순히 가맹점의 결제 완료 페이지로의 이동을 위해 사용됩니다.
        /// </summary>
        public string RetUrl { get; set; }

        /// <summary>
        /// 결제 중단 시 사용자를 이동시킬 가맹점 페이지 URL. 토스페이창에 진입한 사용자가 결제를 중단할 때
        /// 사용자를 이동시킬 가맹점 취소 페이지 URL을 입력해주세요.
        /// </summary>
        public string RetCancelUrl { get; set; }
    }


}
