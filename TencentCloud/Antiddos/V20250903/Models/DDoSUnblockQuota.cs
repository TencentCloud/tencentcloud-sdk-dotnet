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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSUnblockQuota : AbstractModel
    {
        
        /// <summary>
        /// <p>解封次数配额总数。</p>
        /// </summary>
        [JsonProperty("TotalQuota")]
        public ulong? TotalQuota{ get; set; }

        /// <summary>
        /// <p>已使用的配额总数。</p>
        /// </summary>
        [JsonProperty("UsedQuota")]
        public ulong? UsedQuota{ get; set; }

        /// <summary>
        /// <p>配额生效的起始时间。</p>
        /// </summary>
        [JsonProperty("QuotaStartTime")]
        public string QuotaStartTime{ get; set; }

        /// <summary>
        /// <p>配额生效的结束时间。</p>
        /// </summary>
        [JsonProperty("QuotaEndTime")]
        public string QuotaEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "UsedQuota", this.UsedQuota);
            this.SetParamSimple(map, prefix + "QuotaStartTime", this.QuotaStartTime);
            this.SetParamSimple(map, prefix + "QuotaEndTime", this.QuotaEndTime);
        }
    }
}

