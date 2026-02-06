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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PasswordSetting : AbstractModel
    {
        
        /// <summary>
        /// 密码最小长度，8-20，默认8。
        /// </summary>
        [JsonProperty("MinLength")]
        public ulong? MinLength{ get; set; }

        /// <summary>
        /// 密码复杂度，0不限制，1包含字母和数字，2至少包括大写字母、小写字母、数字、特殊符号，默认2。
        /// </summary>
        [JsonProperty("Complexity")]
        public ulong? Complexity{ get; set; }

        /// <summary>
        /// 密码有效期，0不限制，30天，90天，180天。
        /// </summary>
        [JsonProperty("ValidTerm")]
        public ulong? ValidTerm{ get; set; }

        /// <summary>
        /// 检查最近n次密码设置是否存在相同密码，2-10，默认5。
        /// </summary>
        [JsonProperty("CheckHistory")]
        public ulong? CheckHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
            this.SetParamSimple(map, prefix + "Complexity", this.Complexity);
            this.SetParamSimple(map, prefix + "ValidTerm", this.ValidTerm);
            this.SetParamSimple(map, prefix + "CheckHistory", this.CheckHistory);
        }
    }
}

