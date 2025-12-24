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

    public class AlarmGroup : AbstractModel
    {
        
        /// <summary>
        /// 告警方式,1.邮件，2.短信，3.微信，4.语音，5.企业微信，6.Http，7.企业微信群；告警方式code列表（默认1.邮件）
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string[] AlarmWays{ get; set; }

        /// <summary>
        /// 告警接收人类型：1.指定人员，2.任务责任人，3.值班表（默认1.指定人员）
        /// </summary>
        [JsonProperty("AlarmRecipientType")]
        public ulong? AlarmRecipientType{ get; set; }

        /// <summary>
        /// 告警接收人
        /// </summary>
        [JsonProperty("AlarmRecipients")]
        public string[] AlarmRecipients{ get; set; }

        /// <summary>
        /// 告警接收人ID
        /// </summary>
        [JsonProperty("AlarmRecipientIds")]
        public string[] AlarmRecipientIds{ get; set; }

        /// <summary>
        /// 告警升级人
        /// </summary>
        [JsonProperty("AlarmEscalationRecipients")]
        public string[] AlarmEscalationRecipients{ get; set; }

        /// <summary>
        /// 告警升级人ID
        /// </summary>
        [JsonProperty("AlarmEscalationRecipientIds")]
        public string[] AlarmEscalationRecipientIds{ get; set; }

        /// <summary>
        /// 告警升级间隔
        /// </summary>
        [JsonProperty("AlarmEscalationInterval")]
        public ulong? AlarmEscalationInterval{ get; set; }

        /// <summary>
        /// 告警通知疲劳度配置。
        /// </summary>
        [JsonProperty("NotificationFatigue")]
        public NotificationFatigue NotificationFatigue{ get; set; }

        /// <summary>
        /// 告警渠道规则 json 格式
        /// </summary>
        [JsonProperty("AlarmMessageRule")]
        public string AlarmMessageRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AlarmWays.", this.AlarmWays);
            this.SetParamSimple(map, prefix + "AlarmRecipientType", this.AlarmRecipientType);
            this.SetParamArraySimple(map, prefix + "AlarmRecipients.", this.AlarmRecipients);
            this.SetParamArraySimple(map, prefix + "AlarmRecipientIds.", this.AlarmRecipientIds);
            this.SetParamArraySimple(map, prefix + "AlarmEscalationRecipients.", this.AlarmEscalationRecipients);
            this.SetParamArraySimple(map, prefix + "AlarmEscalationRecipientIds.", this.AlarmEscalationRecipientIds);
            this.SetParamSimple(map, prefix + "AlarmEscalationInterval", this.AlarmEscalationInterval);
            this.SetParamObj(map, prefix + "NotificationFatigue.", this.NotificationFatigue);
            this.SetParamSimple(map, prefix + "AlarmMessageRule", this.AlarmMessageRule);
        }
    }
}

