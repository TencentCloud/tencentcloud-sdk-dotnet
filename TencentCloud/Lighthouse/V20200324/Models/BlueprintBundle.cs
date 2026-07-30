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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlueprintBundle : AbstractModel
    {
        
        /// <summary>
        /// 套餐ID。可以通过[DescribeBundles](https://cloud.tencent.com/document/product/1207/47575)接口返回的BundleId获取。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 是否支持 Linux/Unix 平台。
        /// </summary>
        [JsonProperty("SupportLinuxUnixPlatform")]
        public bool? SupportLinuxUnixPlatform{ get; set; }

        /// <summary>
        /// 是否支持 Windows 平台。
        /// </summary>
        [JsonProperty("SupportWindowsPlatform")]
        public bool? SupportWindowsPlatform{ get; set; }

        /// <summary>
        /// 套餐当前单位价格信息。
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }

        /// <summary>
        /// 套餐售卖状态,取值:‘AVAILABLE’(可用) , ‘SOLD_OUT’(售罄)。
        /// </summary>
        [JsonProperty("BundleSalesState")]
        public string BundleSalesState{ get; set; }

        /// <summary>
        /// 套餐类型。
        /// </summary>
        [JsonProperty("BundleType")]
        public string BundleType{ get; set; }

        /// <summary>
        /// 套餐类型描述信息。
        /// </summary>
        [JsonProperty("BundleTypeDescription")]
        public string BundleTypeDescription{ get; set; }

        /// <summary>
        /// 套餐类型权重。取值越小排序越靠前。
        /// </summary>
        [JsonProperty("BundleTypePriority")]
        public long? BundleTypePriority{ get; set; }

        /// <summary>
        /// 套餐展示标签。
        /// </summary>
        [JsonProperty("BundleDisplayLabel")]
        public string BundleDisplayLabel{ get; set; }

        /// <summary>
        /// 支持人数。
        /// </summary>
        [JsonProperty("SupportSlot")]
        public long? SupportSlot{ get; set; }

        /// <summary>
        /// 内存大小，单位 GB。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 系统盘类型。
        /// 取值范围： 
        /// <li> CLOUD_SSD：SSD 云硬盘</li><li> CLOUD_PREMIUM：高性能云硬盘</li>
        /// </summary>
        [JsonProperty("SystemDiskType")]
        public string SystemDiskType{ get; set; }

        /// <summary>
        /// 系统盘大小。单位GB。
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public long? SystemDiskSize{ get; set; }

        /// <summary>
        /// 每月网络流量，单位 GB。
        /// </summary>
        [JsonProperty("MonthlyTraffic")]
        public long? MonthlyTraffic{ get; set; }

        /// <summary>
        /// CPU 核数。
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// 峰值带宽，单位 Mbps。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 网络计费类型。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 流量是否无上限。
        /// </summary>
        [JsonProperty("TrafficUnlimited")]
        public bool? TrafficUnlimited{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "SupportLinuxUnixPlatform", this.SupportLinuxUnixPlatform);
            this.SetParamSimple(map, prefix + "SupportWindowsPlatform", this.SupportWindowsPlatform);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "BundleSalesState", this.BundleSalesState);
            this.SetParamSimple(map, prefix + "BundleType", this.BundleType);
            this.SetParamSimple(map, prefix + "BundleTypeDescription", this.BundleTypeDescription);
            this.SetParamSimple(map, prefix + "BundleTypePriority", this.BundleTypePriority);
            this.SetParamSimple(map, prefix + "BundleDisplayLabel", this.BundleDisplayLabel);
            this.SetParamSimple(map, prefix + "SupportSlot", this.SupportSlot);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "SystemDiskType", this.SystemDiskType);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "MonthlyTraffic", this.MonthlyTraffic);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "TrafficUnlimited", this.TrafficUnlimited);
        }
    }
}

