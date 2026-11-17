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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PasswordComplexity : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启密码复杂度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>大写和小写字符的最小长度</p><p>取值范围：[1, 16]</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MixedCaseCount")]
        public ulong? MixedCaseCount{ get; set; }

        /// <summary>
        /// <p>数字字符的最小长度</p><p>取值范围：[1, 16]</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumberCount")]
        public ulong? NumberCount{ get; set; }

        /// <summary>
        /// <p>特殊字符的最小长度</p><p>取值范围：[1, 16]</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecialCharCount")]
        public ulong? SpecialCharCount{ get; set; }

        /// <summary>
        /// <p>密码的最小长度</p><p>取值范围：[8, 64]</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Length")]
        public ulong? Length{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "MixedCaseCount", this.MixedCaseCount);
            this.SetParamSimple(map, prefix + "NumberCount", this.NumberCount);
            this.SetParamSimple(map, prefix + "SpecialCharCount", this.SpecialCharCount);
            this.SetParamSimple(map, prefix + "Length", this.Length);
        }
    }
}

