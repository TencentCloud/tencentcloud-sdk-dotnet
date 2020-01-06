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

    public class CreateVpcRequest : AbstractModel
    {
        
        /// <summary>
        /// vpc名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// vpc的cidr，只能为10.0.0.0/16，172.16.0.0/16，192.168.0.0/16这三个内网网段内。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 是否开启组播。true: 开启, false: 不开启。
        /// </summary>
        [JsonProperty("EnableMulticast")]
        public string EnableMulticast{ get; set; }

        /// <summary>
        /// DNS地址，最多支持4个
        /// </summary>
        [JsonProperty("DnsServers")]
        public string[] DnsServers{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "EnableMulticast", this.EnableMulticast);
            this.SetParamArraySimple(map, prefix + "DnsServers.", this.DnsServers);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
        }
    }
}

