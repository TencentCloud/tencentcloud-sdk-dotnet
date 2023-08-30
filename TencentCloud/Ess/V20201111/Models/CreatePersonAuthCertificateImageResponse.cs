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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonAuthCertificateImageResponse : AbstractModel
    {
        
        /// <summary>
        /// 个人用户证明证书的下载链接
        /// </summary>
        [JsonProperty("AuthCertUrl")]
        public string AuthCertUrl{ get; set; }

        /// <summary>
        /// 证书图片上的证书编号，20位数字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageCertId")]
        public string ImageCertId{ get; set; }

        /// <summary>
        /// 图片证明对应的CA证书序列号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// CA证书颁发时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidFrom")]
        public ulong? ValidFrom{ get; set; }

        /// <summary>
        /// CA证书有效截止时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthCertUrl", this.AuthCertUrl);
            this.SetParamSimple(map, prefix + "ImageCertId", this.ImageCertId);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "ValidFrom", this.ValidFrom);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

