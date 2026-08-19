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

    public class BaselineOverviewStatistic : AbstractModel
    {
        
        /// <summary>
        /// <p>当前未通过的检测项总数（含主机和容器集群）。</p>
        /// </summary>
        [JsonProperty("NotPassItemCount")]
        public ulong? NotPassItemCount{ get; set; }

        /// <summary>
        /// <p>未通过检测项按策略分组的统计列表。</p>
        /// </summary>
        [JsonProperty("NotPassItemStatistic")]
        public NotPassItemStatistic[] NotPassItemStatistic{ get; set; }

        /// <summary>
        /// <p>近一年累计已修复的基线风险数量。</p>
        /// </summary>
        [JsonProperty("LastYearFixCount")]
        public ulong? LastYearFixCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotPassItemCount", this.NotPassItemCount);
            this.SetParamArrayObj(map, prefix + "NotPassItemStatistic.", this.NotPassItemStatistic);
            this.SetParamSimple(map, prefix + "LastYearFixCount", this.LastYearFixCount);
        }
    }
}

