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

    public class ModifyNatGatewayAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT网关的ID，形如：`nat-df45454`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// NAT网关的名称，形如：`test_nat`。
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// NAT网关最大外网出带宽(单位:Mbps)。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 是否修改NAT网关绑定的安全组。
        /// </summary>
        [JsonProperty("ModifySecurityGroup")]
        public bool? ModifySecurityGroup{ get; set; }

        /// <summary>
        /// NAT网关绑定的安全组列表，最终状态，空列表表示删除所有安全组，形如: `['sg-1n232323', 'sg-o4242424']`
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// NAT实例是否开启删除保护
        /// </summary>
        [JsonProperty("DeletionProtectionEnabled")]
        public bool? DeletionProtectionEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "ModifySecurityGroup", this.ModifySecurityGroup);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "DeletionProtectionEnabled", this.DeletionProtectionEnabled);
        }
    }
}

