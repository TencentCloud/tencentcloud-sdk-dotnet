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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrossBorderCompliance : AbstractModel
    {
        
        /// <summary>
        /// 服务商，可选值：`UNICOM`。
        /// </summary>
        [JsonProperty("ServiceProvider")]
        public string ServiceProvider{ get; set; }

        /// <summary>
        /// 合规化审批单`ID`。
        /// </summary>
        [JsonProperty("ComplianceId")]
        public ulong? ComplianceId{ get; set; }

        /// <summary>
        /// 公司全称。
        /// </summary>
        [JsonProperty("Company")]
        public string Company{ get; set; }

        /// <summary>
        /// 统一社会信用代码。
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 法定代表人。
        /// </summary>
        [JsonProperty("LegalPerson")]
        public string LegalPerson{ get; set; }

        /// <summary>
        /// 发证机关。
        /// </summary>
        [JsonProperty("IssuingAuthority")]
        public string IssuingAuthority{ get; set; }

        /// <summary>
        /// 营业执照。
        /// </summary>
        [JsonProperty("BusinessLicense")]
        public string BusinessLicense{ get; set; }

        /// <summary>
        /// 营业执照住所。
        /// </summary>
        [JsonProperty("BusinessAddress")]
        public string BusinessAddress{ get; set; }

        /// <summary>
        /// 邮编。
        /// </summary>
        [JsonProperty("PostCode")]
        public ulong? PostCode{ get; set; }

        /// <summary>
        /// 经办人。
        /// </summary>
        [JsonProperty("Manager")]
        public string Manager{ get; set; }

        /// <summary>
        /// 经办人身份证号。
        /// </summary>
        [JsonProperty("ManagerId")]
        public string ManagerId{ get; set; }

        /// <summary>
        /// 经办人身份证。
        /// </summary>
        [JsonProperty("ManagerIdCard")]
        public string ManagerIdCard{ get; set; }

        /// <summary>
        /// 经办人身份证地址。
        /// </summary>
        [JsonProperty("ManagerAddress")]
        public string ManagerAddress{ get; set; }

        /// <summary>
        /// 经办人联系电话。
        /// </summary>
        [JsonProperty("ManagerTelephone")]
        public string ManagerTelephone{ get; set; }

        /// <summary>
        /// 电子邮箱。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 服务受理单。
        /// </summary>
        [JsonProperty("ServiceHandlingForm")]
        public string ServiceHandlingForm{ get; set; }

        /// <summary>
        /// 授权函。
        /// </summary>
        [JsonProperty("AuthorizationLetter")]
        public string AuthorizationLetter{ get; set; }

        /// <summary>
        /// 信息安全承诺书。
        /// </summary>
        [JsonProperty("SafetyCommitment")]
        public string SafetyCommitment{ get; set; }

        /// <summary>
        /// 服务开始时间。
        /// </summary>
        [JsonProperty("ServiceStartDate")]
        public string ServiceStartDate{ get; set; }

        /// <summary>
        /// 服务截止时间。
        /// </summary>
        [JsonProperty("ServiceEndDate")]
        public string ServiceEndDate{ get; set; }

        /// <summary>
        /// 状态。待审批：`PENDING`，已通过：`APPROVED`，已拒绝：`DENY`。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 审批单创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 法定代表人身份证号。
        /// </summary>
        [JsonProperty("LegalPersonId")]
        public string LegalPersonId{ get; set; }

        /// <summary>
        /// 法定代表人身份证。
        /// </summary>
        [JsonProperty("LegalPersonIdCard")]
        public string LegalPersonIdCard{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceProvider", this.ServiceProvider);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamSimple(map, prefix + "Company", this.Company);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalPerson", this.LegalPerson);
            this.SetParamSimple(map, prefix + "IssuingAuthority", this.IssuingAuthority);
            this.SetParamSimple(map, prefix + "BusinessLicense", this.BusinessLicense);
            this.SetParamSimple(map, prefix + "BusinessAddress", this.BusinessAddress);
            this.SetParamSimple(map, prefix + "PostCode", this.PostCode);
            this.SetParamSimple(map, prefix + "Manager", this.Manager);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "ManagerIdCard", this.ManagerIdCard);
            this.SetParamSimple(map, prefix + "ManagerAddress", this.ManagerAddress);
            this.SetParamSimple(map, prefix + "ManagerTelephone", this.ManagerTelephone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ServiceHandlingForm", this.ServiceHandlingForm);
            this.SetParamSimple(map, prefix + "AuthorizationLetter", this.AuthorizationLetter);
            this.SetParamSimple(map, prefix + "SafetyCommitment", this.SafetyCommitment);
            this.SetParamSimple(map, prefix + "ServiceStartDate", this.ServiceStartDate);
            this.SetParamSimple(map, prefix + "ServiceEndDate", this.ServiceEndDate);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "LegalPersonId", this.LegalPersonId);
            this.SetParamSimple(map, prefix + "LegalPersonIdCard", this.LegalPersonIdCard);
        }
    }
}

