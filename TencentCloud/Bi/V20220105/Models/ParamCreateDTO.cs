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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamCreateDTO : AbstractModel
    {
        
        /// <summary>
        /// 参数名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 默认值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 参数类型，string/datetime/number
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// 格式化类型，yyyy-MM-dd HH:mm:ss.SSS（只有时间必填）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FormatRule")]
        public string FormatRule{ get; set; }

        /// <summary>
        /// 复杂类型，格式化的另一种表达，例如YYYY-MM
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplexType")]
        public string ComplexType{ get; set; }

        /// <summary>
        /// 作用域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "FormatRule", this.FormatRule);
            this.SetParamSimple(map, prefix + "ComplexType", this.ComplexType);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
        }
    }
}

