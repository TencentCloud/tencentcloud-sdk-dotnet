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

    public class ManagedRuleAction : AbstractModel
    {
        
        /// <summary>
        /// 托管规则组下的具体项，用于改写此单条规则项配置的内容，具体参考产品文档。	
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// RuleId 中指定托管规则项的处置动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，响应拦截页面；</li><li>Monitor：观察，不处理请求记录安全事件到日志中；</li><li>Disabled：未启用，不扫描请求跳过该规则。</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamObj(map, prefix + "Action.", this.Action);
        }
    }
}

