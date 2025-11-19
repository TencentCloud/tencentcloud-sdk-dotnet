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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 审计状态。
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// 是否存在审计任务，0：无任务，1：创建中，2：关闭中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuditTask")]
        public long? AuditTask{ get; set; }

        /// <summary>
        /// 审计日志过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// 高频日志过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public long? HighLogExpireDay{ get; set; }

        /// <summary>
        /// 低频日志过期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LowLogExpireDay")]
        public long? LowLogExpireDay{ get; set; }

        /// <summary>
        /// 费用信息。
        /// </summary>
        [JsonProperty("BillingAmount")]
        public float? BillingAmount{ get; set; }

        /// <summary>
        /// 高频存储容量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighRealStorage")]
        public float? HighRealStorage{ get; set; }

        /// <summary>
        /// 低频存储容量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LowRealStorage")]
        public float? LowRealStorage{ get; set; }

        /// <summary>
        /// 实例详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public InstanceInfo InstanceInfo{ get; set; }

        /// <summary>
        /// 性能分析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PerformancesAnalyse")]
        public long? PerformancesAnalyse{ get; set; }

        /// <summary>
        /// true表示全审计，false表示规则审计
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }

        /// <summary>
        /// 实例审计最近一次的开通时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// 实例绑定的规则模版ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }

        /// <summary>
        /// 是否开启投递：ON，OFF
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deliver")]
        public string Deliver{ get; set; }

        /// <summary>
        /// 日志投递信息
        /// </summary>
        [JsonProperty("DeliverSummary")]
        public DeliverSummary[] DeliverSummary{ get; set; }

        /// <summary>
        /// 旧规则
        /// </summary>
        [JsonProperty("OldRule")]
        public bool? OldRule{ get; set; }

        /// <summary>
        /// 实际存储容量
        /// </summary>
        [JsonProperty("RealStorage")]
        public float? RealStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuditTask", this.AuditTask);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "LowLogExpireDay", this.LowLogExpireDay);
            this.SetParamSimple(map, prefix + "BillingAmount", this.BillingAmount);
            this.SetParamSimple(map, prefix + "HighRealStorage", this.HighRealStorage);
            this.SetParamSimple(map, prefix + "LowRealStorage", this.LowRealStorage);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
            this.SetParamSimple(map, prefix + "PerformancesAnalyse", this.PerformancesAnalyse);
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
            this.SetParamSimple(map, prefix + "Deliver", this.Deliver);
            this.SetParamArrayObj(map, prefix + "DeliverSummary.", this.DeliverSummary);
            this.SetParamSimple(map, prefix + "OldRule", this.OldRule);
            this.SetParamSimple(map, prefix + "RealStorage", this.RealStorage);
        }
    }
}

