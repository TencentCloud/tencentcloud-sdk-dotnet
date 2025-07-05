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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAssetRequest : AbstractModel
    {
        
        /// <summary>
        /// 同步全部普通节点
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// 要同步的主机列表uuid 
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// 同步全部超级节点
        /// </summary>
        [JsonProperty("AllSuperHost")]
        public bool? AllSuperHost{ get; set; }

        /// <summary>
        /// 要同步的超级节点唯一id
        /// </summary>
        [JsonProperty("NodeUniqueIds")]
        public string[] NodeUniqueIds{ get; set; }

        /// <summary>
        /// 超时时间(秒) 最低3600s
        /// </summary>
        [JsonProperty("TimeoutSec")]
        public ulong? TimeoutSec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamSimple(map, prefix + "AllSuperHost", this.AllSuperHost);
            this.SetParamArraySimple(map, prefix + "NodeUniqueIds.", this.NodeUniqueIds);
            this.SetParamSimple(map, prefix + "TimeoutSec", this.TimeoutSec);
        }
    }
}

