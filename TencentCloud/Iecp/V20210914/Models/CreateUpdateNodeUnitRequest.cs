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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUpdateNodeUnitRequest : AbstractModel
    {
        
        /// <summary>
        /// IECP边缘单元ID
        /// </summary>
        [JsonProperty("EdgeUnitId")]
        public ulong? EdgeUnitId{ get; set; }

        /// <summary>
        /// NodeUnit所属的NodeGroup名称
        /// </summary>
        [JsonProperty("NodeGroupName")]
        public string NodeGroupName{ get; set; }

        /// <summary>
        /// 命名空间，默认为default
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// NodeUnit名称，通过模版创建可不填
        /// </summary>
        [JsonProperty("NodeUnitName")]
        public string NodeUnitName{ get; set; }

        /// <summary>
        /// NodeUnit包含的节点列表，通过模版创建可不填
        /// </summary>
        [JsonProperty("Nodes")]
        public string[] Nodes{ get; set; }

        /// <summary>
        /// NodeUnit模版ID列表
        /// </summary>
        [JsonProperty("NodeUnitTemplateIDs")]
        public ulong?[] NodeUnitTemplateIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EdgeUnitId", this.EdgeUnitId);
            this.SetParamSimple(map, prefix + "NodeGroupName", this.NodeGroupName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "NodeUnitName", this.NodeUnitName);
            this.SetParamArraySimple(map, prefix + "Nodes.", this.Nodes);
            this.SetParamArraySimple(map, prefix + "NodeUnitTemplateIDs.", this.NodeUnitTemplateIDs);
        }
    }
}

