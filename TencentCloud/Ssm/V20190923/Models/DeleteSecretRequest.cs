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

    public class DeleteSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定需要删除的凭据名称。
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 指定计划删除日期，单位（天），0（默认）表示立即删除， 1-30 表示预留的天数，超出该日期之后彻底删除。
        /// 当凭据类型为SSH密钥对凭据时，此字段只能取值只能为0。
        /// </summary>
        [JsonProperty("RecoveryWindowInDays")]
        public ulong? RecoveryWindowInDays{ get; set; }

        /// <summary>
        /// 当凭据类型为SSH密钥对凭据时，此字段有效，取值：
        /// True -- 表示不仅仅清理此凭据中存储的SSH密钥信息，还会将SSH密钥对从CVM侧进行清理。注意，如果SSH密钥此时绑定了CVM实例，那么会清理失败。
        /// False --  表示仅仅清理此凭据中存储的SSH密钥信息，不在CVM进侧进行清理。
        /// </summary>
        [JsonProperty("CleanSSHKey")]
        public bool? CleanSSHKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "RecoveryWindowInDays", this.RecoveryWindowInDays);
            this.SetParamSimple(map, prefix + "CleanSSHKey", this.CleanSSHKey);
        }
    }
}

