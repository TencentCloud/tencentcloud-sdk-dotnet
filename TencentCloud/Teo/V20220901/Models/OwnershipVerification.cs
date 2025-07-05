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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OwnershipVerification : AbstractModel
    {
        
        /// <summary>
        /// CNAME 、无域名接入时，使用 DNS 解析验证时所需的信息。详情参考 [站点/域名归属权验证
        /// ](https://cloud.tencent.com/document/product/1552/70789#7af6ecf8-afca-4e35-8811-b5797ed1bde5)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DnsVerification")]
        public DnsVerification DnsVerification{ get; set; }

        /// <summary>
        /// CNAME 、无域名接入时，使用文件验证时所需的信息。详情参考 [站点/域名归属权验证
        /// ](https://cloud.tencent.com/document/product/1552/70789#7af6ecf8-afca-4e35-8811-b5797ed1bde5)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileVerification")]
        public FileVerification FileVerification{ get; set; }

        /// <summary>
        /// NS 接入，切换 DNS 服务器所需的信息。详情参考 [修改 DNS 服务器](https://cloud.tencent.com/document/product/1552/90452)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NsVerification")]
        public NsVerification NsVerification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DnsVerification.", this.DnsVerification);
            this.SetParamObj(map, prefix + "FileVerification.", this.FileVerification);
            this.SetParamObj(map, prefix + "NsVerification.", this.NsVerification);
        }
    }
}

