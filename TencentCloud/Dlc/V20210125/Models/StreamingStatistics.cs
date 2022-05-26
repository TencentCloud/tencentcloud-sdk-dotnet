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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamingStatistics : AbstractModel
    {
        
        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 数据接收器数
        /// </summary>
        [JsonProperty("Receivers")]
        public long? Receivers{ get; set; }

        /// <summary>
        /// 运行中的接收器数
        /// </summary>
        [JsonProperty("NumActiveReceivers")]
        public long? NumActiveReceivers{ get; set; }

        /// <summary>
        /// 不活跃的接收器数
        /// </summary>
        [JsonProperty("NumInactiveReceivers")]
        public long? NumInactiveReceivers{ get; set; }

        /// <summary>
        /// 运行中的批数
        /// </summary>
        [JsonProperty("NumActiveBatches")]
        public long? NumActiveBatches{ get; set; }

        /// <summary>
        /// 待处理的批数
        /// </summary>
        [JsonProperty("NumRetainedCompletedBatches")]
        public long? NumRetainedCompletedBatches{ get; set; }

        /// <summary>
        /// 已完成的批数
        /// </summary>
        [JsonProperty("NumTotalCompletedBatches")]
        public long? NumTotalCompletedBatches{ get; set; }

        /// <summary>
        /// 平均输入速率
        /// </summary>
        [JsonProperty("AverageInputRate")]
        public float? AverageInputRate{ get; set; }

        /// <summary>
        /// 平均等待时长
        /// </summary>
        [JsonProperty("AverageSchedulingDelay")]
        public float? AverageSchedulingDelay{ get; set; }

        /// <summary>
        /// 平均处理时长
        /// </summary>
        [JsonProperty("AverageProcessingTime")]
        public float? AverageProcessingTime{ get; set; }

        /// <summary>
        /// 平均延时
        /// </summary>
        [JsonProperty("AverageTotalDelay")]
        public float? AverageTotalDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Receivers", this.Receivers);
            this.SetParamSimple(map, prefix + "NumActiveReceivers", this.NumActiveReceivers);
            this.SetParamSimple(map, prefix + "NumInactiveReceivers", this.NumInactiveReceivers);
            this.SetParamSimple(map, prefix + "NumActiveBatches", this.NumActiveBatches);
            this.SetParamSimple(map, prefix + "NumRetainedCompletedBatches", this.NumRetainedCompletedBatches);
            this.SetParamSimple(map, prefix + "NumTotalCompletedBatches", this.NumTotalCompletedBatches);
            this.SetParamSimple(map, prefix + "AverageInputRate", this.AverageInputRate);
            this.SetParamSimple(map, prefix + "AverageSchedulingDelay", this.AverageSchedulingDelay);
            this.SetParamSimple(map, prefix + "AverageProcessingTime", this.AverageProcessingTime);
            this.SetParamSimple(map, prefix + "AverageTotalDelay", this.AverageTotalDelay);
        }
    }
}

