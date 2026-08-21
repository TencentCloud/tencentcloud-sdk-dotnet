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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityScoreOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>安全评分<br>取值范围：[0, 100]</p>
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// <p>安全等级<br>枚举值：<br>safe：安全(90-100分)<br>good：良好(70-89分)<br>medium：一般(40-69分)<br>danger：危险(0-39分)</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>评分状态<br>枚举值：<br>success：全部数据源正常<br>partial_error：部分数据源使用了缓存<br>stale：使用上次完整快照<br>error：无法计算</p>
        /// </summary>
        [JsonProperty("ScoreStatus")]
        public string ScoreStatus{ get; set; }

        /// <summary>
        /// <p>初始分<br>默认值：100</p>
        /// </summary>
        [JsonProperty("InitialScore")]
        public long? InitialScore{ get; set; }

        /// <summary>
        /// <p>存在风险的分类数量（X类风险建议尽快处理）</p>
        /// </summary>
        [JsonProperty("RiskCategoryCount")]
        public long? RiskCategoryCount{ get; set; }

        /// <summary>
        /// <p>总扣分</p>
        /// </summary>
        [JsonProperty("DeductScore")]
        public long? DeductScore{ get; set; }

        /// <summary>
        /// <p>计算时间<br>参数格式：YYYY-MM-DDTHH:mm:ss+08:00</p>
        /// </summary>
        [JsonProperty("CalculatedAt")]
        public string CalculatedAt{ get; set; }

        /// <summary>
        /// <p>维度明细，含子项扣分和待办</p>
        /// </summary>
        [JsonProperty("Dimensions")]
        public DimensionItem[] Dimensions{ get; set; }

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
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ScoreStatus", this.ScoreStatus);
            this.SetParamSimple(map, prefix + "InitialScore", this.InitialScore);
            this.SetParamSimple(map, prefix + "RiskCategoryCount", this.RiskCategoryCount);
            this.SetParamSimple(map, prefix + "DeductScore", this.DeductScore);
            this.SetParamSimple(map, prefix + "CalculatedAt", this.CalculatedAt);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

