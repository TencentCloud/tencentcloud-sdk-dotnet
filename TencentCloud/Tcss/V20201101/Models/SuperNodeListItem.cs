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

    public class SuperNodeListItem : AbstractModel
    {
        
        /// <summary>
        /// 超级节点ID
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// 超级节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 所属集群名
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 所属集群ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 节点状态:Running,Ready,Notready,Initializing,Failed,Error
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubNetID")]
        public string SubNetID{ get; set; }

        /// <summary>
        /// 子网名称
        /// </summary>
        [JsonProperty("SubNetName")]
        public string SubNetName{ get; set; }

        /// <summary>
        /// 子网网段
        /// </summary>
        [JsonProperty("SubNetCidr")]
        public string SubNetCidr{ get; set; }

        /// <summary>
        /// 可用区ID
        /// </summary>
        [JsonProperty("ZoneID")]
        public string ZoneID{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 关联pod数
        /// </summary>
        [JsonProperty("RelatePodCount")]
        public ulong? RelatePodCount{ get; set; }

        /// <summary>
        /// 关联容器数
        /// </summary>
        [JsonProperty("RelateContainerCount")]
        public ulong? RelateContainerCount{ get; set; }

        /// <summary>
        /// agent安装状态UNINSTALL:未安装;INSTALLED:已安装;INSTALLING:安装中;
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// 节点唯一id
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// 集群接入状态
        /// </summary>
        [JsonProperty("ClusterAccessedStatus")]
        public string ClusterAccessedStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubNetID", this.SubNetID);
            this.SetParamSimple(map, prefix + "SubNetName", this.SubNetName);
            this.SetParamSimple(map, prefix + "SubNetCidr", this.SubNetCidr);
            this.SetParamSimple(map, prefix + "ZoneID", this.ZoneID);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RelatePodCount", this.RelatePodCount);
            this.SetParamSimple(map, prefix + "RelateContainerCount", this.RelateContainerCount);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "ClusterAccessedStatus", this.ClusterAccessedStatus);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
        }
    }
}

