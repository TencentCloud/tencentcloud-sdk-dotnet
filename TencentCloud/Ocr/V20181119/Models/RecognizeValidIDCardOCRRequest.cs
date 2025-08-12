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

    public class RecognizeValidIDCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Base64 值。要求图片经Base64编码后不超过 10M，分辨率建议500*800以上，支持PNG、JPG、JPEG、BMP格式。建议卡片部分占据图片2/3以上。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片的 Url 地址。要求图片经Base64编码后不超过 10M，分辨率建议500*800以上，支持PNG、JPG、JPEG、BMP格式。建议卡片部分占据图片2/3以上。建议图片存储于腾讯云，可保障更高的下载速度和稳定性。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 0 自动，自动判断输入证件的类型
        /// 1 身份证人像面，指定输入证件类型为二代身份证人像面
        /// 2 身份证国徽面，指定输入证件类型为二代身份证国徽面
        /// 3 身份证人像国徽面，指定输入证件类型为二代身份证人像面或者国徽面
        /// 4 临时身份证人像面，指定输入证件类型为临时身份证人像面
        /// 5 临时身份证国徽面，指定输入证件类型为临时身份证国徽面
        /// 6 临时身份证人像国徽面，指定输入证件类型为临时身份证人像面或者国徽面
        /// 7 港澳台居住证人像面，指定输入证件类型为港澳台居住证人像面
        /// 8 港澳台居住证国徽面，指定输入证件类型为港澳台居住证国徽面
        /// 9 港澳台居住证人像国徽面，指定输入证件类型为港澳台居住证人像面或者国徽面
        /// 10 外国人永久居留身份证人像面，指定输入证件类型为外国人永久居留证人像面
        /// 11 外国人永久居留身份证国徽面，指定输入证件类型为外国人永久居留证国徽面
        /// 12 外国人永久居留身份证人像国徽面，指定输入证件类型为外国人永久居留证人像或者国徽面
        /// 该参数如果不填，将为您自动判断卡证类型。
        /// </summary>
        [JsonProperty("CardType")]
        public long? CardType{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件头像切图。
        /// </summary>
        [JsonProperty("EnablePortrait")]
        public bool? EnablePortrait{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件主体切图。
        /// </summary>
        [JsonProperty("EnableCropImage")]
        public bool? EnableCropImage{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回边缘完整性判断。
        /// </summary>
        [JsonProperty("EnableBorderCheck")]
        public bool? EnableBorderCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件是否被遮挡。
        /// </summary>
        [JsonProperty("EnableOcclusionCheck")]
        public bool? EnableOcclusionCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件是否存在复印。
        /// </summary>
        [JsonProperty("EnableCopyCheck")]
        public bool? EnableCopyCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件是否存在屏幕翻拍。
        /// </summary>
        [JsonProperty("EnableReshootCheck")]
        public bool? EnableReshootCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件是否存在PS。类型为：临时、港澳台居住证、外国人居住证失效
        /// </summary>
        [JsonProperty("EnablePSCheck")]
        public bool? EnablePSCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回字段级反光和字段级完整性告警。类型为：临时、港澳台居住证、外国人居住证失效
        /// </summary>
        [JsonProperty("EnableWordCheck")]
        public bool? EnableWordCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回证件是否模糊。
        /// </summary>
        [JsonProperty("EnableQualityCheck")]
        public bool? EnableQualityCheck{ get; set; }

        /// <summary>
        /// 默认值为false，打开返回是否存在电子身份证判断。
        /// </summary>
        [JsonProperty("EnableElectronCheck")]
        public bool? EnableElectronCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "EnablePortrait", this.EnablePortrait);
            this.SetParamSimple(map, prefix + "EnableCropImage", this.EnableCropImage);
            this.SetParamSimple(map, prefix + "EnableBorderCheck", this.EnableBorderCheck);
            this.SetParamSimple(map, prefix + "EnableOcclusionCheck", this.EnableOcclusionCheck);
            this.SetParamSimple(map, prefix + "EnableCopyCheck", this.EnableCopyCheck);
            this.SetParamSimple(map, prefix + "EnableReshootCheck", this.EnableReshootCheck);
            this.SetParamSimple(map, prefix + "EnablePSCheck", this.EnablePSCheck);
            this.SetParamSimple(map, prefix + "EnableWordCheck", this.EnableWordCheck);
            this.SetParamSimple(map, prefix + "EnableQualityCheck", this.EnableQualityCheck);
            this.SetParamSimple(map, prefix + "EnableElectronCheck", this.EnableElectronCheck);
        }
    }
}

