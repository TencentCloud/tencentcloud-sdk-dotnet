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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatGatewaysResponse : AbstractModel
    {
        
        /// <summary>
        /// NAT网关对象数组。
        /// </summary>
        [JsonProperty("NatGatewaySet")]
        public NatGateway[] NatGatewaySet{ get; set; }

        /// <summary>
        /// 符合条件的NAT网关对象个数。
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 输出信息详细程度，DETAIL代表输出实例所有信息；COMPACT代表不输出NAT规则和自定义路由，输出实例基本信息、特性开关和EIP信息；SIMPLE代表仅输出实例基本信息和特性开关
        /// </summary>
        [JsonProperty("VerboseLevel")]
        public string VerboseLevel{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "NatGatewaySet.", this.NatGatewaySet);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "VerboseLevel", this.VerboseLevel);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

