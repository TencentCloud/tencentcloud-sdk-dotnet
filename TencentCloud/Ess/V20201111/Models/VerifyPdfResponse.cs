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

    public class VerifyPdfResponse : AbstractModel
    {
        
        /// <summary>
        /// 验签结果，1-文件未被篡改，全部签名在腾讯电子签完成； 2-文件未被篡改，部分签名在腾讯电子签完成；3-文件被篡改；4-异常：文件内没有签名域；5-异常：文件签名格式错误
        /// </summary>
        [JsonProperty("VerifyResult")]
        public long? VerifyResult{ get; set; }

        /// <summary>
        /// 验签结果详情，每个签名域对应的验签结果。状态值：1-验签成功，在电子签签署；2-验签成功，在其他平台签署；3-验签失败；4-pdf文件没有签名域；5-文件签名格式错误
        /// </summary>
        [JsonProperty("PdfVerifyResults")]
        public PdfVerifyResult[] PdfVerifyResults{ get; set; }

        /// <summary>
        /// 验签序列号
        /// </summary>
        [JsonProperty("VerifySerialNo")]
        public string VerifySerialNo{ get; set; }

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
            this.SetParamSimple(map, prefix + "VerifyResult", this.VerifyResult);
            this.SetParamArrayObj(map, prefix + "PdfVerifyResults.", this.PdfVerifyResults);
            this.SetParamSimple(map, prefix + "VerifySerialNo", this.VerifySerialNo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

