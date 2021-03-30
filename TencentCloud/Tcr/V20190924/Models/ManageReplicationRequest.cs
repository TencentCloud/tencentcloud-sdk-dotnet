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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManageReplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 复制源实例ID
        /// </summary>
        [JsonProperty("SourceRegistryId")]
        public string SourceRegistryId{ get; set; }

        /// <summary>
        /// 复制目标实例ID
        /// </summary>
        [JsonProperty("DestinationRegistryId")]
        public string DestinationRegistryId{ get; set; }

        /// <summary>
        /// 同步规则
        /// </summary>
        [JsonProperty("Rule")]
        public ReplicationRule Rule{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 目标实例的地域ID，如广州是1
        /// </summary>
        [JsonProperty("DestinationRegionId")]
        public ulong? DestinationRegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceRegistryId", this.SourceRegistryId);
            this.SetParamSimple(map, prefix + "DestinationRegistryId", this.DestinationRegistryId);
            this.SetParamObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DestinationRegionId", this.DestinationRegionId);
        }
    }
}

