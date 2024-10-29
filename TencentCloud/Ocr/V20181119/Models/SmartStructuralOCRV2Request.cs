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

    public class SmartStructuralOCRV2Request : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Url 地址。支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。支持的图片大小：所下载图片经 Base64 编码后不超过 10M。图片下载时间不超过 3 秒。支持的图片像素：需介于20-10000px之间。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片的 Base64 值。支持的图片格式：PNG、JPG、JPEG，暂不支持 GIF 格式。支持的图片大小：所下载图片经Base64编码后不超过 10M。图片下载时间不超过 3 秒。支持的图片像素：需介于20-10000px之间。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

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
        /// 自定义结构化功能需返回的字段名称，例：
        /// 若客户只想返回姓名、性别两个字段的识别结果，则输入
        /// ItemNames=["姓名","性别"]
        /// </summary>
        [JsonProperty("ItemNames")]
        public string[] ItemNames{ get; set; }

        /// <summary>
        /// 是否开启全文字段识别
        /// </summary>
        [JsonProperty("ReturnFullText")]
        public bool? ReturnFullText{ get; set; }

        /// <summary>
        /// 配置id支持：
        /// General -- 通用场景
        /// OnlineTaxiItinerary -- 网约车行程单
        /// RideHailingDriverLicense -- 网约车驾驶证
        /// RideHailingTransportLicense -- 网约车运输证
        /// WayBill -- 快递运单
        /// AccountOpeningPermit -- 银行开户许可证
        /// InvoiceEng -- 海外发票模版
        /// Coin --钱币识别模板
        /// OnboardingDocuments -- 入职材料识别
        /// PropertyOwnershipCertificate -- 房产证识别
        /// RealEstateCertificate --不动产权证识别
        /// HouseEncumbranceCertificate -- 他权证识别
        /// CarInsurance -- 车险保单
        /// MultiRealEstateCertificate -- 房产证、不动产证、产权证等材料合一模板
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 是否打开印章识别
        /// </summary>
        [JsonProperty("EnableSealRecognize")]
        public bool? EnableSealRecognize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "IsPdf", this.IsPdf);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamArraySimple(map, prefix + "ItemNames.", this.ItemNames);
            this.SetParamSimple(map, prefix + "ReturnFullText", this.ReturnFullText);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "EnableSealRecognize", this.EnableSealRecognize);
        }
    }
}

