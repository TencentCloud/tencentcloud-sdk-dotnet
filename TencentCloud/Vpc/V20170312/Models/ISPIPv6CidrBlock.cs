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

    public class ISPIPv6CidrBlock : AbstractModel
    {
        
        /// <summary>
        /// <p>IPv6网段</p>
        /// </summary>
        [JsonProperty("IPv6CidrBlock")]
        public string IPv6CidrBlock{ get; set; }

        /// <summary>
        /// <p>网络运营商类型</p><p>枚举值：</p><ul><li>BGP： 默认</li><li>CMCC： 中国移动</li><li>CTCC： 中国电信</li><li>CUCC： 中国联通</li></ul>
        /// </summary>
        [JsonProperty("ISPType")]
        public string ISPType{ get; set; }

        /// <summary>
        /// <p>IPv6网段类型</p><p>枚举值：</p><ul><li>GUA： 全球单播地址</li><li>ULA： 唯一本地地址</li></ul>
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPv6CidrBlock", this.IPv6CidrBlock);
            this.SetParamSimple(map, prefix + "ISPType", this.ISPType);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
        }
    }
}

