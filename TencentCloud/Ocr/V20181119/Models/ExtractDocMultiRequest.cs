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
        /// <p>图片/PDF的 Url 地址。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>图片/PDF的 Base64 值。要求Base64不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>需要识别的PDF页面的对应页码，仅支持PDF单页识别。</p>
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public ulong? PdfPageNumber{ get; set; }

        /// <summary>
        /// <p>自定义结构化功能需返回的字段名称，例：若客户想新增返回姓名、性别两个字段的识别结果，则输入ItemNames=[&quot;姓名&quot;,&quot;性别&quot;]</p>
        /// </summary>
        [JsonProperty("ItemNames")]
        public string[] ItemNames{ get; set; }

        /// <summary>
        /// <p>true：仅输出自定义字段<br>false：输出默认字段+自定义字段<br>默认true</p>
        /// </summary>
        [JsonProperty("ItemNamesShowMode")]
        public bool? ItemNamesShowMode{ get; set; }

        /// <summary>
        /// <p>是否开启全文字段识别</p>
        /// </summary>
        [JsonProperty("ReturnFullText")]
        public bool? ReturnFullText{ get; set; }

        /// <summary>
        /// <p>配置id支持：<br>General -- 通用场景<br>InvoiceEng -- 国际invoice模板<br>WayBillEng --海运订单模板<br>CustomsDeclaration -- 进出口报关单<br>WeightNote -- 磅单<br>MedicalMeter -- 血压仪表识别<br>BillOfLading -- 海运提单<br>EntrustmentBook -- 海运托书<br>Statement -- 对账单识别模板<br>BookingConfirmation -- 配舱通知书识别模板<br>AirWayBill -- 航空运单识别模板<br>Table -- 表格模板<br>SteelLabel -- 实物标签识别模板<br>CarInsurance -- 车辆保险单识别模板<br>MultiRealEstateCertificate -- 房产材料识别模板<br>MultiRealEstateMaterial -- 房产证明识别模板<br>HongKongUtilityBill -- 中国香港水电煤单识别模板<br>OverseasCheques -- 海外支票<br>RegistrationCertificate -- 备案证<br>u200bGridPhoto -- 电网系统照片<br>u200bSignaturePage -- 签署页<br>u200bSalesDeliveryNote -- 销售发货单</p>
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// <p>是否开启全文字段坐标值的识别</p>
        /// </summary>
        [JsonProperty("EnableCoord")]
        public bool? EnableCoord{ get; set; }

        /// <summary>
        /// <p>是否开启父子key识别，默认是</p>
        /// </summary>
        [JsonProperty("OutputParentKey")]
        public bool? OutputParentKey{ get; set; }

        /// <summary>
        /// <p>模板的单个属性配置</p>
        /// </summary>
        [JsonProperty("ConfigAdvanced")]
        public ConfigAdvanced ConfigAdvanced{ get; set; }

        /// <summary>
        /// <p>cn时，添加的key为中文<br>en时，添加的key为英语</p>
        /// </summary>
        [JsonProperty("OutputLanguage")]
        public string OutputLanguage{ get; set; }

        /// <summary>
        /// <p>自定义抽取需要的字段名称、字段类型、字段提示词</p>
        /// </summary>
        [JsonProperty("NewItemNames")]
        public ItemNames[] NewItemNames{ get; set; }

        /// <summary>
        /// <p>文档抽取（多模态）识别服务所用的算法模型版本<br>-目前入参支持“1.0”和“2.0“两个输入。</p><ul><li>2026年7月20日开始，默认为“2.0”，之前使用过本接口的账号若未填写本参数默认为“1.0”。</li><li>2026年7月20日后开通服务的账号仅支持输入“2.0”。</li><li>不同算法模型版本对应的文档抽取识别算法不同，新版本的整体效果会优于旧版本，建议使用“2.0”版本。<br>示例值：2.0</li></ul>
        /// </summary>
        [JsonProperty("MultiModelVersion")]
        public string MultiModelVersion{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "NewItemNames.", this.NewItemNames);
            this.SetParamSimple(map, prefix + "MultiModelVersion", this.MultiModelVersion);
        }
    }
}

