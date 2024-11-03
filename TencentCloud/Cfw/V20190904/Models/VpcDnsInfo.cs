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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcDnsInfo : AbstractModel
    {
        
        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// vpc 名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// nat 防火墙模式 0：新增模式， 1: 接入模式
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// vpc ipv4网段范围 CIDR（Classless Inter-Domain Routing，无类域间路由选择）
        /// </summary>
        [JsonProperty("VpcIpv4Cidr")]
        public string VpcIpv4Cidr{ get; set; }

        /// <summary>
        /// 外网弹性ip，防火墙 dns解析地址
        /// </summary>
        [JsonProperty("DNSEip")]
        public string DNSEip{ get; set; }

        /// <summary>
        /// nat网关id
        /// </summary>
        [JsonProperty("NatInsId")]
        public string NatInsId{ get; set; }

        /// <summary>
        /// nat网关名称
        /// </summary>
        [JsonProperty("NatInsName")]
        public string NatInsName{ get; set; }

        /// <summary>
        /// 0：开关关闭 ， 1: 开关打开
        /// </summary>
        [JsonProperty("SwitchStatus")]
        public long? SwitchStatus{ get; set; }

        /// <summary>
        /// 0：未防护， 1: 已防护，2：忽略此字段
        /// </summary>
        [JsonProperty("ProtectedStatus")]
        public ulong? ProtectedStatus{ get; set; }

        /// <summary>
        /// 是否支持DNS FW，0-不支持、1-支持
        /// </summary>
        [JsonProperty("SupportDNSFW")]
        public ulong? SupportDNSFW{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "VpcIpv4Cidr", this.VpcIpv4Cidr);
            this.SetParamSimple(map, prefix + "DNSEip", this.DNSEip);
            this.SetParamSimple(map, prefix + "NatInsId", this.NatInsId);
            this.SetParamSimple(map, prefix + "NatInsName", this.NatInsName);
            this.SetParamSimple(map, prefix + "SwitchStatus", this.SwitchStatus);
            this.SetParamSimple(map, prefix + "ProtectedStatus", this.ProtectedStatus);
            this.SetParamSimple(map, prefix + "SupportDNSFW", this.SupportDNSFW);
        }
    }
}

