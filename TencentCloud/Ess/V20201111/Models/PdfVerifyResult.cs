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

    public class PdfVerifyResult : AbstractModel
    {
        
        /// <summary>
        /// 验签结果。0-签名域未签名；1-验签成功； 3-验签失败；4-未找到签名域：文件内没有签名域；5-签名值格式不正确。
        /// </summary>
        [JsonProperty("VerifyResult")]
        public long? VerifyResult{ get; set; }

        /// <summary>
        /// 签署平台，如果文件是在腾讯电子签平台签署，则返回腾讯电子签，如果文件不在腾讯电子签平台签署，则返回其他平台。
        /// </summary>
        [JsonProperty("SignPlatform")]
        public string SignPlatform{ get; set; }

        /// <summary>
        /// 签署人名称
        /// </summary>
        [JsonProperty("SignerName")]
        public string SignerName{ get; set; }

        /// <summary>
        /// 签署时间
        /// </summary>
        [JsonProperty("SignTime")]
        public long? SignTime{ get; set; }

        /// <summary>
        /// 签名算法
        /// </summary>
        [JsonProperty("SignAlgorithm")]
        public string SignAlgorithm{ get; set; }

        /// <summary>
        /// 签名证书序列号
        /// </summary>
        [JsonProperty("CertSn")]
        public string CertSn{ get; set; }

        /// <summary>
        /// 证书起始时间
        /// </summary>
        [JsonProperty("CertNotBefore")]
        public long? CertNotBefore{ get; set; }

        /// <summary>
        /// 证书过期时间
        /// </summary>
        [JsonProperty("CertNotAfter")]
        public long? CertNotAfter{ get; set; }

        /// <summary>
        /// 签名域横坐标
        /// </summary>
        [JsonProperty("ComponentPosX")]
        public float? ComponentPosX{ get; set; }

        /// <summary>
        /// 签名域纵坐标
        /// </summary>
        [JsonProperty("ComponentPosY")]
        public float? ComponentPosY{ get; set; }

        /// <summary>
        /// 签名域宽度
        /// </summary>
        [JsonProperty("ComponentWidth")]
        public float? ComponentWidth{ get; set; }

        /// <summary>
        /// 签名域高度
        /// </summary>
        [JsonProperty("ComponentHeight")]
        public float? ComponentHeight{ get; set; }

        /// <summary>
        /// 签名域所在页码
        /// </summary>
        [JsonProperty("ComponentPage")]
        public long? ComponentPage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerifyResult", this.VerifyResult);
            this.SetParamSimple(map, prefix + "SignPlatform", this.SignPlatform);
            this.SetParamSimple(map, prefix + "SignerName", this.SignerName);
            this.SetParamSimple(map, prefix + "SignTime", this.SignTime);
            this.SetParamSimple(map, prefix + "SignAlgorithm", this.SignAlgorithm);
            this.SetParamSimple(map, prefix + "CertSn", this.CertSn);
            this.SetParamSimple(map, prefix + "CertNotBefore", this.CertNotBefore);
            this.SetParamSimple(map, prefix + "CertNotAfter", this.CertNotAfter);
            this.SetParamSimple(map, prefix + "ComponentPosX", this.ComponentPosX);
            this.SetParamSimple(map, prefix + "ComponentPosY", this.ComponentPosY);
            this.SetParamSimple(map, prefix + "ComponentWidth", this.ComponentWidth);
            this.SetParamSimple(map, prefix + "ComponentHeight", this.ComponentHeight);
            this.SetParamSimple(map, prefix + "ComponentPage", this.ComponentPage);
        }
    }
}

