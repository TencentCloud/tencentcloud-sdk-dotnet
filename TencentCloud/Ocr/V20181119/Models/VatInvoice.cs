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
        /// 通用机打发票类型时不返回
        /// </summary>
        [JsonProperty("BuyerName")]
        public string BuyerName{ get; set; }

        /// <summary>
        /// 购方税号
        /// 通用机打发票类型时不返回
        /// </summary>
        [JsonProperty("BuyerTaxCode")]
        public string BuyerTaxCode{ get; set; }

        /// <summary>
        /// 购方地址电话
        /// 通用机打发票类型做不返回
        /// </summary>
        [JsonProperty("BuyerAddressPhone")]
        public string BuyerAddressPhone{ get; set; }

        /// <summary>
        /// 购方银行账号
        /// 通用机打发票类型时不返回
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
        /// 09：全电发票，
        /// 0901：全电纸质发票(增值税专用发票)，
        /// 0903：全电纸质(机动车销售统一发票)，
        /// 0904：全电纸质发票(增值税普通发票)，
        /// 0910：电子发票(普通发票)，
        /// 0915：全电纸质(二手车销售统一发票)，
        /// 0920：电子发票(增值税专用发票)，
        /// 0930：电子发票(机动车销售统一发票)，
        /// 0940：电子发票(二手车销售统一发票)，
        /// 10：增值税电子普通发票（含全电，全电仅新版接口支持），
        /// 11：增值税普通发票（卷式），
        /// 14：增值税电子（通行费）发票，
        /// 15：二手车销售统一发票，
        /// 32：深圳区块链发票，
        /// 61：电子发票（航空运输电子客票行程单），
        /// 8208：电子发票(通行费发票)，
        /// 83：电子发票(铁路电子客票)，
        /// 100：区块链发票，
        /// 101：财政票据，
        /// 102：通用电子发票，
        /// 103：车辆通行费
        /// 
        /// 
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 具体的全电发票类型：01: 全电专用发票；02：全电普通发票；03：全电火车票；04：全电机票行程单
        /// </summary>
        [JsonProperty("ElectronicType")]
        public string ElectronicType{ get; set; }

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
        /// 所属税局
        /// </summary>
        [JsonProperty("TaxBureau")]
        public string TaxBureau{ get; set; }

        /// <summary>
        /// 通行费标志:Y、是;N、否
        /// </summary>
        [JsonProperty("TrafficFreeFlag")]
        public string TrafficFreeFlag{ get; set; }

        /// <summary>
        /// 是否为红票
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedLetterInvoiceMark")]
        public bool? RedLetterInvoiceMark{ get; set; }

        /// <summary>
        /// 开具类型标识（0: 委托代开，1：自开，2：代开，3：代办退税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IssuingTypeMark")]
        public long? IssuingTypeMark{ get; set; }

        /// <summary>
        /// 代开销售方名称
        /// </summary>
        [JsonProperty("SellerAgentName")]
        public string SellerAgentName{ get; set; }

        /// <summary>
        /// 代开销售方税号
        /// </summary>
        [JsonProperty("SellerAgentTaxID")]
        public string SellerAgentTaxID{ get; set; }


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
            this.SetParamSimple(map, prefix + "ElectronicType", this.ElectronicType);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "IsAbandoned", this.IsAbandoned);
            this.SetParamSimple(map, prefix + "HasSellerList", this.HasSellerList);
            this.SetParamSimple(map, prefix + "SellerListTitle", this.SellerListTitle);
            this.SetParamSimple(map, prefix + "SellerListTax", this.SellerListTax);
            this.SetParamSimple(map, prefix + "AmountWithoutTax", this.AmountWithoutTax);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "AmountWithTax", this.AmountWithTax);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "TaxBureau", this.TaxBureau);
            this.SetParamSimple(map, prefix + "TrafficFreeFlag", this.TrafficFreeFlag);
            this.SetParamSimple(map, prefix + "RedLetterInvoiceMark", this.RedLetterInvoiceMark);
            this.SetParamSimple(map, prefix + "IssuingTypeMark", this.IssuingTypeMark);
            this.SetParamSimple(map, prefix + "SellerAgentName", this.SellerAgentName);
            this.SetParamSimple(map, prefix + "SellerAgentTaxID", this.SellerAgentTaxID);
        }
    }
}

