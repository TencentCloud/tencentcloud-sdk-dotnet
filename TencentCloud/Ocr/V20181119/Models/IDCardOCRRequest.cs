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
        /// 图片的 Base64 值。
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过 3M。图片下载时间不超过 3 秒。
        /// 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片的 Url 地址。
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经 Base64 编码后不超过 3M。图片下载时间不超过 3 秒。
        /// 图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。
        /// 非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// FRONT 为身份证有照片的一面（人像面），
        /// BACK 为身份证有国徽的一面（国徽面）。
        /// </summary>
        [JsonProperty("CardSide")]
        public string CardSide{ get; set; }

        /// <summary>
        /// 可选字段，根据需要选择是否请求对应字段。
        /// 目前包含的字段为：
        /// CropIdCard，身份证照片裁剪，bool 类型，
        /// CropPortrait，人像照片裁剪，bool 类型，
        /// CopyWarn，复印件告警，bool 类型，
        /// ReshootWarn，翻拍告警，bool 类型。
        /// 
        /// SDK 设置方式参考：
        /// Config = Json.stringify({"CropIdCard":true,"CropPortrait":true})
        /// API 3.0 Explorer 设置方式参考：
        /// Config = {"CropIdCard":true,"CropPortrait":true}
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
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

