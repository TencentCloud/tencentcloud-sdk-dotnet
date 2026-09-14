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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KBCapacity : AbstractModel
    {
        
        /// <summary>
        /// <p>最大字符数</p>
        /// </summary>
        [JsonProperty("MaxCharSize")]
        public string MaxCharSize{ get; set; }

        /// <summary>
        /// <p>超量字符数</p>
        /// </summary>
        [JsonProperty("OverCharSize")]
        public string OverCharSize{ get; set; }

        /// <summary>
        /// <p>已用字符数</p>
        /// </summary>
        [JsonProperty("UsedCharSize")]
        public string UsedCharSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxCharSize", this.MaxCharSize);
            this.SetParamSimple(map, prefix + "OverCharSize", this.OverCharSize);
            this.SetParamSimple(map, prefix + "UsedCharSize", this.UsedCharSize);
        }
    }
}

