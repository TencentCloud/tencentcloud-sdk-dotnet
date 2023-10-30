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

    public class IKEOptionsSpecification : AbstractModel
    {
        
        /// <summary>
        /// 加密算法，可选值：'3DES-CBC', 'AES-CBC-128', 'AES-CBS-192', 'AES-CBC-256', 'DES-CBC'，'SM4', 默认为3DES-CBC
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PropoEncryAlgorithm")]
        public string PropoEncryAlgorithm{ get; set; }

        /// <summary>
        /// 认证算法：可选值：'MD5', 'SHA1'，'SHA-256' 默认为MD5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PropoAuthenAlgorithm")]
        public string PropoAuthenAlgorithm{ get; set; }

        /// <summary>
        /// 协商模式：可选值：'AGGRESSIVE', 'MAIN'，默认为MAIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExchangeMode")]
        public string ExchangeMode{ get; set; }

        /// <summary>
        /// 本端标识类型：可选值：'ADDRESS', 'FQDN'，默认为ADDRESS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalIdentity")]
        public string LocalIdentity{ get; set; }

        /// <summary>
        /// 对端标识类型：可选值：'ADDRESS', 'FQDN'，默认为ADDRESS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteIdentity")]
        public string RemoteIdentity{ get; set; }

        /// <summary>
        /// 本端标识，当LocalIdentity选为ADDRESS时，LocalAddress必填。localAddress默认为vpn网关公网IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalAddress")]
        public string LocalAddress{ get; set; }

        /// <summary>
        /// 对端标识，当RemoteIdentity选为ADDRESS时，RemoteAddress必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteAddress")]
        public string RemoteAddress{ get; set; }

        /// <summary>
        /// 本端标识，当LocalIdentity选为FQDN时，LocalFqdnName必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalFqdnName")]
        public string LocalFqdnName{ get; set; }

        /// <summary>
        /// 对端标识，当remoteIdentity选为FQDN时，RemoteFqdnName必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteFqdnName")]
        public string RemoteFqdnName{ get; set; }

        /// <summary>
        /// DH group，指定IKE交换密钥时使用的DH组，可选值：'GROUP1', 'GROUP2', 'GROUP5', 'GROUP14', 'GROUP24'，
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DhGroupName")]
        public string DhGroupName{ get; set; }

        /// <summary>
        /// IKE SA Lifetime，单位：秒，设置IKE SA的生存周期，取值范围：60-604800
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IKESaLifetimeSeconds")]
        public ulong? IKESaLifetimeSeconds{ get; set; }

        /// <summary>
        /// IKE版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IKEVersion")]
        public string IKEVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PropoEncryAlgorithm", this.PropoEncryAlgorithm);
            this.SetParamSimple(map, prefix + "PropoAuthenAlgorithm", this.PropoAuthenAlgorithm);
            this.SetParamSimple(map, prefix + "ExchangeMode", this.ExchangeMode);
            this.SetParamSimple(map, prefix + "LocalIdentity", this.LocalIdentity);
            this.SetParamSimple(map, prefix + "RemoteIdentity", this.RemoteIdentity);
            this.SetParamSimple(map, prefix + "LocalAddress", this.LocalAddress);
            this.SetParamSimple(map, prefix + "RemoteAddress", this.RemoteAddress);
            this.SetParamSimple(map, prefix + "LocalFqdnName", this.LocalFqdnName);
            this.SetParamSimple(map, prefix + "RemoteFqdnName", this.RemoteFqdnName);
            this.SetParamSimple(map, prefix + "DhGroupName", this.DhGroupName);
            this.SetParamSimple(map, prefix + "IKESaLifetimeSeconds", this.IKESaLifetimeSeconds);
            this.SetParamSimple(map, prefix + "IKEVersion", this.IKEVersion);
        }
    }
}

