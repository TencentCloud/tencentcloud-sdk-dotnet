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

    public class ModifyHTTPSListenerAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 通道ID， 若为单通道监听器，此项必须填写
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 修改后的监听器名称
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 监听器后端转发与源站之间的协议类型
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// 修改后的监听器服务器证书ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 修改后的监听器客户端证书ID，不支持多客户端证书，多客户端证书新采用PolyClientCertificateIds字段
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// 新字段,修改后的监听器客户端证书ID
        /// </summary>
        [JsonProperty("PolyClientCertificateIds")]
        public string[] PolyClientCertificateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamArraySimple(map, prefix + "PolyClientCertificateIds.", this.PolyClientCertificateIds);
        }
    }
}

