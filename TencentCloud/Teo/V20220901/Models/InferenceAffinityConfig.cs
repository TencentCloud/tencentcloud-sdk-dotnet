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

    public class InferenceAffinityConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>推理服务亲和总开关。</p><p>枚举值：</p><ul><li>On： 开启推理服务亲和；</li><li>Off： 关闭推理服务亲和。</li></ul>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>推理服务亲和方式。</p><p>枚举值：</p><ul><li>SessionId： 根据会话 ID 实现亲和。</li></ul><p>默认值：SessionId。</p>
        /// </summary>
        [JsonProperty("AffinityMode")]
        public string AffinityMode{ get; set; }

        /// <summary>
        /// <p>推理服务亲和性配置。当 AffinityMode 为 SessionId 时必填。</p>
        /// </summary>
        [JsonProperty("SessionIdAffinityConfig")]
        public SessionIdAffinityConfig SessionIdAffinityConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "AffinityMode", this.AffinityMode);
            this.SetParamObj(map, prefix + "SessionIdAffinityConfig.", this.SessionIdAffinityConfig);
        }
    }
}

