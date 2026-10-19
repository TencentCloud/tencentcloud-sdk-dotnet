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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>集团名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>管理员账号信息</p>
        /// </summary>
        [JsonProperty("AdminInfo")]
        public MemberInfo AdminInfo{ get; set; }

        /// <summary>
        /// <p>管理员/委派管理员数量</p>
        /// </summary>
        [JsonProperty("AdminCount")]
        public long? AdminCount{ get; set; }

        /// <summary>
        /// <p>已接入成员数</p>
        /// </summary>
        [JsonProperty("JoinedMemberCount")]
        public long? JoinedMemberCount{ get; set; }

        /// <summary>
        /// <p>接入成员上限（-1表示无上限）</p>
        /// </summary>
        [JsonProperty("MemberLimit")]
        public long? MemberLimit{ get; set; }

        /// <summary>
        /// <p>接入成员上限显示</p>
        /// </summary>
        [JsonProperty("MemberLimitDisplay")]
        public string MemberLimitDisplay{ get; set; }

        /// <summary>
        /// <p>规格共享者数量</p>
        /// </summary>
        [JsonProperty("CfwSharerCount")]
        public long? CfwSharerCount{ get; set; }

        /// <summary>
        /// <p>规格使用者数量</p>
        /// </summary>
        [JsonProperty("CfwUserCount")]
        public long? CfwUserCount{ get; set; }

        /// <summary>
        /// <p>部门名称列表</p>
        /// </summary>
        [JsonProperty("Departments")]
        public string[] Departments{ get; set; }

        /// <summary>
        /// <p>纳管账号数</p>
        /// </summary>
        [JsonProperty("ManagedMemberCount")]
        public long? ManagedMemberCount{ get; set; }

        /// <summary>
        /// <p>纳管产品数</p>
        /// </summary>
        [JsonProperty("ManagedProductCount")]
        public long? ManagedProductCount{ get; set; }

        /// <summary>
        /// <p>纳管账号数</p>
        /// </summary>
        [JsonProperty("CfwManageCount")]
        public long? CfwManageCount{ get; set; }

        /// <summary>
        /// <p>规格共享总配额</p>
        /// </summary>
        [JsonProperty("FwmShareUserQuota")]
        public long? FwmShareUserQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamObj(map, prefix + "AdminInfo.", this.AdminInfo);
            this.SetParamSimple(map, prefix + "AdminCount", this.AdminCount);
            this.SetParamSimple(map, prefix + "JoinedMemberCount", this.JoinedMemberCount);
            this.SetParamSimple(map, prefix + "MemberLimit", this.MemberLimit);
            this.SetParamSimple(map, prefix + "MemberLimitDisplay", this.MemberLimitDisplay);
            this.SetParamSimple(map, prefix + "CfwSharerCount", this.CfwSharerCount);
            this.SetParamSimple(map, prefix + "CfwUserCount", this.CfwUserCount);
            this.SetParamArraySimple(map, prefix + "Departments.", this.Departments);
            this.SetParamSimple(map, prefix + "ManagedMemberCount", this.ManagedMemberCount);
            this.SetParamSimple(map, prefix + "ManagedProductCount", this.ManagedProductCount);
            this.SetParamSimple(map, prefix + "CfwManageCount", this.CfwManageCount);
            this.SetParamSimple(map, prefix + "FwmShareUserQuota", this.FwmShareUserQuota);
        }
    }
}

