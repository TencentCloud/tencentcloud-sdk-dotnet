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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostDetail : AbstractModel
    {
        
        /// <summary>
        /// 主机Id
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 主机状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 分配DB实例状态,0:可分配,1:不可分配
        /// </summary>
        [JsonProperty("AssignStatus")]
        public long? AssignStatus{ get; set; }

        /// <summary>
        /// 主机类型, 0:物理机, 1:cvm本地盘, 2:cvm云盘
        /// </summary>
        [JsonProperty("HostType")]
        public long? HostType{ get; set; }

        /// <summary>
        /// DB实例数
        /// </summary>
        [JsonProperty("DbNum")]
        public long? DbNum{ get; set; }

        /// <summary>
        /// 主机CPU(单位:核数)
        /// </summary>
        [JsonProperty("CpuSpec")]
        public long? CpuSpec{ get; set; }

        /// <summary>
        /// 已分配CPU(单位:核数)
        /// </summary>
        [JsonProperty("CpuAssigned")]
        public long? CpuAssigned{ get; set; }

        /// <summary>
        /// 可分配CPU(单位:核数)
        /// </summary>
        [JsonProperty("CpuAssignable")]
        public long? CpuAssignable{ get; set; }

        /// <summary>
        /// 主机内存(单位:GB)
        /// </summary>
        [JsonProperty("MemorySpec")]
        public long? MemorySpec{ get; set; }

        /// <summary>
        /// 已分配内存(单位:GB)
        /// </summary>
        [JsonProperty("MemoryAssigned")]
        public long? MemoryAssigned{ get; set; }

        /// <summary>
        /// 可分配内存(单位:GB)
        /// </summary>
        [JsonProperty("MemoryAssignable")]
        public long? MemoryAssignable{ get; set; }

        /// <summary>
        /// 主机磁盘(单位:GB)
        /// </summary>
        [JsonProperty("DiskSpec")]
        public long? DiskSpec{ get; set; }

        /// <summary>
        /// 已分配磁盘(单位:GB)
        /// </summary>
        [JsonProperty("DiskAssigned")]
        public long? DiskAssigned{ get; set; }

        /// <summary>
        /// 可分配磁盘(GB)
        /// </summary>
        [JsonProperty("DiskAssignable")]
        public long? DiskAssignable{ get; set; }

        /// <summary>
        /// CPU分配比
        /// </summary>
        [JsonProperty("CpuRatio")]
        public float? CpuRatio{ get; set; }

        /// <summary>
        /// 内存分配比
        /// </summary>
        [JsonProperty("MemoryRatio")]
        public float? MemoryRatio{ get; set; }

        /// <summary>
        /// 磁盘分配比
        /// </summary>
        [JsonProperty("DiskRatio")]
        public float? DiskRatio{ get; set; }

        /// <summary>
        /// 机型名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 机型类别
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 计费标签
        /// </summary>
        [JsonProperty("PidTag")]
        public string PidTag{ get; set; }

        /// <summary>
        /// 计费ID
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// 独享集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AssignStatus", this.AssignStatus);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "DbNum", this.DbNum);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "CpuAssigned", this.CpuAssigned);
            this.SetParamSimple(map, prefix + "CpuAssignable", this.CpuAssignable);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "MemoryAssigned", this.MemoryAssigned);
            this.SetParamSimple(map, prefix + "MemoryAssignable", this.MemoryAssignable);
            this.SetParamSimple(map, prefix + "DiskSpec", this.DiskSpec);
            this.SetParamSimple(map, prefix + "DiskAssigned", this.DiskAssigned);
            this.SetParamSimple(map, prefix + "DiskAssignable", this.DiskAssignable);
            this.SetParamSimple(map, prefix + "CpuRatio", this.CpuRatio);
            this.SetParamSimple(map, prefix + "MemoryRatio", this.MemoryRatio);
            this.SetParamSimple(map, prefix + "DiskRatio", this.DiskRatio);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "PidTag", this.PidTag);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

