﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace JAAReceipts.Web.Models
{
    public class Receipt
    {
        [Key]
        public int ReceiptID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Payment Type")]

        public virtual PaymentType PaymentType { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "Bank Account Number")]
        public long BankAccountNumber { get; set; }

        [Display(Name = "Income Account Number")]
        public long IncomeAccountNumber { get; set; }

        [Display(Name = "Line Of Business Account Number")]
        public string LineOfBusinessAccountNumber { get; set; }

        public int DocumentTypeID  { get; set; }

        public DocumentType DocumentType { get; set; }

        [Display(Name = "Receipt Code")]
        public long  ReceiptCode { get; set; }

        [Display(Name = "Recieved From ")]
        public string ReceivedFrom { get; set; }

#nullable enable
        [Display(Name = "Additional Information")]
        public string? AdditionalInfo { get; set; }

#nullable disable 

        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}