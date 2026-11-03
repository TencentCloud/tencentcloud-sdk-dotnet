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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSMCreateAccountInfos : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启SSM托管</p><p>枚举值：</p><ul><li>true： 开启托管</li><li>false： 不开启托管</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsOpenSSM")]
        public bool? IsOpenSSM{ get; set; }

        /// <summary>
        /// <p>是否创建轮转账号</p><p>枚举值：</p><ul><li>true： 创建轮转账号</li><li>false： 创建非轮转账号</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsRotationAccount")]
        public bool? IsRotationAccount{ get; set; }

        /// <summary>
        /// <p>凭据名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>KMS CMK ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>密钥类型</p><p>枚举值：</p><ul><li>0： KMS密码</li><li>1： 软件密钥</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptType")]
        public long? EncryptType{ get; set; }

        /// <summary>
        /// <p>是否开启轮转</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRotation")]
        public bool? EnableRotation{ get; set; }

        /// <summary>
        /// <p>轮转周期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }

        /// <summary>
        /// <p>权限列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivilegesList")]
        public PrivilegeGroup PrivilegesList{ get; set; }

        /// <summary>
        /// <p>独享版 KMS 集群 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KmsHsmClusterId")]
        public string KmsHsmClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsOpenSSM", this.IsOpenSSM);
            this.SetParamSimple(map, prefix + "IsRotationAccount", this.IsRotationAccount);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "EnableRotation", this.EnableRotation);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
            this.SetParamObj(map, prefix + "PrivilegesList.", this.PrivilegesList);
            this.SetParamSimple(map, prefix + "KmsHsmClusterId", this.KmsHsmClusterId);
        }
    }
}

