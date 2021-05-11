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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusRuleSet : AbstractModel
    {
        
        /// <summary>
        /// 规则 ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则状态码
        /// </summary>
        [JsonProperty("RuleState")]
        public long? RuleState{ get; set; }

        /// <summary>
        /// 规则类别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 规则标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public PrometheusRuleKV[] Labels{ get; set; }

        /// <summary>
        /// 规则注释列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Annotations")]
        public PrometheusRuleKV[] Annotations{ get; set; }

        /// <summary>
        /// 规则表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Expr")]
        public string Expr{ get; set; }

        /// <summary>
        /// 规则报警持续时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 报警接收组列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// 规则运行健康状态，取值如下：
        /// <li>unknown 未知状态</li>
        /// <li>pending 加载中</li>
        /// <li>ok 运行正常</li>
        /// <li>err 运行错误</li>
        /// </summary>
        [JsonProperty("Health")]
        public string Health{ get; set; }

        /// <summary>
        /// 规则创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 规则更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleState", this.RuleState);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamSimple(map, prefix + "Expr", this.Expr);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "Health", this.Health);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

