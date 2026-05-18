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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DirectoryConfigResultData : AbstractModel
    {
        
        /// <summary>
        /// <p>企业目录 ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>企业目录名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>身份源配置 ID</p>
        /// </summary>
        [JsonProperty("IdentifySourceId")]
        public string IdentifySourceId{ get; set; }

        /// <summary>
        /// <p>是否同步创建了认证配置</p>
        /// </summary>
        [JsonProperty("CreateAuthConfig")]
        public bool? CreateAuthConfig{ get; set; }

        /// <summary>
        /// <p>认证源配置 ID</p>
        /// </summary>
        [JsonProperty("AuthSourceId")]
        public string AuthSourceId{ get; set; }

        /// <summary>
        /// <p>认证配置 ID</p>
        /// </summary>
        [JsonProperty("AuthConfigId")]
        public long? AuthConfigId{ get; set; }

        /// <summary>
        /// <p>认证策略 ID</p>
        /// </summary>
        [JsonProperty("AuthPolicyId")]
        public long? AuthPolicyId{ get; set; }

        /// <summary>
        /// <p>认证支持的平台, PC 或 Mobile</p>
        /// </summary>
        [JsonProperty("AuthSupportPlatforms")]
        public string[] AuthSupportPlatforms{ get; set; }

        /// <summary>
        /// <p>认证方式，授权认证/扫码认证 等</p>
        /// </summary>
        [JsonProperty("AuthMethods")]
        public string[] AuthMethods{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdentifySourceId", this.IdentifySourceId);
            this.SetParamSimple(map, prefix + "CreateAuthConfig", this.CreateAuthConfig);
            this.SetParamSimple(map, prefix + "AuthSourceId", this.AuthSourceId);
            this.SetParamSimple(map, prefix + "AuthConfigId", this.AuthConfigId);
            this.SetParamSimple(map, prefix + "AuthPolicyId", this.AuthPolicyId);
            this.SetParamArraySimple(map, prefix + "AuthSupportPlatforms.", this.AuthSupportPlatforms);
            this.SetParamArraySimple(map, prefix + "AuthMethods.", this.AuthMethods);
        }
    }
}

