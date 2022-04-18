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

    public class UserNotice : AbstractModel
    {
        
        /// <summary>
        /// 接收者类型 USER=用户 GROUP=用户组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// 通知开始时间 00:00:00 开始的秒数（取值范围0-86399）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 通知结束时间 00:00:00 开始的秒数（取值范围0-86399）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 通知渠道列表 EMAIL=邮件 SMS=短信 CALL=电话 WECHAT=微信 RTX=企业微信
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NoticeWay")]
        public string[] NoticeWay{ get; set; }

        /// <summary>
        /// 用户 uid 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIds")]
        public long?[] UserIds{ get; set; }

        /// <summary>
        /// 用户组 group id 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupIds")]
        public long?[] GroupIds{ get; set; }

        /// <summary>
        /// 电话轮询列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneOrder")]
        public long?[] PhoneOrder{ get; set; }

        /// <summary>
        /// 电话轮询次数 （取值范围1-5）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneCircleTimes")]
        public long? PhoneCircleTimes{ get; set; }

        /// <summary>
        /// 单次轮询内拨打间隔 秒数 （取值范围60-900）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneInnerInterval")]
        public long? PhoneInnerInterval{ get; set; }

        /// <summary>
        /// 两次轮询间隔 秒数（取值范围60-900）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneCircleInterval")]
        public long? PhoneCircleInterval{ get; set; }

        /// <summary>
        /// 是否需要触达通知 0=否 1=是
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NeedPhoneArriveNotice")]
        public long? NeedPhoneArriveNotice{ get; set; }

        /// <summary>
        /// 电话拨打类型 SYNC=同时拨打 CIRCLE=轮询拨打 不指定时默认是轮询
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneCallType")]
        public string PhoneCallType{ get; set; }

        /// <summary>
        /// 通知周期 1-7表示周一到周日
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weekday")]
        public long?[] Weekday{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "NoticeWay.", this.NoticeWay);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArraySimple(map, prefix + "PhoneOrder.", this.PhoneOrder);
            this.SetParamSimple(map, prefix + "PhoneCircleTimes", this.PhoneCircleTimes);
            this.SetParamSimple(map, prefix + "PhoneInnerInterval", this.PhoneInnerInterval);
            this.SetParamSimple(map, prefix + "PhoneCircleInterval", this.PhoneCircleInterval);
            this.SetParamSimple(map, prefix + "NeedPhoneArriveNotice", this.NeedPhoneArriveNotice);
            this.SetParamSimple(map, prefix + "PhoneCallType", this.PhoneCallType);
            this.SetParamArraySimple(map, prefix + "Weekday.", this.Weekday);
        }
    }
}

