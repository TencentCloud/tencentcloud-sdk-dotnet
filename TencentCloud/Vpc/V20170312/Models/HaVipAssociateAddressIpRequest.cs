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

    public class HaVipAssociateAddressIpRequest : AbstractModel
    {
        
        /// <summary>
        /// `HAVIP`唯一`ID`，形如：`havip-9o233uri`。必须是没有绑定`EIP`的`HAVIP`
        /// </summary>
        [JsonProperty("HaVipId")]
        public string HaVipId{ get; set; }

        /// <summary>
        /// 弹性公网`IP`。必须是没有绑定`HAVIP`的`EIP`
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HaVipId", this.HaVipId);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
        }
    }
}

