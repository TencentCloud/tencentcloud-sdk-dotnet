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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListPermissionApplyOrdersResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>申请单列表</p>
        /// </summary>
        [JsonProperty("ApplyOrders")]
        public PermissionApplyOrder[] ApplyOrders{ get; set; }

        /// <summary>
        /// <p>总数</p>
        /// </summary>
        [JsonProperty("TotalCounts")]
        public long? TotalCounts{ get; set; }

        /// <summary>
        /// <p>翻页游标</p>
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// <p>是否还有下一页</p>
        /// </summary>
        [JsonProperty("IsTruncated")]
        public bool? IsTruncated{ get; set; }

        /// <summary>
        /// <p>每页条数</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ApplyOrders.", this.ApplyOrders);
            this.SetParamSimple(map, prefix + "TotalCounts", this.TotalCounts);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "IsTruncated", this.IsTruncated);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

