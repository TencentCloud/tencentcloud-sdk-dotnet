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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetMachineDetail : AbstractModel
    {
        
        /// <summary>
        /// 服务器Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 服务器uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 服务器内网IP
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 服务器名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("OsInfo")]
        public string OsInfo{ get; set; }

        /// <summary>
        /// CPU信息
        /// </summary>
        [JsonProperty("Cpu")]
        public string Cpu{ get; set; }

        /// <summary>
        /// 内存容量：单位G
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 内存使用率百分比
        /// </summary>
        [JsonProperty("MemLoad")]
        public string MemLoad{ get; set; }

        /// <summary>
        /// 硬盘容量：单位G
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 硬盘使用率百分比
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// 分区数
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// 主机外网IP
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// Cpu数量
        /// </summary>
        [JsonProperty("CpuSize")]
        public ulong? CpuSize{ get; set; }

        /// <summary>
        /// Cpu使用率百分比
        /// </summary>
        [JsonProperty("CpuLoad")]
        public string CpuLoad{ get; set; }

        /// <summary>
        /// 防护级别：0基础版，1专业版，2旗舰版，3普惠版
        /// </summary>
        [JsonProperty("ProtectLevel")]
        public ulong? ProtectLevel{ get; set; }

        /// <summary>
        /// 风险状态：UNKNOW-未知，RISK-风险，SAFT-安全
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// 已防护天数
        /// </summary>
        [JsonProperty("ProtectDays")]
        public ulong? ProtectDays{ get; set; }

        /// <summary>
        /// 专业版开通时间
        /// </summary>
        [JsonProperty("BuyTime")]
        public string BuyTime{ get; set; }

        /// <summary>
        /// 专业版到期时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 内核版本
        /// </summary>
        [JsonProperty("CoreVersion")]
        public string CoreVersion{ get; set; }

        /// <summary>
        /// linux/windows
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// agent版本
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// 安装时间
        /// </summary>
        [JsonProperty("InstallTime")]
        public string InstallTime{ get; set; }

        /// <summary>
        /// 系统启动时间
        /// </summary>
        [JsonProperty("BootTime")]
        public string BootTime{ get; set; }

        /// <summary>
        /// 最后上线时间
        /// </summary>
        [JsonProperty("LastLiveTime")]
        public string LastLiveTime{ get; set; }

        /// <summary>
        /// 生产商
        /// </summary>
        [JsonProperty("Producer")]
        public string Producer{ get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 网卡
        /// </summary>
        [JsonProperty("NetCards")]
        public AssetNetworkCardInfo[] NetCards{ get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("Disks")]
        public AssetDiskPartitionInfo[] Disks{ get; set; }

        /// <summary>
        /// 0在线，1已离线
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 业务组ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("DeviceVersion")]
        public string DeviceVersion{ get; set; }

        /// <summary>
        /// 离线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// 主机ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 数据更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 主机二外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "OsInfo", this.OsInfo);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemLoad", this.MemLoad);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskLoad", this.DiskLoad);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "CpuLoad", this.CpuLoad);
            this.SetParamSimple(map, prefix + "ProtectLevel", this.ProtectLevel);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CoreVersion", this.CoreVersion);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "InstallTime", this.InstallTime);
            this.SetParamSimple(map, prefix + "BootTime", this.BootTime);
            this.SetParamSimple(map, prefix + "LastLiveTime", this.LastLiveTime);
            this.SetParamSimple(map, prefix + "Producer", this.Producer);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamArrayObj(map, prefix + "NetCards.", this.NetCards);
            this.SetParamArrayObj(map, prefix + "Disks.", this.Disks);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeviceVersion", this.DeviceVersion);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

