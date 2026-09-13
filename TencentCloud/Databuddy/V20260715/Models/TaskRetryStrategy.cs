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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskRetryStrategy : AbstractModel
    {
        
        /// <summary>
        /// 最多重试次数，默认3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRetryTimes")]
        public long? MaxRetryTimes{ get; set; }

        /// <summary>
        /// 重试之间等待时间，默认5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryBetweenWaitTime")]
        public long? RetryBetweenWaitTime{ get; set; }

        /// <summary>
        /// 重试之间等待时间单位
        /// 毫秒：MILLISECOND秒：SECOND分钟（默认）：MINUTE小时：HOUR
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryBetweenWaitTimeUnit")]
        public string RetryBetweenWaitTimeUnit{ get; set; }

        /// <summary>
        /// 任务运行失败时重试开关，默认为true
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskRunFailureRetrySwitch")]
        public bool? TaskRunFailureRetrySwitch{ get; set; }

        /// <summary>
        /// 任务运行超时时重试开关，默认为false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskRunTimeoutRetrySwitch")]
        public bool? TaskRunTimeoutRetrySwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxRetryTimes", this.MaxRetryTimes);
            this.SetParamSimple(map, prefix + "RetryBetweenWaitTime", this.RetryBetweenWaitTime);
            this.SetParamSimple(map, prefix + "RetryBetweenWaitTimeUnit", this.RetryBetweenWaitTimeUnit);
            this.SetParamSimple(map, prefix + "TaskRunFailureRetrySwitch", this.TaskRunFailureRetrySwitch);
            this.SetParamSimple(map, prefix + "TaskRunTimeoutRetrySwitch", this.TaskRunTimeoutRetrySwitch);
        }
    }
}

