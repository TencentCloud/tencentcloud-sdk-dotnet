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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmReceiverInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 告警接收人ID
        /// </summary>
        [JsonProperty("AlarmReceiver")]
        public string AlarmReceiver{ get; set; }

        /// <summary>
        /// 邮件，0：未设置，1：成功，2：失败
        /// </summary>
        [JsonProperty("Email")]
        public ulong? Email{ get; set; }

        /// <summary>
        /// 短信，0：未设置，1：成功，2：失败
        /// </summary>
        [JsonProperty("Sms")]
        public ulong? Sms{ get; set; }

        /// <summary>
        /// 微信，0：未设置，1：成功，2：失败
        /// </summary>
        [JsonProperty("Wechat")]
        public ulong? Wechat{ get; set; }

        /// <summary>
        /// 电话，0：未设置，1：成功，2：失败
        /// </summary>
        [JsonProperty("Voice")]
        public ulong? Voice{ get; set; }

        /// <summary>
        /// 企业微信，0：未设置，1：成功，2：失败
        /// </summary>
        [JsonProperty("Wecom")]
        public ulong? Wecom{ get; set; }

        /// <summary>
        /// http，0：未设置，1：成功，2：失败
        /// </summary>
        [JsonProperty("Http")]
        public ulong? Http{ get; set; }

        /// <summary>
        /// 企业微信群，0：未设置，1：成功，2：失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WecomGroup")]
        public ulong? WecomGroup{ get; set; }

        /// <summary>
        /// 飞书群，0：未设置，1：成功，2：失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LarkGroup")]
        public ulong? LarkGroup{ get; set; }

        /// <summary>
        /// 发送结果 大json格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmMessageSendResult")]
        public string AlarmMessageSendResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "AlarmReceiver", this.AlarmReceiver);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Sms", this.Sms);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "Voice", this.Voice);
            this.SetParamSimple(map, prefix + "Wecom", this.Wecom);
            this.SetParamSimple(map, prefix + "Http", this.Http);
            this.SetParamSimple(map, prefix + "WecomGroup", this.WecomGroup);
            this.SetParamSimple(map, prefix + "LarkGroup", this.LarkGroup);
            this.SetParamSimple(map, prefix + "AlarmMessageSendResult", this.AlarmMessageSendResult);
        }
    }
}

