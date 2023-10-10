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

    public class ScreenMachine : AbstractModel
    {
        
        /// <summary>
        /// 主机名称。
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 主机系统。
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// 云镜客户端唯一Uuid，若客户端长时间不在线将返回空字符。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 大屏主机状态 0：未安装agent，1：离线状态，2:离线-风险，3：离线-严重
        /// 4：安装设备-正常，5：安装设备-正常 且是专业版或旗舰版，6：安装设备-风险（网络攻击事件>0） ，
        ///  7：安装设备-风险（网络攻击事件>0 且是专业版或旗舰版，8：安装设备-严重（入侵检测事件>0），
        /// 9：安装设备-严重（入侵检测事件>0）且是专业版或旗舰版
        /// </summary>
        [JsonProperty("MachineStatus")]
        public ulong? MachineStatus{ get; set; }

        /// <summary>
        /// CVM或BM机器唯一Uuid。
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 漏洞数。
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }

        /// <summary>
        /// 主机IP。
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 主机外网IP。
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// 基线风险数。
        /// </summary>
        [JsonProperty("BaselineNum")]
        public long? BaselineNum{ get; set; }

        /// <summary>
        /// 网络风险数。
        /// </summary>
        [JsonProperty("CyberAttackNum")]
        public long? CyberAttackNum{ get; set; }

        /// <summary>
        /// 风险状态。
        /// <li>SAFE：安全</li>
        /// <li>RISK：风险</li>
        /// <li>UNKNOWN：未知</li>
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public string SecurityStatus{ get; set; }

        /// <summary>
        /// 入侵事件数
        /// </summary>
        [JsonProperty("InvasionNum")]
        public long? InvasionNum{ get; set; }

        /// <summary>
        /// 机器所属专区类型 CVM 云服务器, BM 黑石, ECM 边缘计算, LH 轻量应用服务器 ,Other 混合云专区
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// cpu 负载状态
        /// </summary>
        [JsonProperty("CpuLoad")]
        public string CpuLoad{ get; set; }

        /// <summary>
        /// cpu 核数
        /// </summary>
        [JsonProperty("CpuSize")]
        public float? CpuSize{ get; set; }

        /// <summary>
        /// 硬盘使用率 %
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// 硬盘容量GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public float? DiskSize{ get; set; }

        /// <summary>
        /// 内存负载率%
        /// </summary>
        [JsonProperty("MemLoad")]
        public string MemLoad{ get; set; }

        /// <summary>
        /// 内存容量 GB
        /// </summary>
        [JsonProperty("MemSize")]
        public float? MemSize{ get; set; }

        /// <summary>
        /// 内核版本
        /// </summary>
        [JsonProperty("CoreVersion")]
        public string CoreVersion{ get; set; }

        /// <summary>
        /// 附加信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "BaselineNum", this.BaselineNum);
            this.SetParamSimple(map, prefix + "CyberAttackNum", this.CyberAttackNum);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
            this.SetParamSimple(map, prefix + "InvasionNum", this.InvasionNum);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "CpuLoad", this.CpuLoad);
            this.SetParamSimple(map, prefix + "CpuSize", this.CpuSize);
            this.SetParamSimple(map, prefix + "DiskLoad", this.DiskLoad);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MemLoad", this.MemLoad);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "CoreVersion", this.CoreVersion);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

