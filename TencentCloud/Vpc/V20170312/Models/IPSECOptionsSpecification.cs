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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPSECOptionsSpecification : AbstractModel
    {
        
        /// <summary>
        /// <p>加密算法，可选值：&#39;3DES-CBC&#39;, &#39;AES-CBC-128&#39;, &#39;AES-CBC-192&#39;, &#39;AES-CBC-256&#39;, &#39;DES-CBC&#39;, &#39;SM4&#39;, &#39;NULL&#39;， 默认为AES-CBC-128</p>
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// <p>认证算法：可选值：&#39;MD5&#39;, &#39;SHA1&#39;，&#39;SHA-256&#39; 默认为</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntegrityAlgorith")]
        [System.Obsolete]
        public string IntegrityAlgorith{ get; set; }

        /// <summary>
        /// <p>IPsec SA lifetime(s)</p><p>取值范围：[180, 604800]</p><p>单位：秒</p><p>默认值：14400</p>
        /// </summary>
        [JsonProperty("IPSECSaLifetimeSeconds")]
        public ulong? IPSECSaLifetimeSeconds{ get; set; }

        /// <summary>
        /// <p>PFS：可选值：&#39;NULL&#39;, &#39;DH-GROUP1&#39;, &#39;DH-GROUP2&#39;, &#39;DH-GROUP5&#39;, &#39;DH-GROUP14&#39;, &#39;DH-GROUP15&#39;,&#39;DH-GROUP16&#39;,&#39;DH-GROUP19&#39;,&#39;DH-GROUP20&#39;,&#39;DH-GROUP21&#39;,&#39;DH-GROUP24&#39;，默认为NULL</p>
        /// </summary>
        [JsonProperty("PfsDhGroup")]
        public string PfsDhGroup{ get; set; }

        /// <summary>
        /// <p>IPsec SA lifetime(KB)</p><p>取值范围：[2560, 4294967295]</p><p>单位：KB</p><p>默认值：4096000000</p>
        /// </summary>
        [JsonProperty("IPSECSaLifetimeTraffic")]
        public ulong? IPSECSaLifetimeTraffic{ get; set; }

        /// <summary>
        /// <p>认证算法：可选值：&#39;MD5&#39;, &#39;SHA1&#39;，&#39;SHA-256&#39; 默认为</p>
        /// </summary>
        [JsonProperty("IntegrityAlgorithm")]
        public string IntegrityAlgorithm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamSimple(map, prefix + "IntegrityAlgorith", this.IntegrityAlgorith);
            this.SetParamSimple(map, prefix + "IPSECSaLifetimeSeconds", this.IPSECSaLifetimeSeconds);
            this.SetParamSimple(map, prefix + "PfsDhGroup", this.PfsDhGroup);
            this.SetParamSimple(map, prefix + "IPSECSaLifetimeTraffic", this.IPSECSaLifetimeTraffic);
            this.SetParamSimple(map, prefix + "IntegrityAlgorithm", this.IntegrityAlgorithm);
        }
    }
}

