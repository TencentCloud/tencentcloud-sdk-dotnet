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

    public class InOutputBotUCBRule : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// UCB的具体规则项
        /// </summary>
        [JsonProperty("Rule")]
        public InOutputUCBRuleEntry[] Rule{ get; set; }

        /// <summary>
        /// 处置动作
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 规则开关
        /// </summary>
        [JsonProperty("OnOff")]
        public string OnOff{ get; set; }

        /// <summary>
        /// 规则类型
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 规则优先级
        /// </summary>
        [JsonProperty("Prior")]
        public long? Prior{ get; set; }

        /// <summary>
        /// 修改时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 入参ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonProperty("ValidTime")]
        public long? ValidTime{ get; set; }

        /// <summary>
        /// 传入的appid
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [JsonProperty("AdditionArg")]
        public string AdditionArg{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// true-系统预设规则 false-自定义规则
        /// </summary>
        [JsonProperty("PreDefine")]
        public bool? PreDefine{ get; set; }

        /// <summary>
        /// 定时任务类型
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 定时任务配置
        /// </summary>
        [JsonProperty("JobDateTime")]
        public JobDateTime JobDateTime{ get; set; }

        /// <summary>
        /// 生效截止时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 生效-1,失效-0
        /// </summary>
        [JsonProperty("ValidStatus")]
        public long? ValidStatus{ get; set; }

        /// <summary>
        /// 自定义拦截页面ID
        /// </summary>
        [JsonProperty("BlockPageId")]
        public ulong? BlockPageId{ get; set; }

        /// <summary>
        /// 当Action=intercept时，此字段必填
        /// </summary>
        [JsonProperty("ActionList")]
        public UCBActionProportion[] ActionList{ get; set; }

        /// <summary>
        /// 惩罚时间
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "OnOff", this.OnOff);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Prior", this.Prior);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "ValidTime", this.ValidTime);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "AdditionArg", this.AdditionArg);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "PreDefine", this.PreDefine);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "JobDateTime.", this.JobDateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ValidStatus", this.ValidStatus);
            this.SetParamSimple(map, prefix + "BlockPageId", this.BlockPageId);
            this.SetParamArrayObj(map, prefix + "ActionList.", this.ActionList);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
        }
    }
}

