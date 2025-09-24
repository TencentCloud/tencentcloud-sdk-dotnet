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

    public class CCRuleItems : AbstractModel
    {
        
        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 模式
        /// </summary>
        [JsonProperty("Advance")]
        public ulong? Advance{ get; set; }

        /// <summary>
        /// 限制
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 范围
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 匹配类型
        /// </summary>
        [JsonProperty("MatchFunc")]
        public ulong? MatchFunc{ get; set; }

        /// <summary>
        /// 动作，20表示观察，21表示人机识别，22表示拦截，23表示精准拦截，24表示JS校验
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// 有效时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public ulong? ValidTime{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("TsVersion")]
        public ulong? TsVersion{ get; set; }

        /// <summary>
        /// key为匹配字段；args为base64编码后的参数，等于号前为匹配参数，等于号后为匹配内容；match为逻辑符号；encodeflag为参数内容是否编码
        /// </summary>
        [JsonProperty("Options")]
        public string Options{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 关联的Session规则
        /// </summary>
        [JsonProperty("SessionApplied")]
        public long?[] SessionApplied{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 限频方式
        /// </summary>
        [JsonProperty("LimitMethod")]
        public string LimitMethod{ get; set; }

        /// <summary>
        /// cel表达式
        /// </summary>
        [JsonProperty("CelRule")]
        public string CelRule{ get; set; }

        /// <summary>
        /// 逻辑操作符
        /// </summary>
        [JsonProperty("LogicalOp")]
        public string LogicalOp{ get; set; }

        /// <summary>
        /// 页面ID
        /// </summary>
        [JsonProperty("PageId")]
        public string PageId{ get; set; }

        /// <summary>
        /// 动作灰度比例，默认值100
        /// </summary>
        [JsonProperty("ActionRatio")]
        public ulong? ActionRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Advance", this.Advance);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "MatchFunc", this.MatchFunc);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "TsVersion", this.TsVersion);
            this.SetParamSimple(map, prefix + "Options", this.Options);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamArraySimple(map, prefix + "SessionApplied.", this.SessionApplied);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LimitMethod", this.LimitMethod);
            this.SetParamSimple(map, prefix + "CelRule", this.CelRule);
            this.SetParamSimple(map, prefix + "LogicalOp", this.LogicalOp);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "ActionRatio", this.ActionRatio);
        }
    }
}

