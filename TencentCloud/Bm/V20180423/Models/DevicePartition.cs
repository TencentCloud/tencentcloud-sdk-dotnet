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

    public class DevicePartition : AbstractModel
    {
        
        /// <summary>
        /// 系统盘大小
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public ulong? SystemDiskSize{ get; set; }

        /// <summary>
        /// 数据盘大小
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public ulong? DataDiskSize{ get; set; }

        /// <summary>
        /// 是否兼容Uefi
        /// </summary>
        [JsonProperty("SysIsUefiType")]
        public bool? SysIsUefiType{ get; set; }

        /// <summary>
        /// root分区大小
        /// </summary>
        [JsonProperty("SysRootSpace")]
        public ulong? SysRootSpace{ get; set; }

        /// <summary>
        /// Swaporuefi分区大小
        /// </summary>
        [JsonProperty("SysSwaporuefiSpace")]
        public ulong? SysSwaporuefiSpace{ get; set; }

        /// <summary>
        /// Usrlocal分区大小
        /// </summary>
        [JsonProperty("SysUsrlocalSpace")]
        public ulong? SysUsrlocalSpace{ get; set; }

        /// <summary>
        /// data分区大小
        /// </summary>
        [JsonProperty("SysDataSpace")]
        public ulong? SysDataSpace{ get; set; }

        /// <summary>
        /// 硬盘大小详情
        /// </summary>
        [JsonProperty("DeviceDiskSizeInfoSet")]
        public DeviceDiskSizeInfo[] DeviceDiskSizeInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamSimple(map, prefix + "SysIsUefiType", this.SysIsUefiType);
            this.SetParamSimple(map, prefix + "SysRootSpace", this.SysRootSpace);
            this.SetParamSimple(map, prefix + "SysSwaporuefiSpace", this.SysSwaporuefiSpace);
            this.SetParamSimple(map, prefix + "SysUsrlocalSpace", this.SysUsrlocalSpace);
            this.SetParamSimple(map, prefix + "SysDataSpace", this.SysDataSpace);
            this.SetParamArrayObj(map, prefix + "DeviceDiskSizeInfoSet.", this.DeviceDiskSizeInfoSet);
        }
    }
}

