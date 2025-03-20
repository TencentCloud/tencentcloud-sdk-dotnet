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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityAction : AbstractModel
    {
        
        /// <summary>
        /// 安全执行的具体动作。取值有：
        /// <li>Deny：拦截；</li><li>Monitor：观察；</li><li>ReturnCustomPage：使用指定页面拦截；</li><li>Redirect：重定向至 URL；</li><li>BlockIP：IP 封禁；</li><li>JSChallenge：JavaScript 挑战；</li><li>ManagedChallenge：托管挑战；</li><li>Disabled：未启用；</li><li>Allow：放行。</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 当 Name 为 BlockIP 时的附加参数。
        /// </summary>
        [JsonProperty("BlockIPActionParameters")]
        public BlockIPActionParameters BlockIPActionParameters{ get; set; }

        /// <summary>
        /// 当 Name 为 ReturnCustomPage 时的附加参数。
        /// </summary>
        [JsonProperty("ReturnCustomPageActionParameters")]
        public ReturnCustomPageActionParameters ReturnCustomPageActionParameters{ get; set; }

        /// <summary>
        /// 当 Name 为 Redirect 时的附加参数。
        /// </summary>
        [JsonProperty("RedirectActionParameters")]
        public RedirectActionParameters RedirectActionParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "BlockIPActionParameters.", this.BlockIPActionParameters);
            this.SetParamObj(map, prefix + "ReturnCustomPageActionParameters.", this.ReturnCustomPageActionParameters);
            this.SetParamObj(map, prefix + "RedirectActionParameters.", this.RedirectActionParameters);
        }
    }
}

