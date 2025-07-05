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

    public class AirTicketInfo : AbstractModel
    {
        
        /// <summary>
        /// 旅客姓名
        /// </summary>
        [JsonProperty("PassengerName")]
        public string PassengerName{ get; set; }

        /// <summary>
        /// 有效身份证件号码
        /// </summary>
        [JsonProperty("ValidIdNumber")]
        public string ValidIdNumber{ get; set; }

        /// <summary>
        /// 签注
        /// </summary>
        [JsonProperty("Endorsement")]
        public string Endorsement{ get; set; }

        /// <summary>
        /// GP单号
        /// </summary>
        [JsonProperty("NumberOfGPOrder")]
        public string NumberOfGPOrder{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("ElectronicInvoiceAirTransportReceiptNumber")]
        public string ElectronicInvoiceAirTransportReceiptNumber{ get; set; }

        /// <summary>
        /// 机票详细信息元组
        /// </summary>
        [JsonProperty("DetailInformationOfAirTicketTuple")]
        public DetailInformationOfAirTicketTupleList[] DetailInformationOfAirTicketTuple{ get; set; }

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
        [JsonProperty("VatRate")]
        public string VatRate{ get; set; }

        /// <summary>
        /// 增值税税额
        /// </summary>
        [JsonProperty("VatTaxAmount")]
        public string VatTaxAmount{ get; set; }

        /// <summary>
        /// 民航发展基金
        /// </summary>
        [JsonProperty("CivilAviationDevelopmentFund")]
        public string CivilAviationDevelopmentFund{ get; set; }

        /// <summary>
        /// 其他税费
        /// </summary>
        [JsonProperty("OtherTaxes")]
        public string OtherTaxes{ get; set; }

        /// <summary>
        /// 合计
        /// </summary>
        [JsonProperty("TotalAmount")]
        public string TotalAmount{ get; set; }

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
        /// 销售网点代号
        /// </summary>
        [JsonProperty("AgentCode")]
        public string AgentCode{ get; set; }

        /// <summary>
        /// 填开单位
        /// </summary>
        [JsonProperty("IssueParty")]
        public string IssueParty{ get; set; }

        /// <summary>
        /// 填开时间
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// 开具状态
        /// </summary>
        [JsonProperty("IssuingStatus")]
        public string IssuingStatus{ get; set; }

        /// <summary>
        /// 国内国际标识
        /// </summary>
        [JsonProperty("MarkingOfDomesticOrInternational")]
        public string MarkingOfDomesticOrInternational{ get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonProperty("NameOfPurchaser")]
        public string NameOfPurchaser{ get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [JsonProperty("NameOfSeller")]
        public string NameOfSeller{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCodeOfPurchaser")]
        public string UnifiedSocialCreditCodeOfPurchaser{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PassengerName", this.PassengerName);
            this.SetParamSimple(map, prefix + "ValidIdNumber", this.ValidIdNumber);
            this.SetParamSimple(map, prefix + "Endorsement", this.Endorsement);
            this.SetParamSimple(map, prefix + "NumberOfGPOrder", this.NumberOfGPOrder);
            this.SetParamSimple(map, prefix + "ElectronicInvoiceAirTransportReceiptNumber", this.ElectronicInvoiceAirTransportReceiptNumber);
            this.SetParamArrayObj(map, prefix + "DetailInformationOfAirTicketTuple.", this.DetailInformationOfAirTicketTuple);
            this.SetParamSimple(map, prefix + "Fare", this.Fare);
            this.SetParamSimple(map, prefix + "FuelSurcharge", this.FuelSurcharge);
            this.SetParamSimple(map, prefix + "VatRate", this.VatRate);
            this.SetParamSimple(map, prefix + "VatTaxAmount", this.VatTaxAmount);
            this.SetParamSimple(map, prefix + "CivilAviationDevelopmentFund", this.CivilAviationDevelopmentFund);
            this.SetParamSimple(map, prefix + "OtherTaxes", this.OtherTaxes);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "ElectronicTicketNum", this.ElectronicTicketNum);
            this.SetParamSimple(map, prefix + "VerificationCode", this.VerificationCode);
            this.SetParamSimple(map, prefix + "PromptInformation", this.PromptInformation);
            this.SetParamSimple(map, prefix + "Insurance", this.Insurance);
            this.SetParamSimple(map, prefix + "AgentCode", this.AgentCode);
            this.SetParamSimple(map, prefix + "IssueParty", this.IssueParty);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "IssuingStatus", this.IssuingStatus);
            this.SetParamSimple(map, prefix + "MarkingOfDomesticOrInternational", this.MarkingOfDomesticOrInternational);
            this.SetParamSimple(map, prefix + "NameOfPurchaser", this.NameOfPurchaser);
            this.SetParamSimple(map, prefix + "NameOfSeller", this.NameOfSeller);
            this.SetParamSimple(map, prefix + "UnifiedSocialCreditCodeOfPurchaser", this.UnifiedSocialCreditCodeOfPurchaser);
        }
    }
}

