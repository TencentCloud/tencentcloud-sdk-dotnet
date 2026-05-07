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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagedAIModelChargingInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>计费类型</p><p>枚举值：</p><ul><li>Uniform： 固定计费</li><li>Tiered： 分段计费</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>分组名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>输入 Token 价格</p>
        /// </summary>
        [JsonProperty("InputPrice")]
        public string InputPrice{ get; set; }

        /// <summary>
        /// <p>输出 Token 价格</p>
        /// </summary>
        [JsonProperty("OutputPrice")]
        public string OutputPrice{ get; set; }

        /// <summary>
        /// <p>命中缓存价格</p>
        /// </summary>
        [JsonProperty("CachePrice")]
        public string CachePrice{ get; set; }

        /// <summary>
        /// <p>计费单位</p>
        /// </summary>
        [JsonProperty("InputOutputUnit")]
        public string InputOutputUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InputPrice", this.InputPrice);
            this.SetParamSimple(map, prefix + "OutputPrice", this.OutputPrice);
            this.SetParamSimple(map, prefix + "CachePrice", this.CachePrice);
            this.SetParamSimple(map, prefix + "InputOutputUnit", this.InputOutputUnit);
        }
    }
}

