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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChcHost : AbstractModel
    {
        
        /// <summary>
        /// CHC物理服务器ID。
        /// </summary>
        [JsonProperty("ChcId")]
        public string ChcId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 服务器序列号。
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// CHC的状态<br/>
        /// <ul>
        /// <li>REGISTERED: 设备已录入。还未配置带外和部署网络</li>
        /// <li>VPC_READY: 已配置带外和部署网络</li>
        /// <li>PREPARED: 可分配云主机</li>
        /// <li>ONLINE: 已分配云主机</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 设备类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 所属可用区
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 带外网络。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BmcVirtualPrivateCloud")]
        public VirtualPrivateCloud BmcVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 带外网络Ip。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BmcIp")]
        public string BmcIp{ get; set; }

        /// <summary>
        /// 带外网络安全组Id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BmcSecurityGroupIds")]
        public string[] BmcSecurityGroupIds{ get; set; }

        /// <summary>
        /// 部署网络。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployVirtualPrivateCloud")]
        public VirtualPrivateCloud DeployVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 部署网络Ip。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployIp")]
        public string DeployIp{ get; set; }

        /// <summary>
        /// 部署网络安全组Id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeploySecurityGroupIds")]
        public string[] DeploySecurityGroupIds{ get; set; }

        /// <summary>
        /// 关联的云主机Id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// 服务器导入的时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 机型的硬件描述，分别为CPU核数，内存容量和磁盘容量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HardwareDescription")]
        public string HardwareDescription{ get; set; }

        /// <summary>
        /// CHC物理服务器的CPU核数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// CHC物理服务器的内存大小，单位为GB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// CHC物理服务器的磁盘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Disk")]
        public string Disk{ get; set; }

        /// <summary>
        /// 带外网络下分配的MAC地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BmcMAC")]
        public string BmcMAC{ get; set; }

        /// <summary>
        /// 部署网络下分配的MAC地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployMAC")]
        public string DeployMAC{ get; set; }

        /// <summary>
        /// 设备托管类型。
        /// HOSTING: 托管
        /// TENANT: 租赁
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TenantType")]
        public string TenantType{ get; set; }

        /// <summary>
        /// chc dhcp选项，用于minios调试
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployExtraConfig")]
        public ChcDeployExtraConfig DeployExtraConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChcId", this.ChcId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "BmcVirtualPrivateCloud.", this.BmcVirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "BmcIp", this.BmcIp);
            this.SetParamArraySimple(map, prefix + "BmcSecurityGroupIds.", this.BmcSecurityGroupIds);
            this.SetParamObj(map, prefix + "DeployVirtualPrivateCloud.", this.DeployVirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "DeployIp", this.DeployIp);
            this.SetParamArraySimple(map, prefix + "DeploySecurityGroupIds.", this.DeploySecurityGroupIds);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "HardwareDescription", this.HardwareDescription);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "BmcMAC", this.BmcMAC);
            this.SetParamSimple(map, prefix + "DeployMAC", this.DeployMAC);
            this.SetParamSimple(map, prefix + "TenantType", this.TenantType);
            this.SetParamObj(map, prefix + "DeployExtraConfig.", this.DeployExtraConfig);
        }
    }
}

