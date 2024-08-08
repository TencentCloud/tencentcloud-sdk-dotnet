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

    public class CreateOrgServiceAssignRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团服务ID。可以通过[ListOrganizationService](https://cloud.tencent.com/document/product/850/109561)获取
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// 委派管理员Uin列表。 最大长度20个
        /// </summary>
        [JsonProperty("MemberUins")]
        public long?[] MemberUins{ get; set; }

        /// <summary>
        /// 委派管理员管理范围。 取值：1-全部成员 2-部分成员，默认值1
        /// </summary>
        [JsonProperty("ManagementScope")]
        public ulong? ManagementScope{ get; set; }

        /// <summary>
        /// 管理的成员Uin列表。ManagementScope为2时该参数有效
        /// </summary>
        [JsonProperty("ManagementScopeUins")]
        public long?[] ManagementScopeUins{ get; set; }

        /// <summary>
        /// 管理的部门ID列表。ManagementScope为2时该参数有效
        /// </summary>
        [JsonProperty("ManagementScopeNodeIds")]
        public long?[] ManagementScopeNodeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamArraySimple(map, prefix + "MemberUins.", this.MemberUins);
            this.SetParamSimple(map, prefix + "ManagementScope", this.ManagementScope);
            this.SetParamArraySimple(map, prefix + "ManagementScopeUins.", this.ManagementScopeUins);
            this.SetParamArraySimple(map, prefix + "ManagementScopeNodeIds.", this.ManagementScopeNodeIds);
        }
    }
}

