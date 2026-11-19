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
        /// <p>指定需要增加版本的凭据名称。</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>指定新增凭据版本的版本号。可选，未指定时由系统生成 UUID v4，并通过响应 VersionId 返回。</p><p>参数格式：最长64字节，使用字母、数字或 - _ . 的组合，并以字母或数字开头。</p><p>省略 VersionId 的每次调用都会生成新版本。需要识别同一版本或处理重试时，由调用方生成并复用 VersionId；已有版本号返回 ResourceInUse.VersionIdExists。</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>二进制凭据信息，使用base64编码。<br>SecretBinary 和 SecretString 必须且只能设置一个。</p>
        /// </summary>
        [JsonProperty("SecretBinary")]
        public string SecretBinary{ get; set; }

        /// <summary>
        /// <p>文本类型凭据信息明文（不需要进行base64编码），SecretBinary 和 SecretString 必须且只能设置一个。</p>
        /// </summary>
        [JsonProperty("SecretString")]
        public string SecretString{ get; set; }

        /// <summary>
        /// <p>为新增版本设置版本标签，仅支持 Stage_Current，大小写敏感。本接口仅支持自定义凭据。</p><p>入参限制：SecretString 和 SecretBinary 必须且只能指定一个非空值。</p>
        /// </summary>
        [JsonProperty("VersionStage")]
        public string VersionStage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "SecretBinary", this.SecretBinary);
            this.SetParamSimple(map, prefix + "SecretString", this.SecretString);
            this.SetParamSimple(map, prefix + "VersionStage", this.VersionStage);
        }
    }
}

