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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineSetScaling : AbstractModel
    {
        
        /// <summary>
        /// <p>节点池最小副本数</p>
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// <p>节点池最大副本数</p>
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// <p>节点池扩容策略。ZoneEquality：多可用区打散；ZonePriority：首选可用区优先；</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatePolicy")]
        public string CreatePolicy{ get; set; }

        /// <summary>
        /// <p>扩缩容模式</p><p>枚举值：</p><ul><li>ShutdownAndDelete： 释放模式，默认</li><li>Shutdown： 停机模式，关机不计费</li></ul><p>默认值：ShutdownAndDelete</p>
        /// </summary>
        [JsonProperty("ScaleDownMode")]
        public string ScaleDownMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "CreatePolicy", this.CreatePolicy);
            this.SetParamSimple(map, prefix + "ScaleDownMode", this.ScaleDownMode);
        }
    }
}

