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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewaySecretKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>密钥id</p>
        /// </summary>
        [JsonProperty("SecretKeyId")]
        public string SecretKeyId{ get; set; }

        /// <summary>
        /// <p>可选 Boolean，默认 false。仅传 true 且返回记录 ResourceType=Consumer 时，额外返回 CredentialGenerateType、CreationSource、BatchId；省略或 false 时不返回这三个字段，原字段和返回结构保持不变。此参数只控制展示字段，不控制 Filters 是否生效。</p>
        /// </summary>
        [JsonProperty("IncludeCreationInfo")]
        public bool? IncludeCreationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "SecretKeyId", this.SecretKeyId);
            this.SetParamSimple(map, prefix + "IncludeCreationInfo", this.IncludeCreationInfo);
        }
    }
}

