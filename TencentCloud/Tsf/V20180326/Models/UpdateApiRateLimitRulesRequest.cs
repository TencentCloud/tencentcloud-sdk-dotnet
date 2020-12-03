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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateApiRateLimitRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// API ID 列表
        /// </summary>
        [JsonProperty("ApiIds")]
        public string[] ApiIds{ get; set; }

        /// <summary>
        /// 开启/禁用，enabled/disabled
        /// </summary>
        [JsonProperty("UsableStatus")]
        public string UsableStatus{ get; set; }

        /// <summary>
        /// QPS值。开启限流规则时，必填
        /// </summary>
        [JsonProperty("MaxQps")]
        public long? MaxQps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ApiIds.", this.ApiIds);
            this.SetParamSimple(map, prefix + "UsableStatus", this.UsableStatus);
            this.SetParamSimple(map, prefix + "MaxQps", this.MaxQps);
        }
    }
}

