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

    public class UpdateSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定需要更新凭据内容的名称。</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>指定需要更新内容或设置版本标签的已有版本号，必填。</p><p>指定 VersionStage 时，将该标签迁移到此版本。目标版本不存在返回 ResourceNotFound；凭据处于 PendingCreate 或 CreateFailed 状态时返回 FailedOperation。</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>新的二进制凭据内容，须使用 Base64 编码，仅自定义凭据支持通过本接口更新内容。</p><p>入参限制：未指定 VersionStage 时，SecretString 和 SecretBinary 必须且只能一个非空；指定 VersionStage 时可均不传以仅迁移标签，但不能同时非空。云产品及 Redis/MongoDB 凭据须省略两项内容。</p>
        /// </summary>
        [JsonProperty("SecretBinary")]
        public string SecretBinary{ get; set; }

        /// <summary>
        /// <p>新的文本凭据内容，无需 Base64 编码，仅自定义凭据支持通过本接口更新内容。</p><p>入参限制：未指定 VersionStage 时，SecretString 和 SecretBinary 必须且只能一个非空；指定 VersionStage 时可均不传以仅迁移标签，但不能同时非空。云产品及 Redis/MongoDB 凭据须省略两项内容。</p>
        /// </summary>
        [JsonProperty("SecretString")]
        public string SecretString{ get; set; }

        /// <summary>
        /// <p>将 Stage_Current 标签设置或迁移到 VersionId 指定的已有版本，大小写敏感。</p><p>入参限制：支持自定义、云产品及 Redis/MongoDB 凭据；VersionId 必填。</p><p>自定义凭据可仅设置标签，也可同时更新内容；SecretString 和 SecretBinary 不能同时非空。云产品及 Redis/MongoDB 仅支持标签操作，两项内容均须省略。标签绑定版本号，原轮转流程保持不变；绑定历史版本不保证账密仍有效。</p>
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

