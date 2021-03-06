﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace JAAReceipts.WebApp.Models
{
    public class Receipt
    {
        [Key]
        public long ReceiptID { get; set; }

        //public string ReceiptNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Payment Type")]

        public virtual PaymentType PaymentType { get; set; }

        public int PaymentTypeID { get; set; }

        [Display(Name = "Total Amount")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal TotalAmount { get; set; }

        [Display(Name = "Income Account Number")]
        public long IncomeAccountNumber { get; set; }

        [Display(Name = "Line Of Business Account Number")]
        public string LineOfBusinessAccountNumber { get; set; }

        public int DocumentTypeID  { get; set; }

        public DocumentType DocumentType { get; set; }

        [Display(Name = "Receipt Code")]
        public long  ReceiptCode { get; set; }

        [Display(Name = "Recieved From")]
        public string ReceivedFrom { get; set; }

        public Currency Currency { get; set; }



#nullable enable
        public int? CurrencyID { get; set; }

        [Display(Name = "Additional Information")]
        public string? AdditionalInfo { get; set; }

        public string? ChequeNumber { get; set; }

        public int? LastFourDigits { get; set; }

        public string? CustomerID { get; set; }

        public string? ReceiptNumber { get; set; }

        public virtual  CooperateClients? CooperateClient { get; set; }

        public int? CooperateClientID { get; set; }

        [Display(Name = "Bank Account Number")]
        public long? BankAccountNumber { get; set; }

#nullable disable

        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }

        //public int ReceiptItemsID { get; set; }


    }
}
