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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IncrementalMigrationHttpOriginConfig : AbstractModel
    {
        
        /// <summary>
        /// 回源源站信息。
        /// </summary>
        [JsonProperty("OriginInfo")]
        public IncrementalMigrationHttpOriginInfo OriginInfo{ get; set; }

        /// <summary>
        /// 回源参数。
        /// </summary>
        [JsonProperty("OriginParameter")]
        public IncrementalMigrationHttpOriginParameter OriginParameter{ get; set; }

        /// <summary>
        /// 回源模式。取值有：
        /// <li>SYNC：同步回源；</li>
        /// <li>ASYNC：异步回源。</li>若不填，默认取 `SYNC` 同步回源。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 回源条件。
        /// </summary>
        [JsonProperty("OriginCondition")]
        public IncrementalMigrationHttpOriginCondition OriginCondition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "OriginInfo.", this.OriginInfo);
            this.SetParamObj(map, prefix + "OriginParameter.", this.OriginParameter);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "OriginCondition.", this.OriginCondition);
        }
    }
}

