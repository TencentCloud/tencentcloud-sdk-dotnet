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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChcHost : AbstractModel
    {
        
        /// <summary>
        /// <p>CHC物理服务器ID。</p>
        /// </summary>
        [JsonProperty("ChcId")]
        public string ChcId{ get; set; }

        /// <summary>
        /// <p>实例名称。</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>服务器序列号。</p>
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// <p>CHC的状态<br></p><ul><li>INIT: 设备已录入。还未配置带外和部署网络</li><li>READY: 已配置带外和部署网络</li><li>PREPARED: 可分配云主机</li><li>ONLINE: 已分配云主机</li><li>OPERATING: 设备操作中，如正在配置带外网络等。</li><li>CLEAR_NETWORK_FAILED: 清理带外和部署网络失败</li></ul>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// <p>设备类型。</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>所属可用区。</p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>带外网络。</p>
        /// </summary>
        [JsonProperty("BmcVirtualPrivateCloud")]
        public VirtualPrivateCloud BmcVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// <p>带外网络IP。</p>
        /// </summary>
        [JsonProperty("BmcIp")]
        public string BmcIp{ get; set; }

        /// <summary>
        /// <p>带外网络安全组ID。</p>
        /// </summary>
        [JsonProperty("BmcSecurityGroupIds")]
        public string[] BmcSecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>部署网络。</p>
        /// </summary>
        [JsonProperty("DeployVirtualPrivateCloud")]
        public VirtualPrivateCloud DeployVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// <p>部署网络IP。</p>
        /// </summary>
        [JsonProperty("DeployIp")]
        public string DeployIp{ get; set; }

        /// <summary>
        /// <p>部署网络安全组ID。</p>
        /// </summary>
        [JsonProperty("DeploySecurityGroupIds")]
        public string[] DeploySecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>关联的云主机ID。</p>
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// <p>服务器导入的时间。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>机型的硬件描述，分别为CPU核数，内存容量和磁盘容量。</p>
        /// </summary>
        [JsonProperty("HardwareDescription")]
        public string HardwareDescription{ get; set; }

        /// <summary>
        /// <p>CHC物理服务器的CPU核数。</p>
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// <p>CHC物理服务器的内存大小，单位为GB。</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>CHC物理服务器的磁盘信息。</p>
        /// </summary>
        [JsonProperty("Disk")]
        public string Disk{ get; set; }

        /// <summary>
        /// <p>带外网络下分配的MAC地址。</p>
        /// </summary>
        [JsonProperty("BmcMAC")]
        public string BmcMAC{ get; set; }

        /// <summary>
        /// <p>部署网络下分配的MAC地址。</p>
        /// </summary>
        [JsonProperty("DeployMAC")]
        public string DeployMAC{ get; set; }

        /// <summary>
        /// <p>设备托管类型。</p><p>枚举值：</p><ul><li>HOSTING： 托管类型。</li><li>TENANT： 租赁类型。</li></ul>
        /// </summary>
        [JsonProperty("TenantType")]
        public string TenantType{ get; set; }

        /// <summary>
        /// <p>CHC DHCP选项，用于客户自建PXE环境。</p>
        /// </summary>
        [JsonProperty("DeployExtraConfig")]
        public ChcDeployExtraConfig DeployExtraConfig{ get; set; }

        /// <summary>
        /// <p>GPU型号。</p>
        /// </summary>
        [JsonProperty("Gpu")]
        public string Gpu{ get; set; }

        /// <summary>
        /// <p>网卡型号。主要指RDMA网卡。</p>
        /// </summary>
        [JsonProperty("NetworkCard")]
        public string NetworkCard{ get; set; }

        /// <summary>
        /// <p>是否是预定义机型。</p>
        /// </summary>
        [JsonProperty("IsPredefinedType")]
        public bool? IsPredefinedType{ get; set; }

        /// <summary>
        /// <p>CHC云主机机型。</p>
        /// </summary>
        [JsonProperty("ChcInstanceType")]
        public string ChcInstanceType{ get; set; }

        /// <summary>
        /// <p>CHC云主机机型簇。</p>
        /// </summary>
        [JsonProperty("ChcInstanceFamily")]
        public string ChcInstanceFamily{ get; set; }

        /// <summary>
        /// <p>CHC云主机机型簇名称。</p>
        /// </summary>
        [JsonProperty("ChcInstanceFamilyName")]
        public string ChcInstanceFamilyName{ get; set; }

        /// <summary>
        /// <p>转售客户的AppID。</p>
        /// </summary>
        [JsonProperty("ResaleAppId")]
        public string ResaleAppId{ get; set; }

        /// <summary>
        /// <p>转售客户的账号ID。</p>
        /// </summary>
        [JsonProperty("ResaleAccountId")]
        public string ResaleAccountId{ get; set; }

        /// <summary>
        /// <p>售卖状态。<br></p><ul><li>NOT_FOR_SALE:不可售卖</li><li>AVAILABLE: 可售卖</li><li>SOLD: 已售卖</li></ul>
        /// </summary>
        [JsonProperty("SaleStatus")]
        public string SaleStatus{ get; set; }

        /// <summary>
        /// <p>CHC物理服务器关联的标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>最近操作。</p>
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// <p>最近操作错误码。</p>
        /// </summary>
        [JsonProperty("LatestOperationErrorCode")]
        public string LatestOperationErrorCode{ get; set; }

        /// <summary>
        /// <p>最近操作错误详情和建议项。</p>
        /// </summary>
        [JsonProperty("LatestOperationErrorMsg")]
        public string LatestOperationErrorMsg{ get; set; }

        /// <summary>
        /// <p>最近操作名称。</p>
        /// </summary>
        [JsonProperty("LatestOperationName")]
        public string LatestOperationName{ get; set; }

        /// <summary>
        /// <p>最近操作状态。</p><p>枚举值：</p><ul><li>SUCCESS： 成功。</li><li>FAILED： 失败。</li></ul>
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// <p>所在的CHC网关的ID，只有专属网关才会返回。</p>
        /// </summary>
        [JsonProperty("ChcGatewayId")]
        public string ChcGatewayId{ get; set; }

        /// <summary>
        /// <p>所属的CDC集群ID。</p>
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// <p>业务网卡网络模式。</p><p>枚举值：</p><ul><li>DEPLOY： 部署网络模式</li><li>BUSINESS： 业务网络模式</li></ul>
        /// </summary>
        [JsonProperty("NetworkMode")]
        public string NetworkMode{ get; set; }


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
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "NetworkCard", this.NetworkCard);
            this.SetParamSimple(map, prefix + "IsPredefinedType", this.IsPredefinedType);
            this.SetParamSimple(map, prefix + "ChcInstanceType", this.ChcInstanceType);
            this.SetParamSimple(map, prefix + "ChcInstanceFamily", this.ChcInstanceFamily);
            this.SetParamSimple(map, prefix + "ChcInstanceFamilyName", this.ChcInstanceFamilyName);
            this.SetParamSimple(map, prefix + "ResaleAppId", this.ResaleAppId);
            this.SetParamSimple(map, prefix + "ResaleAccountId", this.ResaleAccountId);
            this.SetParamSimple(map, prefix + "SaleStatus", this.SaleStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationErrorCode", this.LatestOperationErrorCode);
            this.SetParamSimple(map, prefix + "LatestOperationErrorMsg", this.LatestOperationErrorMsg);
            this.SetParamSimple(map, prefix + "LatestOperationName", this.LatestOperationName);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "ChcGatewayId", this.ChcGatewayId);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "NetworkMode", this.NetworkMode);
        }
    }
}

