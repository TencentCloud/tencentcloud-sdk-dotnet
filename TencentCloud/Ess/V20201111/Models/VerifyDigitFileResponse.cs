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

    public class VerifyDigitFileResponse : AbstractModel
    {
        
        /// <summary>
        /// 加签文件MD5哈希值
        /// </summary>
        [JsonProperty("PdfResourceMd5")]
        public string PdfResourceMd5{ get; set; }

        /// <summary>
        /// 验签结果代码，代码的含义如下：<ul><li>**1**：文件验证成功。</li><li>**2**：文件验证失败。</li></ul>
        /// </summary>
        [JsonProperty("VerifyResult")]
        public long? VerifyResult{ get; set; }

        /// <summary>
        /// 验签序列号, 为11位数字组成的字符串
        /// </summary>
        [JsonProperty("VerifySerialNo")]
        public string VerifySerialNo{ get; set; }

        /// <summary>
        /// 验签结果详情，每个签名域对应的验签结果。
        /// </summary>
        [JsonProperty("VerifyDigitFileResults")]
        public VerifyDigitFileResult[] VerifyDigitFileResults{ get; set; }

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
            this.SetParamSimple(map, prefix + "PdfResourceMd5", this.PdfResourceMd5);
            this.SetParamSimple(map, prefix + "VerifyResult", this.VerifyResult);
            this.SetParamSimple(map, prefix + "VerifySerialNo", this.VerifySerialNo);
            this.SetParamArrayObj(map, prefix + "VerifyDigitFileResults.", this.VerifyDigitFileResults);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

