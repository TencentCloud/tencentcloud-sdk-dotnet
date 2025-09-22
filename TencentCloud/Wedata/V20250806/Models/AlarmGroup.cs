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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmGroup : AbstractModel
    {
        
        /// <summary>
        /// 告警升级人ID列表
        /// 若告警接收人或上级升级人未在告警间隔时间内确认告警，则会发送告警给下一级升级人。
        /// </summary>
        [JsonProperty("AlarmEscalationRecipientIds")]
        public string[] AlarmEscalationRecipientIds{ get; set; }

        /// <summary>
        /// 告警升级间隔
        /// </summary>
        [JsonProperty("AlarmEscalationInterval")]
        public long? AlarmEscalationInterval{ get; set; }

        /// <summary>
        /// 告警通知疲劳配置
        /// </summary>
        [JsonProperty("NotificationFatigue")]
        public NotificationFatigue NotificationFatigue{ get; set; }

        /// <summary>
        /// 告警渠道 1.邮件，2.短信，3.微信，4.语音，5.企业微信，6.Http，7.企业微信群 8 飞书群 9 钉钉群 10 Slack群 11 Teams群（默认1.邮件） 7.企业微信群 8 飞书群 9 钉钉群 10 Slack群 11 Teams群 只能选择一个渠道
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string[] AlarmWays{ get; set; }

        /// <summary>
        /// 企业微信群/飞书群/钉钉群 /Slack群/Teams群的webhook地址列表
        /// </summary>
        [JsonProperty("WebHooks")]
        public AlarmWayWebHook[] WebHooks{ get; set; }

        /// <summary>
        /// 告警接收人类型：1.指定人员，2.任务责任人，3.值班表（默认1.指定人员）
        /// </summary>
        [JsonProperty("AlarmRecipientType")]
        public long? AlarmRecipientType{ get; set; }

        /// <summary>
        /// 根据AlarmRecipientType的类型该列表具有不同的业务id 1（指定人员）: 告警接收人id列表 2（任务责任人）：无需配置 3（值班表）：值班表id列表
        /// </summary>
        [JsonProperty("AlarmRecipientIds")]
        public string[] AlarmRecipientIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AlarmEscalationRecipientIds.", this.AlarmEscalationRecipientIds);
            this.SetParamSimple(map, prefix + "AlarmEscalationInterval", this.AlarmEscalationInterval);
            this.SetParamObj(map, prefix + "NotificationFatigue.", this.NotificationFatigue);
            this.SetParamArraySimple(map, prefix + "AlarmWays.", this.AlarmWays);
            this.SetParamArrayObj(map, prefix + "WebHooks.", this.WebHooks);
            this.SetParamSimple(map, prefix + "AlarmRecipientType", this.AlarmRecipientType);
            this.SetParamArraySimple(map, prefix + "AlarmRecipientIds.", this.AlarmRecipientIds);
        }
    }
}

