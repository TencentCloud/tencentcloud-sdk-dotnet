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

    public class SubmitExtractDocAgentJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>图片/PDF的 Base64 值。要求Base64不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>图片/PDF的 Url 地址。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>需要识别的PDF页面的对应页码，仅支持PDF单页识别，当上传文件为PDF且IsPdf参数值为true时有效，默认值为前5页。</p>
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        [System.Obsolete]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// <p>自定义抽取需要的字段名称、字段类型、字段提示词。</p>
        /// </summary>
        [JsonProperty("ItemNames")]
        public ItemNames[] ItemNames{ get; set; }

        /// <summary>
        /// <p>是否需要返回坐标，默认false。</p>
        /// </summary>
        [JsonProperty("EnableCoord")]
        public bool? EnableCoord{ get; set; }

        /// <summary>
        /// <p>起始页</p>
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public ulong? FileStartPageNumber{ get; set; }

        /// <summary>
        /// <p>结束页</p>
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public ulong? FileEndPageNumber{ get; set; }

        /// <summary>
        /// <p>model_hunyuan:选择混元底座视觉大模型精调抽取任务  model_youtu：选择优图底座多模态大模型精调抽取任务</p>
        /// </summary>
        [JsonProperty("ModelConfig")]
        public string ModelConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamArrayObj(map, prefix + "ItemNames.", this.ItemNames);
            this.SetParamSimple(map, prefix + "EnableCoord", this.EnableCoord);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
            this.SetParamSimple(map, prefix + "ModelConfig", this.ModelConfig);
        }
    }
}

