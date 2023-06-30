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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGraphDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 开始时间, 会根据数据的统计周期进行取整.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间, 会根据数据的统计周期进行取整.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指标名
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 统计周期(单位秒), 当时间区间为1天内, 统计周期为5分钟; 当时间区间选择为1天以上, 15天以下, 统计周期为1小时; 当时间区间选择为15天以上, 180天以下, 统计周期为1天.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 有效的监控数据, 每个有效监控数据的上报时间可以从时间数组中的对应位置上获取到.
        /// </summary>
        [JsonProperty("Values")]
        public float?[] Values{ get; set; }

        /// <summary>
        /// 时间数据, 标识监控数据Values中的点是哪个时间段上报的.
        /// </summary>
        [JsonProperty("Time")]
        public long?[] Time{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamArraySimple(map, prefix + "Time.", this.Time);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

