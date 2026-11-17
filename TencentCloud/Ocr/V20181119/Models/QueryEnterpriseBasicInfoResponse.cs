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

    public class QueryEnterpriseBasicInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>请求状态。<br>枚举值：<br>0：成功，计费；<br>1：系统异常，不计费；<br>2：查询无结果，不计费。</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// <p>统一社会信用代码。</p>
        /// </summary>
        [JsonProperty("CreditCode")]
        public string CreditCode{ get; set; }

        /// <summary>
        /// <p>企业名称。</p>
        /// </summary>
        [JsonProperty("EntName")]
        public string EntName{ get; set; }

        /// <summary>
        /// <p>主体类型。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>法人代表。</p>
        /// </summary>
        [JsonProperty("LrName")]
        public string LrName{ get; set; }

        /// <summary>
        /// <p>注册资本。</p>
        /// </summary>
        [JsonProperty("Capital")]
        public string Capital{ get; set; }

        /// <summary>
        /// <p>企业登记住所或注册地址。</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>经营范围。</p>
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// <p>登记机关。</p>
        /// </summary>
        [JsonProperty("RegistrationAuthority")]
        public string RegistrationAuthority{ get; set; }

        /// <summary>
        /// <p>经营状态（标准化），枚举值：<br>1：开业（在营）；<br>2：迁出；<br>3：注销；<br>4：吊销；<br>5：撤销；<br>6：停业；<br>7：撤销登记；<br>0：其他；/：无法查询。</p>
        /// </summary>
        [JsonProperty("OperatingStatus")]
        public string OperatingStatus{ get; set; }

        /// <summary>
        /// <p>经营状态（原始值）。</p>
        /// </summary>
        [JsonProperty("RawOperatingStatus")]
        public string RawOperatingStatus{ get; set; }

        /// <summary>
        /// <p>成立日期。</p>
        /// </summary>
        [JsonProperty("SetDate")]
        public string SetDate{ get; set; }

        /// <summary>
        /// <p>营业期限：一般包括营业开始时间和结束时间<br>参数格式：yyyy-MM-dd/yyyy-MM-dd<br>无固定期限的格式为：yyyy-MM-dd/<br>部分企业历史数据可能为空，将返回：/<br>无法查询，将返回：/</p>
        /// </summary>
        [JsonProperty("OperatingPeriod")]
        public string OperatingPeriod{ get; set; }

        /// <summary>
        /// <p>核准日期。</p>
        /// </summary>
        [JsonProperty("ApprovalDate")]
        public string ApprovalDate{ get; set; }

        /// <summary>
        /// <p>所在省份。</p>
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// <p>所在省份的行政区划代码。</p>
        /// </summary>
        [JsonProperty("ProvinceCode")]
        public string ProvinceCode{ get; set; }

        /// <summary>
        /// <p>所在城市。</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// <p>所在城市的行政区划代码。</p>
        /// </summary>
        [JsonProperty("CityCode")]
        public string CityCode{ get; set; }

        /// <summary>
        /// <p>所在区县。</p>
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// <p>所在区县的行政区划代码。</p>
        /// </summary>
        [JsonProperty("DistrictCode")]
        public string DistrictCode{ get; set; }

        /// <summary>
        /// <p>注册资本币种。</p>
        /// </summary>
        [JsonProperty("CapitalCurrency")]
        public string CapitalCurrency{ get; set; }

        /// <summary>
        /// <p>组织机构代码。</p>
        /// </summary>
        [JsonProperty("OrganizationCode")]
        public string OrganizationCode{ get; set; }

        /// <summary>
        /// <p>企业英文名称。</p>
        /// </summary>
        [JsonProperty("EnglishName")]
        public string EnglishName{ get; set; }

        /// <summary>
        /// <p>企业曾用名列表。</p>
        /// </summary>
        [JsonProperty("FormerNames")]
        public string[] FormerNames{ get; set; }

        /// <summary>
        /// <p>原注册号。</p>
        /// </summary>
        [JsonProperty("OriginalRegNum")]
        public string OriginalRegNum{ get; set; }

        /// <summary>
        /// <p>实收资本。</p>
        /// </summary>
        [JsonProperty("PaidInCapital")]
        public string PaidInCapital{ get; set; }

        /// <summary>
        /// <p>吊销日期。</p>
        /// </summary>
        [JsonProperty("RevokeDate")]
        public string RevokeDate{ get; set; }

        /// <summary>
        /// <p>吊销原因。</p>
        /// </summary>
        [JsonProperty("RevokeReason")]
        public string RevokeReason{ get; set; }

        /// <summary>
        /// <p>注销日期。</p>
        /// </summary>
        [JsonProperty("CancellationDate")]
        public string CancellationDate{ get; set; }

        /// <summary>
        /// <p>注销原因。</p>
        /// </summary>
        [JsonProperty("CancellationReason")]
        public string CancellationReason{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "EntName", this.EntName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "LrName", this.LrName);
            this.SetParamSimple(map, prefix + "Capital", this.Capital);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "RegistrationAuthority", this.RegistrationAuthority);
            this.SetParamSimple(map, prefix + "OperatingStatus", this.OperatingStatus);
            this.SetParamSimple(map, prefix + "RawOperatingStatus", this.RawOperatingStatus);
            this.SetParamSimple(map, prefix + "SetDate", this.SetDate);
            this.SetParamSimple(map, prefix + "OperatingPeriod", this.OperatingPeriod);
            this.SetParamSimple(map, prefix + "ApprovalDate", this.ApprovalDate);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "ProvinceCode", this.ProvinceCode);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "CityCode", this.CityCode);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "DistrictCode", this.DistrictCode);
            this.SetParamSimple(map, prefix + "CapitalCurrency", this.CapitalCurrency);
            this.SetParamSimple(map, prefix + "OrganizationCode", this.OrganizationCode);
            this.SetParamSimple(map, prefix + "EnglishName", this.EnglishName);
            this.SetParamArraySimple(map, prefix + "FormerNames.", this.FormerNames);
            this.SetParamSimple(map, prefix + "OriginalRegNum", this.OriginalRegNum);
            this.SetParamSimple(map, prefix + "PaidInCapital", this.PaidInCapital);
            this.SetParamSimple(map, prefix + "RevokeDate", this.RevokeDate);
            this.SetParamSimple(map, prefix + "RevokeReason", this.RevokeReason);
            this.SetParamSimple(map, prefix + "CancellationDate", this.CancellationDate);
            this.SetParamSimple(map, prefix + "CancellationReason", this.CancellationReason);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

