﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDanvenClient.Models {
    public class ClientProduct {
      
        public int Id { get; set; }       
        public string ProductType { get; set; }     
        public string ProductSerialNumber { get; set; }      
        public string InvoiceNumber { get; set; }

        public ClientProduct(string productType, string productSerialNumber, string invoiceNumber) {
            this.ProductType = productType;
            this.ProductSerialNumber = productSerialNumber;
            this.InvoiceNumber = invoiceNumber;
        }

        public ClientProduct() {

        }

    }
}