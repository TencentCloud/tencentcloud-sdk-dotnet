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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoutingDestinationRuleLabel : AbstractModel
    {
        
        /// <summary>
        /// 标签键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelKey")]
        public string LabelKey{ get; set; }

        /// <summary>
        /// 标签值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }

        /// <summary>
        /// 表达式类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelType")]
        public string LabelType{ get; set; }

        /// <summary>
        /// 值类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelValueType")]
        public string LabelValueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LabelKey", this.LabelKey);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
            this.SetParamSimple(map, prefix + "LabelType", this.LabelType);
            this.SetParamSimple(map, prefix + "LabelValueType", this.LabelValueType);
        }
    }
}

