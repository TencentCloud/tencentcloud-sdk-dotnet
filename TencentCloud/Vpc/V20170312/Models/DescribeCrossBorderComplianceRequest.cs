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

    public class DescribeCrossBorderComplianceRequest : AbstractModel
    {
        
        /// <summary>
        /// （精确匹配）服务商，可选值：`UNICOM`。
        /// </summary>
        [JsonProperty("ServiceProvider")]
        public string ServiceProvider{ get; set; }

        /// <summary>
        /// （精确匹配）合规化审批单`ID`。
        /// </summary>
        [JsonProperty("ComplianceId")]
        public ulong? ComplianceId{ get; set; }

        /// <summary>
        /// （模糊查询）公司名称。
        /// </summary>
        [JsonProperty("Company")]
        public string Company{ get; set; }

        /// <summary>
        /// （精确匹配）统一社会信用代码。
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// （模糊查询）法定代表人。
        /// </summary>
        [JsonProperty("LegalPerson")]
        public string LegalPerson{ get; set; }

        /// <summary>
        /// （精确查询）法人身份证号。
        /// </summary>
        [JsonProperty("LegalPersonId")]
        public string LegalPersonId{ get; set; }

        /// <summary>
        /// （模糊查询）发证机关。
        /// </summary>
        [JsonProperty("IssuingAuthority")]
        public string IssuingAuthority{ get; set; }

        /// <summary>
        /// （模糊查询）营业执照住所。
        /// </summary>
        [JsonProperty("BusinessAddress")]
        public string BusinessAddress{ get; set; }

        /// <summary>
        /// （精确匹配）邮编。
        /// </summary>
        [JsonProperty("PostCode")]
        public ulong? PostCode{ get; set; }

        /// <summary>
        /// （模糊查询）经办人。
        /// </summary>
        [JsonProperty("Manager")]
        public string Manager{ get; set; }

        /// <summary>
        /// （精确查询）经办人身份证号。
        /// </summary>
        [JsonProperty("ManagerId")]
        public string ManagerId{ get; set; }

        /// <summary>
        /// （模糊查询）经办人身份证地址。
        /// </summary>
        [JsonProperty("ManagerAddress")]
        public string ManagerAddress{ get; set; }

        /// <summary>
        /// （精确匹配）经办人联系电话。
        /// </summary>
        [JsonProperty("ManagerTelephone")]
        public string ManagerTelephone{ get; set; }

        /// <summary>
        /// （精确匹配）电子邮箱。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// （精确匹配）服务开始日期，如：`2020-07-28`。
        /// </summary>
        [JsonProperty("ServiceStartDate")]
        public string ServiceStartDate{ get; set; }

        /// <summary>
        /// （精确匹配）服务结束日期，如：`2021-07-28`。
        /// </summary>
        [JsonProperty("ServiceEndDate")]
        public string ServiceEndDate{ get; set; }

        /// <summary>
        /// （精确匹配）状态。待审批：`PENDING`，通过：`APPROVED `，拒绝：`DENY`。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


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
            this.SetParamSimple(map, prefix + "LegalPersonId", this.LegalPersonId);
            this.SetParamSimple(map, prefix + "IssuingAuthority", this.IssuingAuthority);
            this.SetParamSimple(map, prefix + "BusinessAddress", this.BusinessAddress);
            this.SetParamSimple(map, prefix + "PostCode", this.PostCode);
            this.SetParamSimple(map, prefix + "Manager", this.Manager);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "ManagerAddress", this.ManagerAddress);
            this.SetParamSimple(map, prefix + "ManagerTelephone", this.ManagerTelephone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ServiceStartDate", this.ServiceStartDate);
            this.SetParamSimple(map, prefix + "ServiceEndDate", this.ServiceEndDate);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

