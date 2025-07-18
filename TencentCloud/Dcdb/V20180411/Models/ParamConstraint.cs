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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamConstraint : AbstractModel
    {
        
        /// <summary>
        /// 约束类型,如枚举enum，区间section
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 约束类型为enum时的可选值列表
        /// </summary>
        [JsonProperty("Enum")]
        public string Enum{ get; set; }

        /// <summary>
        /// 约束类型为section时的范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Range")]
        public ConstraintRange Range{ get; set; }

        /// <summary>
        /// 约束类型为string时的可选值列表
        /// </summary>
        [JsonProperty("String")]
        public string String{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Enum", this.Enum);
            this.SetParamObj(map, prefix + "Range.", this.Range);
            this.SetParamSimple(map, prefix + "String", this.String);
        }
    }
}

