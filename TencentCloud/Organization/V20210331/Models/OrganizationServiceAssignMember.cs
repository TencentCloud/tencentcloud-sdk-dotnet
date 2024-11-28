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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationServiceAssignMember : AbstractModel
    {
        
        /// <summary>
        /// 集团服务ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// 集团服务产品名称。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 委派管理员Uin。
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// 委派管理员名称。
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// 启用状态 。取值：0-服务无启用状态  1-已启用  2-未启用
        /// </summary>
        [JsonProperty("UsageStatus")]
        public ulong? UsageStatus{ get; set; }

        /// <summary>
        /// 委派时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 委派管理员管理范围。取值: 1-全部成员  2-部分成员
        /// </summary>
        [JsonProperty("ManagementScope")]
        public ulong? ManagementScope{ get; set; }

        /// <summary>
        /// 管理的成员Uin列表。ManagementScope值为2时该参数有效
        /// </summary>
        [JsonProperty("ManagementScopeMembers")]
        public MemberMainInfo[] ManagementScopeMembers{ get; set; }

        /// <summary>
        /// 管理的部门ID列表。ManagementScope值为2时该参数有效
        /// </summary>
        [JsonProperty("ManagementScopeNodes")]
        public NodeMainInfo[] ManagementScopeNodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "UsageStatus", this.UsageStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ManagementScope", this.ManagementScope);
            this.SetParamArrayObj(map, prefix + "ManagementScopeMembers.", this.ManagementScopeMembers);
            this.SetParamArrayObj(map, prefix + "ManagementScopeNodes.", this.ManagementScopeNodes);
        }
    }
}

