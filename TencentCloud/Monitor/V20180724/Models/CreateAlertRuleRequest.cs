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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlertRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Prometheus 实例 ID，例如：prom-abcd1234
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则表达式，可参考<a href="https://cloud.tencent.com/document/product/1416/56008">告警规则说明</a>
        /// </summary>
        [JsonProperty("Expr")]
        public string Expr{ get; set; }

        /// <summary>
        /// 告警通知模板 ID 列表
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// 规则状态码，取值如下：
        /// <li>2=RuleEnabled</li>
        /// <li>3=RuleDisabled</li>
        /// </summary>
        [JsonProperty("RuleState")]
        public long? RuleState{ get; set; }

        /// <summary>
        /// 规则报警持续时间
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Labels")]
        public PrometheusRuleKV[] Labels{ get; set; }

        /// <summary>
        /// 注释列表。
        /// 
        /// 告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description。
        /// </summary>
        [JsonProperty("Annotations")]
        public PrometheusRuleKV[] Annotations{ get; set; }

        /// <summary>
        /// 报警策略模板分类
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Expr", this.Expr);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "RuleState", this.RuleState);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

