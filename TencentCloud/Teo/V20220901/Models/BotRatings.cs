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

    public class BotRatings : AbstractModel
    {
        
        /// <summary>
        /// 恶意 Bot 请求的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Allow：放行；</li><li>Challenge：挑战，其中 ChallengeActionParameters 中的 ChallengeOption 支持 JSChallenge 和 ManagedChallenge。</li>
        /// </summary>
        [JsonProperty("HighRiskBotRequestsAction")]
        public SecurityAction HighRiskBotRequestsAction{ get; set; }

        /// <summary>
        /// 疑似 Bot 请求的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Allow：放行；</li><li>Challenge：挑战，其中 ChallengeActionParameters 中的 ChallengeOption 支持 JSChallenge 和 ManagedChallenge。</li>
        /// </summary>
        [JsonProperty("LikelyBotRequestsAction")]
        public SecurityAction LikelyBotRequestsAction{ get; set; }

        /// <summary>
        /// 友好 Bot 请求的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Allow：放行；</li><li>Challenge：挑战，其中 ChallengeActionParameters 中的 ChallengeOption 支持 JSChallenge 和 ManagedChallenge。</li>
        /// </summary>
        [JsonProperty("VerifiedBotRequestsAction")]
        public SecurityAction VerifiedBotRequestsAction{ get; set; }

        /// <summary>
        /// 正常 Bot 请求的执行动作。 SecurityAction 的 Name 取值支持：<li>Allow：放行。</li>
        /// </summary>
        [JsonProperty("HumanRequestsAction")]
        public SecurityAction HumanRequestsAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HighRiskBotRequestsAction.", this.HighRiskBotRequestsAction);
            this.SetParamObj(map, prefix + "LikelyBotRequestsAction.", this.LikelyBotRequestsAction);
            this.SetParamObj(map, prefix + "VerifiedBotRequestsAction.", this.VerifiedBotRequestsAction);
            this.SetParamObj(map, prefix + "HumanRequestsAction.", this.HumanRequestsAction);
        }
    }
}

