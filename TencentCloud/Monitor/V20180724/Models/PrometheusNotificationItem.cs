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

    public class PrometheusNotificationItem : AbstractModel
    {
        
        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 通道类型，默认为amp，支持以下
        /// amp
        /// webhook
        /// alertmanager
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 如果Type为webhook, 则该字段为必填项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebHook")]
        public string WebHook{ get; set; }

        /// <summary>
        /// 如果Type为alertmanager, 则该字段为必填项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertManager")]
        public PrometheusAlertManagerConfig AlertManager{ get; set; }

        /// <summary>
        /// 收敛时间
        /// </summary>
        [JsonProperty("RepeatInterval")]
        public string RepeatInterval{ get; set; }

        /// <summary>
        /// 生效起始时间
        /// </summary>
        [JsonProperty("TimeRangeStart")]
        public string TimeRangeStart{ get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [JsonProperty("TimeRangeEnd")]
        public string TimeRangeEnd{ get; set; }

        /// <summary>
        /// 告警通知方式。目前有SMS、EMAIL、CALL、WECHAT方式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// 告警接收组（用户组）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public string[] ReceiverGroups{ get; set; }

        /// <summary>
        /// 电话告警顺序。
        /// 注：NotifyWay选择CALL，采用该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneNotifyOrder")]
        public ulong?[] PhoneNotifyOrder{ get; set; }

        /// <summary>
        /// 电话告警次数。
        /// 注：NotifyWay选择CALL，采用该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneCircleTimes")]
        public long? PhoneCircleTimes{ get; set; }

        /// <summary>
        /// 电话告警轮内间隔。单位：秒
        /// 注：NotifyWay选择CALL，采用该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneInnerInterval")]
        public long? PhoneInnerInterval{ get; set; }

        /// <summary>
        /// 电话告警轮外间隔。单位：秒
        /// 注：NotifyWay选择CALL，采用该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneCircleInterval")]
        public long? PhoneCircleInterval{ get; set; }

        /// <summary>
        /// 电话告警触达通知
        /// 注：NotifyWay选择CALL，采用该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneArriveNotice")]
        public bool? PhoneArriveNotice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WebHook", this.WebHook);
            this.SetParamObj(map, prefix + "AlertManager.", this.AlertManager);
            this.SetParamSimple(map, prefix + "RepeatInterval", this.RepeatInterval);
            this.SetParamSimple(map, prefix + "TimeRangeStart", this.TimeRangeStart);
            this.SetParamSimple(map, prefix + "TimeRangeEnd", this.TimeRangeEnd);
            this.SetParamArraySimple(map, prefix + "NotifyWay.", this.NotifyWay);
            this.SetParamArraySimple(map, prefix + "ReceiverGroups.", this.ReceiverGroups);
            this.SetParamArraySimple(map, prefix + "PhoneNotifyOrder.", this.PhoneNotifyOrder);
            this.SetParamSimple(map, prefix + "PhoneCircleTimes", this.PhoneCircleTimes);
            this.SetParamSimple(map, prefix + "PhoneInnerInterval", this.PhoneInnerInterval);
            this.SetParamSimple(map, prefix + "PhoneCircleInterval", this.PhoneCircleInterval);
            this.SetParamSimple(map, prefix + "PhoneArriveNotice", this.PhoneArriveNotice);
        }
    }
}

