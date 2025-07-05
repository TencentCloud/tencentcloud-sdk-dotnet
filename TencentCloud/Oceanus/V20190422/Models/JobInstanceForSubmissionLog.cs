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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobInstanceForSubmissionLog : AbstractModel
    {
        
        /// <summary>
        /// 实例的Id, 按照启动的时间顺序，从1开始
        /// </summary>
        [JsonProperty("RunningOrderId")]
        public long? RunningOrderId{ get; set; }

        /// <summary>
        /// 作业实例的启动时间
        /// </summary>
        [JsonProperty("JobInstanceStartTime")]
        public string JobInstanceStartTime{ get; set; }

        /// <summary>
        /// 作业实例启动的时间（毫秒）
        /// </summary>
        [JsonProperty("StartingMillis")]
        public long? StartingMillis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunningOrderId", this.RunningOrderId);
            this.SetParamSimple(map, prefix + "JobInstanceStartTime", this.JobInstanceStartTime);
            this.SetParamSimple(map, prefix + "StartingMillis", this.StartingMillis);
        }
    }
}

