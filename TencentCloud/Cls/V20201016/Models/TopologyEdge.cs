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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopologyEdge : AbstractModel
    {
        
        /// <summary>
        /// <p>源实体 ID</p>
        /// </summary>
        [JsonProperty("SrcEntityId")]
        public string SrcEntityId{ get; set; }

        /// <summary>
        /// <p>目的实体 ID</p>
        /// </summary>
        [JsonProperty("DstEntityId")]
        public string DstEntityId{ get; set; }

        /// <summary>
        /// <p>关系类型：contains / same_as / calls</p><p>枚举值：</p><ul><li>contains： 包含关系，A 包含 B</li><li>same_as： 等价关系，A 等价 B</li><li>calls： 调用关系， A 调用 B</li></ul><p>默认值：-</p>
        /// </summary>
        [JsonProperty("RelationType")]
        public string RelationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcEntityId", this.SrcEntityId);
            this.SetParamSimple(map, prefix + "DstEntityId", this.DstEntityId);
            this.SetParamSimple(map, prefix + "RelationType", this.RelationType);
        }
    }
}

