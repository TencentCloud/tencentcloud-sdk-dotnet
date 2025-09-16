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

    public class ExtractDocMultiRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Url 地址。支持的图片格式：PNG、JPG、JPEG，WORD，EXCEL，暂不支持 GIF 格式。支持的图片大小：所下载图片经 Base64 编码后不超过 10M。图片下载时间不超过 3 秒。支持的图片像素：需介于20-10000px之间。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片的 Base64 值。支持的图片格式：PNG、JPG、JPEG，WORD，EXCEL，暂不支持 GIF 格式。支持的图片大小：所下载图片经Base64编码后不超过 10M。图片下载时间不超过 3 秒。支持的图片像素：需介于20-10000px之间。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 需要识别的PDF页面的对应页码，仅支持PDF单页识别，当上传文件为PDF且IsPdf参数值为true时有效，默认值为前3页。
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// 自定义结构化功能需返回的字段名称，例：若客户想新增返回姓名、性别两个字段的识别结果，则输入ItemNames=["姓名","性别"]
        /// </summary>
        [JsonProperty("ItemNames")]
        public string[] ItemNames{ get; set; }

        /// <summary>
        /// true：仅输出自定义字段
        /// false：输出默认字段+自定义字段
        /// 默认true
        /// </summary>
        [JsonProperty("ItemNamesShowMode")]
        public bool? ItemNamesShowMode{ get; set; }

        /// <summary>
        /// 是否开启全文字段识别
        /// </summary>
        [JsonProperty("ReturnFullText")]
        public bool? ReturnFullText{ get; set; }

        /// <summary>
        /// 配置id支持：
        /// General -- 通用场景 
        /// InvoiceEng -- 国际invoice模板 
        /// WayBillEng --海运订单模板
        /// CustomsDeclaration -- 进出口报关单
        /// WeightNote -- 磅单
        /// MedicalMeter -- 血压仪表识别
        /// BillOfLading -- 海运提单
        /// EntrustmentBook -- 海运托书
        /// Statement -- 对账单识别模板
        /// BookingConfirmation -- 配舱通知书识别模板
        /// AirWayBill -- 航空运单识别模板
        /// Table -- 表格模板
        /// SteelLabel -- 实物标签识别模板
        /// CarInsurance -- 车辆保险单识别模板
        /// MultiRealEstateCertificate -- 房产材料识别模板
        /// MultiRealEstateMaterial -- 房产证明识别模板
        /// HongKongUtilityBill -- 中国香港水电煤单识别模板
        /// OverseasCheques -- 海外支票
        /// RegistrationCertificate -- 备案证
        /// ​GridPhoto -- 电网系统照片
        /// ​SignaturePage -- 签署页
        /// 
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 是否开启全文字段坐标值的识别
        /// </summary>
        [JsonProperty("EnableCoord")]
        public bool? EnableCoord{ get; set; }

        /// <summary>
        /// 是否开启父子key识别，默认是
        /// </summary>
        [JsonProperty("OutputParentKey")]
        public bool? OutputParentKey{ get; set; }

        /// <summary>
        /// 模板的单个属性配置
        /// </summary>
        [JsonProperty("ConfigAdvanced")]
        public ConfigAdvanced ConfigAdvanced{ get; set; }

        /// <summary>
        /// cn时，添加的key为中文  
        /// en时，添加的key为英语
        /// </summary>
        [JsonProperty("OutputLanguage")]
        public string OutputLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamArraySimple(map, prefix + "ItemNames.", this.ItemNames);
            this.SetParamSimple(map, prefix + "ItemNamesShowMode", this.ItemNamesShowMode);
            this.SetParamSimple(map, prefix + "ReturnFullText", this.ReturnFullText);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "EnableCoord", this.EnableCoord);
            this.SetParamSimple(map, prefix + "OutputParentKey", this.OutputParentKey);
            this.SetParamObj(map, prefix + "ConfigAdvanced.", this.ConfigAdvanced);
            this.SetParamSimple(map, prefix + "OutputLanguage", this.OutputLanguage);
        }
    }
}

