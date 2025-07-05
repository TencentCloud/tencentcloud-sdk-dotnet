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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Encryption : AbstractModel
    {
        
        /// <summary>
        /// 有加密需求的用户，接入传入kms的CiphertextBlob（Base64编码），关于数据加密可查阅[敏感数据加密指引](https://cloud.tencent.com/document/product/866/106048)文档。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// 有加密需求的用户，传入CBC加密的初始向量（客户自定义字符串，长度16字符，Base64编码）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Iv")]
        public string Iv{ get; set; }

        /// <summary>
        /// 加密使用的算法（支持'AES-256-CBC'、'SM4-GCM'），不传默认为'AES-256-CBC'
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// SM4-GCM算法生成的消息摘要（校验消息完整性时使用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public string[] TagList{ get; set; }

        /// <summary>
        /// 在使用加密服务时，指定要被加密的字段。本接口默认为EncryptedBody
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptList")]
        public string[] EncryptList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamSimple(map, prefix + "Iv", this.Iv);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamArraySimple(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "EncryptList.", this.EncryptList);
        }
    }
}

