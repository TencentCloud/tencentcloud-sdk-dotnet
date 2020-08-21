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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Bundle : AbstractModel
    {
        
        /// <summary>
        /// 套餐 ID。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 内存大小，单位 GB。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 系统盘类型。
        /// 取值范围： 
        /// <li> LOCAL_BASIC：本地硬盘</li><li> LOCAL_SSD：本地 SSD 硬盘</li><li> CLOUD_BASIC：普通云硬盘</li><li> CLOUD_SSD：SSD 云硬盘</li><li> CLOUD_PREMIUM：高性能云硬盘</li>
        /// </summary>
        [JsonProperty("SystemDiskType")]
        public string SystemDiskType{ get; set; }

        /// <summary>
        /// 系统盘大小。
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public long? SystemDiskSize{ get; set; }

        /// <summary>
        /// 每月网络流量，单位 Gb。
        /// </summary>
        [JsonProperty("MonthlyTraffic")]
        public long? MonthlyTraffic{ get; set; }

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
        /// 套餐售卖状态,取值:‘AVAILABLE’(可用) , ‘SOLD_OUT’(售罄)
        /// </summary>
        [JsonProperty("BundleSalesState")]
        public string BundleSalesState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "SystemDiskType", this.SystemDiskType);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "MonthlyTraffic", this.MonthlyTraffic);
            this.SetParamSimple(map, prefix + "SupportLinuxUnixPlatform", this.SupportLinuxUnixPlatform);
            this.SetParamSimple(map, prefix + "SupportWindowsPlatform", this.SupportWindowsPlatform);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "BundleSalesState", this.BundleSalesState);
        }
    }
}

