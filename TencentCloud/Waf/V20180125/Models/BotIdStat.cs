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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotIdStat : AbstractModel
    {
        
        /// <summary>
        /// 模式：观察/拦截/自定义
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// 规则总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 配置观察的规则数
        /// </summary>
        [JsonProperty("MonitorCount")]
        public long? MonitorCount{ get; set; }

        /// <summary>
        /// 配置拦截的规则数
        /// </summary>
        [JsonProperty("InterceptCount")]
        public long? InterceptCount{ get; set; }

        /// <summary>
        /// 配置重定向的规则数
        /// </summary>
        [JsonProperty("RedirectCount")]
        public long? RedirectCount{ get; set; }

        /// <summary>
        /// 配置人机识别的规则数
        /// </summary>
        [JsonProperty("CaptchaCount")]
        public long? CaptchaCount{ get; set; }

        /// <summary>
        /// 全局防护等级
        /// </summary>
        [JsonProperty("ProtectLevel")]
        public string ProtectLevel{ get; set; }

        /// <summary>
        /// 全局重定向路径
        /// </summary>
        [JsonProperty("GlobalRedirect")]
        public string GlobalRedirect{ get; set; }

        /// <summary>
        /// JS挑战的数目
        /// </summary>
        [JsonProperty("JsChallengeCount")]
        public long? JsChallengeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "MonitorCount", this.MonitorCount);
            this.SetParamSimple(map, prefix + "InterceptCount", this.InterceptCount);
            this.SetParamSimple(map, prefix + "RedirectCount", this.RedirectCount);
            this.SetParamSimple(map, prefix + "CaptchaCount", this.CaptchaCount);
            this.SetParamSimple(map, prefix + "ProtectLevel", this.ProtectLevel);
            this.SetParamSimple(map, prefix + "GlobalRedirect", this.GlobalRedirect);
            this.SetParamSimple(map, prefix + "JsChallengeCount", this.JsChallengeCount);
        }
    }
}

