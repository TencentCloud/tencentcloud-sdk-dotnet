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

    public class DescribePolicyGroupInfoReceiverInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警接收组id列表
        /// </summary>
        [JsonProperty("ReceiverGroupList")]
        public long?[] ReceiverGroupList{ get; set; }

        /// <summary>
        /// 告警接收人id列表
        /// </summary>
        [JsonProperty("ReceiverUserList")]
        public long?[] ReceiverUserList{ get; set; }

        /// <summary>
        /// 告警时间段开始时间。范围[0,86400)，作为unix时间戳转成北京时间后去掉日期，例如7200表示"10:0:0"
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 告警时间段结束时间。含义同StartTime
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 接收类型。“group”(接收组)或“user”(接收人)
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// 告警通知方式。可选 "SMS","SITE","EMAIL","CALL","WECHAT"
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// 电话告警接收者uid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UidList")]
        public long?[] UidList{ get; set; }

        /// <summary>
        /// 电话告警轮数
        /// </summary>
        [JsonProperty("RoundNumber")]
        public long? RoundNumber{ get; set; }

        /// <summary>
        /// 电话告警每轮间隔（秒）
        /// </summary>
        [JsonProperty("RoundInterval")]
        public long? RoundInterval{ get; set; }

        /// <summary>
        /// 电话告警对个人间隔（秒）
        /// </summary>
        [JsonProperty("PersonInterval")]
        public long? PersonInterval{ get; set; }

        /// <summary>
        /// 是否需要电话告警触达提示。0不需要，1需要
        /// </summary>
        [JsonProperty("NeedSendNotice")]
        public long? NeedSendNotice{ get; set; }

        /// <summary>
        /// 电话告警通知时机。可选"OCCUR"(告警时通知),"RECOVER"(恢复时通知)
        /// </summary>
        [JsonProperty("SendFor")]
        public string[] SendFor{ get; set; }

        /// <summary>
        /// 恢复通知方式。可选"SMS"
        /// </summary>
        [JsonProperty("RecoverNotify")]
        public string[] RecoverNotify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ReceiverGroupList.", this.ReceiverGroupList);
            this.SetParamArraySimple(map, prefix + "ReceiverUserList.", this.ReceiverUserList);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "NotifyWay.", this.NotifyWay);
            this.SetParamArraySimple(map, prefix + "UidList.", this.UidList);
            this.SetParamSimple(map, prefix + "RoundNumber", this.RoundNumber);
            this.SetParamSimple(map, prefix + "RoundInterval", this.RoundInterval);
            this.SetParamSimple(map, prefix + "PersonInterval", this.PersonInterval);
            this.SetParamSimple(map, prefix + "NeedSendNotice", this.NeedSendNotice);
            this.SetParamArraySimple(map, prefix + "SendFor.", this.SendFor);
            this.SetParamArraySimple(map, prefix + "RecoverNotify.", this.RecoverNotify);
        }
    }
}

