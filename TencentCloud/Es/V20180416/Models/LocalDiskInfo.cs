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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LocalDiskInfo : AbstractModel
    {
        
        /// <summary>
        /// 本地盘类型<li>LOCAL_SATA：大数据型</li><li>NVME_SSD：高IO型</li>
        /// </summary>
        [JsonProperty("LocalDiskType")]
        public string LocalDiskType{ get; set; }

        /// <summary>
        /// 本地盘单盘大小
        /// </summary>
        [JsonProperty("LocalDiskSize")]
        public ulong? LocalDiskSize{ get; set; }

        /// <summary>
        /// 本地盘块数
        /// </summary>
        [JsonProperty("LocalDiskCount")]
        public ulong? LocalDiskCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalDiskType", this.LocalDiskType);
            this.SetParamSimple(map, prefix + "LocalDiskSize", this.LocalDiskSize);
            this.SetParamSimple(map, prefix + "LocalDiskCount", this.LocalDiskCount);
        }
    }
}

