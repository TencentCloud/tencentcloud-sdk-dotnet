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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeManagerDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 状态: audit: 审核中 ok: 审核通过 invalid: 失效 expiring: 即将过期 expired: 已过期
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 管理人姓名
        /// </summary>
        [JsonProperty("ManagerFirstName")]
        public string ManagerFirstName{ get; set; }

        /// <summary>
        /// 管理人邮箱
        /// </summary>
        [JsonProperty("ManagerMail")]
        public string ManagerMail{ get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("ContactFirstName")]
        public string ContactFirstName{ get; set; }

        /// <summary>
        /// 管理人姓名
        /// </summary>
        [JsonProperty("ManagerLastName")]
        public string ManagerLastName{ get; set; }

        /// <summary>
        /// 联系人职位
        /// </summary>
        [JsonProperty("ContactPosition")]
        public string ContactPosition{ get; set; }

        /// <summary>
        /// 管理人职位
        /// </summary>
        [JsonProperty("ManagerPosition")]
        public string ManagerPosition{ get; set; }

        /// <summary>
        /// 核验通过时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyTime")]
        public string VerifyTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 核验过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("ContactLastName")]
        public string ContactLastName{ get; set; }

        /// <summary>
        /// 管理人电话
        /// </summary>
        [JsonProperty("ManagerPhone")]
        public string ManagerPhone{ get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("ContactPhone")]
        public string ContactPhone{ get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("ContactMail")]
        public string ContactMail{ get; set; }

        /// <summary>
        /// 管理人所属部门
        /// </summary>
        [JsonProperty("ManagerDepartment")]
        public string ManagerDepartment{ get; set; }

        /// <summary>
        /// 管理人所属公司信息
        /// </summary>
        [JsonProperty("CompanyInfo")]
        public CompanyInfo CompanyInfo{ get; set; }

        /// <summary>
        /// 管理人公司ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 管理人ID
        /// </summary>
        [JsonProperty("ManagerId")]
        public long? ManagerId{ get; set; }

        /// <summary>
        /// 审核状态详细信息
        /// </summary>
        [JsonProperty("StatusInfo")]
        public ManagerStatusInfo[] StatusInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ManagerFirstName", this.ManagerFirstName);
            this.SetParamSimple(map, prefix + "ManagerMail", this.ManagerMail);
            this.SetParamSimple(map, prefix + "ContactFirstName", this.ContactFirstName);
            this.SetParamSimple(map, prefix + "ManagerLastName", this.ManagerLastName);
            this.SetParamSimple(map, prefix + "ContactPosition", this.ContactPosition);
            this.SetParamSimple(map, prefix + "ManagerPosition", this.ManagerPosition);
            this.SetParamSimple(map, prefix + "VerifyTime", this.VerifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ContactLastName", this.ContactLastName);
            this.SetParamSimple(map, prefix + "ManagerPhone", this.ManagerPhone);
            this.SetParamSimple(map, prefix + "ContactPhone", this.ContactPhone);
            this.SetParamSimple(map, prefix + "ContactMail", this.ContactMail);
            this.SetParamSimple(map, prefix + "ManagerDepartment", this.ManagerDepartment);
            this.SetParamObj(map, prefix + "CompanyInfo.", this.CompanyInfo);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamArrayObj(map, prefix + "StatusInfo.", this.StatusInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

