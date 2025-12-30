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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Identity : AbstractModel
    {
        
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("CreditCode")]
        public string CreditCode{ get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        [JsonProperty("OrgCode")]
        public string OrgCode{ get; set; }

        /// <summary>
        /// 营业执照注册编号
        /// </summary>
        [JsonProperty("RegNo")]
        public string RegNo{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("EntName")]
        public string EntName{ get; set; }

        /// <summary>
        /// 修改人法人代表姓名
        /// </summary>
        [JsonProperty("LegalRepName")]
        public string LegalRepName{ get; set; }

        /// <summary>
        /// 渠道经营状态
        /// </summary>
        [JsonProperty("OpState")]
        public string OpState{ get; set; }

        /// <summary>
        /// 经营期限自(格式YYYY-MM-DD)
        /// </summary>
        [JsonProperty("OpFromDate")]
        public string OpFromDate{ get; set; }

        /// <summary>
        /// 经营期限至
        /// </summary>
        [JsonProperty("OpToDate")]
        public string OpToDate{ get; set; }

        /// <summary>
        /// 成立日期(格式YYYY-MM-DD)
        /// </summary>
        [JsonProperty("EstabDate")]
        public string EstabDate{ get; set; }

        /// <summary>
        /// 核准日期(格式YYYY-MM-DD)
        /// </summary>
        [JsonProperty("ApprDate")]
        public string ApprDate{ get; set; }

        /// <summary>
        /// 吊销日期(格式YYYY-MM-DD)
        /// </summary>
        [JsonProperty("RevoDate")]
        public string RevoDate{ get; set; }

        /// <summary>
        /// 注销日期(格式YYYY-MM-DD)
        /// </summary>
        [JsonProperty("CancelDate")]
        public string CancelDate{ get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [JsonProperty("RegOrg")]
        public string RegOrg{ get; set; }

        /// <summary>
        /// 企业类型编码
        /// </summary>
        [JsonProperty("EntTypeCode")]
        public string EntTypeCode{ get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [JsonProperty("EntType")]
        public string EntType{ get; set; }

        /// <summary>
        /// 经营业务范围
        /// </summary>
        [JsonProperty("BizScope")]
        public string BizScope{ get; set; }

        /// <summary>
        /// 许可经营项目
        /// </summary>
        [JsonProperty("LicenseBizItem")]
        public string LicenseBizItem{ get; set; }

        /// <summary>
        /// 注册地址行政编号
        /// </summary>
        [JsonProperty("RegAreaCode")]
        public string RegAreaCode{ get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonProperty("RegAddress")]
        public string RegAddress{ get; set; }

        /// <summary>
        /// 注册资本币种
        /// </summary>
        [JsonProperty("RegCapitalCurtype")]
        public string RegCapitalCurtype{ get; set; }

        /// <summary>
        /// 注册资本（万元）
        /// </summary>
        [JsonProperty("RegCapital")]
        public string RegCapital{ get; set; }

        /// <summary>
        /// 实收资本（万元）
        /// </summary>
        [JsonProperty("PaidCapital")]
        public string PaidCapital{ get; set; }

        /// <summary>
        /// 原注册号
        /// </summary>
        [JsonProperty("OriRegNo")]
        public string OriRegNo{ get; set; }

        /// <summary>
        /// 企业英文名称
        /// </summary>
        [JsonProperty("EntNameEng")]
        public string EntNameEng{ get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        [JsonProperty("OriEntName")]
        public string OriEntName{ get; set; }

        /// <summary>
        /// 企业经营状态枚举。常见值如下：
        /// 未定义的状态 = 0
        /// 正常  = 1
        /// 注销 = 2
        /// 吊销 = 3
        /// 吊销后注销 = 4
        /// 撤销 = 5
        /// 其他 = 99
        /// </summary>
        [JsonProperty("OpStateCode")]
        public long? OpStateCode{ get; set; }

        /// <summary>
        /// 查询日期(格式YYYY-MM-DD)
        /// </summary>
        [JsonProperty("SearchDate")]
        public string SearchDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "OrgCode", this.OrgCode);
            this.SetParamSimple(map, prefix + "RegNo", this.RegNo);
            this.SetParamSimple(map, prefix + "EntName", this.EntName);
            this.SetParamSimple(map, prefix + "LegalRepName", this.LegalRepName);
            this.SetParamSimple(map, prefix + "OpState", this.OpState);
            this.SetParamSimple(map, prefix + "OpFromDate", this.OpFromDate);
            this.SetParamSimple(map, prefix + "OpToDate", this.OpToDate);
            this.SetParamSimple(map, prefix + "EstabDate", this.EstabDate);
            this.SetParamSimple(map, prefix + "ApprDate", this.ApprDate);
            this.SetParamSimple(map, prefix + "RevoDate", this.RevoDate);
            this.SetParamSimple(map, prefix + "CancelDate", this.CancelDate);
            this.SetParamSimple(map, prefix + "RegOrg", this.RegOrg);
            this.SetParamSimple(map, prefix + "EntTypeCode", this.EntTypeCode);
            this.SetParamSimple(map, prefix + "EntType", this.EntType);
            this.SetParamSimple(map, prefix + "BizScope", this.BizScope);
            this.SetParamSimple(map, prefix + "LicenseBizItem", this.LicenseBizItem);
            this.SetParamSimple(map, prefix + "RegAreaCode", this.RegAreaCode);
            this.SetParamSimple(map, prefix + "RegAddress", this.RegAddress);
            this.SetParamSimple(map, prefix + "RegCapitalCurtype", this.RegCapitalCurtype);
            this.SetParamSimple(map, prefix + "RegCapital", this.RegCapital);
            this.SetParamSimple(map, prefix + "PaidCapital", this.PaidCapital);
            this.SetParamSimple(map, prefix + "OriRegNo", this.OriRegNo);
            this.SetParamSimple(map, prefix + "EntNameEng", this.EntNameEng);
            this.SetParamSimple(map, prefix + "OriEntName", this.OriEntName);
            this.SetParamSimple(map, prefix + "OpStateCode", this.OpStateCode);
            this.SetParamSimple(map, prefix + "SearchDate", this.SearchDate);
        }
    }
}

