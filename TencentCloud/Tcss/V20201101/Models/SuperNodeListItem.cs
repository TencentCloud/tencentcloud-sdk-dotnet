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
        /// <p>超级节点ID</p>
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// <p>超级节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>所属集群名</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>所属集群ID</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>节点状态:Running,Ready,Notready,Initializing,Failed,Error</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("SubNetID")]
        public string SubNetID{ get; set; }

        /// <summary>
        /// <p>子网名称</p>
        /// </summary>
        [JsonProperty("SubNetName")]
        public string SubNetName{ get; set; }

        /// <summary>
        /// <p>子网网段</p>
        /// </summary>
        [JsonProperty("SubNetCidr")]
        public string SubNetCidr{ get; set; }

        /// <summary>
        /// <p>可用区ID</p>
        /// </summary>
        [JsonProperty("ZoneID")]
        public string ZoneID{ get; set; }

        /// <summary>
        /// <p>可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>关联pod数</p>
        /// </summary>
        [JsonProperty("RelatePodCount")]
        public ulong? RelatePodCount{ get; set; }

        /// <summary>
        /// <p>关联容器数</p>
        /// </summary>
        [JsonProperty("RelateContainerCount")]
        public ulong? RelateContainerCount{ get; set; }

        /// <summary>
        /// <p>agent安装状态UNINSTALL:未安装;INSTALLED:已安装;INSTALLING:安装中;</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>节点唯一id</p>
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// <p>集群接入状态</p>
        /// </summary>
        [JsonProperty("ClusterAccessedStatus")]
        public string ClusterAccessedStatus{ get; set; }

        /// <summary>
        /// <p>计费核数</p>
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }

        /// <summary>
        /// <p>防护状态:<br>已防护: Defended<br>未防护: UnDefended</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>集群接入子状态</p><p>枚举值：</p><ul><li>AccessedSubNone： 无</li><li>AccessedSubUninstallException： 卸载异常</li><li>AccessedSubTimeout： 接入超时</li><li>AccessedSubUninstallTimeout： 卸载超时</li><li>AccessedSubResourceException： 集群组件检查异常-Deployment/DaemonSet等异常</li><li>AccessedSubCAMPermissionDenied： CAM权限不够</li></ul>
        /// </summary>
        [JsonProperty("ClusterAccessedSubStatus")]
        public string ClusterAccessedSubStatus{ get; set; }

        /// <summary>
        /// <p>失败具体原因描述</p>
        /// </summary>
        [JsonProperty("ClusterAccessedErrorReason")]
        public string ClusterAccessedErrorReason{ get; set; }


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
            this.SetParamSimple(map, prefix + "ClusterAccessedSubStatus", this.ClusterAccessedSubStatus);
            this.SetParamSimple(map, prefix + "ClusterAccessedErrorReason", this.ClusterAccessedErrorReason);
        }
    }
}

