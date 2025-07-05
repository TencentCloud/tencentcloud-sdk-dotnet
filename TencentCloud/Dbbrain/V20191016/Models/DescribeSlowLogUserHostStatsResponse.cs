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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowLogUserHostStatsResponse : AbstractModel
    {
        
        /// <summary>
        /// 来源地址数目。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 各来源地址的慢日志占比详情列表。
        /// </summary>
        [JsonProperty("Items")]
        public SlowLogHost[] Items{ get; set; }

        /// <summary>
        /// 各来源用户名的慢日志占比详情列表。
        /// </summary>
        [JsonProperty("UserNameItems")]
        public SlowLogUser[] UserNameItems{ get; set; }

        /// <summary>
        /// 来源用户数目。
        /// </summary>
        [JsonProperty("UserTotalCount")]
        public long? UserTotalCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamArrayObj(map, prefix + "UserNameItems.", this.UserNameItems);
            this.SetParamSimple(map, prefix + "UserTotalCount", this.UserTotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

