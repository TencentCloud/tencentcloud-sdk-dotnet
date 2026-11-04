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

    public class ModifyFileBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>备份计划ID，此参数必填。</p>
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// <p>备份策略ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        [System.Obsolete]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>计划名称</p>
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// <p>备份路径列表，1~20 个</p>
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// <p>包含文件类型，0~20 个</p>
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// <p>排除文件路径列表，0~20 个</p>
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// <p>是否排除系统目录</p>
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// <p>备份库ID</p>
        /// </summary>
        [JsonProperty("BackupStorageId")]
        [System.Obsolete]
        public string BackupStorageId{ get; set; }

        /// <summary>
        /// <p>计划状态，可选值：normal（正常）、paused（暂停）</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否备份对象ACL（仅COS备份支持）</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// </summary>
        [JsonProperty("EnableObjectAcl")]
        public bool? EnableObjectAcl{ get; set; }

        /// <summary>
        /// <p>是否备份对象标签（仅COS备份支持）</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// </summary>
        [JsonProperty("EnableObjectTags")]
        public bool? EnableObjectTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamArraySimple(map, prefix + "BackupPaths.", this.BackupPaths);
            this.SetParamArraySimple(map, prefix + "IncludeFileTypes.", this.IncludeFileTypes);
            this.SetParamArraySimple(map, prefix + "ExcludePatterns.", this.ExcludePatterns);
            this.SetParamSimple(map, prefix + "ExcludeSystemDirectories", this.ExcludeSystemDirectories);
            this.SetParamSimple(map, prefix + "BackupStorageId", this.BackupStorageId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableObjectAcl", this.EnableObjectAcl);
            this.SetParamSimple(map, prefix + "EnableObjectTags", this.EnableObjectTags);
        }
    }
}

