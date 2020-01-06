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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 付费类型，可能的返回值：1-包年包月；0-按量计费
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 集群类型，可能的返回值：0-副本集实例，1-分片实例，
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// 地域信息
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区信息
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 网络类型，可能的返回值：0-基础网络，1-私有网络
        /// </summary>
        [JsonProperty("NetType")]
        public ulong? NetType{ get; set; }

        /// <summary>
        /// 私有网络的ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络的子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例状态，可能的返回值：0-待初始化，1-流程处理中，2-运行中，-2-实例已过期
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        [JsonProperty("Vport")]
        public ulong? Vport{ get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例到期时间
        /// </summary>
        [JsonProperty("DeadLine")]
        public string DeadLine{ get; set; }

        /// <summary>
        /// 实例版本信息
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 实例内存规格，单位为MB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 实例磁盘规格，单位为MB
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// 实例CPU核心数
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// 实例机器类型
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 实例从节点数
        /// </summary>
        [JsonProperty("SecondaryNum")]
        public ulong? SecondaryNum{ get; set; }

        /// <summary>
        /// 实例分片数
        /// </summary>
        [JsonProperty("ReplicationSetNum")]
        public ulong? ReplicationSetNum{ get; set; }

        /// <summary>
        /// 实例自动续费标志，可能的返回值：0-手动续费，1-自动续费，2-确认不续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 已用容量，单位MB
        /// </summary>
        [JsonProperty("UsedVolume")]
        public ulong? UsedVolume{ get; set; }

        /// <summary>
        /// 维护窗口起始时间
        /// </summary>
        [JsonProperty("MaintenanceStart")]
        public string MaintenanceStart{ get; set; }

        /// <summary>
        /// 维护窗口结束时间
        /// </summary>
        [JsonProperty("MaintenanceEnd")]
        public string MaintenanceEnd{ get; set; }

        /// <summary>
        /// 分片信息
        /// </summary>
        [JsonProperty("ReplicaSets")]
        public ShardInfo[] ReplicaSets{ get; set; }

        /// <summary>
        /// 只读实例信息
        /// </summary>
        [JsonProperty("ReadonlyInstances")]
        public DBInstanceInfo[] ReadonlyInstances{ get; set; }

        /// <summary>
        /// 灾备实例信息
        /// </summary>
        [JsonProperty("StandbyInstances")]
        public DBInstanceInfo[] StandbyInstances{ get; set; }

        /// <summary>
        /// 临时实例信息
        /// </summary>
        [JsonProperty("CloneInstances")]
        public DBInstanceInfo[] CloneInstances{ get; set; }

        /// <summary>
        /// 关联实例信息，对于正式实例，该字段表示它的临时实例信息；对于临时实例，则表示它的正式实例信息;如果为只读/灾备实例,则表示他的主实例信息
        /// </summary>
        [JsonProperty("RelatedInstance")]
        public DBInstanceInfo RelatedInstance{ get; set; }

        /// <summary>
        /// 实例标签信息集合
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 实例版本标记
        /// </summary>
        [JsonProperty("InstanceVer")]
        public ulong? InstanceVer{ get; set; }

        /// <summary>
        /// 实例版本标记
        /// </summary>
        [JsonProperty("ClusterVer")]
        public ulong? ClusterVer{ get; set; }

        /// <summary>
        /// 协议信息，可能的返回值：1-mongodb，2-dynamodb
        /// </summary>
        [JsonProperty("Protocol")]
        public ulong? Protocol{ get; set; }

        /// <summary>
        /// 实例类型，可能的返回值，1-正式实例，2-临时实例，3-只读实例，4-灾备实例
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// 实例状态描述
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// 实例对应的物理实例id，回档并替换过的实例有不同的InstanceId和RealInstanceId，从barad获取监控数据等场景下需要用物理id获取
        /// </summary>
        [JsonProperty("RealInstanceId")]
        public string RealInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

