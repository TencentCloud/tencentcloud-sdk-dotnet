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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveCertRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书Id。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 证书类型。0-用户添加证书；1-腾讯云托管证书。
        /// </summary>
        [JsonProperty("CertType")]
        public ulong? CertType{ get; set; }

        /// <summary>
        /// 证书名称。
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// 证书内容，即公钥。
        /// </summary>
        [JsonProperty("HttpsCrt")]
        public string HttpsCrt{ get; set; }

        /// <summary>
        /// 私钥。
        /// </summary>
        [JsonProperty("HttpsKey")]
        public string HttpsKey{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "HttpsCrt", this.HttpsCrt);
            this.SetParamSimple(map, prefix + "HttpsKey", this.HttpsKey);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

