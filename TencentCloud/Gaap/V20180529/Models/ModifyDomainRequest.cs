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

    public class ModifyDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 7层监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 修改前的域名信息
        /// </summary>
        [JsonProperty("OldDomain")]
        public string OldDomain{ get; set; }

        /// <summary>
        /// 修改后的域名信息
        /// </summary>
        [JsonProperty("NewDomain")]
        public string NewDomain{ get; set; }

        /// <summary>
        /// 服务器SSL证书ID，仅适用于version3.0的通道。其中：
        /// 不带该字段时，表示使用原证书；
        /// 携带该字段时并且CertificateId=default，表示使用监听器证书；
        /// 其他情况，使用该CertificateId指定的证书。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 客户端CA证书ID，仅适用于version3.0的通道。其中：
        /// 不带该字段和PolyClientCertificateIds时，表示使用原证书；
        /// 携带该字段时并且ClientCertificateId=default，表示使用监听器证书；
        /// 其他情况，使用该ClientCertificateId或PolyClientCertificateIds指定的证书。
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// 客户端CA证书ID，仅适用于version3.0的通道。其中：
        /// 不带该字段和ClientCertificateId时，表示使用原证书；
        /// 携带该字段时并且ClientCertificateId=default，表示使用监听器证书；
        /// 其他情况，使用该ClientCertificateId或PolyClientCertificateIds指定的证书。
        /// </summary>
        [JsonProperty("PolyClientCertificateIds")]
        public string[] PolyClientCertificateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "OldDomain", this.OldDomain);
            this.SetParamSimple(map, prefix + "NewDomain", this.NewDomain);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamArraySimple(map, prefix + "PolyClientCertificateIds.", this.PolyClientCertificateIds);
        }
    }
}

