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

    public class VerifyOfdVatInvoiceOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// OFD文件的 Url 地址。
        /// </summary>
        [JsonProperty("OfdFileUrl")]
        public string OfdFileUrl{ get; set; }

        /// <summary>
        /// OFD文件的 Base64 值。OfdFileUrl 和 OfdFileBase64 必传其一，若两者都传，只使用OfdFileUrl。
        /// </summary>
        [JsonProperty("OfdFileBase64")]
        public string OfdFileBase64{ get; set; }

        /// <summary>
        /// 需要识别的OFD发票页面的对应页码，默认值为1。 示例值：1
        /// </summary>
        [JsonProperty("OfdPageNumber")]
        public long? OfdPageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OfdFileUrl", this.OfdFileUrl);
            this.SetParamSimple(map, prefix + "OfdFileBase64", this.OfdFileBase64);
            this.SetParamSimple(map, prefix + "OfdPageNumber", this.OfdPageNumber);
        }
    }
}

