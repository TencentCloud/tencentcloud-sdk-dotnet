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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWConsumerModelScope : AbstractModel
    {
        
        /// <summary>
        /// <p>消费者模型生效范围类型</p><p>枚举值：</p><ul><li>INHERIT： 继承所在消费者组的生效模型范围</li><li>ALLOWLIST： 自定义白名单，必须 ⊆ 所在组针对该资源的生效模型集合</li></ul>
        /// </summary>
        [JsonProperty("ScopeType")]
        public string ScopeType{ get; set; }

        /// <summary>
        /// <p>模型授权白名单列表</p>
        /// </summary>
        [JsonProperty("AllowList")]
        public string[] AllowList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScopeType", this.ScopeType);
            this.SetParamArraySimple(map, prefix + "AllowList.", this.AllowList);
        }
    }
}

