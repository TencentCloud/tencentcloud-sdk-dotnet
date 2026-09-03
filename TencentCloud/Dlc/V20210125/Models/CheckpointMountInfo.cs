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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckpointMountInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>存储类型：COS / CFS / CFS_TURBO / GOOSEFS</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>容器内挂载路径</p>
        /// </summary>
        [JsonProperty("MountPath")]
        public string MountPath{ get; set; }

        /// <summary>
        /// <p>COS key 前缀 或 CFS/GooseFS 子路径</p>
        /// </summary>
        [JsonProperty("VolumeSubPath")]
        public string VolumeSubPath{ get; set; }

        /// <summary>
        /// <p>实际访问的 COS bucket</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>COS region</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>是否平台托管桶（影响凭证选择）</p>
        /// </summary>
        [JsonProperty("PlatformManaged")]
        public bool? PlatformManaged{ get; set; }

        /// <summary>
        /// <p>快照在平台 COS 桶中的 key（仅 CFS/GooseFS 有值）</p>
        /// </summary>
        [JsonProperty("SnapshotKey")]
        public string SnapshotKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "MountPath", this.MountPath);
            this.SetParamSimple(map, prefix + "VolumeSubPath", this.VolumeSubPath);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PlatformManaged", this.PlatformManaged);
            this.SetParamSimple(map, prefix + "SnapshotKey", this.SnapshotKey);
        }
    }
}

