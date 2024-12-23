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

    public class CreateDnsRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS 记录名，如果是中文、韩文、日文域名，需要转换为 punycode 后输入。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS 记录类型，取值有：<li>A：将域名指向一个外网 IPv4 地址，如 8.8.8.8；</li><li>AAAA：将域名指向一个外网 IPv6 地址；</li><li>MX：用于邮箱服务器。存在多条 MX 记录时，优先级越低越优先；</li><li>CNAME：将域名指向另一个域名，再由该域名解析出最终 IP 地址；</li><li>TXT：对域名进行标识和说明，常用于域名验证和 SPF 记录（反垃圾邮件）；</li><li>NS：如果需要将子域名交给其他 DNS 服务商解析，则需要添加 NS 记录。根域名无法添加 NS 记录；</li><li>CAA：指定可为本站点颁发证书的 CA；</li><li>SRV：标识某台服务器使用了某个服务，常见于微软系统的目录管理。</li>
        /// 不同的记录类型呢例如 SRV、CAA 记录对主机记录名称、记录值格式有不同的要求，各记录类型的详细说明介绍和格式示例请参考：[解析记录类型介绍](https://cloud.tencent.com/document/product/1552/90453#2f681022-91ab-4a9e-ac3d-0a6c454d954e)。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS 记录内容，根据 Type 值填入与之相对应的内容，如果是中文、韩文、日文域名，需要转换为 punycode 后输入。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// DNS 记录解析线路，不指定默认为 Default，表示默认解析线路，代表全部地域生效。
        /// 
        /// - 解析线路配置仅适用于当 Type（DNS 记录类型）为 A、AAAA、CNAME 时。
        /// - 解析线路配置仅适用于标准版、企业版套餐使用，取值请参考：[解析线路及对应代码枚举](https://cloud.tencent.com/document/product/1552/112542)。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 缓存时间，用户可指定值范围 60~86400，数值越小，修改记录各地生效时间越快，默认为 300，单位：秒。
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS 记录权重，用户可指定值范围 -1~100，设置为 0 时表示不解析，不指定默认为 -1，表示不设置权重。权重配置仅适用于当 Type（DNS 记录类型）为 A、AAAA、CNAME 时。<br>注意：同一个子域名下，相同解析线路的不同 DNS 记录，应保持同时设置权重或者同时都不设置权重。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX 记录优先级，该参数仅在当 Type（DNS 记录类型）为 MX 时生效，值越小优先级越高，用户可指定值范围0~50，不指定默认为0。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

