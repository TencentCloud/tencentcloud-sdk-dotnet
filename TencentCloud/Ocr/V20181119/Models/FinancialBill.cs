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

    public class FinancialBill : AbstractModel
    {
        
        /// <summary>
        /// 票据代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 票据号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 缴款人纳税识别号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 校验码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 缴款人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 开票日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 收款单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SellerCompany")]
        public string SellerCompany{ get; set; }

        /// <summary>
        /// 复核人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// 收款人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 票据名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 金额合计
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 金额合计中文大写
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCn")]
        public string TotalCn{ get; set; }

        /// <summary>
        /// 冲红
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RushRedStateCode")]
        public string RushRedStateCode{ get; set; }

        /// <summary>
        /// 冲红日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RushRedDate")]
        public string RushRedDate{ get; set; }

        /// <summary>
        /// 冲红时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RushRedTime")]
        public string RushRedTime{ get; set; }

        /// <summary>
        /// 冲红原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RushRedReason")]
        public string RushRedReason{ get; set; }

        /// <summary>
        /// 项目明细
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinancialBillItems")]
        public FinancialBillItem[] FinancialBillItems{ get; set; }

        /// <summary>
        /// 项目清单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinancialBillItemDetails")]
        public FinancialBillItemDetails[] FinancialBillItemDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "SellerCompany", this.SellerCompany);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TotalCn", this.TotalCn);
            this.SetParamSimple(map, prefix + "RushRedStateCode", this.RushRedStateCode);
            this.SetParamSimple(map, prefix + "RushRedDate", this.RushRedDate);
            this.SetParamSimple(map, prefix + "RushRedTime", this.RushRedTime);
            this.SetParamSimple(map, prefix + "RushRedReason", this.RushRedReason);
            this.SetParamArrayObj(map, prefix + "FinancialBillItems.", this.FinancialBillItems);
            this.SetParamArrayObj(map, prefix + "FinancialBillItemDetails.", this.FinancialBillItemDetails);
        }
    }
}

