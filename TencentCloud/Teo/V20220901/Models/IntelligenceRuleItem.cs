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

    public class IntelligenceRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 智能分析标签，取值有：
        /// <li>evil_bot：恶意bot；</li>
        /// <li>suspect_bot：疑似bot；</li>
        /// <li>good_bot：良好bot；</li>
        /// <li>normal：正常请求。</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 触发智能分析标签对应的处置方式，取值有：
        /// <li>drop：拦截；</li>
        /// <li>trans：放行；</li>
        /// <li>alg：Javascript挑战；</li>
        /// <li>captcha：数字验证码；</li>
        /// <li>monitor：观察。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

