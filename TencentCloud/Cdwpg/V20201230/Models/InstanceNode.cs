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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceNode : AbstractModel
    {
        
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// cn
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// ip
        /// </summary>
        [JsonProperty("NodeIp")]
        public string NodeIp{ get; set; }

        /// <summary>
        /// 私有ip
        /// </summary>
        [JsonProperty("PrivateNetworkIp")]
        public string PrivateNetworkIp{ get; set; }

        /// <summary>
        /// 节点角色
        /// </summary>
        [JsonProperty("NodeRole")]
        public string NodeRole{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// cpu
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 数据盘数量
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public long? DataDiskCount{ get; set; }

        /// <summary>
        /// 数据盘大小
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public long? DataDiskSize{ get; set; }

        /// <summary>
        /// 数据盘类型
        /// </summary>
        [JsonProperty("DataDiskType")]
        public string DataDiskType{ get; set; }

        /// <summary>
        /// 唯一uuid
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeIp", this.NodeIp);
            this.SetParamSimple(map, prefix + "PrivateNetworkIp", this.PrivateNetworkIp);
            this.SetParamSimple(map, prefix + "NodeRole", this.NodeRole);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "DataDiskCount", this.DataDiskCount);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamSimple(map, prefix + "DataDiskType", this.DataDiskType);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}

