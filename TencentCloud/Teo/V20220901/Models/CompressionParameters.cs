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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompressionParameters : AbstractModel
    {
        
        /// <summary>
        /// 智能压缩配置开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 支持的压缩算法列表。当 Switch 为 on 时，此字段必填，否则此字段不生效。取值有：
        /// <li>brotli：brotli 算法；</li>
        /// <li>gzip：gzip 算法。</li>
        /// </summary>
        [JsonProperty("Algorithms")]
        public string[] Algorithms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "Algorithms.", this.Algorithms);
        }
    }
}

