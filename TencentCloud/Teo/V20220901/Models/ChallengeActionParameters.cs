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

    public class ChallengeActionParameters : AbstractModel
    {
        
        /// <summary>
        /// 安全执行的具体挑战动作。取值有：<li> InterstitialChallenge：插页式挑战；</li><li> InlineChallenge：内嵌式挑战；</li><li> JSChallenge：JavaScript 挑战；</li><li> ManagedChallenge：托管挑战。</li>
        /// </summary>
        [JsonProperty("ChallengeOption")]
        public string ChallengeOption{ get; set; }

        /// <summary>
        /// 重复挑战的时间间隔，当 Name 为 InterstitialChallenge/InlineChallenge 时，该字段必填。默认值为 300s。支持的单位有：<li>s：秒，取值范围1～60；</li><li>m：分，取值范围1～60；</li><li>h：小时，取值范围1～24。</li>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 客户端认证方式 ID 。当 Name 为 InterstitialChallenge/InlineChallenge 时，该字段必填。
        /// </summary>
        [JsonProperty("AttesterId")]
        public string AttesterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChallengeOption", this.ChallengeOption);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "AttesterId", this.AttesterId);
        }
    }
}

