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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStorageDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前媒体总量。
        /// </summary>
        [JsonProperty("MediaCount")]
        public ulong? MediaCount{ get; set; }

        /// <summary>
        /// 当前总存储量，单位是字节。
        /// </summary>
        [JsonProperty("TotalStorage")]
        public ulong? TotalStorage{ get; set; }

        /// <summary>
        /// 当前标准存储量，单位是字节。
        /// </summary>
        [JsonProperty("StandardStorage")]
        public ulong? StandardStorage{ get; set; }

        /// <summary>
        /// 当前低频存储量，单位是字节。
        /// </summary>
        [JsonProperty("InfrequentStorage")]
        public ulong? InfrequentStorage{ get; set; }

        /// <summary>
        /// 当前归档存储量，单位是字节。
        /// </summary>
        [JsonProperty("ArchiveStorage")]
        public ulong? ArchiveStorage{ get; set; }

        /// <summary>
        /// 当前深度归档存储量，单位是字节。
        /// </summary>
        [JsonProperty("DeepArchiveStorage")]
        public ulong? DeepArchiveStorage{ get; set; }

        /// <summary>
        /// 各计费区域的存储用量。
        /// </summary>
        [JsonProperty("StorageStat")]
        public StorageStatData[] StorageStat{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaCount", this.MediaCount);
            this.SetParamSimple(map, prefix + "TotalStorage", this.TotalStorage);
            this.SetParamSimple(map, prefix + "StandardStorage", this.StandardStorage);
            this.SetParamSimple(map, prefix + "InfrequentStorage", this.InfrequentStorage);
            this.SetParamSimple(map, prefix + "ArchiveStorage", this.ArchiveStorage);
            this.SetParamSimple(map, prefix + "DeepArchiveStorage", this.DeepArchiveStorage);
            this.SetParamArrayObj(map, prefix + "StorageStat.", this.StorageStat);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

