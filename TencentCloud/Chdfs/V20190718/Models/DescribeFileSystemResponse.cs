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

namespace TencentCloud.Chdfs.V20190718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFileSystemResponse : AbstractModel
    {
        
        /// <summary>
        /// 文件系统
        /// </summary>
        [JsonProperty("FileSystem")]
        public FileSystem FileSystem{ get; set; }

        /// <summary>
        /// 文件系统已使用容量（已弃用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSystemCapacityUsed")]
        public ulong? FileSystemCapacityUsed{ get; set; }

        /// <summary>
        /// 已使用容量（byte），包括标准和归档存储
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CapacityUsed")]
        public ulong? CapacityUsed{ get; set; }

        /// <summary>
        /// 已使用归档存储容量（byte）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArchiveCapacityUsed")]
        public ulong? ArchiveCapacityUsed{ get; set; }

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
            this.SetParamObj(map, prefix + "FileSystem.", this.FileSystem);
            this.SetParamSimple(map, prefix + "FileSystemCapacityUsed", this.FileSystemCapacityUsed);
            this.SetParamSimple(map, prefix + "CapacityUsed", this.CapacityUsed);
            this.SetParamSimple(map, prefix + "ArchiveCapacityUsed", this.ArchiveCapacityUsed);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

