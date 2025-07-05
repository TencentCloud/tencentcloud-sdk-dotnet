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

    public class MachinePrintedInvoice : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 是否存在二维码（1：有，0：无）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 密码区
        /// </summary>
        [JsonProperty("Ciphertext")]
        public string Ciphertext{ get; set; }

        /// <summary>
        /// 种类
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 税前金额
        /// </summary>
        [JsonProperty("PretaxAmount")]
        public string PretaxAmount{ get; set; }

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
        /// 合计税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 行业分类
        /// </summary>
        [JsonProperty("IndustryClass")]
        public string IndustryClass{ get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 销售方纳税人识别号
        /// </summary>
        [JsonProperty("SellerTaxID")]
        public string SellerTaxID{ get; set; }

        /// <summary>
        /// 销售方地址电话
        /// </summary>
        [JsonProperty("SellerAddrTel")]
        public string SellerAddrTel{ get; set; }

        /// <summary>
        /// 销售方银行账号
        /// </summary>
        [JsonProperty("SellerBankAccount")]
        public string SellerBankAccount{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 购买方纳税人识别号
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 购买方地址电话
        /// </summary>
        [JsonProperty("BuyerAddrTel")]
        public string BuyerAddrTel{ get; set; }

        /// <summary>
        /// 购买方银行账号
        /// </summary>
        [JsonProperty("BuyerBankAccount")]
        public string BuyerBankAccount{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }

        /// <summary>
        /// 是否为浙江/广东通用机打发票（0：没有，1：有）
        /// </summary>
        [JsonProperty("ElectronicMark")]
        public long? ElectronicMark{ get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonProperty("Receiptor")]
        public string Receiptor{ get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 经办人支付信息
        /// </summary>
        [JsonProperty("PaymentInfo")]
        public string PaymentInfo{ get; set; }

        /// <summary>
        /// 经办人取票用户
        /// </summary>
        [JsonProperty("TicketPickupUser")]
        public string TicketPickupUser{ get; set; }

        /// <summary>
        /// 经办人商户号
        /// </summary>
        [JsonProperty("MerchantNumber")]
        public string MerchantNumber{ get; set; }

        /// <summary>
        /// 经办人订单号
        /// </summary>
        [JsonProperty("OrderNumber")]
        public string OrderNumber{ get; set; }

        /// <summary>
        /// 条目
        /// </summary>
        [JsonProperty("GeneralMachineItems")]
        public GeneralMachineItem[] GeneralMachineItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Ciphertext", this.Ciphertext);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "PretaxAmount", this.PretaxAmount);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "IndustryClass", this.IndustryClass);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "SellerTaxID", this.SellerTaxID);
            this.SetParamSimple(map, prefix + "SellerAddrTel", this.SellerAddrTel);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "BuyerAddrTel", this.BuyerAddrTel);
            this.SetParamSimple(map, prefix + "BuyerBankAccount", this.BuyerBankAccount);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "ElectronicMark", this.ElectronicMark);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Receiptor", this.Receiptor);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PaymentInfo", this.PaymentInfo);
            this.SetParamSimple(map, prefix + "TicketPickupUser", this.TicketPickupUser);
            this.SetParamSimple(map, prefix + "MerchantNumber", this.MerchantNumber);
            this.SetParamSimple(map, prefix + "OrderNumber", this.OrderNumber);
            this.SetParamArrayObj(map, prefix + "GeneralMachineItems.", this.GeneralMachineItems);
        }
    }
}

