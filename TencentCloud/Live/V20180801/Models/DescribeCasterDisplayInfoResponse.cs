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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCasterDisplayInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 导播台状态
        /// 0：停止状态，无预监，无主监 
        /// 1：无预监，有主监 
        /// 2：有预监，无主监 
        /// 3：有预监，有主监
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 预监使用的展示参数。
        /// </summary>
        [JsonProperty("PvwDisplayInfo")]
        public CasterDisplayInfo PvwDisplayInfo{ get; set; }

        /// <summary>
        /// 主监使用的展示参数。
        /// </summary>
        [JsonProperty("PgmDisplayInfo")]
        public CasterDisplayInfo PgmDisplayInfo{ get; set; }

        /// <summary>
        /// 启动直播的时间，值为unix时间戳。
        /// </summary>
        [JsonProperty("StartLiveTime")]
        public ulong? StartLiveTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "PvwDisplayInfo.", this.PvwDisplayInfo);
            this.SetParamObj(map, prefix + "PgmDisplayInfo.", this.PgmDisplayInfo);
            this.SetParamSimple(map, prefix + "StartLiveTime", this.StartLiveTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

