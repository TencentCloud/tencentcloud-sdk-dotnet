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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmRuleDetail : AbstractModel
    {
        
        /// <summary>
        /// 失败触发时机 
        /// 
        /// 1 – 首次失败触发
        /// 2 --所有重试完成触发 (默认)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trigger")]
        public long? Trigger{ get; set; }

        /// <summary>
        /// 补录重跑触发时机
        /// 
        /// 1 –  首次失败触发
        /// 2 – 所有重试完成触发
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataBackfillOrRerunTrigger")]
        public long? DataBackfillOrRerunTrigger{ get; set; }

        /// <summary>
        /// 周期实例超时配置明细
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeOutExtInfo")]
        public TimeOutStrategyInfo[] TimeOutExtInfo{ get; set; }

        /// <summary>
        /// 重跑补录实例超时配置明细
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataBackfillOrRerunTimeOutExtInfo")]
        public TimeOutStrategyInfo[] DataBackfillOrRerunTimeOutExtInfo{ get; set; }

        /// <summary>
        /// 项目波动告警配置明细
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectInstanceStatisticsAlarmInfoList")]
        public ProjectInstanceStatisticsAlarmInfo[] ProjectInstanceStatisticsAlarmInfoList{ get; set; }

        /// <summary>
        /// 离线集成对账告警配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReconciliationExtInfo")]
        public ReconciliationStrategyInfo[] ReconciliationExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Trigger", this.Trigger);
            this.SetParamSimple(map, prefix + "DataBackfillOrRerunTrigger", this.DataBackfillOrRerunTrigger);
            this.SetParamArrayObj(map, prefix + "TimeOutExtInfo.", this.TimeOutExtInfo);
            this.SetParamArrayObj(map, prefix + "DataBackfillOrRerunTimeOutExtInfo.", this.DataBackfillOrRerunTimeOutExtInfo);
            this.SetParamArrayObj(map, prefix + "ProjectInstanceStatisticsAlarmInfoList.", this.ProjectInstanceStatisticsAlarmInfoList);
            this.SetParamArrayObj(map, prefix + "ReconciliationExtInfo.", this.ReconciliationExtInfo);
        }
    }
}

