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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallInMetrics : AbstractModel
    {
        
        /// <summary>
        /// IVR驻留数量
        /// </summary>
        [JsonProperty("IvrCount")]
        public long? IvrCount{ get; set; }

        /// <summary>
        /// 排队中数量
        /// </summary>
        [JsonProperty("QueueCount")]
        public long? QueueCount{ get; set; }

        /// <summary>
        /// 振铃中数量
        /// </summary>
        [JsonProperty("RingCount")]
        public long? RingCount{ get; set; }

        /// <summary>
        /// 接通中数量
        /// </summary>
        [JsonProperty("AcceptCount")]
        public long? AcceptCount{ get; set; }

        /// <summary>
        /// 客服转接外线中数量
        /// </summary>
        [JsonProperty("TransferOuterCount")]
        public long? TransferOuterCount{ get; set; }

        /// <summary>
        /// 最大排队时长
        /// </summary>
        [JsonProperty("MaxQueueDuration")]
        public long? MaxQueueDuration{ get; set; }

        /// <summary>
        /// 平均排队时长
        /// </summary>
        [JsonProperty("AvgQueueDuration")]
        public long? AvgQueueDuration{ get; set; }

        /// <summary>
        /// 最大振铃时长
        /// </summary>
        [JsonProperty("MaxRingDuration")]
        public long? MaxRingDuration{ get; set; }

        /// <summary>
        /// 平均振铃时长
        /// </summary>
        [JsonProperty("AvgRingDuration")]
        public long? AvgRingDuration{ get; set; }

        /// <summary>
        /// 最大接通时长
        /// </summary>
        [JsonProperty("MaxAcceptDuration")]
        public long? MaxAcceptDuration{ get; set; }

        /// <summary>
        /// 平均接通时长
        /// </summary>
        [JsonProperty("AvgAcceptDuration")]
        public long? AvgAcceptDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IvrCount", this.IvrCount);
            this.SetParamSimple(map, prefix + "QueueCount", this.QueueCount);
            this.SetParamSimple(map, prefix + "RingCount", this.RingCount);
            this.SetParamSimple(map, prefix + "AcceptCount", this.AcceptCount);
            this.SetParamSimple(map, prefix + "TransferOuterCount", this.TransferOuterCount);
            this.SetParamSimple(map, prefix + "MaxQueueDuration", this.MaxQueueDuration);
            this.SetParamSimple(map, prefix + "AvgQueueDuration", this.AvgQueueDuration);
            this.SetParamSimple(map, prefix + "MaxRingDuration", this.MaxRingDuration);
            this.SetParamSimple(map, prefix + "AvgRingDuration", this.AvgRingDuration);
            this.SetParamSimple(map, prefix + "MaxAcceptDuration", this.MaxAcceptDuration);
            this.SetParamSimple(map, prefix + "AvgAcceptDuration", this.AvgAcceptDuration);
        }
    }
}

