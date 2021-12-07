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

    public class DescribeClusterDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名字
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 当前集群扫描任务的进度，100表示扫描完成.
        /// </summary>
        [JsonProperty("ScanTaskProgress")]
        public long? ScanTaskProgress{ get; set; }

        /// <summary>
        /// 集群版本
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 运行时组件
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// 集群节点数
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// 集群状态 (Running 运行中 Creating 创建中 Abnormal 异常 )
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 集群类型：为托管集群MANAGED_CLUSTER、独立集群INDEPENDENT_CLUSTER
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 严重风险检查项的数量
        /// </summary>
        [JsonProperty("SeriousRiskCount")]
        public ulong? SeriousRiskCount{ get; set; }

        /// <summary>
        /// 高风险检查项的数量
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public ulong? HighRiskCount{ get; set; }

        /// <summary>
        /// 中风险检查项的数量
        /// </summary>
        [JsonProperty("MiddleRiskCount")]
        public ulong? MiddleRiskCount{ get; set; }

        /// <summary>
        /// 提示风险检查项的数量
        /// </summary>
        [JsonProperty("HintRiskCount")]
        public ulong? HintRiskCount{ get; set; }

        /// <summary>
        /// 检查任务的状态
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 防御容器状态
        /// </summary>
        [JsonProperty("DefenderStatus")]
        public string DefenderStatus{ get; set; }

        /// <summary>
        /// 扫描任务创建时间
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ScanTaskProgress", this.ScanTaskProgress);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SeriousRiskCount", this.SeriousRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MiddleRiskCount", this.MiddleRiskCount);
            this.SetParamSimple(map, prefix + "HintRiskCount", this.HintRiskCount);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "DefenderStatus", this.DefenderStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

