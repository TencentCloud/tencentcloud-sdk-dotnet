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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongCertificatesPreview : AbstractModel
    {
        
        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 绑定的域名
        /// </summary>
        [JsonProperty("BindDomains")]
        public string[] BindDomains{ get; set; }

        /// <summary>
        /// 证书状态：expired(已过期)
        ///                    active(生效中)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 证书pem格式
        /// </summary>
        [JsonProperty("Crt")]
        public string Crt{ get; set; }

        /// <summary>
        /// 证书私钥
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 证书过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 证书上传时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 证书签发时间
        /// </summary>
        [JsonProperty("IssueTime")]
        public string IssueTime{ get; set; }

        /// <summary>
        /// 证书来源：native(kong自定义证书)
        ///                     ssl(ssl平台证书)
        /// </summary>
        [JsonProperty("CertSource")]
        public string CertSource{ get; set; }

        /// <summary>
        /// ssl平台证书Id
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "BindDomains.", this.BindDomains);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Crt", this.Crt);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IssueTime", this.IssueTime);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
        }
    }
}

