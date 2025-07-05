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
        /// Markdown文件中表格返回的形式
        /// 0，表格以MD形式返回
        /// 1，表格以HTML形式返回
        /// 默认为
        /// </summary>
        [JsonProperty("TableResultType")]
        [System.Obsolete]
        public string TableResultType{ get; set; }

        /// <summary>
        /// 智能文档解析返回结果的格式
        /// 0：只返回全文MD；
        /// 1：只返回每一页的OCR原始Json；
        /// 2：只返回每一页的MD，
        /// 3：返回全文MD + 每一页的OCR原始Json；
        /// 4：返回全文MD + 每一页的MD，
        /// 默认值为3（返回全文MD + 每一页的OCR原始Json）
        /// 
        /// </summary>
        [JsonProperty("ResultType")]
        [System.Obsolete]
        public string ResultType{ get; set; }

        /// <summary>
        /// 是否开启mllm
        /// </summary>
        [JsonProperty("EnableMllm")]
        public bool? EnableMllm{ get; set; }

        /// <summary>
        /// 最大分片长度
        /// </summary>
        [JsonProperty("MaxChunkSize")]
        public long? MaxChunkSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableResultType", this.TableResultType);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "EnableMllm", this.EnableMllm);
            this.SetParamSimple(map, prefix + "MaxChunkSize", this.MaxChunkSize);
        }
    }
}

