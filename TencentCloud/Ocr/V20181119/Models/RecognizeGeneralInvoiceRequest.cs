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

    public class RecognizeGeneralInvoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Base64 值。
        /// 支持的图片格式：PNG、JPG、JPEG、PDF，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过 8M。图片下载时间不超过 3 秒。
        /// 支持的图片像素：单边介于20-10000px之间。
        /// 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片的 Url 地址。
        /// 支持的图片格式：PNG、JPG、JPEG、PDF，暂不支持 GIF 格式。
        /// 支持的图片大小：所下载图片经 Base64 编码后不超过 8M。图片下载时间不超过 3 秒。
        /// 支持的图片像素：单边介于20-10000px之间。
        /// 图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。
        /// 非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 需要识别的票据类型列表，为空或不填表示识别全部类型。当传入单个类型时，图片均采用该票类型进行处理。
        /// 暂不支持多个参数进行局部控制。
        /// 0：出租车发票
        /// 1：定额发票
        /// 2：火车票
        /// 3：增值税发票
        /// 5：机票行程单
        /// 8：通用机打发票
        /// 9：汽车票
        /// 10：轮船票
        /// 11：增值税发票（卷票 ）
        /// 12：购车发票
        /// 13：过路过桥费发票
        /// 15：非税发票
        /// 16：全电发票
        /// 17：医疗发票
        /// 18：完税凭证
        /// 19：海关缴款书
        /// -1：其他发票
        /// </summary>
        [JsonProperty("Types")]
        public long?[] Types{ get; set; }

        /// <summary>
        /// 是否开启其他票识别，默认值为true，开启后可支持其他发票的智能识别。	
        /// </summary>
        [JsonProperty("EnableOther")]
        public bool? EnableOther{ get; set; }

        /// <summary>
        /// 是否开启PDF识别，默认值为true，开启后可同时支持图片和PDF的识别。
        /// </summary>
        [JsonProperty("EnablePdf")]
        public bool? EnablePdf{ get; set; }

        /// <summary>
        /// 需要识别的PDF页面的对应页码，传入时仅支持PDF单页识别，当上传文件为PDF且EnablePdf参数值为true时有效，默认值为1。
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// 是否开启PDF多页识别，默认值为false，开启后可同时支持多页PDF的识别返回，仅支持返回文件前30页。开启后EnablePdf和PdfPageNumber入参不进行控制。
        /// </summary>
        [JsonProperty("EnableMultiplePage")]
        public bool? EnableMultiplePage{ get; set; }

        /// <summary>
        /// 是否返回切割图片base64，默认值为false。
        /// </summary>
        [JsonProperty("EnableCutImage")]
        public bool? EnableCutImage{ get; set; }

        /// <summary>
        /// 是否打开字段坐标返回。默认为false。
        /// </summary>
        [JsonProperty("EnableItemPolygon")]
        public bool? EnableItemPolygon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "EnableOther", this.EnableOther);
            this.SetParamSimple(map, prefix + "EnablePdf", this.EnablePdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "EnableMultiplePage", this.EnableMultiplePage);
            this.SetParamSimple(map, prefix + "EnableCutImage", this.EnableCutImage);
            this.SetParamSimple(map, prefix + "EnableItemPolygon", this.EnableItemPolygon);
        }
    }
}

