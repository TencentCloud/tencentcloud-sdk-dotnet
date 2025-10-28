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

    public class SessionRateControl : AbstractModel
    {
        
        /// <summary>
        /// 会话速率和周期特征校验配置是否开启。取值有：<li>on：启用</li><li>off：关闭</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// 会话速率和周期特征校验高风险的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("HighRateSessionAction")]
        public SecurityAction HighRateSessionAction{ get; set; }

        /// <summary>
        /// 会话速率和周期特征校验中风险的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("MidRateSessionAction")]
        public SecurityAction MidRateSessionAction{ get; set; }

        /// <summary>
        /// 会话速率和周期特征校验低风险的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("LowRateSessionAction")]
        public SecurityAction LowRateSessionAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "HighRateSessionAction.", this.HighRateSessionAction);
            this.SetParamObj(map, prefix + "MidRateSessionAction.", this.MidRateSessionAction);
            this.SetParamObj(map, prefix + "LowRateSessionAction.", this.LowRateSessionAction);
        }
    }
}

