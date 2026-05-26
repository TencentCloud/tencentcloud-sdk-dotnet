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

    public class CreateSSHKeyPairSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>凭据名称，同一region内不可重复，最长128字节，使用字母、数字或者 - _ 的组合，第一个字符必须为字母或者数字。</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>密钥对创建后所属的项目ID。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>描述信息，用于详细描述用途等，最大支持2048字节。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>指定对凭据进行加密的KMS CMK。<br>如果为空则表示使用Secrets Manager为您默认创建的CMK进行加密。<br>您也可以指定在同region 下自行创建的KMS CMK进行加密。</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>用户自定义输入的SSH密钥对的名称，可由数字，字母和下划线组成，只能以数字和字母开头，长度不超过25个字符。</p>
        /// </summary>
        [JsonProperty("SSHKeyName")]
        public string SSHKeyName{ get; set; }

        /// <summary>
        /// <p>KMS的独享集群的ID。当KmsKeyId为空,并且用户的KMS存在有效的HsmClusterId时有效。</p>
        /// </summary>
        [JsonProperty("KmsHsmClusterId")]
        public string KmsHsmClusterId{ get; set; }

        /// <summary>
        /// <p>凭据加密类型</p><p>枚举值：</p><ul><li>0： KMS 密钥</li><li>1： 软件密钥</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("EncryptType")]
        public ulong? EncryptType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "SSHKeyName", this.SSHKeyName);
            this.SetParamSimple(map, prefix + "KmsHsmClusterId", this.KmsHsmClusterId);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
        }
    }
}

