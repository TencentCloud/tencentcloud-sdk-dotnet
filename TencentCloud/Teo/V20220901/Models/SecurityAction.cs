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

    public class SecurityAction : AbstractModel
    {
        
        /// <summary>
        /// 安全执行的具体动作。取值有：
        /// <li>Deny：拦截，阻止请求访问站点资源；</li>
        /// <li>Monitor：观察，仅记录日志；</li>
        /// <li>Redirect：重定向至 URL；</li>
        /// <li>Disabled：未启用，不启用指定规则；</li>
        /// <li>Allow：允许访问，但延迟处理请求；</li>
        /// <li>Challenge：挑战，响应挑战内容；</li>
        /// <li>Trans：放行，允许请求直接访问站点资源；</li>
        /// <li>BlockIP：待废弃，IP 封禁；</li>
        /// <li>ReturnCustomPage：待废弃，使用指定页面拦截；</li>
        /// <li>JSChallenge：待废弃，JavaScript 挑战；</li>
        /// <li>ManagedChallenge：待废弃，托管挑战。</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 当 Name 为 Deny 时的附加参数。
        /// </summary>
        [JsonProperty("DenyActionParameters")]
        public DenyActionParameters DenyActionParameters{ get; set; }

        /// <summary>
        /// 当 Name 为 Redirect 时的附加参数。
        /// </summary>
        [JsonProperty("RedirectActionParameters")]
        public RedirectActionParameters RedirectActionParameters{ get; set; }

        /// <summary>
        /// 当 Name 为 Allow 时的附加参数。
        /// </summary>
        [JsonProperty("AllowActionParameters")]
        public AllowActionParameters AllowActionParameters{ get; set; }

        /// <summary>
        /// 当 Name 为 Challenge 时的附加参数。
        /// </summary>
        [JsonProperty("ChallengeActionParameters")]
        public ChallengeActionParameters ChallengeActionParameters{ get; set; }

        /// <summary>
        /// 待废弃，当 Name 为 BlockIP 时的附加参数。
        /// </summary>
        [JsonProperty("BlockIPActionParameters")]
        public BlockIPActionParameters BlockIPActionParameters{ get; set; }

        /// <summary>
        /// 待废弃，当 Name 为 ReturnCustomPage 时的附加参数。
        /// </summary>
        [JsonProperty("ReturnCustomPageActionParameters")]
        public ReturnCustomPageActionParameters ReturnCustomPageActionParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "DenyActionParameters.", this.DenyActionParameters);
            this.SetParamObj(map, prefix + "RedirectActionParameters.", this.RedirectActionParameters);
            this.SetParamObj(map, prefix + "AllowActionParameters.", this.AllowActionParameters);
            this.SetParamObj(map, prefix + "ChallengeActionParameters.", this.ChallengeActionParameters);
            this.SetParamObj(map, prefix + "BlockIPActionParameters.", this.BlockIPActionParameters);
            this.SetParamObj(map, prefix + "ReturnCustomPageActionParameters.", this.ReturnCustomPageActionParameters);
        }
    }
}

