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

namespace TencentCloud.Ecm.V20190719.Models
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
        /// vpc的cidr，只能为10.*.0.0/16，172.[16-31].0.0/16，192.168.0.0/16这三个内网网段内。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// ECM 地域
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 是否开启组播。true: 开启, false: 不开启。暂不支持
        /// </summary>
        [JsonProperty("EnableMulticast")]
        public string EnableMulticast{ get; set; }

        /// <summary>
        /// DNS地址，最多支持4个，暂不支持
        /// </summary>
        [JsonProperty("DnsServers")]
        public string[] DnsServers{ get; set; }

        /// <summary>
        /// 域名，暂不支持
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 网络运营商类型 取值范围:'CMCC'-中国移动, 'CTCC'-中国电信, 'CUCC'-中国联调	
        /// </summary>
        [JsonProperty("ISPTypes")]
        public ISPTypeItem[] ISPTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "EnableMulticast", this.EnableMulticast);
            this.SetParamArraySimple(map, prefix + "DnsServers.", this.DnsServers);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "ISPTypes.", this.ISPTypes);
        }
    }
}

