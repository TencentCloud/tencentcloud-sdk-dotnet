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

    public class IDCardOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Base64 值。要求图片经Base64编码后不超过 7M，分辨率建议500*800以上，支持PNG、JPG、JPEG、BMP格式。建议卡片部分占据图片2/3以上。
        /// 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片的 Url 地址。要求图片经Base64编码后不超过 7M，分辨率建议500*800以上，支持PNG、JPG、JPEG、BMP格式。建议卡片部分占据图片2/3以上。
        /// 建议图片存储于腾讯云，可保障更高的下载速度和稳定性。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// FRONT：身份证有照片的一面（人像面），
        /// BACK：身份证有国徽的一面（国徽面），
        /// 该参数如果不填，将为您自动判断身份证正反面。
        /// </summary>
        [JsonProperty("CardSide")]
        public string CardSide{ get; set; }

        /// <summary>
        /// 以下可选字段均为bool 类型，默认false：
        /// CropIdCard，身份证照片裁剪（去掉证件外多余的边缘、自动矫正拍摄角度）
        /// CropPortrait，人像照片裁剪（自动抠取身份证头像区域）
        /// CopyWarn，复印件告警
        /// BorderCheckWarn，边框和框内遮挡告警
        /// ReshootWarn，翻拍告警
        /// DetectPsWarn，PS检测告警
        /// TempIdWarn，临时身份证告警
        /// InvalidDateWarn，身份证有效日期不合法告警
        /// Quality，图片质量分数（评价图片的模糊程度）
        /// 
        /// SDK 设置方式参考：
        /// Config = Json.stringify({"CropIdCard":true,"CropPortrait":true})
        /// API 3.0 Explorer 设置方式参考：
        /// Config = {"CropIdCard":true,"CropPortrait":true}
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "CardSide", this.CardSide);
            this.SetParamSimple(map, prefix + "Config", this.Config);
        }
    }
}

