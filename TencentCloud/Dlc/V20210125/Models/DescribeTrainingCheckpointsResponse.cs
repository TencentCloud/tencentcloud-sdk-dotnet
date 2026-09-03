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

    public class DescribeTrainingCheckpointsResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>当前层级文件/目录列表</p>
        /// </summary>
        [JsonProperty("Items")]
        public SharedMountFileItem[] Items{ get; set; }

        /// <summary>
        /// <p>当前挂载路径</p>
        /// </summary>
        [JsonProperty("MountPath")]
        public string MountPath{ get; set; }

        /// <summary>
        /// <p>当前浏览的子路径</p>
        /// </summary>
        [JsonProperty("SubPath")]
        public string SubPath{ get; set; }

        /// <summary>
        /// <p>存储类型：COS / CFS / CFS_TURBO / GOOSEFS</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>存储路径（COS 桶路径或 CFS/GooseFSx 挂载路径）</p>
        /// </summary>
        [JsonProperty("StoragePath")]
        public string StoragePath{ get; set; }

        /// <summary>
        /// <p>错误或提示信息（仅在请求异常时有值）</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>快照时间戳（仅 CFS/GooseFSx 存储时有值）</p>
        /// </summary>
        [JsonProperty("SnapshotTimestamp")]
        public long? SnapshotTimestamp{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "MountPath", this.MountPath);
            this.SetParamSimple(map, prefix + "SubPath", this.SubPath);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StoragePath", this.StoragePath);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "SnapshotTimestamp", this.SnapshotTimestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

