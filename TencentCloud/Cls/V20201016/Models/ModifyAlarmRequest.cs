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

    public class ModifyAlarmRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警策略ID。
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 告警策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 监控任务运行时间点。
        /// </summary>
        [JsonProperty("MonitorTime")]
        public MonitorTime MonitorTime{ get; set; }

        /// <summary>
        /// 触发条件。
        /// 
        /// 注意:  
        /// - Condition和AlarmLevel是一组配置，MultiConditions是另一组配置，2组配置互斥。
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 告警级别。
        /// 
        /// 0:警告(Warn);1:提醒(Info);2:紧急 (Critical)
        /// 
        /// 注意:  
        /// - Condition和AlarmLevel是一组配置，MultiConditions是另一组配置，2组配置互斥。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// 多触发条件。 
        /// 
        /// 注意:  
        /// - Condition和AlarmLevel是一组配置，MultiConditions是另一组配置，2组配置互斥。
        /// </summary>
        [JsonProperty("MultiConditions")]
        public MultiCondition[] MultiConditions{ get; set; }

        /// <summary>
        /// 持续周期。持续满足触发条件TriggerCount个周期后，再进行告警；最小值为1，最大值为2000。
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// 告警重复的周期。单位是分钟。取值范围是0~1440。
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// 关联的告警通知模板列表。
        /// </summary>
        [JsonProperty("AlarmNoticeIds")]
        public string[] AlarmNoticeIds{ get; set; }

        /// <summary>
        /// 监控对象列表。
        /// </summary>
        [JsonProperty("AlarmTargets")]
        public AlarmTarget[] AlarmTargets{ get; set; }

        /// <summary>
        /// 是否开启告警策略。
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 该参数已废弃，请使用Status参数控制是否开启告警策略。
        /// </summary>
        [JsonProperty("Enable")]
        [System.Obsolete]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 用户自定义告警内容
        /// </summary>
        [JsonProperty("MessageTemplate")]
        public string MessageTemplate{ get; set; }

        /// <summary>
        /// 用户自定义回调
        /// </summary>
        [JsonProperty("CallBack")]
        public CallBackInfo CallBack{ get; set; }

        /// <summary>
        /// 多维分析
        /// </summary>
        [JsonProperty("Analysis")]
        public AnalysisDimensional[] Analysis{ get; set; }

        /// <summary>
        /// 分组触发状态。true：开启，false：关闭（默认）
        /// </summary>
        [JsonProperty("GroupTriggerStatus")]
        public bool? GroupTriggerStatus{ get; set; }

        /// <summary>
        /// 分组触发条件。
        /// </summary>
        [JsonProperty("GroupTriggerCondition")]
        public string[] GroupTriggerCondition{ get; set; }

        /// <summary>
        /// 标签描述列表，通过指定该参数可以同时绑定标签到相应的告警策略。最大支持10个标签键值对，并且不能有重复的键值对。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 监控对象类型。0:执行语句共用监控对象; 1:每个执行语句单独选择监控对象。 
        /// 当值为1时，AlarmTargets元素个数不能超过10个，AlarmTargets中的Number必须是从1开始的连续正整数，不能重复。
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public ulong? MonitorObjectType{ get; set; }

        /// <summary>
        /// 告警附加分类信息列表。
        /// Classifications元素个数不能超过20个。
        /// Classifications元素的Key不能为空，不能重复，长度不能超过50个字符，符合正则 `^[a-z]([a-z0-9_]{0,49})$`。
        /// Classifications元素的Value长度不能超过200个字符。
        /// </summary>
        [JsonProperty("Classifications")]
        public AlarmClassification[] Classifications{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "MonitorTime.", this.MonitorTime);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArrayObj(map, prefix + "MultiConditions.", this.MultiConditions);
            this.SetParamSimple(map, prefix + "TriggerCount", this.TriggerCount);
            this.SetParamSimple(map, prefix + "AlarmPeriod", this.AlarmPeriod);
            this.SetParamArraySimple(map, prefix + "AlarmNoticeIds.", this.AlarmNoticeIds);
            this.SetParamArrayObj(map, prefix + "AlarmTargets.", this.AlarmTargets);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "MessageTemplate", this.MessageTemplate);
            this.SetParamObj(map, prefix + "CallBack.", this.CallBack);
            this.SetParamArrayObj(map, prefix + "Analysis.", this.Analysis);
            this.SetParamSimple(map, prefix + "GroupTriggerStatus", this.GroupTriggerStatus);
            this.SetParamArraySimple(map, prefix + "GroupTriggerCondition.", this.GroupTriggerCondition);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
            this.SetParamArrayObj(map, prefix + "Classifications.", this.Classifications);
        }
    }
}

