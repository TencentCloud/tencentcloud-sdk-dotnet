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
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 价税合计（小写）
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 价税合计（大写）
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// 交款人名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 交款人纳税人识别号
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 收款人名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 收款单位名称
        /// </summary>
        [JsonProperty("SellerCompany")]
        public string SellerCompany{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode{ get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// 是否存在二维码（1：有，0：无）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        [JsonProperty("OtherInfo")]
        public string OtherInfo{ get; set; }

        /// <summary>
        /// 缴款码
        /// </summary>
        [JsonProperty("PaymentCode")]
        public string PaymentCode{ get; set; }

        /// <summary>
        /// 执收单位编码
        /// </summary>
        [JsonProperty("ReceiveUnitCode")]
        public string ReceiveUnitCode{ get; set; }

        /// <summary>
        /// 执收单位名称
        /// </summary>
        [JsonProperty("Receiver")]
        public string Receiver{ get; set; }

        /// <summary>
        /// 经办人
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 付款人账号
        /// </summary>
        [JsonProperty("PayerAccount")]
        public string PayerAccount{ get; set; }

        /// <summary>
        /// 付款人开户银行
        /// </summary>
        [JsonProperty("PayerBank")]
        public string PayerBank{ get; set; }

        /// <summary>
        /// 收款人账号
        /// </summary>
        [JsonProperty("ReceiverAccount")]
        public string ReceiverAccount{ get; set; }

        /// <summary>
        /// 收款人开户银行
        /// </summary>
        [JsonProperty("ReceiverBank")]
        public string ReceiverBank{ get; set; }

        /// <summary>
        /// 条目
        /// </summary>
        [JsonProperty("NonTaxItems")]
        public NonTaxItem[] NonTaxItems{ get; set; }


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
        }
    }
}

