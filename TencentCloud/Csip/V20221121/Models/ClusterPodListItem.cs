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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterPodListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>资产id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>pod唯一id</p>
        /// </summary>
        [JsonProperty("PodUid")]
        public string PodUid{ get; set; }

        /// <summary>
        /// <p>pod名称</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>podip数组</p>
        /// </summary>
        [JsonProperty("PodIPs")]
        public string[] PodIPs{ get; set; }

        /// <summary>
        /// <p>pod状态</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>防护核数</p>
        /// </summary>
        [JsonProperty("DefendCoresCount")]
        [System.Obsolete]
        public long? DefendCoresCount{ get; set; }

        /// <summary>
        /// <p>节点id</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>节点类型</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>负载名称</p>
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// <p>负载类型</p>
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Pod唯一标识ID</p>
        /// </summary>
        [JsonProperty("UniqueID")]
        public string UniqueID{ get; set; }

        /// <summary>
        /// <p>严重风险数量</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        [System.Obsolete]
        public ulong? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高危风险数量</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        [System.Obsolete]
        public ulong? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>中危风险数量</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        [System.Obsolete]
        public ulong? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低危风险数量</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        [System.Obsolete]
        public ulong? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>严重告警数量</p>
        /// </summary>
        [JsonProperty("AlarmEventCriticalCount")]
        [System.Obsolete]
        public ulong? AlarmEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高危告警数量</p>
        /// </summary>
        [JsonProperty("AlarmEventHighCount")]
        [System.Obsolete]
        public ulong? AlarmEventHighCount{ get; set; }

        /// <summary>
        /// <p>中危告警数量</p>
        /// </summary>
        [JsonProperty("AlarmEventMiddleCount")]
        [System.Obsolete]
        public ulong? AlarmEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低危告警数量</p>
        /// </summary>
        [JsonProperty("AlarmEventLowCount")]
        [System.Obsolete]
        public ulong? AlarmEventLowCount{ get; set; }

        /// <summary>
        /// <p>关联容器列表</p>
        /// </summary>
        [JsonProperty("ContainerList")]
        public ClusterContainerListItem[] ContainerList{ get; set; }

        /// <summary>
        /// <p>关联告警数</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

        /// <summary>
        /// <p>核数</p><p>单位：毫核</p>
        /// </summary>
        [JsonProperty("CoresCount")]
        public long? CoresCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "PodUid", this.PodUid);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamArraySimple(map, prefix + "PodIPs.", this.PodIPs);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "DefendCoresCount", this.DefendCoresCount);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UniqueID", this.UniqueID);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "AlarmEventCriticalCount", this.AlarmEventCriticalCount);
            this.SetParamSimple(map, prefix + "AlarmEventHighCount", this.AlarmEventHighCount);
            this.SetParamSimple(map, prefix + "AlarmEventMiddleCount", this.AlarmEventMiddleCount);
            this.SetParamSimple(map, prefix + "AlarmEventLowCount", this.AlarmEventLowCount);
            this.SetParamArrayObj(map, prefix + "ContainerList.", this.ContainerList);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "CoresCount", this.CoresCount);
        }
    }
}

