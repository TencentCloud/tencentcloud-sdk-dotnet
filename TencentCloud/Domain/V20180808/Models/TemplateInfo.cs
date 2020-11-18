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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 认证状态：未实名认证:NotUpload, 实名审核中:InAudit，已实名认证:Approved，实名审核失败:Reject
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// 用户UIN
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 是否是默认模板: 是:yes，否:no
        /// </summary>
        [JsonProperty("IsDefault")]
        public string IsDefault{ get; set; }

        /// <summary>
        /// 认证失败原因
        /// </summary>
        [JsonProperty("AuditReason")]
        public string AuditReason{ get; set; }

        /// <summary>
        /// 认证信息
        /// </summary>
        [JsonProperty("CertificateInfo")]
        public CertificateInfo CertificateInfo{ get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [JsonProperty("ContactInfo")]
        public ContactInfo ContactInfo{ get; set; }

        /// <summary>
        /// 模板是否符合规范， 1是 0 否
        /// </summary>
        [JsonProperty("IsValidTemplate")]
        public long? IsValidTemplate{ get; set; }

        /// <summary>
        /// 不符合规范原因
        /// </summary>
        [JsonProperty("InvalidReason")]
        public string InvalidReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "AuditReason", this.AuditReason);
            this.SetParamObj(map, prefix + "CertificateInfo.", this.CertificateInfo);
            this.SetParamObj(map, prefix + "ContactInfo.", this.ContactInfo);
            this.SetParamSimple(map, prefix + "IsValidTemplate", this.IsValidTemplate);
            this.SetParamSimple(map, prefix + "InvalidReason", this.InvalidReason);
        }
    }
}

