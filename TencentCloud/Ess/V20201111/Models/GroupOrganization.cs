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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupOrganization : AbstractModel
    {
        
        /// <summary>
        /// 成员企业名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 成员企业别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 成员企业id，为 32 位字符串，可在电子签PC 控制台，企业设置->企业电子签账号 获取
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 记录更新时间， unix时间戳，单位秒
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 成员企业加入集团的当前状态
        /// <ul><li> **1**：待授权</li>
        /// <li> **2**：已授权待激活</li>
        /// <li> **3**：拒绝授权</li>
        /// <li> **4**：已解除</li>
        /// <li> **5**：已加入</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 是否为集团主企业
        /// </summary>
        [JsonProperty("IsMainOrganization")]
        public bool? IsMainOrganization{ get; set; }

        /// <summary>
        /// 企业社会信用代码
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 企业超管信息
        /// </summary>
        [JsonProperty("AdminInfo")]
        public Admin AdminInfo{ get; set; }

        /// <summary>
        /// 企业许可证Id，此字段暂时不需要关注
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// 企业许可证过期时间，unix时间戳，单位秒
        /// </summary>
        [JsonProperty("LicenseExpireTime")]
        public ulong? LicenseExpireTime{ get; set; }

        /// <summary>
        /// 成员企业加入集团时间，unix时间戳，单位秒
        /// </summary>
        [JsonProperty("JoinTime")]
        public ulong? JoinTime{ get; set; }

        /// <summary>
        /// 是否使用自建审批流引擎（即不是企微审批流引擎）
        /// <ul><li> **true**：是</li>
        /// <li> **false**：否</li></ul>
        /// </summary>
        [JsonProperty("FlowEngineEnable")]
        public bool? FlowEngineEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsMainOrganization", this.IsMainOrganization);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamObj(map, prefix + "AdminInfo.", this.AdminInfo);
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "LicenseExpireTime", this.LicenseExpireTime);
            this.SetParamSimple(map, prefix + "JoinTime", this.JoinTime);
            this.SetParamSimple(map, prefix + "FlowEngineEnable", this.FlowEngineEnable);
        }
    }
}

