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

    public class BotUserRule : AbstractModel
    {
        
        /// <summary>
        /// 规则名，只能以英文字符，数字，下划线组合，且不能以下划线开头。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 处置动作，取值有：
        /// <li>drop：拦截；</li>
        /// <li>monitor：观察；</li>
        /// <li>trans：放行；</li>
        /// <li>redirect：重定向；</li>
        /// <li>page：指定页面；</li>
        /// <li>alg：JavaScript 挑战；</li>
        /// <li>captcha：托管挑战；</li>
        /// <li>random：随机处置；</li>
        /// <li>silence：静默；</li>
        /// <li>shortdelay：短时响应；</li>
        /// <li>longdelay：长时响应。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 规则状态，取值有：
        /// <li>on：生效；</li>
        /// <li>off：不生效。</li>默认 on 生效。
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// 规则详情。
        /// </summary>
        [JsonProperty("AclConditions")]
        public AclCondition[] AclConditions{ get; set; }

        /// <summary>
        /// 规则权重，取值范围0-100。
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// 规则 Id。仅出参使用。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 随机处置的处置方式及占比，非随机处置可不填暂不支持。
        /// </summary>
        [JsonProperty("ExtendActions")]
        public BotExtendAction[] ExtendActions{ get; set; }

        /// <summary>
        /// 过滤词，取值有：
        /// <li>sip：客户端 ip。</li>
        /// 默认为空字符串。
        /// </summary>
        [JsonProperty("FreqFields")]
        public string[] FreqFields{ get; set; }

        /// <summary>
        /// 更新时间。仅出参使用。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 统计范围。取值有：
        /// <li>source_to_eo：（响应）源站到 EdgeOne；</li>
        /// <li>client_to_eo：（请求）客户端到 EdgeOne。</li>
        /// 默认为 source_to_eo。
        /// </summary>
        [JsonProperty("FreqScope")]
        public string[] FreqScope{ get; set; }

        /// <summary>
        /// 自定义返回页面的名称。Action 是 page 时必填，且不能为空。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 自定义响应 Id。该 Id 可通过查询自定义错误页列表接口获取。默认值为default，使用系统默认页面。Action 是 page 时必填，且不能为空。	
        /// </summary>
        [JsonProperty("CustomResponseId")]
        public string CustomResponseId{ get; set; }

        /// <summary>
        /// 自定义返回页面的响应码。Action 是 page 时必填，且不能为空，取值: 100~600，不支持 3xx 响应码。默认值：567。
        /// </summary>
        [JsonProperty("ResponseCode")]
        public long? ResponseCode{ get; set; }

        /// <summary>
        /// 重定向时候的地址。Action 是 redirect 时必填，且不能为空。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamArrayObj(map, prefix + "AclConditions.", this.AclConditions);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArrayObj(map, prefix + "ExtendActions.", this.ExtendActions);
            this.SetParamArraySimple(map, prefix + "FreqFields.", this.FreqFields);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "FreqScope.", this.FreqScope);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CustomResponseId", this.CustomResponseId);
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
        }
    }
}

