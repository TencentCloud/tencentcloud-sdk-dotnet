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

    public class RecognizeAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>图片/PDF的 Url 地址。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>图片/PDF的 Base64 值。要求图片经Base64编码后不超过 10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>需识别的PDF页码。仅支持PDF单页识别，当上传文件为PDF时有效。</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// <p>模型选择。</p><p>枚举值：</p><ul><li>0： 推理模型。</li><li>1： 识别、推理模型。</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("SelectModel")]
        public long? SelectModel{ get; set; }

        /// <summary>
        /// <p>任务类型。</p><p>枚举值：</p><ul><li><p>0： 全文识别。识别且输出全文内容。</p></li><li><p>1： 判断。判断输入图的内容是否为Query中的内容，返回结果为是或否。如Query:&quot;增值税发票&quot;，该任务类型下，将判断输入图是否为增值税发票，返回&quot;是&quot;或&quot;否&quot;。</p></li><li><p>2： 分类。判断输入图属于Query中具体哪个分类项。如Query:[&quot;营业执照&quot;,&quot;合同&quot;,&quot;票据&quot;]，在该任务类型下，将判断输入图是否属于&quot;营业执照&quot;、&quot;合同&quot;、&quot;票据&quot;，返回&quot;营业执照&quot;/&quot;合同&quot;/&quot;票据&quot;或&quot;均不符合&quot;。</p></li><li><p>3： 总结提炼。总结输入图与Query相关的内容。如Query:&quot;工作经历&quot;，在该任务类型下，将输出输入图中和&quot;工作经历&quot;相关的内容，或&quot;无相关内容&quot;。</p></li><li><p>4： 信息提取。按照自定义字段提取Key-Value，且支持多层级提取，详见入参SchemaItems说明。入参可参考下面的接口示例QueryType=4场景</p></li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("QueryType")]
        public long? QueryType{ get; set; }

        /// <summary>
        /// <p>自定义提取字段的结构，详见SchemaList结构。仅当QueryType=4时生效。</p><p>注：.N表示数组型参数。</p>
        /// </summary>
        [JsonProperty("SchemaItems")]
        public SchemaList[] SchemaItems{ get; set; }

        /// <summary>
        /// <p>推理任务的提示词。与QueryType搭配使用，具体说明见QueryType描述。1）仅当QueryType=1/2/3时生效，且QueryType=1/3时，长度必须为1；2）QueryType=2，Query长度必须符合2≤x≤5。</p><p>注：.N表示数组型参数。</p>
        /// </summary>
        [JsonProperty("Query")]
        public string[] Query{ get; set; }

        /// <summary>
        /// <p>是否需要返回坐标。</p><p>默认值：false</p><p>注：仅对QueryType=4时生效，且坐标位置为 Response.ExtractFields.Polygon。</p>
        /// </summary>
        [JsonProperty("EnableCoord")]
        public bool? EnableCoord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "SelectModel", this.SelectModel);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamArrayObj(map, prefix + "SchemaItems.", this.SchemaItems);
            this.SetParamArraySimple(map, prefix + "Query.", this.Query);
            this.SetParamSimple(map, prefix + "EnableCoord", this.EnableCoord);
        }
    }
}

