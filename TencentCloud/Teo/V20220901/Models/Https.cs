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

    public class Https : AbstractModel
    {
        
        /// <summary>
        /// http2 配置开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Http2")]
        public string Http2{ get; set; }

        /// <summary>
        /// OCSP 配置开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcspStapling")]
        public string OcspStapling{ get; set; }

        /// <summary>
        /// Tls版本设置，取值有：
        /// <li>TLSv1：TLSv1版本；</li>
        /// <li>TLSV1.1：TLSv1.1版本；</li>
        /// <li>TLSV1.2：TLSv1.2版本；</li>
        /// <li>TLSv1.3：TLSv1.3版本。</li>修改时必须开启连续的版本。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TlsVersion")]
        public string[] TlsVersion{ get; set; }

        /// <summary>
        /// HSTS 配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hsts")]
        public Hsts Hsts{ get; set; }

        /// <summary>
        /// 证书配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCertInfo[] CertInfo{ get; set; }

        /// <summary>
        /// 申请类型，取值有：
        /// <li>apply：托管EdgeOne；</li>
        /// <li>none：不托管EdgeOne。</li>不填，默认取值为none。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplyType")]
        public string ApplyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "OcspStapling", this.OcspStapling);
            this.SetParamArraySimple(map, prefix + "TlsVersion.", this.TlsVersion);
            this.SetParamObj(map, prefix + "Hsts.", this.Hsts);
            this.SetParamArrayObj(map, prefix + "CertInfo.", this.CertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
        }
    }
}

