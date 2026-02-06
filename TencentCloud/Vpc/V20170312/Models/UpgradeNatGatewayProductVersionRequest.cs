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

    public class UpgradeNatGatewayProductVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。可通过DescribeVpcs接口返回值中的VpcId获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// NAT网关的ID，形如：`nat-ig8xpno8`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 是否热迁移。1表示冷迁移，0表示热迁移，默认值是0。
        /// </summary>
        [JsonProperty("Force")]
        public long? Force{ get; set; }

        /// <summary>
        /// 是否仅校验迁移可能性。true表示仅校验能否迁移，不做实际迁移。false表示正常迁移。默认值为false。
        /// 仅校验模式，不报错表示校验迁移成功。
        /// </summary>
        [JsonProperty("CheckOnlyMode")]
        public bool? CheckOnlyMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamSimple(map, prefix + "CheckOnlyMode", this.CheckOnlyMode);
        }
    }
}

