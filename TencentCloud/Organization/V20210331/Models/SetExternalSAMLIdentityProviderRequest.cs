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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetExternalSAMLIdentityProviderRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// IdP 元数据文档（Base64 编码）。  由支持 SAML 2.0 协议的 IdP 提供。
        /// </summary>
        [JsonProperty("EncodedMetadataDocument")]
        public string EncodedMetadataDocument{ get; set; }

        /// <summary>
        /// SSO 登录的启用状态。取值：  Enabled：启用。 Disabled（默认值）：禁用。
        /// </summary>
        [JsonProperty("SSOStatus")]
        public string SSOStatus{ get; set; }

        /// <summary>
        /// IdP 标识。
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// IdP 的登录地址。
        /// </summary>
        [JsonProperty("LoginUrl")]
        public string LoginUrl{ get; set; }

        /// <summary>
        /// PEM 格式的 X509 证书。指定该参数会替换所有已经存在的证书。
        /// </summary>
        [JsonProperty("X509Certificate")]
        public string X509Certificate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "EncodedMetadataDocument", this.EncodedMetadataDocument);
            this.SetParamSimple(map, prefix + "SSOStatus", this.SSOStatus);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "LoginUrl", this.LoginUrl);
            this.SetParamSimple(map, prefix + "X509Certificate", this.X509Certificate);
        }
    }
}

