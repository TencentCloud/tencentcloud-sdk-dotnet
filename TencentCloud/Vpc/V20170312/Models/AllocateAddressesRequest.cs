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

    public class AllocateAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// 申请 EIP 数量，默认值为1。
        /// </summary>
        [JsonProperty("AddressCount")]
        public long? AddressCount{ get; set; }

        /// <summary>
        /// 运营商名称，可选值[BGP|CTCC|CMCC|CUCC]，默认BGP。
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// EIP类型，EIP|AnycastEIP，默认EIP。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Anycast发布域，ANYCAST_ZONE_A|ANYCAST_ZONE_B，默认为当前地域可选的任一发布域。
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "AnycastZone", this.AnycastZone);
        }
    }
}

