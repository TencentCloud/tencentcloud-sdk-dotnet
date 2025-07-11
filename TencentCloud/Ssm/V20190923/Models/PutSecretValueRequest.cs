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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutSecretValueRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定需要增加版本的凭据名称。
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 指定新增加的版本号，最长64 字节，使用字母、数字或者 - _ . 的组合并且以字母或数字开头。
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 二进制凭据信息，使用base64编码。
        /// SecretBinary 和 SecretString 必须且只能设置一个。
        /// </summary>
        [JsonProperty("SecretBinary")]
        public string SecretBinary{ get; set; }

        /// <summary>
        /// 文本类型凭据信息明文（不需要进行base64编码），SecretBinary 和 SecretString 必须且只能设置一个。
        /// </summary>
        [JsonProperty("SecretString")]
        public string SecretString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "SecretBinary", this.SecretBinary);
            this.SetParamSimple(map, prefix + "SecretString", this.SecretString);
        }
    }
}

