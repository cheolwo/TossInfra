namespace TossInfa.토스결제.RequestModel
{
    public class 결제생성Request
    {
        public string OrderNo { get; set; } // 토스몰 고유의 주문번호
        public int Amount { get; set; } // 결제 금액
        public int AmountTaxFree { get; set; } // 비과세 금액
        public string ProductDesc { get; set; } // 상품 정보
        public string ApiKey { get; set; } // 상점의 API Key
        public string RetUrl { get; set; } // 결제 완료 후 연결할 웹 URL
        public string RetCancelUrl { get; set; } // 결제 취소 시 연결할 웹 URL
        public bool AutoExecute { get; set; } // 자동 승인 설정
        public string ResultCallback { get; set; } // 결제 결과 callback 웹 URL
        public string CallbackVersion { get; set; } // callback 버전
        public int AmountTaxable { get; set; } // 결제 금액 중 과세금액
        public int AmountVat { get; set; } // 결제 금액 중 부가세
        public int AmountServiceFee { get; set; } // 결제 금액 중 봉사료
        public DateTime ExpiredTime { get; set; } // 결제 만료 예정 시각
        public bool CashReceipt { get; set; } // 현금영수증 발급 가능 여부
    }
}
