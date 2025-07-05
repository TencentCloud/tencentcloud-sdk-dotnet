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

    public class UserQuota : AbstractModel
    {
        
        /// <summary>
        /// 指定配额类型，包括Uid、Gid、Dir
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// UID/GID信息
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 容量硬限制，单位GiB
        /// </summary>
        [JsonProperty("CapacityHardLimit")]
        public ulong? CapacityHardLimit{ get; set; }

        /// <summary>
        /// 文件硬限制，单位个
        /// </summary>
        [JsonProperty("FileHardLimit")]
        public ulong? FileHardLimit{ get; set; }

        /// <summary>
        /// 文件系统ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 容量使用，单位GiB
        /// </summary>
        [JsonProperty("CapacityUsed")]
        public ulong? CapacityUsed{ get; set; }

        /// <summary>
        /// 文件使用个数，单位个
        /// </summary>
        [JsonProperty("FileUsed")]
        public ulong? FileUsed{ get; set; }

        /// <summary>
        /// 目录配额的目录绝对路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DirectoryPath")]
        public string DirectoryPath{ get; set; }

        /// <summary>
        /// 配置规则状态，inavailable---配置中，available --已生效，deleting--删除中，deleted 已删除，failed--配置失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "CapacityHardLimit", this.CapacityHardLimit);
            this.SetParamSimple(map, prefix + "FileHardLimit", this.FileHardLimit);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "CapacityUsed", this.CapacityUsed);
            this.SetParamSimple(map, prefix + "FileUsed", this.FileUsed);
            this.SetParamSimple(map, prefix + "DirectoryPath", this.DirectoryPath);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

