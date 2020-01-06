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

    public class ModifyVpcAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。形如：vpc-f49l6u0z。每次请求的实例的上限为100。参数不支持同时指定VpcIds和Filters。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称，可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 是否开启组播。true: 开启, false: 关闭。
        /// </summary>
        [JsonProperty("EnableMulticast")]
        public string EnableMulticast{ get; set; }

        /// <summary>
        /// DNS地址，最多支持4个，第1个默认为主，其余为备
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
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "EnableMulticast", this.EnableMulticast);
            this.SetParamArraySimple(map, prefix + "DnsServers.", this.DnsServers);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
        }
    }
}

