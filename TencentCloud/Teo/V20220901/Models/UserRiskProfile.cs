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

    public class UserRiskProfile : AbstractModel
    {
        
        /// <summary>
        /// <p>高风险请求的最低风险分数。分数大于等于该值时，判定为高风险。</p><p>取值范围：[2, 99]</p><p>默认值：50</p>
        /// </summary>
        [JsonProperty("HighRiskMinScore")]
        public ulong? HighRiskMinScore{ get; set; }

        /// <summary>
        /// <p>高风险请求的处置方式。SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Redirect：重定向；</li><li>Challenge：挑战。</li>默认值：Monitor</p>
        /// </summary>
        [JsonProperty("HighRiskRequestAction")]
        public SecurityAction HighRiskRequestAction{ get; set; }

        /// <summary>
        /// <p>中风险请求的最低风险分数。分数大于等于该值且小于 HighRiskMinScore 时，判定为中风险；低于该值时，判定为低风险。</p><p>取值范围：[1, 98]</p><p>默认值：15</p>
        /// </summary>
        [JsonProperty("MediumRiskMinScore")]
        public ulong? MediumRiskMinScore{ get; set; }

        /// <summary>
        /// <p>中风险请求的处置方式。SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Redirect：重定向；</li><li>Challenge：挑战。</li>默认值：Monitor</p>
        /// </summary>
        [JsonProperty("MediumRiskRequestAction")]
        public SecurityAction MediumRiskRequestAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighRiskMinScore", this.HighRiskMinScore);
            this.SetParamObj(map, prefix + "HighRiskRequestAction.", this.HighRiskRequestAction);
            this.SetParamSimple(map, prefix + "MediumRiskMinScore", this.MediumRiskMinScore);
            this.SetParamObj(map, prefix + "MediumRiskRequestAction.", this.MediumRiskRequestAction);
        }
    }
}

