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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWSmartBalanceConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>负载均衡类型</p><p>枚举值：</p><ul><li>LeastRequests： 最少运行请求</li><li>LeastQueued： 最少排队请求</li><li>LeastTTFT： 最少TTFT</li><li>LeastTPOT： 最少TPOT</li></ul>
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
        }
    }
}

