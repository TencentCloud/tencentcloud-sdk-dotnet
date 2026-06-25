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

    public class MachineDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent状态</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>Agent版本</p>
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// <p>账号AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>资产类型名称</p>
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// <p>系统启动时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("BootTime")]
        public long? BootTime{ get; set; }

        /// <summary>
        /// <p>购买时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("BuyTime")]
        public long? BuyTime{ get; set; }

        /// <summary>
        /// <p>云服务商</p>
        /// </summary>
        [JsonProperty("CloudFromEnum")]
        public string CloudFromEnum{ get; set; }

        /// <summary>
        /// <p>云标签列表</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// <p>内核版本</p>
        /// </summary>
        [JsonProperty("CoreVersion")]
        public string CoreVersion{ get; set; }

        /// <summary>
        /// <p>CPU信息</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public string Cpu{ get; set; }

        /// <summary>
        /// <p>CPU负载</p>
        /// </summary>
        [JsonProperty("CpuLoad")]
        public string CpuLoad{ get; set; }

        /// <summary>
        /// <p>CPU核数</p>
        /// </summary>
        [JsonProperty("CpuSize")]
        public ulong? CpuSize{ get; set; }

        /// <summary>
        /// <p>设备型号</p>
        /// </summary>
        [JsonProperty("DeviceVersion")]
        public string DeviceVersion{ get; set; }

        /// <summary>
        /// <p>磁盘分区信息</p>
        /// </summary>
        [JsonProperty("Disks")]
        public DiskPartitionInfo[] Disks{ get; set; }

        /// <summary>
        /// <p>到期时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>暴露状态</p>
        /// </summary>
        [JsonProperty("ExposedStatus")]
        public string ExposedStatus{ get; set; }

        /// <summary>
        /// <p>安装时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("InstallTime")]
        public long? InstallTime{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>内核版本</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// <p>最近一次在线时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("LatestLiveTime")]
        public long? LatestLiveTime{ get; set; }

        /// <summary>
        /// <p>最近一次离线时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("LatestOfflineTime")]
        public long? LatestOfflineTime{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>主机名称</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>操作系统（云采集）</p>
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// <p>主机状态</p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>外网IP</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>内存大小(MB)</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// <p>内存使用率</p>
        /// </summary>
        [JsonProperty("MemoryLoad")]
        public string MemoryLoad{ get; set; }

        /// <summary>
        /// <p>网卡信息</p>
        /// </summary>
        [JsonProperty("NetCards")]
        public NetworkCardInfo[] NetCards{ get; set; }

        /// <summary>
        /// <p>操作系统（端采集）</p>
        /// </summary>
        [JsonProperty("OsByAgent")]
        public string OsByAgent{ get; set; }

        /// <summary>
        /// <p>付费模式</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>已防护天数</p>
        /// </summary>
        [JsonProperty("ProtectDays")]
        public ulong? ProtectDays{ get; set; }

        /// <summary>
        /// <p>防护类型</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>主机唯一标识</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>地域信息</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>序列号</p>
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// <p>资产标签列表</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>标签修改信息</p>
        /// </summary>
        [JsonProperty("TagModifyInfo")]
        public AssetTagModifyAssetItem TagModifyInfo{ get; set; }

        /// <summary>
        /// <p>Agent唯一标识</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>VPC CIDR</p>
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>VPC名称</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>主机节点类型</p><p>枚举值：</p><ul><li>NONE： 主机节点</li><li>CLUSTER： 集群节点</li><li>CONTAINER： 容器节点</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>容器防护状态</p><p>枚举值：</p><ul><li>Enabled： 开启防护</li><li>Disabled： 关闭防护</li><li>Unknown： 未知</li></ul>
        /// </summary>
        [JsonProperty("ContainerDefendStatus")]
        public string ContainerDefendStatus{ get; set; }

        /// <summary>
        /// <p>集群签证md5</p>
        /// </summary>
        [JsonProperty("ClusterCaMd5")]
        public string ClusterCaMd5{ get; set; }

        /// <summary>
        /// <p>容器环境信息</p>
        /// </summary>
        [JsonProperty("ContainerEnvInfo")]
        public ContainerEnvInfo ContainerEnvInfo{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AssetTypeName", this.AssetTypeName);
            this.SetParamSimple(map, prefix + "BootTime", this.BootTime);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "CloudFromEnum", this.CloudFromEnum);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "CoreVersion", this.CoreVersion);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "CpuLoad", this.CpuLoad);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "DeviceVersion", this.DeviceVersion);
            this.SetParamArrayObj(map, prefix + "Disks.", this.Disks);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExposedStatus", this.ExposedStatus);
            this.SetParamSimple(map, prefix + "InstallTime", this.InstallTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "LatestLiveTime", this.LatestLiveTime);
            this.SetParamSimple(map, prefix + "LatestOfflineTime", this.LatestOfflineTime);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemoryLoad", this.MemoryLoad);
            this.SetParamArrayObj(map, prefix + "NetCards.", this.NetCards);
            this.SetParamSimple(map, prefix + "OsByAgent", this.OsByAgent);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamObj(map, prefix + "TagModifyInfo.", this.TagModifyInfo);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ContainerDefendStatus", this.ContainerDefendStatus);
            this.SetParamSimple(map, prefix + "ClusterCaMd5", this.ClusterCaMd5);
            this.SetParamObj(map, prefix + "ContainerEnvInfo.", this.ContainerEnvInfo);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
        }
    }
}

