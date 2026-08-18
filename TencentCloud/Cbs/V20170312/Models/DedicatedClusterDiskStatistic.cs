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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterDiskStatistic : AbstractModel
    {
        
        /// <summary>
        /// <p>硬盘介质类型。取值范围：<br>&lt;li&gt;CLOUD_BASIC：表示普通云硬盘<br>&lt;li&gt;CLOUD_PREMIUM：表示高性能云硬盘<br>&lt;li&gt;CLOUD_SSD：表示SSD云硬盘<br>&lt;li&gt;CLOUD_HSSD：表示增强型SSD云硬盘<br>&lt;li&gt;CLOUD_TSSD：表示极速型SSD云硬盘。</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>云硬盘总容量。</p><p>单位：GiB</p>
        /// </summary>
        [JsonProperty("TotalDiskSize")]
        public ulong? TotalDiskSize{ get; set; }

        /// <summary>
        /// <p>已使用的云硬盘容量。</p><p>单位：GiB</p>
        /// </summary>
        [JsonProperty("UsedDiskSize")]
        public ulong? UsedDiskSize{ get; set; }

        /// <summary>
        /// <p>可用的云硬盘容量。</p><p>单位：GiB</p>
        /// </summary>
        [JsonProperty("AvailableDiskSize")]
        public ulong? AvailableDiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "TotalDiskSize", this.TotalDiskSize);
            this.SetParamSimple(map, prefix + "UsedDiskSize", this.UsedDiskSize);
            this.SetParamSimple(map, prefix + "AvailableDiskSize", this.AvailableDiskSize);
        }
    }
}

