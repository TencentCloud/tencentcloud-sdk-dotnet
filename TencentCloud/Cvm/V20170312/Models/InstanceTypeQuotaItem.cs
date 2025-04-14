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

    public class InstanceTypeQuotaItem : AbstractModel
    {
        
        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例机型。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围： <br><li>PREPAID：表示预付费，即包年包月<br></li><li>POSTPAID_BY_HOUR：表示后付费，即按量计费</li><li>CDHPAID：表示[专用宿主机](https://cloud.tencent.com/document/product/416)付费，即只对`专用宿主机`计费，不对`专用宿主机`上的实例计费。<br></li><li>SPOTPAID：表示竞价实例付费。</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 网卡类型，例如：25代表25G网卡
        /// </summary>
        [JsonProperty("NetworkCard")]
        public long? NetworkCard{ get; set; }

        /// <summary>
        /// 扩展属性。
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// 实例的CPU核数，单位：核。
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 实例内存容量，单位：`GB`。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例机型系列。
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// 机型名称。
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 本地磁盘规格列表。当该参数返回为空值时，表示当前情况下无法创建本地盘。
        /// </summary>
        [JsonProperty("LocalDiskTypeList")]
        public LocalDiskType[] LocalDiskTypeList{ get; set; }

        /// <summary>
        /// 实例是否售卖。取值范围： <br><li>SELL：表示实例可购买<br></li><li>SOLD_OUT：表示实例已售罄。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 实例的售卖价格。
        /// </summary>
        [JsonProperty("Price")]
        public ItemPrice Price{ get; set; }

        /// <summary>
        /// 售罄原因。
        /// </summary>
        [JsonProperty("SoldOutReason")]
        public string SoldOutReason{ get; set; }

        /// <summary>
        /// 内网带宽，单位Gbps。
        /// </summary>
        [JsonProperty("InstanceBandwidth")]
        public float? InstanceBandwidth{ get; set; }

        /// <summary>
        /// 网络收发包能力，单位万PPS。
        /// </summary>
        [JsonProperty("InstancePps")]
        public long? InstancePps{ get; set; }

        /// <summary>
        /// 本地存储块数量。
        /// </summary>
        [JsonProperty("StorageBlockAmount")]
        public long? StorageBlockAmount{ get; set; }

        /// <summary>
        /// 处理器型号。
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 实例的GPU数量。
        /// </summary>
        [JsonProperty("Gpu")]
        public long? Gpu{ get; set; }

        /// <summary>
        /// 实例的FPGA数量。
        /// </summary>
        [JsonProperty("Fpga")]
        public long? Fpga{ get; set; }

        /// <summary>
        /// 实例备注信息。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 实例机型映射的物理GPU卡数，单位：卡。vGPU卡型小于1，直通卡型大于等于1。vGPU是通过分片虚拟化技术，将物理GPU卡重新划分，同一块GPU卡经虚拟化分割后可分配至不同的实例使用。直通卡型会将GPU设备直接挂载给实例使用。
        /// </summary>
        [JsonProperty("GpuCount")]
        public float? GpuCount{ get; set; }

        /// <summary>
        /// 实例的CPU主频信息
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// 描述库存情况。取值范围：
        /// <li> EnoughStock：表示对应库存非常充足</li> <li>NormalStock：表示对应库存供应有保障</li><li> UnderStock：表示对应库存即将售罄</li> <li>WithoutStock：表示对应库存已经售罄</li>
        /// </summary>
        [JsonProperty("StatusCategory")]
        public string StatusCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "NetworkCard", this.NetworkCard);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamArrayObj(map, prefix + "LocalDiskTypeList.", this.LocalDiskTypeList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "SoldOutReason", this.SoldOutReason);
            this.SetParamSimple(map, prefix + "InstanceBandwidth", this.InstanceBandwidth);
            this.SetParamSimple(map, prefix + "InstancePps", this.InstancePps);
            this.SetParamSimple(map, prefix + "StorageBlockAmount", this.StorageBlockAmount);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "Fpga", this.Fpga);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "GpuCount", this.GpuCount);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "StatusCategory", this.StatusCategory);
        }
    }
}

