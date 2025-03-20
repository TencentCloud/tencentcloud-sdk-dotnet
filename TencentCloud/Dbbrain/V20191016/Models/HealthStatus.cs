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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthStatus : AbstractModel
    {
        
        /// <summary>
        /// 健康分数，满分100。
        /// </summary>
        [JsonProperty("HealthScore")]
        public long? HealthScore{ get; set; }

        /// <summary>
        /// 健康等级，取值包括："HEALTH" - 健康；"SUB_HEALTH" - 亚健康；"RISK"- 危险；"HIGH_RISK" - 高危。
        /// </summary>
        [JsonProperty("HealthLevel")]
        public string HealthLevel{ get; set; }

        /// <summary>
        /// 总扣分分数。
        /// </summary>
        [JsonProperty("ScoreLost")]
        public long? ScoreLost{ get; set; }

        /// <summary>
        /// 扣分详情。
        /// </summary>
        [JsonProperty("ScoreDetails")]
        public ScoreDetail[] ScoreDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthScore", this.HealthScore);
            this.SetParamSimple(map, prefix + "HealthLevel", this.HealthLevel);
            this.SetParamSimple(map, prefix + "ScoreLost", this.ScoreLost);
            this.SetParamArrayObj(map, prefix + "ScoreDetails.", this.ScoreDetails);
        }
    }
}

