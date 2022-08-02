/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class VatInvoice : AbstractModel
    {
        
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
        /// 购方抬头
        /// </summary>
        [JsonProperty("BuyerName")]
        public string BuyerName{ get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [JsonProperty("BuyerTaxCode")]
        public string BuyerTaxCode{ get; set; }

        /// <summary>
        /// 购方地址电话
        /// </summary>
        [JsonProperty("BuyerAddressPhone")]
        public string BuyerAddressPhone{ get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [JsonProperty("BuyerBankAccount")]
        public string BuyerBankAccount{ get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [JsonProperty("SellerName")]
        public string SellerName{ get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [JsonProperty("SellerTaxCode")]
        public string SellerTaxCode{ get; set; }

        /// <summary>
        /// 销方地址电话
        /// </summary>
        [JsonProperty("SellerAddressPhone")]
        public string SellerAddressPhone{ get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [JsonProperty("SellerBankAccount")]
        public string SellerBankAccount{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 机器编码
        /// </summary>
        [JsonProperty("MachineNo")]
        public string MachineNo{ get; set; }

        /// <summary>
        /// 票种类型
        /// 01：增值税专用发票，
        /// 02：货运运输业增值税专用发票，
        /// 03：机动车销售统一发票，
        /// 04：增值税普通发票，
        /// 08：增值税电子专用发票（含全电，全电仅新版接口支持），
        /// 10：增值税电子普通发票（含全电，全电仅新版接口支持），
        /// 11：增值税普通发票（卷式），
        /// 14：增值税电子（通行费）发票，
        /// 15：二手车销售统一发票，
        /// 32：深圳区块链发票
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 检验码
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 是否作废（红冲）是否作废（红冲）
        /// Y：已作废，N：未作废，H：红冲，HP：部分红冲，HF：全额红冲
        /// </summary>
        [JsonProperty("IsAbandoned")]
        public string IsAbandoned{ get; set; }

        /// <summary>
        /// 是否有销货清单 
        /// Y: 有清单 N：无清单 
        /// 卷票无
        /// </summary>
        [JsonProperty("HasSellerList")]
        public string HasSellerList{ get; set; }

        /// <summary>
        /// 销货清单标题
        /// </summary>
        [JsonProperty("SellerListTitle")]
        public string SellerListTitle{ get; set; }

        /// <summary>
        /// 销货清单税额
        /// </summary>
        [JsonProperty("SellerListTax")]
        public string SellerListTax{ get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("AmountWithoutTax")]
        public string AmountWithoutTax{ get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// 含税金额
        /// </summary>
        [JsonProperty("AmountWithTax")]
        public string AmountWithTax{ get; set; }

        /// <summary>
        /// 项目明细
        /// </summary>
        [JsonProperty("Items")]
        public VatInvoiceItem[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "BuyerName", this.BuyerName);
            this.SetParamSimple(map, prefix + "BuyerTaxCode", this.BuyerTaxCode);
            this.SetParamSimple(map, prefix + "BuyerAddressPhone", this.BuyerAddressPhone);
            this.SetParamSimple(map, prefix + "BuyerBankAccount", this.BuyerBankAccount);
            this.SetParamSimple(map, prefix + "SellerName", this.SellerName);
            this.SetParamSimple(map, prefix + "SellerTaxCode", this.SellerTaxCode);
            this.SetParamSimple(map, prefix + "SellerAddressPhone", this.SellerAddressPhone);
            this.SetParamSimple(map, prefix + "SellerBankAccount", this.SellerBankAccount);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MachineNo", this.MachineNo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "IsAbandoned", this.IsAbandoned);
            this.SetParamSimple(map, prefix + "HasSellerList", this.HasSellerList);
            this.SetParamSimple(map, prefix + "SellerListTitle", this.SellerListTitle);
            this.SetParamSimple(map, prefix + "SellerListTax", this.SellerListTax);
            this.SetParamSimple(map, prefix + "AmountWithoutTax", this.AmountWithoutTax);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "AmountWithTax", this.AmountWithTax);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

