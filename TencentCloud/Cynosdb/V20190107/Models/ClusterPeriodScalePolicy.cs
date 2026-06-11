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

    public class ClusterPeriodScalePolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>实例类型。rw-读写类型，ro-只读类型。</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>弹性下限, 后续废弃, 请使用MinCcu</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>弹性上限,后续废弃，请使用MaxCcu</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>弹性开始时间</p>
        /// </summary>
        [JsonProperty("ScaleStartTime")]
        public string ScaleStartTime{ get; set; }

        /// <summary>
        /// <p>弹性结束时间</p>
        /// </summary>
        [JsonProperty("ScaleEndTime")]
        public string ScaleEndTime{ get; set; }

        /// <summary>
        /// <p>策略有效起始日期时间</p>
        /// </summary>
        [JsonProperty("PolicyStartTime")]
        public string PolicyStartTime{ get; set; }

        /// <summary>
        /// <p>策略有效截止日期时间</p>
        /// </summary>
        [JsonProperty("PolicyEndTime")]
        public string PolicyEndTime{ get; set; }

        /// <summary>
        /// <p>周期类型。day-天， week-星期，month-月</p>
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// <p>在周期内的时间配置。对于week，表示星期几；对于month，表示几号。对于day，此参数不生效。</p>
        /// </summary>
        [JsonProperty("PeriodConfig")]
        public long?[] PeriodConfig{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>策略状态。normal-正常，expired-过期, deleted-删除</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "ScaleStartTime", this.ScaleStartTime);
            this.SetParamSimple(map, prefix + "ScaleEndTime", this.ScaleEndTime);
            this.SetParamSimple(map, prefix + "PolicyStartTime", this.PolicyStartTime);
            this.SetParamSimple(map, prefix + "PolicyEndTime", this.PolicyEndTime);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamArraySimple(map, prefix + "PeriodConfig.", this.PeriodConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

