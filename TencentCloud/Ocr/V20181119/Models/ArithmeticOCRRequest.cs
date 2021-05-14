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

    public class ArithmeticOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Base64 值。
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过 7M。图片下载时间不超过 3 秒。
        /// 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片的 Url 地址。
        /// 支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经 Base64 编码后不超过 7M。图片下载时间不超过 3 秒。
        /// 图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。
        /// 非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 用于选择是否支持横屏拍摄。打开则支持横屏拍摄图片角度判断，角度信息在返回参数的angle中，默认值为true
        /// </summary>
        [JsonProperty("SupportHorizontalImage")]
        public bool? SupportHorizontalImage{ get; set; }

        /// <summary>
        /// 是否拒绝非速算图，打开则拒绝非速算图(注：非速算图是指风景人物等明显不是速算图片的图片)，默认值为false
        /// </summary>
        [JsonProperty("RejectNonArithmeticPic")]
        public bool? RejectNonArithmeticPic{ get; set; }

        /// <summary>
        /// 是否展开耦合算式中的竖式计算，默认值为false
        /// </summary>
        [JsonProperty("EnableDispRelatedVertical")]
        public bool? EnableDispRelatedVertical{ get; set; }

        /// <summary>
        /// 是否展示竖式算式的中间结果和格式控制字符，默认值为false
        /// </summary>
        [JsonProperty("EnableDispMidResult")]
        public bool? EnableDispMidResult{ get; set; }

        /// <summary>
        /// 是否开启pdf识别，默认值为true
        /// </summary>
        [JsonProperty("EnablePdfRecognize")]
        public bool? EnablePdfRecognize{ get; set; }

        /// <summary>
        /// pdf页码，从0开始，默认为0
        /// </summary>
        [JsonProperty("PdfPageIndex")]
        public long? PdfPageIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "SupportHorizontalImage", this.SupportHorizontalImage);
            this.SetParamSimple(map, prefix + "RejectNonArithmeticPic", this.RejectNonArithmeticPic);
            this.SetParamSimple(map, prefix + "EnableDispRelatedVertical", this.EnableDispRelatedVertical);
            this.SetParamSimple(map, prefix + "EnableDispMidResult", this.EnableDispMidResult);
            this.SetParamSimple(map, prefix + "EnablePdfRecognize", this.EnablePdfRecognize);
            this.SetParamSimple(map, prefix + "PdfPageIndex", this.PdfPageIndex);
        }
    }
}

