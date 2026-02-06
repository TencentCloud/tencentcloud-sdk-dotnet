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

    public class AICrawlerDetection : AbstractModel
    {
        
        /// <summary>
        /// AI 爬虫检测是否开启。取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// AI 爬虫检测的执行动作，当 Enabled 为 on 时，此字段必填。SecurityAction 的 Name 取值仅支持：
        /// <li>Deny：拦截；</li>
        /// <li>Monitor：观察；</li>
        /// <li>Allow：放行；</li>
        /// <li>Challenge：挑战，其中 ChallengeActionParameters 中的 ChallengeOption 仅支持 JSChallenge 和 ManagedChallenge。</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "Action.", this.Action);
        }
    }
}

