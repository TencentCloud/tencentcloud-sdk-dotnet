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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SrcAddressInfo : AbstractModel
    {
        
        /// <summary>
        /// 内网Ip4地址
        /// </summary>
        [JsonProperty("SrcIpv4")]
        public string SrcIpv4{ get; set; }

        /// <summary>
        /// 公网Ip4地址
        /// </summary>
        [JsonProperty("SrcPublicIpv4")]
        public string SrcPublicIpv4{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcIpv4", this.SrcIpv4);
            this.SetParamSimple(map, prefix + "SrcPublicIpv4", this.SrcPublicIpv4);
        }
    }
}

