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

    public class ResourcePlan : AbstractModel
    {
        
        /// <summary>
        /// <p>云服务器实例 ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>备份路径，[0,20]</p>
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// <p>包含文件类型，[0,20]</p>
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// <p>排除路径，[0,20]</p>
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// <p>是否排除系统目录</p>
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// <p>是否立即触发全量备份</p>
        /// </summary>
        [JsonProperty("ExecuteImmediately")]
        public bool? ExecuteImmediately{ get; set; }

        /// <summary>
        /// <p>cos备份是否备份ACL</p>
        /// </summary>
        [JsonProperty("EnableObjectAcl")]
        public bool? EnableObjectAcl{ get; set; }

        /// <summary>
        /// <p>cos备份是否备份tag</p>
        /// </summary>
        [JsonProperty("EnableObjectTags")]
        public bool? EnableObjectTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArraySimple(map, prefix + "BackupPaths.", this.BackupPaths);
            this.SetParamArraySimple(map, prefix + "IncludeFileTypes.", this.IncludeFileTypes);
            this.SetParamArraySimple(map, prefix + "ExcludePatterns.", this.ExcludePatterns);
            this.SetParamSimple(map, prefix + "ExcludeSystemDirectories", this.ExcludeSystemDirectories);
            this.SetParamSimple(map, prefix + "ExecuteImmediately", this.ExecuteImmediately);
            this.SetParamSimple(map, prefix + "EnableObjectAcl", this.EnableObjectAcl);
            this.SetParamSimple(map, prefix + "EnableObjectTags", this.EnableObjectTags);
        }
    }
}

