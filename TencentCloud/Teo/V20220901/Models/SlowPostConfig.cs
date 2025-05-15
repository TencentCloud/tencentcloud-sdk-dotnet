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

    public class SlowPostConfig : AbstractModel
    {
        
        /// <summary>
        /// 开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 首包配置。
        /// </summary>
        [JsonProperty("FirstPartConfig")]
        public FirstPartConfig FirstPartConfig{ get; set; }

        /// <summary>
        /// 基础配置。
        /// </summary>
        [JsonProperty("SlowRateConfig")]
        public SlowRateConfig SlowRateConfig{ get; set; }

        /// <summary>
        /// 慢速攻击的处置动作，取值有：
        /// <li>monitor：观察；</li>
        /// <li>drop：拦截。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 本规则的Id。
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "FirstPartConfig.", this.FirstPartConfig);
            this.SetParamObj(map, prefix + "SlowRateConfig.", this.SlowRateConfig);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

