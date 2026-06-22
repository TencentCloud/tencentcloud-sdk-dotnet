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

    public class AdvancedOriginRoutingParameters : AbstractModel
    {
        
        /// <summary>
        /// <p>回源优化方向，取值有：</p><li>MainlandChinaAndGlobalAdaptive：自适应。域名需同时开启「智能加速」后生效，EdgeOne将根据客户端与源站的实际地理位置，自动匹配最优回源优化方向，无需手动指定。例如 www.example.com 开启「高级回源优化」，但「智能加速」关闭或仅部分匹配条件开启时，「高级回源优化」将不生效。</li>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

