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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomDnsHostRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名实例ID
        /// 可通过DescribeDomainLIst接口获取
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// Dns名称
        /// 例如：<>.test.com;其中<>就是Dns名称，可以是任意域名允许的格式
        /// </summary>
        [JsonProperty("DnsName")]
        public string DnsName{ get; set; }

        /// <summary>
        /// IP地址列表
        /// 可选择：正常IP地址范围
        /// </summary>
        [JsonProperty("IpSet")]
        public string[] IpSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DnsName", this.DnsName);
            this.SetParamArraySimple(map, prefix + "IpSet.", this.IpSet);
        }
    }
}

