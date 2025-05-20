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

    public class ModifyOriginParameters : AbstractModel
    {
        
        /// <summary>
        /// 源站类型。取值有：
        /// <li>IPDomain：IPV4、IPV6 或域名类型源站；</li>
        /// <li>OriginGroup：源站组类型源站；</li>
        /// <li>LoadBalance：负载均衡，该功能内测中，如需使用，请提工单或联系智能客服；</li>
        /// <li>COS：腾讯云 COS 对象存储源站；</li>
        /// <li>AWSS3：支持 AWS S3 协议的所有对象存储源站。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站地址，根据 OriginType 的取值分为以下情况：
        /// <li>当 OriginType = IPDomain 时，该参数请填写 IPV4、IPV6 地址或域名；</li>
        /// <li>当 OriginType = COS 时，该参数请填写 COS 桶的访问域名；</li>
        /// <li>当 OriginType = AWSS3，该参数请填写 S3 桶的访问域名；</li>
        /// <li>当 OriginType = OriginGroup 时，该参数请填写源站组 ID；</li>
        /// <li>当 OriginType = LoadBalance 时，该参数请填写负载均衡实例 ID，该功能当前仅白名单开放。</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 回源协议配置。当 OriginType 取值为 IPDomain、OriginGroup、LoadBalance 时该参数必填。取值有：
        /// <li>http：使用 HTTP 协议；</li>
        /// <li>https：使用 HTTPS 协议；</li>
        /// <li>follow：协议跟随。</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP 回源端口，取值范围 1～65535。当回源协议 OriginProtocol 为 http 或者 follow 时该参数必填。
        /// </summary>
        [JsonProperty("HTTPOriginPort")]
        public long? HTTPOriginPort{ get; set; }

        /// <summary>
        /// HTTPS 回源端口，取值范围 1～65535。当回源协议 OriginProtocol 为 https 或者 follow 时该参数必填。
        /// </summary>
        [JsonProperty("HTTPSOriginPort")]
        public long? HTTPSOriginPort{ get; set; }

        /// <summary>
        /// 指定是否允许访问私有对象存储源站，当源站类型 OriginType = COS 或 AWSS3 时该参数必填，取值有：
        /// <li>on：使用私有鉴权；</li>
        /// <li>off：不使用私有鉴权。</li>
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// 私有鉴权使用参数，该参数仅当 OriginType = AWSS3 且 PrivateAccess = on 时会生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public OriginPrivateParameters PrivateParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HTTPOriginPort", this.HTTPOriginPort);
            this.SetParamSimple(map, prefix + "HTTPSOriginPort", this.HTTPSOriginPort);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
        }
    }
}

