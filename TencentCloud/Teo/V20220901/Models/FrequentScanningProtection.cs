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

    public class FrequentScanningProtection : AbstractModel
    {
        
        /// <summary>
        /// 高频扫描防护规则是否开启。取值有：<li>on：开启，高频扫描防护规则生效；</li><li>off：关闭，高频扫描防护规则不生效。</li>	
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// 高频扫描防护的处置动作。 当 Enabled 为 on 时，此字段必填。SecurityAction 的 Name 取值支持：<li>Deny：拦截，响应拦截页面；</li><li>Monitor：观察，不处理请求记录安全事件到日志中；</li><li>JSChallenge：JavaScript 挑战，响应 JavaScript 挑战页面。</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// 请求统计的匹配方式，当 Enabled 为 on 时，此字段必填。取值有：<li>http.request.xff_header_ip：客户端 IP（优先匹配 XFF 头部）；</li><li>http.request.ip：客户端 IP。</li> 
        /// </summary>
        [JsonProperty("CountBy")]
        public string CountBy{ get; set; }

        /// <summary>
        /// 此参数指定高频扫描防护的阈值，即在 CountingPeriod 所设置时间范围内命中「配置为拦截」的托管规则时的累计拦截次数，取值范围 1 ~ 4294967294，例如 100，当超过此统计值时，后续请求将触发 Action 所设置的处置动作。当 Enabled 为 on 时，此字段必填。
        /// </summary>
        [JsonProperty("BlockThreshold")]
        public long? BlockThreshold{ get; set; }

        /// <summary>
        /// 此参数指定高频扫描防护所统计的时间窗口，即命中「配置为拦截」的托管规则的请求的统计时间窗口，取值 5 ~ 1800，单位仅支持秒（s），例如 5s。 当 Enabled 为 on 时，此字段必填。
        /// </summary>
        [JsonProperty("CountingPeriod")]
        public string CountingPeriod{ get; set; }

        /// <summary>
        /// 此参数指定高频扫描防护 Action 参数所设置处置动作的持续时长，取值范围 60 ~ 86400，单位仅支持秒（s），例如 60s。当 Enabled 为 on 时，此字段必填。
        /// </summary>
        [JsonProperty("ActionDuration")]
        public string ActionDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "CountBy", this.CountBy);
            this.SetParamSimple(map, prefix + "BlockThreshold", this.BlockThreshold);
            this.SetParamSimple(map, prefix + "CountingPeriod", this.CountingPeriod);
            this.SetParamSimple(map, prefix + "ActionDuration", this.ActionDuration);
        }
    }
}

