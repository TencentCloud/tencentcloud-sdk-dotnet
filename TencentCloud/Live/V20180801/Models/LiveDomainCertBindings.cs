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

    public class LiveDomainCertBindings : AbstractModel
    {
        
        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 证书备注。与CertName同义。
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// 证书类型。
        /// 0：自有证书
        /// 1：腾讯云ssl托管证书
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// https状态。
        /// 1：已开启。
        /// 0：已关闭。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 证书过期时间。
        /// </summary>
        [JsonProperty("CertExpireTime")]
        public string CertExpireTime{ get; set; }

        /// <summary>
        /// 证书Id。
        /// </summary>
        [JsonProperty("CertId")]
        public long? CertId{ get; set; }

        /// <summary>
        /// 腾讯云ssl的证书Id。
        /// </summary>
        [JsonProperty("CloudCertId")]
        public string CloudCertId{ get; set; }

        /// <summary>
        /// 规则最后更新时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CertExpireTime", this.CertExpireTime);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CloudCertId", this.CloudCertId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

