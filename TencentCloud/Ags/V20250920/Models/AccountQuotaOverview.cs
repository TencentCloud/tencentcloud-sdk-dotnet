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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountQuotaOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>主账号各资源维度的配额上限</p>
        /// </summary>
        [JsonProperty("Quota")]
        public QuotaResourceInfo Quota{ get; set; }

        /// <summary>
        /// <p>主账号各资源维度的当前用量</p>
        /// </summary>
        [JsonProperty("Usage")]
        public QuotaResourceInfo Usage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Quota.", this.Quota);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
        }
    }
}

