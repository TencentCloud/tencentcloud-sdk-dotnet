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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFileBackupRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源ID列表
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 备份路径列表，1~20 个
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// 包含文件类型，0~20 个
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// 排除文件路径列表，0~20 个
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// 是否排除系统目录
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// 备份库ID
        /// </summary>
        [JsonProperty("BackupStorageId")]
        public string BackupStorageId{ get; set; }

        /// <summary>
        /// 备份到期时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamArraySimple(map, prefix + "BackupPaths.", this.BackupPaths);
            this.SetParamArraySimple(map, prefix + "IncludeFileTypes.", this.IncludeFileTypes);
            this.SetParamArraySimple(map, prefix + "ExcludePatterns.", this.ExcludePatterns);
            this.SetParamSimple(map, prefix + "ExcludeSystemDirectories", this.ExcludeSystemDirectories);
            this.SetParamSimple(map, prefix + "BackupStorageId", this.BackupStorageId);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
        }
    }
}

