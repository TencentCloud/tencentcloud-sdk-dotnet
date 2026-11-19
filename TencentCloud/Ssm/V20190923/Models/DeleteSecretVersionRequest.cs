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

    public class DeleteSecretVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定凭据名称。</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>指定该名称下需要删除的凭据的版本号。</p><p>仅支持删除自定义凭据版本。目标版本持有 Stage_Current 标签时返回 FailedOperation，须先通过 UpdateSecret 将标签迁移到其他已有版本。存在并发写入或轮转等操作、未取得共享写锁时返回 OperationDenied。</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
        }
    }
}

