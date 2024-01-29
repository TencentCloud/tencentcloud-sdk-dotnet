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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TCHouseXTaskParameter : AbstractModel
    {
        
        /// <summary>
        /// DriverCPU核数
        /// </summary>
        [JsonProperty("DriverCores")]
        public long? DriverCores{ get; set; }

        /// <summary>
        /// ExecutorCPU核数
        /// </summary>
        [JsonProperty("ExecutorCores")]
        public long? ExecutorCores{ get; set; }

        /// <summary>
        /// Executor个数
        /// </summary>
        [JsonProperty("NumExecutors")]
        public long? NumExecutors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DriverCores", this.DriverCores);
            this.SetParamSimple(map, prefix + "ExecutorCores", this.ExecutorCores);
            this.SetParamSimple(map, prefix + "NumExecutors", this.NumExecutors);
        }
    }
}

