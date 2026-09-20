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

    public class DescribeQuotaOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>主账号配额上限及全账号当前用量</p>
        /// </summary>
        [JsonProperty("AccountQuotaOverview")]
        public AccountQuotaOverview AccountQuotaOverview{ get; set; }

        /// <summary>
        /// <p>当前分页下的配额组配额与用量列表。没有数据时返回空数组。</p>
        /// </summary>
        [JsonProperty("QuotaGroupSet")]
        public QuotaGroupOverview[] QuotaGroupSet{ get; set; }

        /// <summary>
        /// <p>满足过滤条件的配额组总数，不受当前分页大小影响。</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>本次查询完成时间，格式为 RFC3339</p>
        /// </summary>
        [JsonProperty("DataTime")]
        public string DataTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AccountQuotaOverview.", this.AccountQuotaOverview);
            this.SetParamArrayObj(map, prefix + "QuotaGroupSet.", this.QuotaGroupSet);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

