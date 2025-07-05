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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadonlyNode : AbstractModel
    {
        
        /// <summary>
        /// 是否分布在随机可用区。传入YES表示随机可用区。否则使用Zone指定的可用区。
        /// </summary>
        [JsonProperty("IsRandomZone")]
        public string IsRandomZone{ get; set; }

        /// <summary>
        /// 指定该节点分布在哪个可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 升级集群版实例时，如果要调整只读节点可用区，需要指定节点id。
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsRandomZone", this.IsRandomZone);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
        }
    }
}

