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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SuperNodePodListItem : AbstractModel
    {
        
        /// <summary>
        /// pod名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// podIP
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// 节点唯一id
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// cpu需求核数
        /// </summary>
        [JsonProperty("CpuRequest")]
        public long? CpuRequest{ get; set; }

        /// <summary>
        /// cpu限制核数
        /// </summary>
        [JsonProperty("CpuLimit")]
        public long? CpuLimit{ get; set; }

        /// <summary>
        /// 内存需求大小
        /// </summary>
        [JsonProperty("MemRequest")]
        public long? MemRequest{ get; set; }

        /// <summary>
        /// 内存限制大小
        /// </summary>
        [JsonProperty("MemLimit")]
        public long? MemLimit{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 工作负载名称
        /// </summary>
        [JsonProperty("DeploymentName")]
        public string DeploymentName{ get; set; }

        /// <summary>
        /// 工作负载id
        /// </summary>
        [JsonProperty("DeploymentID")]
        public string DeploymentID{ get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 关联容器个数
        /// </summary>
        [JsonProperty("RelateContainerCount")]
        public ulong? RelateContainerCount{ get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        [JsonProperty("RunningTime")]
        public string RunningTime{ get; set; }

        /// <summary>
        /// PodUid
        /// </summary>
        [JsonProperty("PodUid")]
        public string PodUid{ get; set; }

        /// <summary>
        /// 计费核数
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }

        /// <summary>
        /// 防护状态
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "DeploymentName", this.DeploymentName);
            this.SetParamSimple(map, prefix + "DeploymentID", this.DeploymentID);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RelateContainerCount", this.RelateContainerCount);
            this.SetParamSimple(map, prefix + "RunningTime", this.RunningTime);
            this.SetParamSimple(map, prefix + "PodUid", this.PodUid);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
        }
    }
}

