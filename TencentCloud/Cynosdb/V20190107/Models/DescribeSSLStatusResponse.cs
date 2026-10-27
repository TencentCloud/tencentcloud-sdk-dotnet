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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSSLStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>yes-开启，no-关闭</p>
        /// </summary>
        [JsonProperty("IsOpenSSL")]
        public string IsOpenSSL{ get; set; }

        /// <summary>
        /// <p>证书下载地址</p>
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// <p>证书类型</p><p>枚举值：</p><ul><li>platform： 云端证书</li><li>custom： 自定义证书</li></ul>
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// <p>自定义证书详情，仅 CertType=custom 时有值。</p>
        /// </summary>
        [JsonProperty("CertDetail")]
        public CertDetail CertDetail{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsOpenSSL", this.IsOpenSSL);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamObj(map, prefix + "CertDetail.", this.CertDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

