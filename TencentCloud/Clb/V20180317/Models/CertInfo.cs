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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertInfo : AbstractModel
    {
        
        /// <summary>
        /// 证书 ID，如果不填写此项则必须上传证书内容，包括CertName, CertContent，若为服务端证书必须包含CertKey。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 上传证书的名称，如果没有 CertId，则此项必传。
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// 上传证书的公钥；如果没有 CertId，则此项必传。
        /// </summary>
        [JsonProperty("CertContent")]
        public string CertContent{ get; set; }

        /// <summary>
        /// 上传服务端证书的私钥；如果没有 CertId，则此项必传。
        /// </summary>
        [JsonProperty("CertKey")]
        public string CertKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertContent", this.CertContent);
            this.SetParamSimple(map, prefix + "CertKey", this.CertKey);
        }
    }
}

