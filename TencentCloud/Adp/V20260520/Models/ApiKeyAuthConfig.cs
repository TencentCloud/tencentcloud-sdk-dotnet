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

    public class ApiKeyAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>密钥位置 HEADER/QUERY</p><p>枚举值:<br>| uint | 描述 |<br>| --- | --- |<br>| 0 | Header鉴权 |<br>| 1 | Query鉴权 |</p>
        /// </summary>
        [JsonProperty("KeyLocation")]
        public long? KeyLocation{ get; set; }

        /// <summary>
        /// <p>密钥参数名</p>
        /// </summary>
        [JsonProperty("KeyParamName")]
        public string KeyParamName{ get; set; }

        /// <summary>
        /// <p>密钥参数值</p>
        /// </summary>
        [JsonProperty("KeyParamValue")]
        public string KeyParamValue{ get; set; }

        /// <summary>
        /// <p>密钥值用途，未指定按允许工具调用处理</p><p>枚举值：</p><ul><li>1： 允许用于工具调用</li><li>2： 仅用于连接测试和获取工具列表</li></ul>
        /// </summary>
        [JsonProperty("KeyValueUsage")]
        public long? KeyValueUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyLocation", this.KeyLocation);
            this.SetParamSimple(map, prefix + "KeyParamName", this.KeyParamName);
            this.SetParamSimple(map, prefix + "KeyParamValue", this.KeyParamValue);
            this.SetParamSimple(map, prefix + "KeyValueUsage", this.KeyValueUsage);
        }
    }
}

