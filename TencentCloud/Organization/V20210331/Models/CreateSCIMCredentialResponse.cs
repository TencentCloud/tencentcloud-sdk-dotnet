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

    public class CreateSCIMCredentialResponse : AbstractModel
    {
        
        /// <summary>
        /// 空间ID。z-前缀开头，后面是12位随机数字/小写字母。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// SCIM密钥ID。scimcred-前缀开头，后面是12位随机数字/小写字母。
        /// </summary>
        [JsonProperty("CredentialId")]
        public string CredentialId{ get; set; }

        /// <summary>
        /// SCIM密钥类型。
        /// </summary>
        [JsonProperty("CredentialType")]
        public string CredentialType{ get; set; }

        /// <summary>
        /// SCIM 密钥的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// SCIM 密钥的过期时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// SCIM密钥状态，Enabled已开启，Disabled已关闭。
        /// </summary>
        [JsonProperty("CredentialStatus")]
        public string CredentialStatus{ get; set; }

        /// <summary>
        /// SCIM密钥。
        /// </summary>
        [JsonProperty("CredentialSecret")]
        public string CredentialSecret{ get; set; }

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
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "CredentialId", this.CredentialId);
            this.SetParamSimple(map, prefix + "CredentialType", this.CredentialType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CredentialStatus", this.CredentialStatus);
            this.SetParamSimple(map, prefix + "CredentialSecret", this.CredentialSecret);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

