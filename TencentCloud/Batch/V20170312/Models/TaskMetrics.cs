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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskMetrics : AbstractModel
    {
        
        /// <summary>
        /// Submitted个数
        /// </summary>
        [JsonProperty("SubmittedCount")]
        public long? SubmittedCount{ get; set; }

        /// <summary>
        /// Pending个数
        /// </summary>
        [JsonProperty("PendingCount")]
        public long? PendingCount{ get; set; }

        /// <summary>
        /// Runnable个数
        /// </summary>
        [JsonProperty("RunnableCount")]
        public long? RunnableCount{ get; set; }

        /// <summary>
        /// Starting个数
        /// </summary>
        [JsonProperty("StartingCount")]
        public long? StartingCount{ get; set; }

        /// <summary>
        /// Running个数
        /// </summary>
        [JsonProperty("RunningCount")]
        public long? RunningCount{ get; set; }

        /// <summary>
        /// Succeed个数
        /// </summary>
        [JsonProperty("SucceedCount")]
        public long? SucceedCount{ get; set; }

        /// <summary>
        /// FailedInterrupted个数
        /// </summary>
        [JsonProperty("FailedInterruptedCount")]
        public long? FailedInterruptedCount{ get; set; }

        /// <summary>
        /// Failed个数
        /// </summary>
        [JsonProperty("FailedCount")]
        public long? FailedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubmittedCount", this.SubmittedCount);
            this.SetParamSimple(map, prefix + "PendingCount", this.PendingCount);
            this.SetParamSimple(map, prefix + "RunnableCount", this.RunnableCount);
            this.SetParamSimple(map, prefix + "StartingCount", this.StartingCount);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamSimple(map, prefix + "SucceedCount", this.SucceedCount);
            this.SetParamSimple(map, prefix + "FailedInterruptedCount", this.FailedInterruptedCount);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
        }
    }
}

