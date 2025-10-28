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

    public class SourceIDC : AbstractModel
    {
        
        /// <summary>
        /// 来自指定 IDC 请求的处置方式。 SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Disabled：未启用，不启用指定规则；</li><li>Challenge：挑战，其中 ChallengeActionParameters 中的 ChallengeOption 支持 JSChallenge 和 ManagedChallenge；</li><li>Allow：放行（待废弃）。</li>
        /// </summary>
        [JsonProperty("BaseAction")]
        public SecurityAction BaseAction{ get; set; }

        /// <summary>
        /// 指定 IDC 请求的处置方式。
        /// </summary>
        [JsonProperty("BotManagementActionOverrides")]
        public BotManagementActionOverrides[] BotManagementActionOverrides{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BaseAction.", this.BaseAction);
            this.SetParamArrayObj(map, prefix + "BotManagementActionOverrides.", this.BotManagementActionOverrides);
        }
    }
}

