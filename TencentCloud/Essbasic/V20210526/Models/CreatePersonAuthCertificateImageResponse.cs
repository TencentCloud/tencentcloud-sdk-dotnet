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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePersonAuthCertificateImageResponse : AbstractModel
    {
        
        /// <summary>
        /// 个人用户认证证书图片下载URL，`有效期为5分钟`，超过有效期后将无法再下载。
        /// </summary>
        [JsonProperty("AuthCertUrl")]
        public string AuthCertUrl{ get; set; }

        /// <summary>
        /// 个人用户认证证书的编号, 为20位数字组成的字符串,  由腾讯电子签下发此编号 。该编号会合成到个人用户证书证明图片。注: `个人用户认证证书的编号和证明图片绑定, 获取新的证明图片编号会变动`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageCertId")]
        public string ImageCertId{ get; set; }

        /// <summary>
        /// 在数字证书申请过程中，系统会自动生成一个独一无二的序列号。请注意，当证书到期并自动续期时，该序列号将会发生变化。值得注意的是，此序列号不会被合成至个人用户证书的证明图片中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// CA证书颁发时间，格式为Unix标准时间戳（秒）   该时间格式化后会合成到个人用户证书证明图片
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidFrom")]
        public ulong? ValidFrom{ get; set; }

        /// <summary>
        /// CA证书有效截止时间，格式为Unix标准时间戳（秒）该时间格式化后会合成到个人用户证书证明图片
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
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

