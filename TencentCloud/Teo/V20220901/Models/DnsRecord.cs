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

    public class DnsRecord : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。<br>注意：ZoneId 仅做出参使用，在 ModifyDnsRecords 不可作为入参使用，如有传此参数，会忽略。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS 记录 ID。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// DNS 记录名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS 记录类型，取值有：
        /// <li>A：将域名指向一个外网 IPv4 地址，如 8.8.8.8；</li>
        /// <li>AAAA：将域名指向一个外网 IPv6 地址；</li>
        /// <li>MX：用于邮箱服务器。存在多条 MX 记录时，优先级越低越优先；</li>
        /// <li>CNAME：将域名指向另一个域名，再由该域名解析出最终 IP 地址；</li>
        /// <li>TXT：对域名进行标识和说明，常用于域名验证和 SPF 记录（反垃圾邮件）；</li>
        /// <li>NS：如果需要将子域名交给其他 DNS 服务商解析，则需要添加 NS 记录。根域名无法添加 NS 记录；</li>
        /// <li>CAA：指定可为本站点颁发证书的 CA；</li>
        /// <li>SRV：标识某台服务器使用了某个服务，常见于微软系统的目录管理。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS 记录解析线路，不指定默认为 Default，表示默认解析线路，代表全部地域生效。<br>解析线路配置仅适用于当 Type（DNS 记录类型）为 A、AAAA、CNAME 时。<br>取值请参考：[解析线路及对应代码枚举](https://cloud.tencent.com/document/product/1552/112542)。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// DNS 记录内容。根据 Type 值填入与之相对应的内容。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 缓存时间，取值范围 60~86400，数值越小，修改记录各地生效时间越快，单位：秒。
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS 记录权重，取值范围 -1~100，为 -1 时表示不分配权重，为 0 时表示不解析。权重配置仅适用于当 Type（DNS 记录类型）为 A、AAAA、CNAME 时。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX 记录优先级，取值范围 0~50，数值越小越优先。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// DNS 记录解析状态，取值有：<li>enable：已生效；</li><li>disable：已停用。</li>注意：Status 仅做出参使用，在 ModifyDnsRecords 不可作为入参使用，如有传此参数，会忽略。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间。<br>注意：CreatedOn 仅做出参使用，在 ModifyDnsRecords 不可作为入参使用，如有传此参数，会忽略。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 修改时间。<br>注意：ModifiedOn 仅做出参使用，在 ModifyDnsRecords 不可作为入参使用，如有传此参数，会忽略。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

