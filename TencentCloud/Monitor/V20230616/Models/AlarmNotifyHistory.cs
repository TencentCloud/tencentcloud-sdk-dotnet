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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmNotifyHistory : AbstractModel
    {
        
        /// <summary>
        /// 通知的唯一ID
        /// </summary>
        [JsonProperty("NotifyId")]
        public string NotifyId{ get; set; }

        /// <summary>
        /// 告警策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 告警周期iD
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 通知时间 unix秒级时间戳
        /// </summary>
        [JsonProperty("NotifyTime")]
        public long? NotifyTime{ get; set; }

        /// <summary>
        /// 触发时间 unix秒级时间戳
        /// </summary>
        [JsonProperty("TriggerTime")]
        public long? TriggerTime{ get; set; }

        /// <summary>
        /// 告警级别 None 非分级告警级别; Note 提示级别; Warn 严重级别; Serious 紧急级别
        /// </summary>
        [JsonProperty("TriggerLevel")]
        public string TriggerLevel{ get; set; }

        /// <summary>
        /// 告警内容
        /// </summary>
        [JsonProperty("AlarmContent")]
        public string AlarmContent{ get; set; }

        /// <summary>
        /// 告警对象
        /// </summary>
        [JsonProperty("AlarmObject")]
        public string AlarmObject{ get; set; }

        /// <summary>
        /// 本次告警通知涉及到的渠道合集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelSet")]
        public string[] ChannelSet{ get; set; }

        /// <summary>
        /// 渠道的接收人信息
        /// </summary>
        [JsonProperty("ChannelsReceivers")]
        public ChannelsReceivers[] ChannelsReceivers{ get; set; }

        /// <summary>
        /// 告警策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Prometheus实例ID, 仅当 MT_PROME 时有效
        /// </summary>
        [JsonProperty("PromeInstanceID")]
        public string PromeInstanceID{ get; set; }

        /// <summary>
        /// Prometheus实例所在的地域, 仅当 MT_PROME 时有效
        /// </summary>
        [JsonProperty("PromeInstanceRegion")]
        public string PromeInstanceRegion{ get; set; }

        /// <summary>
        /// 通知模板相关的配置信息
        /// </summary>
        [JsonProperty("Notices")]
        public NotifyRelatedNotice[] Notices{ get; set; }

        /// <summary>
        /// 告警触发状态  Trigger 告警状态触发; Recovery 告警状态恢复
        /// </summary>
        [JsonProperty("TriggerStatus")]
        public string TriggerStatus{ get; set; }

        /// <summary>
        /// 与当前Prometheus通知历史相关控制台页面地址，仅当 MR_PROME 时有效
        /// </summary>
        [JsonProperty("PromeConsoleURL")]
        public string PromeConsoleURL{ get; set; }

        /// <summary>
        /// 告警的lable
        /// </summary>
        [JsonProperty("Labels")]
        public AlarmLable[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotifyId", this.NotifyId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "NotifyTime", this.NotifyTime);
            this.SetParamSimple(map, prefix + "TriggerTime", this.TriggerTime);
            this.SetParamSimple(map, prefix + "TriggerLevel", this.TriggerLevel);
            this.SetParamSimple(map, prefix + "AlarmContent", this.AlarmContent);
            this.SetParamSimple(map, prefix + "AlarmObject", this.AlarmObject);
            this.SetParamArraySimple(map, prefix + "ChannelSet.", this.ChannelSet);
            this.SetParamArrayObj(map, prefix + "ChannelsReceivers.", this.ChannelsReceivers);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PromeInstanceID", this.PromeInstanceID);
            this.SetParamSimple(map, prefix + "PromeInstanceRegion", this.PromeInstanceRegion);
            this.SetParamArrayObj(map, prefix + "Notices.", this.Notices);
            this.SetParamSimple(map, prefix + "TriggerStatus", this.TriggerStatus);
            this.SetParamSimple(map, prefix + "PromeConsoleURL", this.PromeConsoleURL);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

