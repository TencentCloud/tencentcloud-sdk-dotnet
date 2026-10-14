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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLLMContentRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>优先级</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>规则开关</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>检测范围，1：入向，2：出向，3：入向和出向</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public ulong? CheckType{ get; set; }

        /// <summary>
        /// <p>检测内容匹配</p>
        /// </summary>
        [JsonProperty("RuleItem")]
        public RuleItem[] RuleItem{ get; set; }

        /// <summary>
        /// <p>匹配条件</p>
        /// </summary>
        [JsonProperty("Options")]
        public LLMOptionsItem[] Options{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>动作，观察monitor，拦截intercept</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>响应提示内容</p>
        /// </summary>
        [JsonProperty("ResponseText")]
        public string ResponseText{ get; set; }

        /// <summary>
        /// <p>规则需要启用的SessionID</p>
        /// </summary>
        [JsonProperty("SessionApplied")]
        public string[] SessionApplied{ get; set; }

        /// <summary>
        /// <p>规则ID，新增时填0</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>拦截页面id</p>
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// <p>检测内容and or表达式,默认为and</p>
        /// </summary>
        [JsonProperty("ContentLogicalOp")]
        public string ContentLogicalOp{ get; set; }

        /// <summary>
        /// <p>实例id，必填项</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>代答类型：1-内置可信模型安全代答，2-自定义代答（ActionType=reply时生效</p><p>枚举值：</p><ul><li>1： 内置可信模型安全代答</li><li>2： 自定义代答ActionType=reply时生效</li></ul>
        /// </summary>
        [JsonProperty("ReplyType")]
        public ulong? ReplyType{ get; set; }

        /// <summary>
        /// <p>自定义回答模板</p>
        /// </summary>
        [JsonProperty("CustomReplyRuleId")]
        public string CustomReplyRuleId{ get; set; }

        /// <summary>
        /// <p>模态类型：0-文本（默认），1-图片</p><p>枚举值：</p><ul><li>0： 文本</li><li>1： 图片</li></ul>
        /// </summary>
        [JsonProperty("ModalType")]
        public ulong? ModalType{ get; set; }

        /// <summary>
        /// <p>规则类别：black-普通规则(默认)，white-白名单规则；空值按black处理。white时ActionType仅允许pass(放行)，RuleItem支持白名单匹配字段(Key: ip/geo/type/content/chat_id/user_id/tool_name/tool_args/keyword_whitelist；Op: belong/not_belong/equal/not_equal/contain/not_contain/prefix/suffix/wildcard)</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>白名单规则生效范围：多个serviceId/domain列表（Category=white时使用），表示该白名单规则同时生效于哪些域名/serviceId。黑名单规则不使用此字段。</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>加白生效模块type列表（Category=white时使用），表示该白名单规则命中后对哪些防护模块生效(放行)。取值：2-算力消耗规则，3-自定义防护规则，4-ToolCall防护，5-提示词攻击防护，6-内容合规检测，7-敏感数据检测。</p>
        /// </summary>
        [JsonProperty("AppliedModules")]
        public ulong?[] AppliedModules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamArrayObj(map, prefix + "RuleItem.", this.RuleItem);
            this.SetParamArrayObj(map, prefix + "Options.", this.Options);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ResponseText", this.ResponseText);
            this.SetParamArraySimple(map, prefix + "SessionApplied.", this.SessionApplied);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "ContentLogicalOp", this.ContentLogicalOp);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ReplyType", this.ReplyType);
            this.SetParamSimple(map, prefix + "CustomReplyRuleId", this.CustomReplyRuleId);
            this.SetParamSimple(map, prefix + "ModalType", this.ModalType);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "AppliedModules.", this.AppliedModules);
        }
    }
}

