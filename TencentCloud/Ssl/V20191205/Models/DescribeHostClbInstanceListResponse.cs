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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostClbInstanceListResponse : AbstractModel
    {
        
        /// <summary>
        /// 总数，取不到值返回0
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// CLB实例监听器列表，取不到值返回空数组
        /// </summary>
        [JsonProperty("InstanceList")]
        public ClbInstanceDetail[] InstanceList{ get; set; }

        /// <summary>
        /// 异步刷新总数，取不到值返回0
        /// </summary>
        [JsonProperty("AsyncTotalNum")]
        public long? AsyncTotalNum{ get; set; }

        /// <summary>
        /// 异步刷新当前执行数，取不到值返回0
        /// </summary>
        [JsonProperty("AsyncOffset")]
        public long? AsyncOffset{ get; set; }

        /// <summary>
        /// 当前缓存读取时间，去不到值返回空
        /// </summary>
        [JsonProperty("AsyncCacheTime")]
        public string AsyncCacheTime{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "InstanceList.", this.InstanceList);
            this.SetParamSimple(map, prefix + "AsyncTotalNum", this.AsyncTotalNum);
            this.SetParamSimple(map, prefix + "AsyncOffset", this.AsyncOffset);
            this.SetParamSimple(map, prefix + "AsyncCacheTime", this.AsyncCacheTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

