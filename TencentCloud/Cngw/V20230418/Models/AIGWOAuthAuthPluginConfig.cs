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

    public class AIGWOAuthAuthPluginConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>取token的头部名称</p>
        /// </summary>
        [JsonProperty("HeaderNames")]
        public string[] HeaderNames{ get; set; }

        /// <summary>
        /// <p>过期时间</p>
        /// </summary>
        [JsonProperty("TokenExpiration")]
        public long? TokenExpiration{ get; set; }

        /// <summary>
        /// <p>授权范围</p>
        /// </summary>
        [JsonProperty("Scopes")]
        public string[] Scopes{ get; set; }

        /// <summary>
        /// <p>是否强制判断授权范围</p>
        /// </summary>
        [JsonProperty("MandatoryScope")]
        public bool? MandatoryScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HeaderNames.", this.HeaderNames);
            this.SetParamSimple(map, prefix + "TokenExpiration", this.TokenExpiration);
            this.SetParamArraySimple(map, prefix + "Scopes.", this.Scopes);
            this.SetParamSimple(map, prefix + "MandatoryScope", this.MandatoryScope);
        }
    }
}

