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

    public class VerifyGeneralCardWarnRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>卡证类型参数，仅支持传入下列指定值，请按实际情况选择对应卡证类型，目前支持以下类型：<br><strong>身份证件</strong><br>0101 身份证<br>0102 护照<br><strong>经营证照</strong><br>0201 营业执照<br><strong>权属登记</strong><br>0301 行驶证<br><strong>资格许可</strong><br>0401 驾驶证</p>
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// <p>图片的 Url 地址。要求图片经Base64编码后不超过 10M。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>图片的 Base64 值。要求图片经Base64编码后不超过 10M。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
        }
    }
}

