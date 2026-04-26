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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSplitDocumentFlowConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Markdown文件中表格返回的形式<br>0，表格以MD形式返回<br>1，表格以HTML形式返回<br>默认为</p>
        /// </summary>
        [JsonProperty("TableResultType")]
        [System.Obsolete]
        public string TableResultType{ get; set; }

        /// <summary>
        /// <p>智能文档解析返回结果的格式<br>0：只返回全文MD；<br>1：只返回每一页的OCR原始Json；<br>2：只返回每一页的MD；<br>3：返回全文MD + 每一页的OCR原始Json；<br>4：返回全文MD + 每一页的MD；<br>5：返回全文md，每一页ocr原始json，每一页md。</p>
        /// </summary>
        [JsonProperty("ResultType")]
        [System.Obsolete]
        public string ResultType{ get; set; }

        /// <summary>
        /// <p>是否开启mllm</p>
        /// </summary>
        [JsonProperty("EnableMllm")]
        public bool? EnableMllm{ get; set; }

        /// <summary>
        /// <p>最大分片长度</p>
        /// </summary>
        [JsonProperty("MaxChunkSize")]
        public long? MaxChunkSize{ get; set; }

        /// <summary>
        /// <p>是否忽略返回失败页码</p>
        /// </summary>
        [JsonProperty("IgnoreFailedPage")]
        public bool? IgnoreFailedPage{ get; set; }

        /// <summary>
        /// <p>智能文档解析返回结果的格式<br>0：只返回全文MD；<br>1：只返回每一页的OCR原始Json；<br>2：只返回每一页的MD；<br>3：返回全文MD + 每一页的OCR原始Json；<br>4：返回全文MD + 每一页的MD；<br>5：返回全文md，每一页ocr原始json，每一页md。</p>
        /// </summary>
        [JsonProperty("SplitResultType")]
        public string SplitResultType{ get; set; }

        /// <summary>
        /// <p>Markdown文件中表格返回的形式<br>0，表格以MD形式返回<br>1，表格以HTML形式返回<br>默认为</p>
        /// </summary>
        [JsonProperty("SplitTableResultType")]
        public string SplitTableResultType{ get; set; }

        /// <summary>
        /// <p>Markdown文件中是否包含页码信息</p>
        /// </summary>
        [JsonProperty("ReturnPageFormat")]
        public bool? ReturnPageFormat{ get; set; }

        /// <summary>
        /// <p>自定义输出页码样式,{{p}}为页码占位符，开启ReturnPageFormat生效。未填默认样式:<page_num>page {{p}}</page_num></p>
        /// </summary>
        [JsonProperty("PageFormat")]
        public string PageFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableResultType", this.TableResultType);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "EnableMllm", this.EnableMllm);
            this.SetParamSimple(map, prefix + "MaxChunkSize", this.MaxChunkSize);
            this.SetParamSimple(map, prefix + "IgnoreFailedPage", this.IgnoreFailedPage);
            this.SetParamSimple(map, prefix + "SplitResultType", this.SplitResultType);
            this.SetParamSimple(map, prefix + "SplitTableResultType", this.SplitTableResultType);
            this.SetParamSimple(map, prefix + "ReturnPageFormat", this.ReturnPageFormat);
            this.SetParamSimple(map, prefix + "PageFormat", this.PageFormat);
        }
    }
}

