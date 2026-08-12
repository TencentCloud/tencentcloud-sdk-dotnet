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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyReplicationRule : AbstractModel
    {
        
        /// <summary>
        /// <p>目标命名空间</p>
        /// </summary>
        [JsonProperty("DestNamespace")]
        public string DestNamespace{ get; set; }

        /// <summary>
        /// <p>是否覆盖</p>
        /// </summary>
        [JsonProperty("Override")]
        public bool? Override{ get; set; }

        /// <summary>
        /// <p>是否同步删除事件</p>
        /// </summary>
        [JsonProperty("Deletion")]
        public bool? Deletion{ get; set; }

        /// <summary>
        /// <p>过滤同步条件</p>
        /// </summary>
        [JsonProperty("Filters")]
        public ReplicationFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>是否开启规则</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DestNamespace", this.DestNamespace);
            this.SetParamSimple(map, prefix + "Override", this.Override);
            this.SetParamSimple(map, prefix + "Deletion", this.Deletion);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

