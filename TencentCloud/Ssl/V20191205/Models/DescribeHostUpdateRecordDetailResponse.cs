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

    public class DescribeHostUpdateRecordDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 总数,如果取不到返回0
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 证书部署记录列表，如果取不到值返回空数组
        /// </summary>
        [JsonProperty("RecordDetailList")]
        public UpdateRecordDetails[] RecordDetailList{ get; set; }

        /// <summary>
        /// 成功总数,如果取不到返回0
        /// </summary>
        [JsonProperty("SuccessTotalCount")]
        public long? SuccessTotalCount{ get; set; }

        /// <summary>
        /// 失败总数,如果取不到返回0
        /// </summary>
        [JsonProperty("FailedTotalCount")]
        public long? FailedTotalCount{ get; set; }

        /// <summary>
        /// 部署中总数,如果取不到返回0
        /// </summary>
        [JsonProperty("RunningTotalCount")]
        public long? RunningTotalCount{ get; set; }

        /// <summary>
        /// 待部署总数
        /// </summary>
        [JsonProperty("PendingTotalCount")]
        public long? PendingTotalCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "RecordDetailList.", this.RecordDetailList);
            this.SetParamSimple(map, prefix + "SuccessTotalCount", this.SuccessTotalCount);
            this.SetParamSimple(map, prefix + "FailedTotalCount", this.FailedTotalCount);
            this.SetParamSimple(map, prefix + "RunningTotalCount", this.RunningTotalCount);
            this.SetParamSimple(map, prefix + "PendingTotalCount", this.PendingTotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

