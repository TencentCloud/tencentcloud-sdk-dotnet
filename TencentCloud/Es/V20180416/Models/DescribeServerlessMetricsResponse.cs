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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServerlessMetricsResponse : AbstractModel
    {
        
        /// <summary>
        /// storage指标值，单位byte
        /// </summary>
        [JsonProperty("Storage")]
        public float? Storage{ get; set; }

        /// <summary>
        /// IndexTraffic指标值，单位byte
        /// </summary>
        [JsonProperty("IndexTraffic")]
        public float? IndexTraffic{ get; set; }

        /// <summary>
        /// 读请求数，单位次数
        /// </summary>
        [JsonProperty("ReadReqTimes")]
        public long? ReadReqTimes{ get; set; }

        /// <summary>
        /// 写请求数，单位次数
        /// </summary>
        [JsonProperty("WriteReqTimes")]
        public long? WriteReqTimes{ get; set; }

        /// <summary>
        /// 文档数量，单位个数
        /// </summary>
        [JsonProperty("DocCount")]
        public long? DocCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "IndexTraffic", this.IndexTraffic);
            this.SetParamSimple(map, prefix + "ReadReqTimes", this.ReadReqTimes);
            this.SetParamSimple(map, prefix + "WriteReqTimes", this.WriteReqTimes);
            this.SetParamSimple(map, prefix + "DocCount", this.DocCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

