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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlertHistoryRecord : AbstractModel
    {
        
        /// <summary>
        /// 告警历史ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 告警策略ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 告警策略名称
        /// </summary>
        [JsonProperty("AlarmName")]
        public string AlarmName{ get; set; }

        /// <summary>
        /// 监控对象ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 监控对象名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 监控对象所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 触发条件
        /// </summary>
        [JsonProperty("Trigger")]
        public string Trigger{ get; set; }

        /// <summary>
        /// 持续周期，持续满足触发条件TriggerCount个周期后，再进行告警
        /// </summary>
        [JsonProperty("TriggerCount")]
        public long? TriggerCount{ get; set; }

        /// <summary>
        /// 告警通知发送频率，单位为分钟
        /// </summary>
        [JsonProperty("AlarmPeriod")]
        public long? AlarmPeriod{ get; set; }

        /// <summary>
        /// 通知渠道组
        /// </summary>
        [JsonProperty("Notices")]
        public AlertHistoryNotice[] Notices{ get; set; }

        /// <summary>
        /// 告警持续时间，单位为分钟
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 告警状态，0代表未恢复，1代表已恢复，2代表已失效
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 告警发生时间，毫秒级Unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 告警分组触发时对应的分组信息
        /// </summary>
        [JsonProperty("GroupTriggerCondition")]
        public GroupTriggerConditionInfo[] GroupTriggerCondition{ get; set; }

        /// <summary>
        /// 告警级别，0代表警告(Warn)，1代表提醒(Info)，2代表紧急 (Critical)
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// 监控对象类型。
        /// 0:执行语句共用监控对象; 1:每个执行语句单独选择监控对象。 
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public ulong? MonitorObjectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "AlarmName", this.AlarmName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Trigger", this.Trigger);
            this.SetParamSimple(map, prefix + "TriggerCount", this.TriggerCount);
            this.SetParamSimple(map, prefix + "AlarmPeriod", this.AlarmPeriod);
            this.SetParamArrayObj(map, prefix + "Notices.", this.Notices);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "GroupTriggerCondition.", this.GroupTriggerCondition);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
        }
    }
}

