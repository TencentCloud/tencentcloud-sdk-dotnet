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

    public class NoticeContent : AbstractModel
    {
        
        /// <summary>
        /// 渠道类型
        /// 
        /// Email:邮件;Sms:短信;WeChat:微信;Phone:电话;WeCom:企业微信;DingTalk:钉钉;Lark:飞书;Http:自定义回调;
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 告警触发通知内容模板。
        /// </summary>
        [JsonProperty("TriggerContent")]
        public NoticeContentInfo TriggerContent{ get; set; }

        /// <summary>
        /// 告警恢复通知内容模板。
        /// </summary>
        [JsonProperty("RecoveryContent")]
        public NoticeContentInfo RecoveryContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "TriggerContent.", this.TriggerContent);
            this.SetParamObj(map, prefix + "RecoveryContent.", this.RecoveryContent);
        }
    }
}

