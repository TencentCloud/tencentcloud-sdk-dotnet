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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyOutwardOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 对接方汇出指令编号
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 定价币种
        /// </summary>
        [JsonProperty("PricingCurrency")]
        public string PricingCurrency{ get; set; }

        /// <summary>
        /// 源币种
        /// </summary>
        [JsonProperty("SourceCurrency")]
        public string SourceCurrency{ get; set; }

        /// <summary>
        /// 目的币种
        /// </summary>
        [JsonProperty("TargetCurrency")]
        public string TargetCurrency{ get; set; }

        /// <summary>
        /// 收款人类型
        /// </summary>
        [JsonProperty("PayeeType")]
        public string PayeeType{ get; set; }

        /// <summary>
        /// 收款人账号
        /// </summary>
        [JsonProperty("PayeeAccount")]
        public string PayeeAccount{ get; set; }

        /// <summary>
        /// 源币种金额
        /// </summary>
        [JsonProperty("SourceAmount")]
        public float? SourceAmount{ get; set; }

        /// <summary>
        /// 目的金额
        /// </summary>
        [JsonProperty("TargetAmount")]
        public float? TargetAmount{ get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [JsonProperty("PayeeName")]
        public string PayeeName{ get; set; }

        /// <summary>
        /// 收款人地址
        /// </summary>
        [JsonProperty("PayeeAddress")]
        public string PayeeAddress{ get; set; }

        /// <summary>
        /// 收款人银行账号类型
        /// </summary>
        [JsonProperty("PayeeBankAccountType")]
        public string PayeeBankAccountType{ get; set; }

        /// <summary>
        /// 收款人国家或地区编码
        /// </summary>
        [JsonProperty("PayeeCountryCode")]
        public string PayeeCountryCode{ get; set; }

        /// <summary>
        /// 收款人开户银行名称
        /// </summary>
        [JsonProperty("PayeeBankName")]
        public string PayeeBankName{ get; set; }

        /// <summary>
        /// 收款人开户银行地址
        /// </summary>
        [JsonProperty("PayeeBankAddress")]
        public string PayeeBankAddress{ get; set; }

        /// <summary>
        /// 收款人开户银行所在国家或地区编码
        /// </summary>
        [JsonProperty("PayeeBankDistrict")]
        public string PayeeBankDistrict{ get; set; }

        /// <summary>
        /// 收款银行SwiftCode
        /// </summary>
        [JsonProperty("PayeeBankSwiftCode")]
        public string PayeeBankSwiftCode{ get; set; }

        /// <summary>
        /// 收款银行国际编码类型
        /// </summary>
        [JsonProperty("PayeeBankType")]
        public string PayeeBankType{ get; set; }

        /// <summary>
        /// 收款银行国际编码
        /// </summary>
        [JsonProperty("PayeeBankCode")]
        public string PayeeBankCode{ get; set; }

        /// <summary>
        /// 收款人附言
        /// </summary>
        [JsonProperty("ReferenceForBeneficiary")]
        public string ReferenceForBeneficiary{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "PricingCurrency", this.PricingCurrency);
            this.SetParamSimple(map, prefix + "SourceCurrency", this.SourceCurrency);
            this.SetParamSimple(map, prefix + "TargetCurrency", this.TargetCurrency);
            this.SetParamSimple(map, prefix + "PayeeType", this.PayeeType);
            this.SetParamSimple(map, prefix + "PayeeAccount", this.PayeeAccount);
            this.SetParamSimple(map, prefix + "SourceAmount", this.SourceAmount);
            this.SetParamSimple(map, prefix + "TargetAmount", this.TargetAmount);
            this.SetParamSimple(map, prefix + "PayeeName", this.PayeeName);
            this.SetParamSimple(map, prefix + "PayeeAddress", this.PayeeAddress);
            this.SetParamSimple(map, prefix + "PayeeBankAccountType", this.PayeeBankAccountType);
            this.SetParamSimple(map, prefix + "PayeeCountryCode", this.PayeeCountryCode);
            this.SetParamSimple(map, prefix + "PayeeBankName", this.PayeeBankName);
            this.SetParamSimple(map, prefix + "PayeeBankAddress", this.PayeeBankAddress);
            this.SetParamSimple(map, prefix + "PayeeBankDistrict", this.PayeeBankDistrict);
            this.SetParamSimple(map, prefix + "PayeeBankSwiftCode", this.PayeeBankSwiftCode);
            this.SetParamSimple(map, prefix + "PayeeBankType", this.PayeeBankType);
            this.SetParamSimple(map, prefix + "PayeeBankCode", this.PayeeBankCode);
            this.SetParamSimple(map, prefix + "ReferenceForBeneficiary", this.ReferenceForBeneficiary);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

