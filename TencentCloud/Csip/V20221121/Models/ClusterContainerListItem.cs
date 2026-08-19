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

    public class ClusterContainerListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>资产id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>容器id</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>容器名称</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>运行状态</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

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
        /// <p>镜像id</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>镜像名称</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>隔离状态</p>
        /// </summary>
        [JsonProperty("IsolateStatus")]
        public string IsolateStatus{ get; set; }

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
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>关联告警数</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "PodUid", this.PodUid);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "IsolateStatus", this.IsolateStatus);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
        }
    }
}

