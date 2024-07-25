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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReservedInstanceUtilizationRateResponse : AbstractModel
    {
        
        /// <summary>
        /// 预留券使用率
        /// </summary>
        [JsonProperty("UtilizationRateSet")]
        public ReservedInstanceUtilizationRate[] UtilizationRateSet{ get; set; }

        /// <summary>
        /// 按量计费的 Pod 总数
        /// </summary>
        [JsonProperty("PodNum")]
        public ulong? PodNum{ get; set; }

        /// <summary>
        ///  Pod 被预留券抵扣的抵扣率
        /// </summary>
        [JsonProperty("PodRate")]
        public float? PodRate{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "UtilizationRateSet.", this.UtilizationRateSet);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
            this.SetParamSimple(map, prefix + "PodRate", this.PodRate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

