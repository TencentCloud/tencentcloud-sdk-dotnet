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

    public class ClusterInfoItem : AbstractModel
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
        /// 集群版本
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 集群操作系统
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群节点数
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// 集群区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 防护状态: 
        /// 已防护: Defended 
        /// 未防护: UnDefended
        /// 部分防护: PartDefened
        /// </summary>
        [JsonProperty("DefenderStatus")]
        public string DefenderStatus{ get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// 集群运行子状态
        /// </summary>
        [JsonProperty("ClusterSubStatus")]
        public string ClusterSubStatus{ get; set; }

        /// <summary>
        /// 集群的检测模式，为Cluster_Normal或者Cluster_Actived.
        /// </summary>
        [JsonProperty("ClusterCheckMode")]
        public string ClusterCheckMode{ get; set; }

        /// <summary>
        /// 是否自动定期检测
        /// </summary>
        [JsonProperty("ClusterAutoCheck")]
        public bool? ClusterAutoCheck{ get; set; }

        /// <summary>
        /// 防护容器部署失败原因，为UserDaemonSetNotReady时,和UnreadyNodeNum转成"N个节点防御容器为就绪"，其他错误直接展示
        /// </summary>
        [JsonProperty("DefenderErrorReason")]
        public string DefenderErrorReason{ get; set; }

        /// <summary>
        /// 防御容器没有ready状态的节点数量
        /// </summary>
        [JsonProperty("UnreadyNodeNum")]
        public ulong? UnreadyNodeNum{ get; set; }

        /// <summary>
        /// 严重风险检查项的数量
        /// </summary>
        [JsonProperty("SeriousRiskCount")]
        public long? SeriousRiskCount{ get; set; }

        /// <summary>
        /// 高风险检查项的数量
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public long? HighRiskCount{ get; set; }

        /// <summary>
        /// 中风险检查项的数量
        /// </summary>
        [JsonProperty("MiddleRiskCount")]
        public long? MiddleRiskCount{ get; set; }

        /// <summary>
        /// 提示风险检查项的数量
        /// </summary>
        [JsonProperty("HintRiskCount")]
        public long? HintRiskCount{ get; set; }

        /// <summary>
        /// 检查失败原因
        /// </summary>
        [JsonProperty("CheckFailReason")]
        public string CheckFailReason{ get; set; }

        /// <summary>
        /// 检查状态,为Task_Running, NoRisk, HasRisk, Uncheck, Task_Error
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 任务创建时间,检查时间
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// 接入状态:
        /// 未接入: AccessedNone
        /// 已防护: AccessedDefended
        /// 未防护: AccessedInstalled
        /// 部分防护: AccessedPartialDefence
        /// 接入异常: AccessedException
        /// 卸载异常: AccessedUninstallException
        /// 接入中: AccessedInstalling
        /// 卸载中: AccessedUninstalling
        /// </summary>
        [JsonProperty("AccessedStatus")]
        public string AccessedStatus{ get; set; }

        /// <summary>
        /// 接入失败原因
        /// </summary>
        [JsonProperty("AccessedSubStatus")]
        public string AccessedSubStatus{ get; set; }

        /// <summary>
        /// 接入/卸载失败原因
        /// </summary>
        [JsonProperty("AccessedErrorReason")]
        public string AccessedErrorReason{ get; set; }

        /// <summary>
        /// 节点总数
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// 离线节点数
        /// </summary>
        [JsonProperty("OffLineNodeCount")]
        public ulong? OffLineNodeCount{ get; set; }

        /// <summary>
        /// 未安装agent节点数
        /// </summary>
        [JsonProperty("UnInstallAgentNodeCount")]
        public ulong? UnInstallAgentNodeCount{ get; set; }

        /// <summary>
        /// 计费核数(弹性计费核数+普通计费核数)
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }

        /// <summary>
        /// master 地址列表
        /// </summary>
        [JsonProperty("MasterAddresses")]
        public string[] MasterAddresses{ get; set; }

        /// <summary>
        /// 核数
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// 集群审计开关状态：
        /// 已关闭Closed/关闭中Closing/关闭失败CloseFailed/已开启Opened/开启中Opening/开启失败OpenFailed
        /// </summary>
        [JsonProperty("ClusterAuditStatus")]
        public string ClusterAuditStatus{ get; set; }

        /// <summary>
        /// 集群审计开关失败信息
        /// </summary>
        [JsonProperty("ClusterAuditFailedInfo")]
        public string ClusterAuditFailedInfo{ get; set; }

        /// <summary>
        /// 所有者名称
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DefenderStatus", this.DefenderStatus);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterSubStatus", this.ClusterSubStatus);
            this.SetParamSimple(map, prefix + "ClusterCheckMode", this.ClusterCheckMode);
            this.SetParamSimple(map, prefix + "ClusterAutoCheck", this.ClusterAutoCheck);
            this.SetParamSimple(map, prefix + "DefenderErrorReason", this.DefenderErrorReason);
            this.SetParamSimple(map, prefix + "UnreadyNodeNum", this.UnreadyNodeNum);
            this.SetParamSimple(map, prefix + "SeriousRiskCount", this.SeriousRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MiddleRiskCount", this.MiddleRiskCount);
            this.SetParamSimple(map, prefix + "HintRiskCount", this.HintRiskCount);
            this.SetParamSimple(map, prefix + "CheckFailReason", this.CheckFailReason);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "AccessedStatus", this.AccessedStatus);
            this.SetParamSimple(map, prefix + "AccessedSubStatus", this.AccessedSubStatus);
            this.SetParamSimple(map, prefix + "AccessedErrorReason", this.AccessedErrorReason);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "OffLineNodeCount", this.OffLineNodeCount);
            this.SetParamSimple(map, prefix + "UnInstallAgentNodeCount", this.UnInstallAgentNodeCount);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
            this.SetParamArraySimple(map, prefix + "MasterAddresses.", this.MasterAddresses);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "ClusterAuditStatus", this.ClusterAuditStatus);
            this.SetParamSimple(map, prefix + "ClusterAuditFailedInfo", this.ClusterAuditFailedInfo);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
        }
    }
}

