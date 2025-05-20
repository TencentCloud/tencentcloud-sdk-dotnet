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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpsertCCRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 高级模式（是否使用Session检测），0表示不启用，1表示启用
        /// </summary>
        [JsonProperty("Advance")]
        public string Advance{ get; set; }

        /// <summary>
        /// CC检测阈值
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// CC检测周期
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// 动作，20表示观察，21表示人机识别，22表示拦截，23表示精准拦截，26表示精准人机识别，27表示JS校验
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 动作有效时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public long? ValidTime{ get; set; }

        /// <summary>
        /// 检测Url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 匹配方法，0表示等于，1表示前缀匹配，2表示包含，3表示不等于，6表示后缀匹配，7表示不包含
        /// </summary>
        [JsonProperty("MatchFunc")]
        public long? MatchFunc{ get; set; }

        /// <summary>
        /// CC的匹配条件JSON序列化的字符串，示例：[{\"key\":\"Method\",\"args\":[\"=R0VU\"],\"match\":\"0\",\"encodeflag\":true}] Key可选值为 Method、Post、Referer、Cookie、User-Agent、CustomHeader match可选值为，当Key为Method的时候可选值为0（等于）、3（不等于）。 Key为Post的时候可选值为0（等于）、3（不等于），Key为Cookie的时候可选值为0（等于）、2（包含），3（不等于）、7（不包含）、 当Key为Referer的时候可选值为0（等于）、3（不等于）、1（前缀匹配）、6（后缀匹配）、2（包含）、7（不包含）、12（存在）、5（不存在）、4（内容为空）， 当Key为Cookie的时候可选值为0（等于）、3（不等于）、2（包含）、7（不包含）、12（存在）、5（不存在）、4（内容为空）， 当Key为User-Agent的时候可选值为0（等于）、3（不等于）、1（前缀匹配）、6（后缀匹配）、2（包含）、7（不包含）、12（存在）、5（不存在）、4（内容为空）， 当Key为CustomHeader的时候可选值为0（等于）、3（不等于）、2（包含）、7（不包含）、12（存在）、5（不存在）、4（内容为空）。 Key为IPLocation时，可选值为13（属于）、14（不属于）。args用来表示匹配内容，需要设置encodeflag为true，当Key为Post、Cookie、CustomHeader时，用等号=来分别串接Key和Value，并分别用Base64编码，类似YWJj=YWJj。当Key为Referer、User-Agent时，用等号=来串接Value，类似=YWJj。
        /// </summary>
        [JsonProperty("OptionsArr")]
        public string OptionsArr{ get; set; }

        /// <summary>
        /// waf版本，sparta-waf或者clb-waf
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 添加规则的来源事件id
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 规则需要启用的SessionID
        /// </summary>
        [JsonProperty("SessionApplied")]
        public long?[] SessionApplied{ get; set; }

        /// <summary>
        /// 规则ID，新增时填0
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 规则创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// url长度
        /// </summary>
        [JsonProperty("Length")]
        public ulong? Length{ get; set; }

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
        /// 配置方式的逻辑操作符，and或者or
        /// </summary>
        [JsonProperty("LogicalOp")]
        public string LogicalOp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Advance", this.Advance);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "MatchFunc", this.MatchFunc);
            this.SetParamSimple(map, prefix + "OptionsArr", this.OptionsArr);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamArraySimple(map, prefix + "SessionApplied.", this.SessionApplied);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Length", this.Length);
            this.SetParamSimple(map, prefix + "LimitMethod", this.LimitMethod);
            this.SetParamSimple(map, prefix + "CelRule", this.CelRule);
            this.SetParamSimple(map, prefix + "LogicalOp", this.LogicalOp);
        }
    }
}

