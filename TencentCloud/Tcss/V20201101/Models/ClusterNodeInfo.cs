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

    public class ClusterNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 内网ip地址
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 节点的角色，Master、Work等
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// 实例的状态（running 运行中，initializing 初始化中，failed 异常）
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// agent安装状态
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// 公网ip
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// 主机类型(普通节点情况)
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 节点类型(
        /// NORMAL: 普通节点
        /// SUPER:超级节点
        /// )
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// 计费核数
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }

        /// <summary>
        /// 防护状态:
        /// 已防护: Defended
        /// 未防护: UnDefended
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PrivateIpAddresses", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
        }
    }
}

