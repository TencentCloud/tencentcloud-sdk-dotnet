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

    public class ElectronicAirTransport : AbstractModel
    {
        
        /// <summary>
        /// 发票代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 发票号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 开票日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Amount")]
        public string Amount{ get; set; }

        /// <summary>
        /// 校验码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckCode")]
        public string CheckCode{ get; set; }

        /// <summary>
        /// 价税合计
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 抵扣标志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeductionMark")]
        public string DeductionMark{ get; set; }

        /// <summary>
        /// 发票状态代码，0正常 1 未更新  2作废 3已红冲
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StateCode")]
        public string StateCode{ get; set; }

        /// <summary>
        /// 购方识别号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuyerTaxCode")]
        public string BuyerTaxCode{ get; set; }

        /// <summary>
        /// 购方名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuyerName")]
        public string BuyerName{ get; set; }

        /// <summary>
        /// 合计税额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 国内国际标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomesticInternationalMark")]
        public string DomesticInternationalMark{ get; set; }

        /// <summary>
        /// 旅客姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassengerName")]
        public string PassengerName{ get; set; }

        /// <summary>
        /// 有效身份证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassengerNo")]
        public string PassengerNo{ get; set; }

        /// <summary>
        /// 电子客票号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElectronicNumber")]
        public string ElectronicNumber{ get; set; }

        /// <summary>
        /// 全电发票（航空运输电子客票行程单）详细信息
        /// 
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElectronicAirTransportDetails")]
        public ElectronicAirTransportDetail[] ElectronicAirTransportDetails{ get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonProperty("Fare")]
        public string Fare{ get; set; }

        /// <summary>
        /// 燃油附加费
        /// </summary>
        [JsonProperty("FuelSurcharge")]
        public string FuelSurcharge{ get; set; }

        /// <summary>
        /// 增值税税额
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// 民航发展基金
        /// </summary>
        [JsonProperty("DevelopmentFund")]
        public string DevelopmentFund{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "CheckCode", this.CheckCode);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "DeductionMark", this.DeductionMark);
            this.SetParamSimple(map, prefix + "StateCode", this.StateCode);
            this.SetParamSimple(map, prefix + "BuyerTaxCode", this.BuyerTaxCode);
            this.SetParamSimple(map, prefix + "BuyerName", this.BuyerName);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "DomesticInternationalMark", this.DomesticInternationalMark);
            this.SetParamSimple(map, prefix + "PassengerName", this.PassengerName);
            this.SetParamSimple(map, prefix + "PassengerNo", this.PassengerNo);
            this.SetParamSimple(map, prefix + "ElectronicNumber", this.ElectronicNumber);
            this.SetParamArrayObj(map, prefix + "ElectronicAirTransportDetails.", this.ElectronicAirTransportDetails);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "FuelSurcharge", this.FuelSurcharge);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "DevelopmentFund", this.DevelopmentFund);
        }
    }
}

