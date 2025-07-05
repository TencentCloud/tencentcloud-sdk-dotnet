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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskSpecPlus : AbstractModel
    {
        
        /// <summary>
        /// 磁盘个数
        /// </summary>
        [JsonProperty("DiskCount")]
        public long? DiskCount{ get; set; }

        /// <summary>
        /// 磁盘最大值
        /// </summary>
        [JsonProperty("MaxDiskSize")]
        public long? MaxDiskSize{ get; set; }

        /// <summary>
        /// 磁盘最小值
        /// </summary>
        [JsonProperty("MinDiskSize")]
        public long? MinDiskSize{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 磁盘类型详情
        /// </summary>
        [JsonProperty("DiskDesc")]
        public string DiskDesc{ get; set; }

        /// <summary>
        /// 机型类型
        /// </summary>
        [JsonProperty("CvmClass")]
        public string CvmClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "MaxDiskSize", this.MaxDiskSize);
            this.SetParamSimple(map, prefix + "MinDiskSize", this.MinDiskSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskDesc", this.DiskDesc);
            this.SetParamSimple(map, prefix + "CvmClass", this.CvmClass);
        }
    }
}

