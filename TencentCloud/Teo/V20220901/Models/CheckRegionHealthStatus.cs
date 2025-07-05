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

    public class CheckRegionHealthStatus : AbstractModel
    {
        
        /// <summary>
        /// 健康检查区域，ISO-3166-1 两位字母代码。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 单健康检查区域下探测源站的健康状态，取值有：
        /// <li>Healthy：健康；</li>
        /// <li>Unhealthy：不健康；</li>
        /// <li> Undetected：未探测到数据。</li>说明：单健康检查区域下所有源站为健康，则状态为健康，否则为不健康。
        /// </summary>
        [JsonProperty("Healthy")]
        public string Healthy{ get; set; }

        /// <summary>
        /// 源站健康状态。
        /// </summary>
        [JsonProperty("OriginHealthStatus")]
        public OriginHealthStatus[] OriginHealthStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamArrayObj(map, prefix + "OriginHealthStatus.", this.OriginHealthStatus);
        }
    }
}

