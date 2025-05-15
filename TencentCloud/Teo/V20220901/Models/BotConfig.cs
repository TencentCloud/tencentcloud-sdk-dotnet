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

    public class BotConfig : AbstractModel
    {
        
        /// <summary>
        /// bot开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 通用详细基础规则。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("BotManagedRule")]
        public BotManagedRule BotManagedRule{ get; set; }

        /// <summary>
        /// 用户画像规则。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("BotPortraitRule")]
        public BotPortraitRule BotPortraitRule{ get; set; }

        /// <summary>
        /// Bot智能分析。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("IntelligenceRule")]
        public IntelligenceRule IntelligenceRule{ get; set; }

        /// <summary>
        /// Bot自定义规则。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("BotUserRules")]
        public BotUserRule[] BotUserRules{ get; set; }

        /// <summary>
        /// Bot主动特征识别规则。
        /// </summary>
        [JsonProperty("AlgDetectRule")]
        public AlgDetectRule[] AlgDetectRule{ get; set; }

        /// <summary>
        /// Bot托管定制策略，入参可不填，仅出参使用。
        /// </summary>
        [JsonProperty("Customizes")]
        public BotUserRule[] Customizes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "BotManagedRule.", this.BotManagedRule);
            this.SetParamObj(map, prefix + "BotPortraitRule.", this.BotPortraitRule);
            this.SetParamObj(map, prefix + "IntelligenceRule.", this.IntelligenceRule);
            this.SetParamArrayObj(map, prefix + "BotUserRules.", this.BotUserRules);
            this.SetParamArrayObj(map, prefix + "AlgDetectRule.", this.AlgDetectRule);
            this.SetParamArrayObj(map, prefix + "Customizes.", this.Customizes);
        }
    }
}

