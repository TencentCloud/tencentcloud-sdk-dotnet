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

    public class CreateFileRestoreTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待恢复的备份ID</p>
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// <p>目标实例ID</p>
        /// </summary>
        [JsonProperty("TargetResourceId")]
        public string TargetResourceId{ get; set; }

        /// <summary>
        /// <ol><li>恢复路径列表（1-500项）；2. CVM和CFS文件备份不传则使用备份点中所有路径，COS备份该参数必填；3. 必须是绝对路径；</li></ol>
        /// </summary>
        [JsonProperty("RestorePaths")]
        public string[] RestorePaths{ get; set; }

        /// <summary>
        /// <p>目标位置</p><ol><li>不传则恢复到原始路径</li><li>cos恢复时不能以【/】开头</li></ol>
        /// </summary>
        [JsonProperty("TargetLocation")]
        public string TargetLocation{ get; set; }

        /// <summary>
        /// <p>冲突处理策略：skip-跳过/&quot;         &quot;overwrite-覆盖/newer-保留较新的版本/&quot;         &quot;if_changed-内容变化时覆盖，默认overwrite</p>
        /// </summary>
        [JsonProperty("ConflictStrategy")]
        public string ConflictStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "TargetResourceId", this.TargetResourceId);
            this.SetParamArraySimple(map, prefix + "RestorePaths.", this.RestorePaths);
            this.SetParamSimple(map, prefix + "TargetLocation", this.TargetLocation);
            this.SetParamSimple(map, prefix + "ConflictStrategy", this.ConflictStrategy);
        }
    }
}

