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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedAuthenticationTypeF : AbstractModel
    {
        
        /// <summary>
        /// uri串中签名的字段名，字母，数字或下划线构成，同时必须以字母开头。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// uri串中时间的字段名，字母，数字或下划线构成，同时必须以字母开头。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// uri串中Transaction字段名，字母，数字或下划线构成，同时必须以字母开头。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransactionParam")]
        public string TransactionParam{ get; set; }

        /// <summary>
        /// 用于计算签名的主密钥，只允许字母和数字，长度6-32字节。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 用于计算签名的备选密钥，主密钥校验失败后再次尝试备选密钥，只允许字母和数字，长度6-32字节。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "TransactionParam", this.TransactionParam);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
        }
    }
}

