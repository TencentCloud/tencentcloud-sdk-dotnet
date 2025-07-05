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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvanceHttps : AbstractModel
    {
        
        /// <summary>
        /// 自定义Tls数据开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomTlsStatus")]
        public string CustomTlsStatus{ get; set; }

        /// <summary>
        /// Tls版本列表，支持设置 TLSv1, TLSV1.1, TLSV1.2, TLSv1.3，修改时必须开启连续的版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TlsVersion")]
        public string[] TlsVersion{ get; set; }

        /// <summary>
        /// 自定义加密套件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cipher")]
        public string Cipher{ get; set; }

        /// <summary>
        /// 回源双向校验开启状态
        /// off - 关闭校验
        /// oneWay - 校验源站
        /// twoWay - 双向校验
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyOriginType")]
        public string VerifyOriginType{ get; set; }

        /// <summary>
        /// 回源层证书配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCert CertInfo{ get; set; }

        /// <summary>
        /// 源站证书配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginCertInfo")]
        public ClientCert OriginCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomTlsStatus", this.CustomTlsStatus);
            this.SetParamArraySimple(map, prefix + "TlsVersion.", this.TlsVersion);
            this.SetParamSimple(map, prefix + "Cipher", this.Cipher);
            this.SetParamSimple(map, prefix + "VerifyOriginType", this.VerifyOriginType);
            this.SetParamObj(map, prefix + "CertInfo.", this.CertInfo);
            this.SetParamObj(map, prefix + "OriginCertInfo.", this.OriginCertInfo);
        }
    }
}

