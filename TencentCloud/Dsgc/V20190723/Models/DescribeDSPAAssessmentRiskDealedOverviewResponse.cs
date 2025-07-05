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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDSPAAssessmentRiskDealedOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 遗留待处理风险总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 昨日完成风险处置数
        /// </summary>
        [JsonProperty("YesterdayDealedCount")]
        public ulong? YesterdayDealedCount{ get; set; }

        /// <summary>
        /// 遗留待处理风险数周同比
        /// </summary>
        [JsonProperty("UnDealedRiskWeekRatio")]
        public float? UnDealedRiskWeekRatio{ get; set; }

        /// <summary>
        /// 遗留待处理风险数日环比
        /// </summary>
        [JsonProperty("UnDealedRiskDayRatio")]
        public float? UnDealedRiskDayRatio{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "YesterdayDealedCount", this.YesterdayDealedCount);
            this.SetParamSimple(map, prefix + "UnDealedRiskWeekRatio", this.UnDealedRiskWeekRatio);
            this.SetParamSimple(map, prefix + "UnDealedRiskDayRatio", this.UnDealedRiskDayRatio);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

