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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例所属地域。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 健康得分。
        /// </summary>
        [JsonProperty("HealthScore")]
        public long? HealthScore{ get; set; }

        /// <summary>
        /// 所属产品。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 异常事件数量。
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// 实例类型：1:MASTER；2:DR，3：RO，4:SDR。
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 核心数。
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存，单位MB。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 硬盘存储，单位GB。
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// 数据库版本。
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 内网地址。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 内网端口。
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 接入来源。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 分组ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 分组组名。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 实例状态：0：发货中；1：运行正常；4：销毁中；5：隔离中。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 子网统一ID。
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// cdb类型。
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// cdb实例初始化标志：0：未初始化；1：已初始化。
        /// </summary>
        [JsonProperty("InitFlag")]
        public long? InitFlag{ get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 私有网络统一ID。
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 实例巡检/概览的状态。
        /// </summary>
        [JsonProperty("InstanceConf")]
        public InstanceConfs InstanceConf{ get; set; }

        /// <summary>
        /// 资源到期时间。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 是否是DBbrain支持的实例。
        /// </summary>
        [JsonProperty("IsSupported")]
        public bool? IsSupported{ get; set; }

        /// <summary>
        /// 实例安全审计日志开启状态：ON： 安全审计开启；OFF： 未开启安全审计。
        /// </summary>
        [JsonProperty("SecAuditStatus")]
        public string SecAuditStatus{ get; set; }

        /// <summary>
        /// 实例审计日志开启状态，ALL_AUDIT： 开启全审计；RULE_AUDIT： 开启规则审计；UNBOUND： 未开启审计。
        /// </summary>
        [JsonProperty("AuditPolicyStatus")]
        public string AuditPolicyStatus{ get; set; }

        /// <summary>
        /// 实例审计日志运行状态：normal： 运行中； paused： 欠费暂停。
        /// </summary>
        [JsonProperty("AuditRunningStatus")]
        public string AuditRunningStatus{ get; set; }

        /// <summary>
        /// 内网vip。
        /// </summary>
        [JsonProperty("InternalVip")]
        public string InternalVip{ get; set; }

        /// <summary>
        /// 内网port。
        /// </summary>
        [JsonProperty("InternalVport")]
        public long? InternalVport{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 所属集群ID（仅对集群数据库产品该字段非空，如TDSQL-C）。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 所属集群名称（仅对集群数据库产品该字段非空，如TDSQL-C）。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 自建MySQL的Agent状态，"not_deployed" - 未部署，"deploying" - 部署中，"connected" - 连接正常，"deploy_failed" - 连接失败，"monitoring" - 连接正常，"stopped" - 暂停连接，"connect_failed" - 连接失败，unknown - 未知。
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// 自建MySQL的实例状态，"not_attached" - 未连接，"attached" - 连接正常，"failed" - 连接失败，"stopped" - 停止监控，unknown- 未知。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "HealthScore", this.HealthScore);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "InitFlag", this.InitFlag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamObj(map, prefix + "InstanceConf.", this.InstanceConf);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "IsSupported", this.IsSupported);
            this.SetParamSimple(map, prefix + "SecAuditStatus", this.SecAuditStatus);
            this.SetParamSimple(map, prefix + "AuditPolicyStatus", this.AuditPolicyStatus);
            this.SetParamSimple(map, prefix + "AuditRunningStatus", this.AuditRunningStatus);
            this.SetParamSimple(map, prefix + "InternalVip", this.InternalVip);
            this.SetParamSimple(map, prefix + "InternalVport", this.InternalVport);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
        }
    }
}

