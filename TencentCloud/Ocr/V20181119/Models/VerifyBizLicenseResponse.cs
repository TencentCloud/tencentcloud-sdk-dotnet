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

    public class VerifyBizLicenseResponse : AbstractModel
    {
        
        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

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
        /// 经营期限自（YYYY-MM-DD）
        /// </summary>
        [JsonProperty("OpenFrom")]
        public string OpenFrom{ get; set; }

        /// <summary>
        /// 经营期限至（YYYY-MM-DD）
        /// </summary>
        [JsonProperty("OpenTo")]
        public string OpenTo{ get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonProperty("FrName")]
        public string FrName{ get; set; }

        /// <summary>
        /// 经营状态（在营、注销、吊销、其他）
        /// </summary>
        [JsonProperty("EnterpriseStatus")]
        public string EnterpriseStatus{ get; set; }

        /// <summary>
        /// 经营（业务）范围及方式
        /// </summary>
        [JsonProperty("OperateScopeAndForm")]
        public string OperateScopeAndForm{ get; set; }

        /// <summary>
        /// 注册资金（单位:万元）
        /// </summary>
        [JsonProperty("RegCap")]
        public string RegCap{ get; set; }

        /// <summary>
        /// 注册币种
        /// </summary>
        [JsonProperty("RegCapCur")]
        public string RegCapCur{ get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [JsonProperty("RegOrg")]
        public string RegOrg{ get; set; }

        /// <summary>
        /// 开业日期（YYYY-MM-DD）
        /// </summary>
        [JsonProperty("EsDate")]
        public string EsDate{ get; set; }

        /// <summary>
        /// 企业（机构）类型
        /// </summary>
        [JsonProperty("EnterpriseType")]
        public string EnterpriseType{ get; set; }

        /// <summary>
        /// 注销日期
        /// </summary>
        [JsonProperty("CancelDate")]
        public string CancelDate{ get; set; }

        /// <summary>
        /// 吊销日期
        /// </summary>
        [JsonProperty("RevokeDate")]
        public string RevokeDate{ get; set; }

        /// <summary>
        /// 许可经营项目
        /// </summary>
        [JsonProperty("AbuItem")]
        public string AbuItem{ get; set; }

        /// <summary>
        /// 一般经营项目
        /// </summary>
        [JsonProperty("CbuItem")]
        public string CbuItem{ get; set; }

        /// <summary>
        /// 核准时间
        /// </summary>
        [JsonProperty("ApprDate")]
        public string ApprDate{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 地级市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 区\县
        /// </summary>
        [JsonProperty("County")]
        public string County{ get; set; }

        /// <summary>
        /// 住所所在行政区划代码
        /// </summary>
        [JsonProperty("AreaCode")]
        public string AreaCode{ get; set; }

        /// <summary>
        /// 行业门类代码
        /// </summary>
        [JsonProperty("IndustryPhyCode")]
        public string IndustryPhyCode{ get; set; }

        /// <summary>
        /// 行业门类名称
        /// </summary>
        [JsonProperty("IndustryPhyName")]
        public string IndustryPhyName{ get; set; }

        /// <summary>
        /// 国民经济行业代码
        /// </summary>
        [JsonProperty("IndustryCode")]
        public string IndustryCode{ get; set; }

        /// <summary>
        /// 国民经济行业名称
        /// </summary>
        [JsonProperty("IndustryName")]
        public string IndustryName{ get; set; }

        /// <summary>
        /// 经营（业务）范围
        /// </summary>
        [JsonProperty("OperateScope")]
        public string OperateScope{ get; set; }

        /// <summary>
        /// 要核验的工商注册号
        /// </summary>
        [JsonProperty("VerifyRegNo")]
        public string VerifyRegNo{ get; set; }

        /// <summary>
        /// 工商注册号
        /// </summary>
        [JsonProperty("RegNo")]
        public string RegNo{ get; set; }

        /// <summary>
        /// 要核验的企业名称
        /// </summary>
        [JsonProperty("VerifyEnterpriseName")]
        public string VerifyEnterpriseName{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("EnterpriseName")]
        public string EnterpriseName{ get; set; }

        /// <summary>
        /// 要核验的注册地址
        /// </summary>
        [JsonProperty("VerifyAddress")]
        public string VerifyAddress{ get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 验证结果
        /// </summary>
        [JsonProperty("RegNumResult")]
        public BizLicenseVerifyResult RegNumResult{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "OrgCode", this.OrgCode);
            this.SetParamSimple(map, prefix + "OpenFrom", this.OpenFrom);
            this.SetParamSimple(map, prefix + "OpenTo", this.OpenTo);
            this.SetParamSimple(map, prefix + "FrName", this.FrName);
            this.SetParamSimple(map, prefix + "EnterpriseStatus", this.EnterpriseStatus);
            this.SetParamSimple(map, prefix + "OperateScopeAndForm", this.OperateScopeAndForm);
            this.SetParamSimple(map, prefix + "RegCap", this.RegCap);
            this.SetParamSimple(map, prefix + "RegCapCur", this.RegCapCur);
            this.SetParamSimple(map, prefix + "RegOrg", this.RegOrg);
            this.SetParamSimple(map, prefix + "EsDate", this.EsDate);
            this.SetParamSimple(map, prefix + "EnterpriseType", this.EnterpriseType);
            this.SetParamSimple(map, prefix + "CancelDate", this.CancelDate);
            this.SetParamSimple(map, prefix + "RevokeDate", this.RevokeDate);
            this.SetParamSimple(map, prefix + "AbuItem", this.AbuItem);
            this.SetParamSimple(map, prefix + "CbuItem", this.CbuItem);
            this.SetParamSimple(map, prefix + "ApprDate", this.ApprDate);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "County", this.County);
            this.SetParamSimple(map, prefix + "AreaCode", this.AreaCode);
            this.SetParamSimple(map, prefix + "IndustryPhyCode", this.IndustryPhyCode);
            this.SetParamSimple(map, prefix + "IndustryPhyName", this.IndustryPhyName);
            this.SetParamSimple(map, prefix + "IndustryCode", this.IndustryCode);
            this.SetParamSimple(map, prefix + "IndustryName", this.IndustryName);
            this.SetParamSimple(map, prefix + "OperateScope", this.OperateScope);
            this.SetParamSimple(map, prefix + "VerifyRegNo", this.VerifyRegNo);
            this.SetParamSimple(map, prefix + "RegNo", this.RegNo);
            this.SetParamSimple(map, prefix + "VerifyEnterpriseName", this.VerifyEnterpriseName);
            this.SetParamSimple(map, prefix + "EnterpriseName", this.EnterpriseName);
            this.SetParamSimple(map, prefix + "VerifyAddress", this.VerifyAddress);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamObj(map, prefix + "RegNumResult.", this.RegNumResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

