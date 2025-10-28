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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotSessionValidation : AbstractModel
    {
        
        /// <summary>
        /// 是否更新 Cookie 并校验。取值有：<li>on：更新 Cookie 并校验；</li><li>off：仅校验。</li>
        /// </summary>
        [JsonProperty("IssueNewBotSessionCookie")]
        public string IssueNewBotSessionCookie{ get; set; }

        /// <summary>
        /// 更新 Cookie 并校验时的触发阈值，仅当 IssueNewBotSessionCookie 为 on 时有效。
        /// </summary>
        [JsonProperty("MaxNewSessionTriggerConfig")]
        public MaxNewSessionTriggerConfig MaxNewSessionTriggerConfig{ get; set; }

        /// <summary>
        /// 未携带 Cookie 或 Cookie 已过期的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("SessionExpiredAction")]
        public SecurityAction SessionExpiredAction{ get; set; }

        /// <summary>
        /// 不合法 Cookie 的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("SessionInvalidAction")]
        public SecurityAction SessionInvalidAction{ get; set; }

        /// <summary>
        /// 会话速率和周期特征校验的具体配置。
        /// </summary>
        [JsonProperty("SessionRateControl")]
        public SessionRateControl SessionRateControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IssueNewBotSessionCookie", this.IssueNewBotSessionCookie);
            this.SetParamObj(map, prefix + "MaxNewSessionTriggerConfig.", this.MaxNewSessionTriggerConfig);
            this.SetParamObj(map, prefix + "SessionExpiredAction.", this.SessionExpiredAction);
            this.SetParamObj(map, prefix + "SessionInvalidAction.", this.SessionInvalidAction);
            this.SetParamObj(map, prefix + "SessionRateControl.", this.SessionRateControl);
        }
    }
}

