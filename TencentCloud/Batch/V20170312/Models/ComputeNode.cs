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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeNode : AbstractModel
    {
        
        /// <summary>
        /// 计算节点ID
        /// </summary>
        [JsonProperty("ComputeNodeId")]
        public string ComputeNodeId{ get; set; }

        /// <summary>
        /// 计算节点实例ID，对于CVM场景，即为CVM的InstanceId
        /// </summary>
        [JsonProperty("ComputeNodeInstanceId")]
        public string ComputeNodeInstanceId{ get; set; }

        /// <summary>
        /// 计算节点状态
        /// </summary>
        [JsonProperty("ComputeNodeState")]
        public string ComputeNodeState{ get; set; }

        /// <summary>
        /// CPU核数
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存容量，单位GiB
        /// </summary>
        [JsonProperty("Mem")]
        public ulong? Mem{ get; set; }

        /// <summary>
        /// 资源创建完成时间
        /// </summary>
        [JsonProperty("ResourceCreatedTime")]
        public string ResourceCreatedTime{ get; set; }

        /// <summary>
        /// 计算节点运行  TaskInstance 可用容量。0表示计算节点忙碌。
        /// </summary>
        [JsonProperty("TaskInstanceNumAvailable")]
        public ulong? TaskInstanceNumAvailable{ get; set; }

        /// <summary>
        /// Batch Agent 版本
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// 实例内网IP
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 实例公网IP
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 计算环境资源类型，当前为CVM和CPM（黑石）
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComputeNodeId", this.ComputeNodeId);
            this.SetParamSimple(map, prefix + "ComputeNodeInstanceId", this.ComputeNodeInstanceId);
            this.SetParamSimple(map, prefix + "ComputeNodeState", this.ComputeNodeState);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "ResourceCreatedTime", this.ResourceCreatedTime);
            this.SetParamSimple(map, prefix + "TaskInstanceNumAvailable", this.TaskInstanceNumAvailable);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
        }
    }
}

