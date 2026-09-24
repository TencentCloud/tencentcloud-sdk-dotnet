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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudRecordLabelMutation : AbstractModel
    {
        
        /// <summary>
        /// <p>操作类型。SET：创建或移动 Label；DELETE：删除自定义 Label（stable/latest 保留 Label 禁止删除）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// <p>Label 名称，长度 1..63，格式 ^[a-z][a-z0-9._-]{0,62}$，按小写规范化。stable、latest 为系统保留 Label。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>目标 Version ID。SET 时可选：省略表示未绑定（自定义 Label 允许，stable 禁止）；DELETE 时禁止携带。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>变更原因，最大 1024 字符，可选。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

