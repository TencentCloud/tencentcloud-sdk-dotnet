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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncMachinesResponse : AbstractModel
    {
        
        /// <summary>
        /// 枚举值有(大写)：NOTASK（没有同步任务），SYNCING（同步中），FINISHED（同步完成）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 最新开始同步时间
        /// </summary>
        [JsonProperty("LatestStartTime")]
        public string LatestStartTime{ get; set; }

        /// <summary>
        /// 最新同步结束时间
        /// </summary>
        [JsonProperty("LatestEndTime")]
        public string LatestEndTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "LatestStartTime", this.LatestStartTime);
            this.SetParamSimple(map, prefix + "LatestEndTime", this.LatestEndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

