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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PasswordPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>是否启用实例级密码复杂度策略。</p><ul><li>true：开启。所有密码变动（创建/重置）必须通过下方定义的复杂度校验。</li><li>false：关闭。不进行复杂度过滤。</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>大小写字母最小字符数。</p><ul><li>取值范围：[1,16]。</li><li>默认值：1。</li></ul>
        /// </summary>
        [JsonProperty("MinLetterCount")]
        public long? MinLetterCount{ get; set; }

        /// <summary>
        /// <p>数字字符的最小字符数。</p><ul><li>取值范围：[1,16]。</li><li>默认值：1。</li></ul>
        /// </summary>
        [JsonProperty("MinDigitCount")]
        public long? MinDigitCount{ get; set; }

        /// <summary>
        /// <p>特殊字符最小字符数。</p><ul><li>取值范围：[1,16]。</li><li>默认值：1。</li></ul>
        /// </summary>
        [JsonProperty("MinSpecialCount")]
        public long? MinSpecialCount{ get; set; }

        /// <summary>
        /// <p>密码的最小总长度（字符数）。</p><ul><li>取值范围：[8, 64]。</li><li>默认值：8。</li><li>约束限制：密码的最小总长度必须大于或等于 MinLetterCount 、MinDigitCount 与 MinSpecialCount 三个参数之和。</li></ul>
        /// </summary>
        [JsonProperty("MinLength")]
        public long? MinLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "MinLetterCount", this.MinLetterCount);
            this.SetParamSimple(map, prefix + "MinDigitCount", this.MinDigitCount);
            this.SetParamSimple(map, prefix + "MinSpecialCount", this.MinSpecialCount);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
        }
    }
}

