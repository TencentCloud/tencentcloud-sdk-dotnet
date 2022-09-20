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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDnsRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 记录ID。
        /// </summary>
        [JsonProperty("DnsRecordId")]
        public string DnsRecordId{ get; set; }

        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS记录类型，取值有：
        /// <li>A：将域名指向一个外网 IPv4 地址，如 8.8.8.8；</li>
        /// <li>AAAA：将域名指向一个外网 IPv6 地址；</li>
        /// <li>MX：用于邮箱服务器，相关记录值/优先级参数由邮件注册商提供。存在多条 MX 记录时，优先级越低越优先；</li>
        /// <li>CNAME：将域名指向另一个域名，再由该域名解析出最终 IP 地址；</li>
        /// <li>TXT：对域名进行标识和说明，常用于域名验证和 SPF 记录（反垃圾邮件）；</li>
        /// <li>NS：如果需要将子域名交给其他 DNS 服务商解析，则需要添加 NS 记录。根域名无法添加 NS 记录；</li>
        /// <li>CAA：指定可为本站点颁发证书的 CA；</li>
        /// <li>SRV：标识某台服务器使用了某个服务，常见于微软系统的目录管理。</li>不填写保持原有配置。
        /// </summary>
        [JsonProperty("DnsRecordType")]
        public string DnsRecordType{ get; set; }

        /// <summary>
        /// 记录名称，由主机记录+站点名称组成，不填写保持原有配置。
        /// </summary>
        [JsonProperty("DnsRecordName")]
        public string DnsRecordName{ get; set; }

        /// <summary>
        /// 记录内容，不填写保持原有配置。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 缓存时间，数值越小，修改记录各地生效时间越快，默认为300，单位：秒，不填写保持原有配置。
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// 该参数在修改MX记录时生效，值越小优先级越高，用户可指定值范围为1~50，不指定默认为0，不填写保持原有配置。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 代理模式，取值有：
        /// <li>dns_only：仅DNS解析；</li>
        /// <li>proxied：代理加速。</li>不填写保持原有配置。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsRecordId", this.DnsRecordId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DnsRecordType", this.DnsRecordType);
            this.SetParamSimple(map, prefix + "DnsRecordName", this.DnsRecordName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

