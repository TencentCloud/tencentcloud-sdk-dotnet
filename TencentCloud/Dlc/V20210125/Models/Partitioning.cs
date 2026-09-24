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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Partitioning : AbstractModel
    {
        
        /// <summary>
        /// <p>转换策略</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// <p>按年分区策略</p>
        /// </summary>
        [JsonProperty("YearPartitioning")]
        public SingleFieldPartitioning YearPartitioning{ get; set; }

        /// <summary>
        /// <p>按月分区策略</p>
        /// </summary>
        [JsonProperty("MonthPartitioning")]
        public SingleFieldPartitioning MonthPartitioning{ get; set; }

        /// <summary>
        /// <p>按天分区策略</p>
        /// </summary>
        [JsonProperty("DayPartitioning")]
        public SingleFieldPartitioning DayPartitioning{ get; set; }

        /// <summary>
        /// <p>按小时分区策略</p>
        /// </summary>
        [JsonProperty("HourPartitioning")]
        public SingleFieldPartitioning HourPartitioning{ get; set; }

        /// <summary>
        /// <p>按字段分区策略</p>
        /// </summary>
        [JsonProperty("IdentityPartitioning")]
        public SingleFieldPartitioning IdentityPartitioning{ get; set; }

        /// <summary>
        /// <p>列表分区策略</p>
        /// </summary>
        [JsonProperty("ListPartitioning")]
        public ListPartitioning ListPartitioning{ get; set; }

        /// <summary>
        /// <p>范围分区策略</p>
        /// </summary>
        [JsonProperty("RangePartitioning")]
        public RangePartitioning RangePartitioning{ get; set; }

        /// <summary>
        /// <p>分桶分区策略</p>
        /// </summary>
        [JsonProperty("BucketPartitioning")]
        public BucketPartitioning BucketPartitioning{ get; set; }

        /// <summary>
        /// <p>截断分区策略</p>
        /// </summary>
        [JsonProperty("TruncatePartitioning")]
        public TruncatePartitioning TruncatePartitioning{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamObj(map, prefix + "YearPartitioning.", this.YearPartitioning);
            this.SetParamObj(map, prefix + "MonthPartitioning.", this.MonthPartitioning);
            this.SetParamObj(map, prefix + "DayPartitioning.", this.DayPartitioning);
            this.SetParamObj(map, prefix + "HourPartitioning.", this.HourPartitioning);
            this.SetParamObj(map, prefix + "IdentityPartitioning.", this.IdentityPartitioning);
            this.SetParamObj(map, prefix + "ListPartitioning.", this.ListPartitioning);
            this.SetParamObj(map, prefix + "RangePartitioning.", this.RangePartitioning);
            this.SetParamObj(map, prefix + "BucketPartitioning.", this.BucketPartitioning);
            this.SetParamObj(map, prefix + "TruncatePartitioning.", this.TruncatePartitioning);
        }
    }
}

