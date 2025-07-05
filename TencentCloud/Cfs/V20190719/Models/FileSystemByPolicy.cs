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

    public class FileSystemByPolicy : AbstractModel
    {
        
        /// <summary>
        /// 文件系统名称
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// 文件系统ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 文件系统大小，单位Byte
        /// </summary>
        [JsonProperty("SizeByte")]
        public ulong? SizeByte{ get; set; }

        /// <summary>
        /// 存储类型，HP：通用性能型；SD：通用标准型；TP:turbo性能型；TB：turbo标准型；THP：吞吐型
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 快照总大小，单位GiB
        /// </summary>
        [JsonProperty("TotalSnapshotSize")]
        public ulong? TotalSnapshotSize{ get; set; }

        /// <summary>
        /// 文件系统创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 文件系统所在区ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "SizeByte", this.SizeByte);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "TotalSnapshotSize", this.TotalSnapshotSize);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
        }
    }
}

