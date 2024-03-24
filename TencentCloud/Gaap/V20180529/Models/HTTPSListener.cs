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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPSListener : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听器名称
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 监听器端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 监听器协议， HTTP表示HTTP，HTTPS表示HTTPS，此结构取值HTTPS
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 监听器状态，其中：
        /// 0表示运行中；
        /// 1表示创建中；
        /// 2表示销毁中；
        /// 3表示源站调整中；
        /// 4表示配置变更中。
        /// </summary>
        [JsonProperty("ListenerStatus")]
        public ulong? ListenerStatus{ get; set; }

        /// <summary>
        /// 监听器服务器SSL证书ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 监听器后端转发源站协议
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// 监听器创建时间，Unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 服务器SSL证书的别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// 监听器客户端CA证书ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// 监听器认证方式。其中，
        /// 0表示单向认证；
        /// 1表示双向认证。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// 客户端CA证书别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCertificateAlias")]
        public string ClientCertificateAlias{ get; set; }

        /// <summary>
        /// 多客户端CA证书别名信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolyClientCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyClientCertificateAliasInfo{ get; set; }

        /// <summary>
        /// 是否支持Http3，其中：
        /// 0，不支持Http3接入；
        /// 1，持Http3接入。
        /// 注意：如果支持了Http3的功能，那么该监听器会占用对应的UDP接入端口，不可再创建相同端口的UDP监听器。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }

        /// <summary>
        /// 监听器的通道ID，如果监听器属于通道组，则为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 监听器的通道组ID，如果监听器属于通道，则为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 支持的TLS版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TLSSupportVersion")]
        public string[] TLSSupportVersion{ get; set; }

        /// <summary>
        /// 支持的TLS密码套件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TLSCiphers")]
        public string TLSCiphers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ClientCertificateAlias", this.ClientCertificateAlias);
            this.SetParamArrayObj(map, prefix + "PolyClientCertificateAliasInfo.", this.PolyClientCertificateAliasInfo);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "TLSSupportVersion.", this.TLSSupportVersion);
            this.SetParamSimple(map, prefix + "TLSCiphers", this.TLSCiphers);
        }
    }
}

