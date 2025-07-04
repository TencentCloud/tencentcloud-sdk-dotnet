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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LbRsItem : AbstractModel
    {
        
        /// <summary>
        /// vpc的字符串id，只支持字符串id。
        /// 可以通过 [DescribeVpcs](https://cloud.tencent.com/document/api/215/15778) 接口查询。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 需要查询后端的内网 IP，可以是 CVM 和弹性网卡。
        /// 可以通过 [DescribeAddresses](https://cloud.tencent.com/document/product/215/16702) 接口查询。
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
        }
    }
}

