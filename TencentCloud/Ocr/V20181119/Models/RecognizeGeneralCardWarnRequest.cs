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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeGeneralCardWarnRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片base64
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 卡证类型参数，包含以下范围：  
        /// default：通用卡证  
        /// idcard：身份证  
        /// passport：护照  
        /// bizlicense：营业执照  
        /// regcertificate：登记证书  
        /// residpermit：居住证  
        /// transpermit：通行证  
        /// signboard：门头照  
        /// bankcard：银行卡  
        /// drivinglicense：驾驶证、行驶证
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// 是否开启PDF识别，默认值为false，开启后可同时支持图片和PDF的识别。
        /// </summary>
        [JsonProperty("IsPdf")]
        public bool? IsPdf{ get; set; }

        /// <summary>
        /// 需要识别的PDF页面的对应页码，仅支持PDF单页识别，当上传文件为PDF且IsPdf参数值为true时有效，默认值为1。
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "IsPdf", this.IsPdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
        }
    }
}

