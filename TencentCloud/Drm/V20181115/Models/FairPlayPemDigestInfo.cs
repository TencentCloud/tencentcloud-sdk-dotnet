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

namespace TencentCloud.Drm.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FairPlayPemDigestInfo : AbstractModel
    {
        
        /// <summary>
        /// fairplay 私钥pem id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FairPlayPemId")]
        public ulong? FairPlayPemId{ get; set; }

        /// <summary>
        /// 私钥的优先级。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// 私钥的md5 信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Md5Pem")]
        public string Md5Pem{ get; set; }

        /// <summary>
        /// ASK的md5信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Md5Ask")]
        public string Md5Ask{ get; set; }

        /// <summary>
        /// 私钥解密密钥的md5值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Md5PemDecryptKey")]
        public string Md5PemDecryptKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FairPlayPemId", this.FairPlayPemId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Md5Pem", this.Md5Pem);
            this.SetParamSimple(map, prefix + "Md5Ask", this.Md5Ask);
            this.SetParamSimple(map, prefix + "Md5PemDecryptKey", this.Md5PemDecryptKey);
        }
    }
}

