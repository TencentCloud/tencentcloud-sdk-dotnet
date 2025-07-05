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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeConfig : AbstractModel
    {
        
        /// <summary>
        /// Node ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Node parallelism
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Parallelism")]
        public long? Parallelism{ get; set; }

        /// <summary>
        /// Slot sharing group
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlotSharingGroup")]
        public string SlotSharingGroup{ get; set; }

        /// <summary>
        /// Configuration properties
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Configuration")]
        public Property[] Configuration{ get; set; }

        /// <summary>
        /// 节点的状态ttl配置, 多个用 ; 分割
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StateTTL")]
        public string StateTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Parallelism", this.Parallelism);
            this.SetParamSimple(map, prefix + "SlotSharingGroup", this.SlotSharingGroup);
            this.SetParamArrayObj(map, prefix + "Configuration.", this.Configuration);
            this.SetParamSimple(map, prefix + "StateTTL", this.StateTTL);
        }
    }
}

