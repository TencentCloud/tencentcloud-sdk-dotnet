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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodAffinityTerm : AbstractModel
    {
        
        /// <summary>
        /// <p>标签选择器</p>
        /// </summary>
        [JsonProperty("LabelSelector")]
        public LabelSelector LabelSelector{ get; set; }

        /// <summary>
        /// <p>命名空间列表</p>
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// <p>拓扑域键</p>
        /// </summary>
        [JsonProperty("TopologyKey")]
        public string TopologyKey{ get; set; }

        /// <summary>
        /// <p>命名空间选择器</p>
        /// </summary>
        [JsonProperty("NamespaceSelector")]
        public LabelSelector NamespaceSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LabelSelector.", this.LabelSelector);
            this.SetParamArraySimple(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamSimple(map, prefix + "TopologyKey", this.TopologyKey);
            this.SetParamObj(map, prefix + "NamespaceSelector.", this.NamespaceSelector);
        }
    }
}

