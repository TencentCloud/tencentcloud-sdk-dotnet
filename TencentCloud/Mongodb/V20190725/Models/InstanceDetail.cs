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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 付费类型。
        /// - 1：包年包月。
        /// - 0：按量计费。
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 集群类型。
        /// - 0：副本集实例。
        /// - 1：分片实例。
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// 地域信息。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区信息。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 网络类型。
        /// - 0：基础网络。
        /// - 1：私有网络。
        /// </summary>
        [JsonProperty("NetType")]
        public ulong? NetType{ get; set; }

        /// <summary>
        /// 私有网络的ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络的子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例状态。
        /// - 0：待初始化。
        /// - 1：流程处理中，例如：变更规格、参数修改等。
        /// - 2：实例正常运行中。
        /// - -2：已隔离（包年包月）。
        /// - -3：已隔离（按量计费）。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例IP。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 端口号。
        /// </summary>
        [JsonProperty("Vport")]
        public ulong? Vport{ get; set; }

        /// <summary>
        /// 实例创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例到期时间。
        /// </summary>
        [JsonProperty("DeadLine")]
        public string DeadLine{ get; set; }

        /// <summary>
        /// 实例存储引擎版本信息。
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本。
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本。
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// - MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。
        /// - MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。
        /// - MONGO_60_WT：MongoDB 6.0 WiredTiger存储引擎版本。
        /// - MONGO_70_WT：MongoDB 7.0 WiredTiger存储引擎版本。
        /// - MONGO_80_WT：MongoDB 8.0 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 实例内存规格，单位：MB。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 实例磁盘规格，单位：MB。
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// 实例 CPU 核心数。
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// 实例机器类型。
        /// - HIO10G：通用高 HIO 万兆型。
        /// - HCD：云盘版类型。
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 实例从节点数。
        /// </summary>
        [JsonProperty("SecondaryNum")]
        public ulong? SecondaryNum{ get; set; }

        /// <summary>
        /// 实例分片数。
        /// </summary>
        [JsonProperty("ReplicationSetNum")]
        public ulong? ReplicationSetNum{ get; set; }

        /// <summary>
        /// 实例自动续费标志。
        /// - 0：手动续费。
        /// - 1：自动续费。
        /// - 2：确认不续费。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 已用容量，单位：MB。
        /// </summary>
        [JsonProperty("UsedVolume")]
        public ulong? UsedVolume{ get; set; }

        /// <summary>
        /// 维护窗口起始时间。
        /// </summary>
        [JsonProperty("MaintenanceStart")]
        public string MaintenanceStart{ get; set; }

        /// <summary>
        /// 维护窗口结束时间。
        /// </summary>
        [JsonProperty("MaintenanceEnd")]
        public string MaintenanceEnd{ get; set; }

        /// <summary>
        /// 分片信息。
        /// </summary>
        [JsonProperty("ReplicaSets")]
        public ShardInfo[] ReplicaSets{ get; set; }

        /// <summary>
        /// 只读实例信息。
        /// </summary>
        [JsonProperty("ReadonlyInstances")]
        public DBInstanceInfo[] ReadonlyInstances{ get; set; }

        /// <summary>
        /// 灾备实例信息。
        /// </summary>
        [JsonProperty("StandbyInstances")]
        public DBInstanceInfo[] StandbyInstances{ get; set; }

        /// <summary>
        /// 临时实例信息。
        /// </summary>
        [JsonProperty("CloneInstances")]
        public DBInstanceInfo[] CloneInstances{ get; set; }

        /// <summary>
        /// 关联实例信息，对于正式实例，该字段表示它的临时实例信息；对于临时实例，则表示它的正式实例信息;如果为只读/灾备实例,则表示他的主实例信息。
        /// </summary>
        [JsonProperty("RelatedInstance")]
        public DBInstanceInfo RelatedInstance{ get; set; }

        /// <summary>
        /// 实例标签信息集合。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 实例版本标记。
        /// </summary>
        [JsonProperty("InstanceVer")]
        public ulong? InstanceVer{ get; set; }

        /// <summary>
        /// 实例版本标记。
        /// </summary>
        [JsonProperty("ClusterVer")]
        public ulong? ClusterVer{ get; set; }

        /// <summary>
        /// 协议信息：mongodb。
        /// </summary>
        [JsonProperty("Protocol")]
        public ulong? Protocol{ get; set; }

        /// <summary>
        /// 实例类型。
        /// - 0：所有实例。
        /// - 1：正式实例。
        /// - 2：临时实例
        /// - 3：只读实例。
        /// - -1：同时包括正式实例、只读实例与灾备实例。
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// 实例状态描述。
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// 实例对应的物理实例 ID。回档并替换过的实例有不同的 InstanceId 和 RealInstanceId，从 barad 获取监控数据等场景下需要用物理 ID 获取。
        /// </summary>
        [JsonProperty("RealInstanceId")]
        public string RealInstanceId{ get; set; }

        /// <summary>
        /// 实例当前可用区信息。
        /// </summary>
        [JsonProperty("ZoneList")]
        public string[] ZoneList{ get; set; }

        /// <summary>
        /// mongos 节点个数。
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }

        /// <summary>
        /// mongos 节点内存。单位：MB。
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// mongos 节点 CPU 核数。
        /// </summary>
        [JsonProperty("MongosCpuNum")]
        public ulong? MongosCpuNum{ get; set; }

        /// <summary>
        /// Config Server节点个数。
        /// </summary>
        [JsonProperty("ConfigServerNodeNum")]
        public ulong? ConfigServerNodeNum{ get; set; }

        /// <summary>
        /// Config Server节点内存。单位：MB。
        /// </summary>
        [JsonProperty("ConfigServerMemory")]
        public ulong? ConfigServerMemory{ get; set; }

        /// <summary>
        /// Config Server节点磁盘大小。单位：MB。
        /// </summary>
        [JsonProperty("ConfigServerVolume")]
        public ulong? ConfigServerVolume{ get; set; }

        /// <summary>
        /// Config Server 节点 CPU 核数。
        /// </summary>
        [JsonProperty("ConfigServerCpuNum")]
        public ulong? ConfigServerCpuNum{ get; set; }

        /// <summary>
        /// readonly节点个数。
        /// </summary>
        [JsonProperty("ReadonlyNodeNum")]
        public ulong? ReadonlyNodeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeadLine", this.DeadLine);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "SecondaryNum", this.SecondaryNum);
            this.SetParamSimple(map, prefix + "ReplicationSetNum", this.ReplicationSetNum);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "UsedVolume", this.UsedVolume);
            this.SetParamSimple(map, prefix + "MaintenanceStart", this.MaintenanceStart);
            this.SetParamSimple(map, prefix + "MaintenanceEnd", this.MaintenanceEnd);
            this.SetParamArrayObj(map, prefix + "ReplicaSets.", this.ReplicaSets);
            this.SetParamArrayObj(map, prefix + "ReadonlyInstances.", this.ReadonlyInstances);
            this.SetParamArrayObj(map, prefix + "StandbyInstances.", this.StandbyInstances);
            this.SetParamArrayObj(map, prefix + "CloneInstances.", this.CloneInstances);
            this.SetParamObj(map, prefix + "RelatedInstance.", this.RelatedInstance);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceVer", this.InstanceVer);
            this.SetParamSimple(map, prefix + "ClusterVer", this.ClusterVer);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamSimple(map, prefix + "RealInstanceId", this.RealInstanceId);
            this.SetParamArraySimple(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "MongosNodeNum", this.MongosNodeNum);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamSimple(map, prefix + "MongosCpuNum", this.MongosCpuNum);
            this.SetParamSimple(map, prefix + "ConfigServerNodeNum", this.ConfigServerNodeNum);
            this.SetParamSimple(map, prefix + "ConfigServerMemory", this.ConfigServerMemory);
            this.SetParamSimple(map, prefix + "ConfigServerVolume", this.ConfigServerVolume);
            this.SetParamSimple(map, prefix + "ConfigServerCpuNum", this.ConfigServerCpuNum);
            this.SetParamSimple(map, prefix + "ReadonlyNodeNum", this.ReadonlyNodeNum);
        }
    }
}

