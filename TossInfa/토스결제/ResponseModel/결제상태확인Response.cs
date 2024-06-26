﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TossInfa.토스결제.ResponseModel
{
    public enum PaymentStatus
    {
        PayStandby,
        PayApproved,
        PayCancel,
        PayProgress,
        PayComplete,
        RefundProgress,
        RefundSuccess,
        SettlementComplete,
        SettlementRefundComplete
    }
    public class 결제상태확인Response
    {
        public int Code { get; set; }
        public string PayToken { get; set; }
        public string OrderNo { get; set; }
        public string PayStatus { get; set; }
        public string PayMethod { get; set; }
        public int Amount { get; set; }
        public List<Transaction> Transactions { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime PaidTs { get; set; }
    }

    public class Transaction
    {
        public string StepType { get; set; }
        public string TransactionId { get; set; }
        public int TransactionAmount { get; set; }
        public int DiscountAmount { get; set; }
        public int PointAmount { get; set; }
        public int PaidAmount { get; set; }
        public DateTime RegTs { get; set; }
    }
}
