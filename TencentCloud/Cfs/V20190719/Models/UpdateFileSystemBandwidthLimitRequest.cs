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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFileSystemBandwidthLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统 ID,可通过[DescribeCfsFileSystems](https://cloud.tencent.com/document/api/582/38170)接口获取
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 文件系统带宽，仅吞吐型可填。单位MiB/s，最小为1GiB/s，最大200GiB/s。
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public long? BandwidthLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
        }
    }
}

