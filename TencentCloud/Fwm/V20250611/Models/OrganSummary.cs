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
        /// 集团名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 管理员账号信息
        /// </summary>
        [JsonProperty("AdminInfo")]
        public MemberInfo AdminInfo{ get; set; }

        /// <summary>
        /// 管理员/委派管理员数量
        /// </summary>
        [JsonProperty("AdminCount")]
        public long? AdminCount{ get; set; }

        /// <summary>
        /// 已接入成员数
        /// </summary>
        [JsonProperty("JoinedMemberCount")]
        public long? JoinedMemberCount{ get; set; }

        /// <summary>
        /// 接入成员上限（-1表示无上限）
        /// </summary>
        [JsonProperty("MemberLimit")]
        public long? MemberLimit{ get; set; }

        /// <summary>
        /// 接入成员上限显示
        /// </summary>
        [JsonProperty("MemberLimitDisplay")]
        public string MemberLimitDisplay{ get; set; }

        /// <summary>
        /// 规格共享者数量
        /// </summary>
        [JsonProperty("CfwSharerCount")]
        public long? CfwSharerCount{ get; set; }

        /// <summary>
        /// 规格使用者数量
        /// </summary>
        [JsonProperty("CfwUserCount")]
        public long? CfwUserCount{ get; set; }

        /// <summary>
        /// 部门名称列表
        /// </summary>
        [JsonProperty("Departments")]
        public string[] Departments{ get; set; }

        /// <summary>
        /// 纳管账号数
        /// </summary>
        [JsonProperty("ManagedMemberCount")]
        public long? ManagedMemberCount{ get; set; }

        /// <summary>
        /// 纳管产品数
        /// </summary>
        [JsonProperty("ManagedProductCount")]
        public long? ManagedProductCount{ get; set; }

        /// <summary>
        /// 纳管账号数
        /// </summary>
        [JsonProperty("CfwManageCount")]
        public long? CfwManageCount{ get; set; }


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
        }
    }
}

