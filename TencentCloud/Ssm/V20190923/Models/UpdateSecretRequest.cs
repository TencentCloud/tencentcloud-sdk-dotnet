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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定需要更新凭据内容的名称。
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 指定需要更新凭据内容的版本号。
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 新的凭据内容为二进制的场景使用该字段，并使用base64进行编码。SecretBinary 和 SecretString 只能一个不为空。
        /// </summary>
        [JsonProperty("SecretBinary")]
        public string SecretBinary{ get; set; }

        /// <summary>
        /// 新的凭据内容为文本的场景使用该字段，不需要base64编码。SecretBinary 和 SecretString 只能一个不为空。
        /// </summary>
        [JsonProperty("SecretString")]
        public string SecretString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "SecretBinary", this.SecretBinary);
            this.SetParamSimple(map, prefix + "SecretString", this.SecretString);
        }
    }
}

