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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Relabeling : AbstractModel
    {
        
        /// <summary>
        /// 基于正则表达式匹配执行的动作。
        /// - replace: Label替换, 必填: SourceLabels, Separator, Regex, TargetLabel, Replacement
        /// - labeldrop: 丢弃Label, 必填: Regex
        /// - labelkeep: 保留Label, 必填: Regex
        /// - lowercase: 小写化, 必填: SourceLabels, Separator, TargetLabel
        /// - uppercase: 大写化, 必填: SourceLabels, Separator, TargetLabel
        /// - dropequal: 丢弃指标-完全匹配, 必填: SourceLabels, Separator, TargetLabel
        /// - keepequal: 保留指标-完全匹配, 必填: SourceLabels, Separator, TargetLabel
        /// - drop: 丢弃指标-正则匹配, 必填: SourceLabels, Separator, Regex
        /// - keep: 保留指标-正则匹配, 必填: SourceLabels, Separator, Regex
        /// - hashmod:哈希取模, 必填: SourceLabels, Separator, TargetLabel, Modulus
        /// - labelmap:Label映射, 必填: Regex, Replacement
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 原始label
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceLabels")]
        public string[] SourceLabels{ get; set; }

        /// <summary>
        /// 原始label连接符。 必填时不能为空串， 长度不能超过256
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Separator")]
        public string Separator{ get; set; }

        /// <summary>
        /// 目标label。必填时不能为空串，校验格式：`^[a-zA-Z_][a-zA-Z0-9_]*$` ， 长度不能超过256
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetLabel")]
        public string TargetLabel{ get; set; }

        /// <summary>
        /// 替换值。如果正则表达式匹配，则对其执行替换操作。
        /// - 必填时不能为空串，长度不能超过256
        /// - 当action为LabelMap时， Replacement 校验格式：`^(?:(?:[a-zA-Z_]|\$(?:\{\w+\}|\w+))+\w*)+$`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replacement")]
        public string Replacement{ get; set; }

        /// <summary>
        /// 正则表达式。提取与之匹配值。必填时不能为空串，校验必须是一个合法的 RE2 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regex")]
        public string Regex{ get; set; }

        /// <summary>
        /// 获取源标签值的哈希值。必填时不能为空,不能为0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Modulus")]
        public ulong? Modulus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArraySimple(map, prefix + "SourceLabels.", this.SourceLabels);
            this.SetParamSimple(map, prefix + "Separator", this.Separator);
            this.SetParamSimple(map, prefix + "TargetLabel", this.TargetLabel);
            this.SetParamSimple(map, prefix + "Replacement", this.Replacement);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Modulus", this.Modulus);
        }
    }
}

