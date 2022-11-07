/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class SecHitRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则ID。
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 规则类型名称。
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// 执行动作（处置方式），取值有：
        /// <li>trans ：通过 ；</li>
        /// <li>alg ：算法挑战 ；</li>
        /// <li>drop ：丢弃 ；</li>
        /// <li>ban ：封禁源ip ；</li>
        /// <li>redirect ：重定向 ；</li>
        /// <li>page ：返回指定页面 ；</li>
        /// <li>monitor ：观察 。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 命中时间，采用unix秒级时间戳。
        /// </summary>
        [JsonProperty("HitTime")]
        public long? HitTime{ get; set; }

        /// <summary>
        /// 请求数。
        /// </summary>
        [JsonProperty("RequestNum")]
        public long? RequestNum{ get; set; }

        /// <summary>
        /// 规则描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 子域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Bot标签，取值有:
        /// <li>evil_bot：恶意Bot；</li>
        /// <li>suspect_bot：疑似Bot；</li>
        /// <li>good_bot：正常Bot；</li>
        /// <li>normal：正常请求；</li>
        /// <li>none：未分类。</li>
        /// </summary>
        [JsonProperty("BotLabel")]
        public string BotLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "HitTime", this.HitTime);
            this.SetParamSimple(map, prefix + "RequestNum", this.RequestNum);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "BotLabel", this.BotLabel);
        }
    }
}

