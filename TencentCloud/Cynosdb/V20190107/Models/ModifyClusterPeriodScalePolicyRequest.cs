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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterPeriodScalePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>当天开始弹性时间。格式是小时:分钟</p>
        /// </summary>
        [JsonProperty("ScaleStartTime")]
        public string ScaleStartTime{ get; set; }

        /// <summary>
        /// <p>当天结束弹性时间。格式是小时:分钟</p>
        /// </summary>
        [JsonProperty("ScaleEndTime")]
        public string ScaleEndTime{ get; set; }

        /// <summary>
        /// <p>策略生效的起始日期时间</p>
        /// </summary>
        [JsonProperty("PolicyStartTime")]
        public string PolicyStartTime{ get; set; }

        /// <summary>
        /// <p>策略生效的截止日期时间</p>
        /// </summary>
        [JsonProperty("PolicyEndTime")]
        public string PolicyEndTime{ get; set; }

        /// <summary>
        /// <p>周期类型。day-天，week-周，month-月。</p>
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// <p>周期内的时间列表。针对PeriodType=week， 表示星期几，比如[1,3]表示星期一、星期三。同理，对于PeriodType=month，[1,3,10]表示每月的1、3、10号。PeriodType=day则该字段无效。</p>
        /// </summary>
        [JsonProperty("PeriodConfig")]
        public long?[] PeriodConfig{ get; set; }

        /// <summary>
        /// <p>弹性规格下限</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>弹性规格上限</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "ScaleStartTime", this.ScaleStartTime);
            this.SetParamSimple(map, prefix + "ScaleEndTime", this.ScaleEndTime);
            this.SetParamSimple(map, prefix + "PolicyStartTime", this.PolicyStartTime);
            this.SetParamSimple(map, prefix + "PolicyEndTime", this.PolicyEndTime);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamArraySimple(map, prefix + "PeriodConfig.", this.PeriodConfig);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
        }
    }
}

