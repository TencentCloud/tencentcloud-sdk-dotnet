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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSSLConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。可通过<a href="https://cloud.tencent.com/document/api/409/16773">DescribeDBInstances</a>接口获取</p>
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// <p>开启或关闭SSL。true - 开启 ；false - 关闭。</p>
        /// </summary>
        [JsonProperty("SSLEnabled")]
        public bool? SSLEnabled{ get; set; }

        /// <summary>
        /// <p>SSL证书保护的唯一连接地址，若为主实例，可设置为内外网IP地址；若为只读实例，可设置为实例IP或只读组IP。在开启SSL或修改SSL保护的连接地址时，该参数为必传项；在关闭SSL时，该参数将被忽略。</p>
        /// </summary>
        [JsonProperty("ConnectAddress")]
        public string ConnectAddress{ get; set; }

        /// <summary>
        /// <p>SSL证书来源。</p><p>枚举值：</p><ul><li>cloud： 平台自签发的云端证书</li><li>custom： 腾讯云SSL证书产品托管的用户自有证书</li></ul>
        /// </summary>
        [JsonProperty("CertSource")]
        public string CertSource{ get; set; }

        /// <summary>
        /// <p>腾讯云 SSL 证书产品的证书 ID。证书类型为custom时必须填写。</p>
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "SSLEnabled", this.SSLEnabled);
            this.SetParamSimple(map, prefix + "ConnectAddress", this.ConnectAddress);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
        }
    }
}

