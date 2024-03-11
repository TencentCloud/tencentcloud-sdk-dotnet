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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRollbackTimeValidityResponse : AbstractModel
    {
        
        /// <summary>
        /// 存储poolID
        /// </summary>
        [JsonProperty("PoolId")]
        public ulong? PoolId{ get; set; }

        /// <summary>
        /// 回滚任务ID，后续按该时间点回滚时，需要传入
        /// </summary>
        [JsonProperty("QueryId")]
        public ulong? QueryId{ get; set; }

        /// <summary>
        /// 时间点是否有效：pass，检测通过；fail，检测失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 建议时间点，在Status为fail时，该值才有效
        /// </summary>
        [JsonProperty("SuggestTime")]
        public string SuggestTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "PoolId", this.PoolId);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SuggestTime", this.SuggestTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

