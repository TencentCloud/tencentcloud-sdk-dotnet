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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpansionPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>扩容方式。可选值：LAUNCH_TEMPLATE（启动模板）、MULTI_CARD（多卡型混扩）。</p>
        /// </summary>
        [JsonProperty("ExpansionMode")]
        public string ExpansionMode{ get; set; }

        /// <summary>
        /// <p>启动模板 ID 列表，最多 10 个。ExpansionMode=LAUNCH_TEMPLATE 时使用。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LaunchTemplateIds")]
        public string[] LaunchTemplateIds{ get; set; }

        /// <summary>
        /// <p>参考实例 ID，根据已有实例配置生成启动模板。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReferenceInstanceId")]
        public string ReferenceInstanceId{ get; set; }

        /// <summary>
        /// <p>启动模板扩容覆盖配置。ExpansionMode=MULTI_CARD 时使用。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateOverrides")]
        public TemplateOverrides TemplateOverrides{ get; set; }

        /// <summary>
        /// <p>候选规格排序策略。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpansionPriority")]
        public ExpansionPriority ExpansionPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpansionMode", this.ExpansionMode);
            this.SetParamArraySimple(map, prefix + "LaunchTemplateIds.", this.LaunchTemplateIds);
            this.SetParamSimple(map, prefix + "ReferenceInstanceId", this.ReferenceInstanceId);
            this.SetParamObj(map, prefix + "TemplateOverrides.", this.TemplateOverrides);
            this.SetParamObj(map, prefix + "ExpansionPriority.", this.ExpansionPriority);
        }
    }
}

