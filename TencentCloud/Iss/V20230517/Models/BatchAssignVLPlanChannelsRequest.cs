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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchAssignVLPlanChannelsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>计划 ID</p>
        /// </summary>
        [JsonProperty("VLPlanId")]
        public string VLPlanId{ get; set; }

        /// <summary>
        /// <p>操作命令：1=关联，2=解绑</p>
        /// </summary>
        [JsonProperty("Cmd")]
        public long? Cmd{ get; set; }

        /// <summary>
        /// <p>通道 ID 列表，最多 500 个；与 OrganizationIds 至少传一个（Cmd=1 时）</p>
        /// </summary>
        [JsonProperty("ChannelIds")]
        public string[] ChannelIds{ get; set; }

        /// <summary>
        /// <p>组织 ID 列表（仅 Cmd=1 时有效，Cmd=2 时不允许传入）；展开该组织下所有通道参与关联，与 ChannelIds 取并集去重</p>
        /// </summary>
        [JsonProperty("OrganizationIds")]
        public string[] OrganizationIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VLPlanId", this.VLPlanId);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamArraySimple(map, prefix + "ChannelIds.", this.ChannelIds);
            this.SetParamArraySimple(map, prefix + "OrganizationIds.", this.OrganizationIds);
        }
    }
}

