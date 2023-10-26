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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警策略名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 监控对象列表。
        /// </summary>
        [JsonProperty("AlarmTargets")]
        public AlarmTargetInfo[] AlarmTargets{ get; set; }

        /// <summary>
        /// 监控任务运行时间点。
        /// </summary>
        [JsonProperty("MonitorTime")]
        public MonitorTime MonitorTime{ get; set; }

        /// <summary>
        /// 触发条件。
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 持续周期。持续满足触发条件TriggerCount个周期后，再进行告警；最小值为1，最大值为10。
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// 告警重复的周期。单位是min。取值范围是0~1440。
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// 关联的告警通知模板列表。
        /// </summary>
        [JsonProperty("AlarmNoticeIds")]
        public string[] AlarmNoticeIds{ get; set; }

        /// <summary>
        /// 开启状态。
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 告警策略ID。
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 自定义通知模板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageTemplate")]
        public string MessageTemplate{ get; set; }

        /// <summary>
        /// 自定义回调模板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallBack")]
        public CallBackInfo CallBack{ get; set; }

        /// <summary>
        /// 多维分析设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Analysis")]
        public AnalysisDimensional[] Analysis{ get; set; }

        /// <summary>
        /// 分组触发状态。1：开启，0：关闭（默认）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupTriggerStatus")]
        public bool? GroupTriggerStatus{ get; set; }

        /// <summary>
        /// 分组触发条件。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupTriggerCondition")]
        public string[] GroupTriggerCondition{ get; set; }

        /// <summary>
        /// 监控对象类型。0:执行语句共用监控对象;1:每个执行语句单独选择监控对象。 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public ulong? MonitorObjectType{ get; set; }

        /// <summary>
        /// 告警级别。0:警告(Warn);1:提醒(Info);2:紧急 (Critical)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// 多触发条件。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiConditions")]
        public MultiCondition[] MultiConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "AlarmTargets.", this.AlarmTargets);
            this.SetParamObj(map, prefix + "MonitorTime.", this.MonitorTime);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "TriggerCount", this.TriggerCount);
            this.SetParamSimple(map, prefix + "AlarmPeriod", this.AlarmPeriod);
            this.SetParamArraySimple(map, prefix + "AlarmNoticeIds.", this.AlarmNoticeIds);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "MessageTemplate", this.MessageTemplate);
            this.SetParamObj(map, prefix + "CallBack.", this.CallBack);
            this.SetParamArrayObj(map, prefix + "Analysis.", this.Analysis);
            this.SetParamSimple(map, prefix + "GroupTriggerStatus", this.GroupTriggerStatus);
            this.SetParamArraySimple(map, prefix + "GroupTriggerCondition.", this.GroupTriggerCondition);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArrayObj(map, prefix + "MultiConditions.", this.MultiConditions);
        }
    }
}

