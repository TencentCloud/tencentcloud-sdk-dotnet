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

    public class ElectronicFlightTicketFull : AbstractModel
    {
        
        /// <summary>
        /// 旅客姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 有效身份证件号码
        /// </summary>
        [JsonProperty("UserID")]
        public string UserID{ get; set; }

        /// <summary>
        /// 签注
        /// </summary>
        [JsonProperty("Endorsement")]
        public string Endorsement{ get; set; }

        /// <summary>
        /// GP单号
        /// </summary>
        [JsonProperty("GPOrder")]
        public string GPOrder{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

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
        /// 增值税税率
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// 增值税税额
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 民航发展基金
        /// </summary>
        [JsonProperty("DevelopmentFund")]
        public string DevelopmentFund{ get; set; }

        /// <summary>
        /// 其他税费
        /// </summary>
        [JsonProperty("OtherTax")]
        public string OtherTax{ get; set; }

        /// <summary>
        /// 合计
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 电子客票号码
        /// </summary>
        [JsonProperty("ElectronicTicketNum")]
        public string ElectronicTicketNum{ get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [JsonProperty("VerificationCode")]
        public string VerificationCode{ get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("PromptInformation")]
        public string PromptInformation{ get; set; }

        /// <summary>
        /// 保险费
        /// </summary>
        [JsonProperty("Insurance")]
        public string Insurance{ get; set; }

        /// <summary>
        /// 填开单位
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 填开时间
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 国内国际标识
        /// </summary>
        [JsonProperty("DomesticInternationalTag")]
        public string DomesticInternationalTag{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("Buyer")]
        public string Buyer{ get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [JsonProperty("Seller")]
        public string Seller{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("BuyerTaxID")]
        public string BuyerTaxID{ get; set; }

        /// <summary>
        /// 机票详细信息元组
        /// </summary>
        [JsonProperty("FlightItems")]
        public FlightItemInfo[] FlightItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserID", this.UserID);
            this.SetParamSimple(map, prefix + "Endorsement", this.Endorsement);
            this.SetParamSimple(map, prefix + "GPOrder", this.GPOrder);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "FuelSurcharge", this.FuelSurcharge);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "DevelopmentFund", this.DevelopmentFund);
            this.SetParamSimple(map, prefix + "OtherTax", this.OtherTax);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "ElectronicTicketNum", this.ElectronicTicketNum);
            this.SetParamSimple(map, prefix + "VerificationCode", this.VerificationCode);
            this.SetParamSimple(map, prefix + "PromptInformation", this.PromptInformation);
            this.SetParamSimple(map, prefix + "Insurance", this.Insurance);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "DomesticInternationalTag", this.DomesticInternationalTag);
            this.SetParamSimple(map, prefix + "Buyer", this.Buyer);
            this.SetParamSimple(map, prefix + "Seller", this.Seller);
            this.SetParamSimple(map, prefix + "BuyerTaxID", this.BuyerTaxID);
            this.SetParamArrayObj(map, prefix + "FlightItems.", this.FlightItems);
        }
    }
}

