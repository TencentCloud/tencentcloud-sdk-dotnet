/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NonTaxIncomeBill : AbstractModel
    {
        
        /// <summary>
        /// <p>发票名称</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>发票号码</p>
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// <p>发票代码</p>
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// <p>校验码</p>
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// <p>开票日期</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>价税合计（小写）</p>
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// <p>价税合计（大写）</p>
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// <p>交款人名称</p>
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// <p>交款人纳税人识别号</p>
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// <p>收款人名称</p>
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// <p>收款单位名称</p>
        /// </summary>
        [JsonProperty("SellerCompany")]
        public string SellerCompany{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>币种</p>
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// <p>复核人</p>
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// <p>是否存在二维码（1：有，0：无）</p>
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// <p>其他信息</p>
        /// </summary>
        [JsonProperty("OtherInfo")]
        public string OtherInfo{ get; set; }

        /// <summary>
        /// <p>缴款码</p>
        /// </summary>
        [JsonProperty("PaymentCode")]
        public string PaymentCode{ get; set; }

        /// <summary>
        /// <p>执收单位编码</p>
        /// </summary>
        [JsonProperty("ReceiveUnitCode")]
        public string ReceiveUnitCode{ get; set; }

        /// <summary>
        /// <p>执收单位名称</p>
        /// </summary>
        [JsonProperty("Receiver")]
        public string Receiver{ get; set; }

        /// <summary>
        /// <p>经办人</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>付款人账号</p>
        /// </summary>
        [JsonProperty("PayerAccount")]
        public string PayerAccount{ get; set; }

        /// <summary>
        /// <p>付款人开户银行</p>
        /// </summary>
        [JsonProperty("PayerBank")]
        public string PayerBank{ get; set; }

        /// <summary>
        /// <p>收款人账号</p>
        /// </summary>
        [JsonProperty("ReceiverAccount")]
        public string ReceiverAccount{ get; set; }

        /// <summary>
        /// <p>收款人开户银行</p>
        /// </summary>
        [JsonProperty("ReceiverBank")]
        public string ReceiverBank{ get; set; }

        /// <summary>
        /// <p>条目</p>
        /// </summary>
        [JsonProperty("NonTaxItems")]
        public NonTaxItem[] NonTaxItems{ get; set; }

        /// <summary>
        /// <p>票据名称</p>
        /// </summary>
        [JsonProperty("BillName")]
        public string BillName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerCompany", this.SellerCompany);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CurrencyCode", this.CurrencyCode);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "OtherInfo", this.OtherInfo);
            this.SetParamSimple(map, prefix + "PaymentCode", this.PaymentCode);
            this.SetParamSimple(map, prefix + "ReceiveUnitCode", this.ReceiveUnitCode);
            this.SetParamSimple(map, prefix + "Receiver", this.Receiver);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "PayerAccount", this.PayerAccount);
            this.SetParamSimple(map, prefix + "PayerBank", this.PayerBank);
            this.SetParamSimple(map, prefix + "ReceiverAccount", this.ReceiverAccount);
            this.SetParamSimple(map, prefix + "ReceiverBank", this.ReceiverBank);
            this.SetParamArrayObj(map, prefix + "NonTaxItems.", this.NonTaxItems);
            this.SetParamSimple(map, prefix + "BillName", this.BillName);
        }
    }
}

