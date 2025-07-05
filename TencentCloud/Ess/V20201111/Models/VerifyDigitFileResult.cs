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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyDigitFileResult : AbstractModel
    {
        
        /// <summary>
        /// 证书起始时间的Unix时间戳，单位毫秒
        /// </summary>
        [JsonProperty("CertNotBefore")]
        public long? CertNotBefore{ get; set; }

        /// <summary>
        /// 证书过期时间的时间戳，单位毫秒
        /// </summary>
        [JsonProperty("CertNotAfter")]
        public long? CertNotAfter{ get; set; }

        /// <summary>
        /// 证书序列号，在数字证书申请过程中，系统会自动生成一个独一无二的序号。	
        /// </summary>
        [JsonProperty("CertSn")]
        public string CertSn{ get; set; }

        /// <summary>
        /// 证书签名算法, 如SHA1withRSA等算法
        /// </summary>
        [JsonProperty("SignAlgorithm")]
        public string SignAlgorithm{ get; set; }

        /// <summary>
        /// 签署时间的Unix时间戳，单位毫秒
        /// </summary>
        [JsonProperty("SignTime")]
        public long? SignTime{ get; set; }

        /// <summary>
        /// 签名类型。0表示带签章的数字签名，1表示仅数字签名
        /// </summary>
        [JsonProperty("SignType")]
        public long? SignType{ get; set; }

        /// <summary>
        /// 申请证书的主体的名字
        /// 
        /// 如果是在腾讯电子签平台签署, 则对应的主体的名字个数如下
        /// **企业**:  ESS@企业名称@编码
        /// **个人**: ESS@个人姓名@证件号@808854
        /// 
        /// 如果在其他平台签署的, 主体的名字参考其他平台的说明
        /// </summary>
        [JsonProperty("SignerName")]
        public string SignerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertNotBefore", this.CertNotBefore);
            this.SetParamSimple(map, prefix + "CertNotAfter", this.CertNotAfter);
            this.SetParamSimple(map, prefix + "CertSn", this.CertSn);
            this.SetParamSimple(map, prefix + "SignAlgorithm", this.SignAlgorithm);
            this.SetParamSimple(map, prefix + "SignTime", this.SignTime);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "SignerName", this.SignerName);
        }
    }
}

