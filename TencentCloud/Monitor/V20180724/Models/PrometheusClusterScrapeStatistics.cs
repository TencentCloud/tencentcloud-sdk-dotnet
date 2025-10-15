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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusClusterScrapeStatistics : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 被采集的点数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScrapedRate")]
        public float? ScrapedRate{ get; set; }

        /// <summary>
        /// Job列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Jobs")]
        public PrometheusJobScrapeStatistics[] Jobs{ get; set; }

        /// <summary>
        /// 过滤前的指标采集速率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SamplesRate")]
        public float? SamplesRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ScrapedRate", this.ScrapedRate);
            this.SetParamArrayObj(map, prefix + "Jobs.", this.Jobs);
            this.SetParamSimple(map, prefix + "SamplesRate", this.SamplesRate);
        }
    }
}

