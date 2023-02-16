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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceVersionBrief : AbstractModel
    {
        
        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否启动弹性 -- 已废弃
        /// </summary>
        [JsonProperty("EnableEs")]
        public long? EnableEs{ get; set; }

        /// <summary>
        /// 当前实例
        /// </summary>
        [JsonProperty("CurrentInstances")]
        public long? CurrentInstances{ get; set; }

        /// <summary>
        /// version的id
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 日志输出配置 -- 已废弃
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogOutputConf")]
        public LogOutputConf LogOutputConf{ get; set; }

        /// <summary>
        /// 期望实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpectedInstances")]
        public long? ExpectedInstances{ get; set; }

        /// <summary>
        /// 部署方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// 建构任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuildTaskId")]
        public string BuildTaskId{ get; set; }

        /// <summary>
        /// 环境ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 环境name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// 服务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 服务name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 是否正在发布中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnderDeploying")]
        public bool? UnderDeploying{ get; set; }

        /// <summary>
        /// 分批次部署状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchDeployStatus")]
        public string BatchDeployStatus{ get; set; }

        /// <summary>
        /// 可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeInfos")]
        public NodeInfo[] NodeInfos{ get; set; }

        /// <summary>
        /// 实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodList")]
        public DescribeRunPodPage PodList{ get; set; }

        /// <summary>
        /// 工作负载信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkloadInfo")]
        public WorkloadInfo WorkloadInfo{ get; set; }

        /// <summary>
        /// 创建日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// 地域id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableEs", this.EnableEs);
            this.SetParamSimple(map, prefix + "CurrentInstances", this.CurrentInstances);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamObj(map, prefix + "LogOutputConf.", this.LogOutputConf);
            this.SetParamSimple(map, prefix + "ExpectedInstances", this.ExpectedInstances);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "BuildTaskId", this.BuildTaskId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "UnderDeploying", this.UnderDeploying);
            this.SetParamSimple(map, prefix + "BatchDeployStatus", this.BatchDeployStatus);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "NodeInfos.", this.NodeInfos);
            this.SetParamObj(map, prefix + "PodList.", this.PodList);
            this.SetParamObj(map, prefix + "WorkloadInfo.", this.WorkloadInfo);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

