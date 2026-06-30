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

    public class PolicyGroupReceiverInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>有效时段结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>是否需要发送通知</p>
        /// </summary>
        [JsonProperty("NeedSendNotice")]
        public long? NeedSendNotice{ get; set; }

        /// <summary>
        /// <p>告警接收渠道</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// <p>电话告警对个人间隔（秒）</p>
        /// </summary>
        [JsonProperty("PersonInterval")]
        public long? PersonInterval{ get; set; }

        /// <summary>
        /// <p>消息接收组列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverGroupList")]
        public long?[] ReceiverGroupList{ get; set; }

        /// <summary>
        /// <p>接受者类型</p>
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// <p>接收人列表。通过平台接口查询到的接收人id列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverUserList")]
        public long?[] ReceiverUserList{ get; set; }

        /// <summary>
        /// <p>告警恢复通知方式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecoverNotify")]
        public string[] RecoverNotify{ get; set; }

        /// <summary>
        /// <p>电话告警每轮间隔（秒）</p>
        /// </summary>
        [JsonProperty("RoundInterval")]
        public long? RoundInterval{ get; set; }

        /// <summary>
        /// <p>电话告警轮数</p>
        /// </summary>
        [JsonProperty("RoundNumber")]
        public long? RoundNumber{ get; set; }

        /// <summary>
        /// <p>电话告警通知时机。可选&quot;OCCUR&quot;(告警时通知),&quot;RECOVER&quot;(恢复时通知)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendFor")]
        public string[] SendFor{ get; set; }

        /// <summary>
        /// <p>有效时段开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>电话告警接收者uid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UIDList")]
        public long?[] UIDList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NeedSendNotice", this.NeedSendNotice);
            this.SetParamArraySimple(map, prefix + "NotifyWay.", this.NotifyWay);
            this.SetParamSimple(map, prefix + "PersonInterval", this.PersonInterval);
            this.SetParamArraySimple(map, prefix + "ReceiverGroupList.", this.ReceiverGroupList);
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "ReceiverUserList.", this.ReceiverUserList);
            this.SetParamArraySimple(map, prefix + "RecoverNotify.", this.RecoverNotify);
            this.SetParamSimple(map, prefix + "RoundInterval", this.RoundInterval);
            this.SetParamSimple(map, prefix + "RoundNumber", this.RoundNumber);
            this.SetParamArraySimple(map, prefix + "SendFor.", this.SendFor);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArraySimple(map, prefix + "UIDList.", this.UIDList);
        }
    }
}

