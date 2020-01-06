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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceClassPartitionInfo : AbstractModel
    {
        
        /// <summary>
        /// RAID类型ID
        /// </summary>
        [JsonProperty("RaidId")]
        public ulong? RaidId{ get; set; }

        /// <summary>
        /// RAID名称
        /// </summary>
        [JsonProperty("Raid")]
        public string Raid{ get; set; }

        /// <summary>
        /// RAID名称（前台展示用）
        /// </summary>
        [JsonProperty("RaidDisplay")]
        public string RaidDisplay{ get; set; }

        /// <summary>
        /// 系统盘总大小（单位GiB）
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public ulong? SystemDiskSize{ get; set; }

        /// <summary>
        /// 系统盘/分区默认大小（单位GiB）
        /// </summary>
        [JsonProperty("SysRootSpace")]
        public ulong? SysRootSpace{ get; set; }

        /// <summary>
        /// 系统盘swap分区默认大小（单位GiB）
        /// </summary>
        [JsonProperty("SysSwaporuefiSpace")]
        public ulong? SysSwaporuefiSpace{ get; set; }

        /// <summary>
        /// 系统盘/usr/local分区默认大小（单位GiB）
        /// </summary>
        [JsonProperty("SysUsrlocalSpace")]
        public ulong? SysUsrlocalSpace{ get; set; }

        /// <summary>
        /// 系统盘/data分区默认大小（单位GiB）
        /// </summary>
        [JsonProperty("SysDataSpace")]
        public ulong? SysDataSpace{ get; set; }

        /// <summary>
        /// 设备是否是uefi启动方式。0:legacy启动; 1:uefi启动
        /// </summary>
        [JsonProperty("SysIsUefiType")]
        public ulong? SysIsUefiType{ get; set; }

        /// <summary>
        /// 数据盘总大小
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public ulong? DataDiskSize{ get; set; }

        /// <summary>
        /// 硬盘列表
        /// </summary>
        [JsonProperty("DeviceDiskSizeInfoSet")]
        public DeviceDiskSizeInfo[] DeviceDiskSizeInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RaidId", this.RaidId);
            this.SetParamSimple(map, prefix + "Raid", this.Raid);
            this.SetParamSimple(map, prefix + "RaidDisplay", this.RaidDisplay);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "SysRootSpace", this.SysRootSpace);
            this.SetParamSimple(map, prefix + "SysSwaporuefiSpace", this.SysSwaporuefiSpace);
            this.SetParamSimple(map, prefix + "SysUsrlocalSpace", this.SysUsrlocalSpace);
            this.SetParamSimple(map, prefix + "SysDataSpace", this.SysDataSpace);
            this.SetParamSimple(map, prefix + "SysIsUefiType", this.SysIsUefiType);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamArrayObj(map, prefix + "DeviceDiskSizeInfoSet.", this.DeviceDiskSizeInfoSet);
        }
    }
}

