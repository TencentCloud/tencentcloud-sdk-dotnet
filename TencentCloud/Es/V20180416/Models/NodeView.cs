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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeView : AbstractModel
    {
        
        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 节点IP
        /// </summary>
        [JsonProperty("NodeIp")]
        public string NodeIp{ get; set; }

        /// <summary>
        /// 节点是否可见
        /// </summary>
        [JsonProperty("Visible")]
        public float? Visible{ get; set; }

        /// <summary>
        /// 是否熔断
        /// </summary>
        [JsonProperty("Break")]
        public float? Break{ get; set; }

        /// <summary>
        /// 节点总磁盘大小
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 磁盘使用率
        /// </summary>
        [JsonProperty("DiskUsage")]
        public float? DiskUsage{ get; set; }

        /// <summary>
        /// 节点内存大小，单位GB
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// 内存使用率
        /// </summary>
        [JsonProperty("MemUsage")]
        public float? MemUsage{ get; set; }

        /// <summary>
        /// 节点cpu个数
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// cpu使用率
        /// </summary>
        [JsonProperty("CpuUsage")]
        public float? CpuUsage{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 节点角色
        /// </summary>
        [JsonProperty("NodeRole")]
        public string NodeRole{ get; set; }

        /// <summary>
        /// 节点HTTP IP
        /// </summary>
        [JsonProperty("NodeHttpIp")]
        public string NodeHttpIp{ get; set; }

        /// <summary>
        /// JVM内存使用率
        /// </summary>
        [JsonProperty("JvmMemUsage")]
        public float? JvmMemUsage{ get; set; }

        /// <summary>
        /// 节点分片数
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// 节点上磁盘ID列表
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 是否为隐藏可用区
        /// </summary>
        [JsonProperty("Hidden")]
        public bool? Hidden{ get; set; }

        /// <summary>
        /// 是否充当协调节点的角色
        /// </summary>
        [JsonProperty("IsCoordinationNode")]
        public bool? IsCoordinationNode{ get; set; }

        /// <summary>
        /// CVM运行状态
        /// </summary>
        [JsonProperty("CVMStatus")]
        public string CVMStatus{ get; set; }

        /// <summary>
        /// cvm绑定的置放群组的id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CVMDisasterRecoverGroupId")]
        public string CVMDisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// cvm绑定置放群组的状态。2: 已绑定；1: 绑定中；0: 未开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CVMDisasterRecoverGroupStatus")]
        public long? CVMDisasterRecoverGroupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeIp", this.NodeIp);
            this.SetParamSimple(map, prefix + "Visible", this.Visible);
            this.SetParamSimple(map, prefix + "Break", this.Break);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "CpuUsage", this.CpuUsage);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeRole", this.NodeRole);
            this.SetParamSimple(map, prefix + "NodeHttpIp", this.NodeHttpIp);
            this.SetParamSimple(map, prefix + "JvmMemUsage", this.JvmMemUsage);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "Hidden", this.Hidden);
            this.SetParamSimple(map, prefix + "IsCoordinationNode", this.IsCoordinationNode);
            this.SetParamSimple(map, prefix + "CVMStatus", this.CVMStatus);
            this.SetParamSimple(map, prefix + "CVMDisasterRecoverGroupId", this.CVMDisasterRecoverGroupId);
            this.SetParamSimple(map, prefix + "CVMDisasterRecoverGroupStatus", this.CVMDisasterRecoverGroupStatus);
        }
    }
}

