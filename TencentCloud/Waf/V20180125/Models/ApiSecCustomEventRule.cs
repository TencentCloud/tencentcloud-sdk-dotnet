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

    public class ApiSecCustomEventRule : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 开关，1：开，0:关
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// api匹配列表
        /// </summary>
        [JsonProperty("ApiNameOp")]
        public ApiNameOp[] ApiNameOp{ get; set; }

        /// <summary>
        /// 事件详情
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 时间戳，出参有该值，入参不需要传没有
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// 匹配规则列表
        /// </summary>
        [JsonProperty("MatchRuleList")]
        public ApiSecSceneRuleEntry[] MatchRuleList{ get; set; }

        /// <summary>
        /// 统计规则列表
        /// </summary>
        [JsonProperty("StatRuleList")]
        public ApiSecSceneRuleEntry[] StatRuleList{ get; set; }

        /// <summary>
        /// 访问频次，第一个字段表示次数，第二个字段表示分钟
        /// </summary>
        [JsonProperty("ReqFrequency")]
        public long?[] ReqFrequency{ get; set; }

        /// <summary>
        /// 风险等级，取值为100,200,300，分别表示低位、中危、高危
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 规则来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "ApiNameOp.", this.ApiNameOp);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "MatchRuleList.", this.MatchRuleList);
            this.SetParamArrayObj(map, prefix + "StatRuleList.", this.StatRuleList);
            this.SetParamArraySimple(map, prefix + "ReqFrequency.", this.ReqFrequency);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

