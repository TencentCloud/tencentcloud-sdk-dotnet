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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetVpnGatewaysRenewFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// VPNGW字符型ID列表
        /// </summary>
        [JsonProperty("VpnGatewayIds")]
        public string[] VpnGatewayIds{ get; set; }

        /// <summary>
        /// 自动续费标记[0, 1, 2]
        /// 0表示默认状态(初始状态)， 1表示自动续费，2表示明确不自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// VPNGW类型['IPSEC', 'SSL']
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "VpnGatewayIds.", this.VpnGatewayIds);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

