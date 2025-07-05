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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInvoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 开票平台ID。0：高灯，1：票易通
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }

        /// <summary>
        /// 抬头类型：1：个人/政府事业单位；2：企业
        /// </summary>
        [JsonProperty("TitleType")]
        public long? TitleType{ get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [JsonProperty("BuyerTitle")]
        public string BuyerTitle{ get; set; }

        /// <summary>
        /// 业务开票号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 含税总金额（单位为分）
        /// </summary>
        [JsonProperty("AmountHasTax")]
        public long? AmountHasTax{ get; set; }

        /// <summary>
        /// 总税额（单位为分）
        /// </summary>
        [JsonProperty("TaxAmount")]
        public long? TaxAmount{ get; set; }

        /// <summary>
        /// 不含税总金额（单位为分）。InvoicePlatformId 为1时，传默认值-1
        /// </summary>
        [JsonProperty("AmountWithoutTax")]
        public long? AmountWithoutTax{ get; set; }

        /// <summary>
        /// 销方纳税人识别号
        /// </summary>
        [JsonProperty("SellerTaxpayerNum")]
        public string SellerTaxpayerNum{ get; set; }

        /// <summary>
        /// 销方名称。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("SellerName")]
        public string SellerName{ get; set; }

        /// <summary>
        /// 销方地址。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("SellerAddress")]
        public string SellerAddress{ get; set; }

        /// <summary>
        /// 销方电话。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("SellerPhone")]
        public string SellerPhone{ get; set; }

        /// <summary>
        /// 销方银行名称。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("SellerBankName")]
        public string SellerBankName{ get; set; }

        /// <summary>
        /// 销方银行账号。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("SellerBankAccount")]
        public string SellerBankAccount{ get; set; }

        /// <summary>
        /// 购方纳税人识别号（购方票面信息）,若抬头类型为2时，必传
        /// </summary>
        [JsonProperty("BuyerTaxpayerNum")]
        public string BuyerTaxpayerNum{ get; set; }

        /// <summary>
        /// 购方地址。开具专用发票时必填
        /// </summary>
        [JsonProperty("BuyerAddress")]
        public string BuyerAddress{ get; set; }

        /// <summary>
        /// 购方银行名称。开具专用发票时必填
        /// </summary>
        [JsonProperty("BuyerBankName")]
        public string BuyerBankName{ get; set; }

        /// <summary>
        /// 购方银行账号。开具专用发票时必填
        /// </summary>
        [JsonProperty("BuyerBankAccount")]
        public string BuyerBankAccount{ get; set; }

        /// <summary>
        /// 购方电话。开具专用发票时必填
        /// </summary>
        [JsonProperty("BuyerPhone")]
        public string BuyerPhone{ get; set; }

        /// <summary>
        /// 收票人邮箱。若填入，会收到发票推送邮件
        /// </summary>
        [JsonProperty("BuyerEmail")]
        public string BuyerEmail{ get; set; }

        /// <summary>
        /// 收票人手机号。若填入，会收到发票推送短信
        /// </summary>
        [JsonProperty("TakerPhone")]
        public string TakerPhone{ get; set; }

        /// <summary>
        /// 开票类型：
        /// 1：增值税专用发票；
        /// 2：增值税普通发票；
        /// 3：增值税电子发票；
        /// 4：增值税卷式发票；
        /// 5：区块链电子发票。
        /// 若该字段不填，或值不为1-5，则认为开具”增值税电子发票”
        /// </summary>
        [JsonProperty("InvoiceType")]
        public long? InvoiceType{ get; set; }

        /// <summary>
        /// 发票结果回传地址
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 开票人姓名。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("Drawer")]
        public string Drawer{ get; set; }

        /// <summary>
        /// 收款人姓名。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("Payee")]
        public string Payee{ get; set; }

        /// <summary>
        /// 复核人姓名。（不填默认读取商户注册时输入的信息）
        /// </summary>
        [JsonProperty("Checker")]
        public string Checker{ get; set; }

        /// <summary>
        /// 税盘号
        /// </summary>
        [JsonProperty("TerminalCode")]
        public string TerminalCode{ get; set; }

        /// <summary>
        /// 征收方式。开具差额征税发票时必填2。开具普通征税发票时为空
        /// </summary>
        [JsonProperty("LevyMethod")]
        public string LevyMethod{ get; set; }

        /// <summary>
        /// 差额征税扣除额（单位为分）
        /// </summary>
        [JsonProperty("Deduction")]
        public long? Deduction{ get; set; }

        /// <summary>
        /// 备注（票面信息）
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 项目商品明细
        /// </summary>
        [JsonProperty("Items")]
        public CreateInvoiceItem[] Items{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 撤销部分商品。0-不撤销，1-撤销
        /// </summary>
        [JsonProperty("UndoPart")]
        public long? UndoPart{ get; set; }

        /// <summary>
        /// 订单下单时间（格式 YYYYMMDD）
        /// </summary>
        [JsonProperty("OrderDate")]
        public string OrderDate{ get; set; }

        /// <summary>
        /// 订单级别折扣（单位为分）
        /// </summary>
        [JsonProperty("Discount")]
        public long? Discount{ get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [JsonProperty("StoreNo")]
        public string StoreNo{ get; set; }

        /// <summary>
        /// 开票渠道。0：APP渠道，1：线下渠道，2：小程序渠道。不填默认为APP渠道
        /// </summary>
        [JsonProperty("InvoiceChannel")]
        public long? InvoiceChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
            this.SetParamSimple(map, prefix + "TitleType", this.TitleType);
            this.SetParamSimple(map, prefix + "BuyerTitle", this.BuyerTitle);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "AmountHasTax", this.AmountHasTax);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "AmountWithoutTax", this.AmountWithoutTax);
            this.SetParamSimple(map, prefix + "SellerTaxpayerNum", this.SellerTaxpayerNum);
            this.SetParamSimple(map, prefix + "SellerName", this.SellerName);
            this.SetParamSimple(map, prefix + "SellerAddress", this.SellerAddress);
            this.SetParamSimple(map, prefix + "SellerPhone", this.SellerPhone);
            this.SetParamSimple(map, prefix + "SellerBankName", this.SellerBankName);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "BuyerTaxpayerNum", this.BuyerTaxpayerNum);
            this.SetParamSimple(map, prefix + "BuyerAddress", this.BuyerAddress);
            this.SetParamSimple(map, prefix + "BuyerBankName", this.BuyerBankName);
            this.SetParamSimple(map, prefix + "BuyerBankAccount", this.BuyerBankAccount);
            this.SetParamSimple(map, prefix + "BuyerPhone", this.BuyerPhone);
            this.SetParamSimple(map, prefix + "BuyerEmail", this.BuyerEmail);
            this.SetParamSimple(map, prefix + "TakerPhone", this.TakerPhone);
            this.SetParamSimple(map, prefix + "InvoiceType", this.InvoiceType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Drawer", this.Drawer);
            this.SetParamSimple(map, prefix + "Payee", this.Payee);
            this.SetParamSimple(map, prefix + "Checker", this.Checker);
            this.SetParamSimple(map, prefix + "TerminalCode", this.TerminalCode);
            this.SetParamSimple(map, prefix + "LevyMethod", this.LevyMethod);
            this.SetParamSimple(map, prefix + "Deduction", this.Deduction);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "UndoPart", this.UndoPart);
            this.SetParamSimple(map, prefix + "OrderDate", this.OrderDate);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "StoreNo", this.StoreNo);
            this.SetParamSimple(map, prefix + "InvoiceChannel", this.InvoiceChannel);
        }
    }
}

