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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransformsParam : AbstractModel
    {
        
        /// <summary>
        /// 原始数据
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 处理链
        /// </summary>
        [JsonProperty("FieldChain")]
        public FieldParam[] FieldChain{ get; set; }

        /// <summary>
        /// 过滤器
        /// </summary>
        [JsonProperty("FilterParam")]
        public FilterMapParam[] FilterParam{ get; set; }

        /// <summary>
        /// 失败处理
        /// </summary>
        [JsonProperty("FailureParam")]
        public FailureParam FailureParam{ get; set; }

        /// <summary>
        /// 测试结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 输出格式，JSON，ROW，默认为JSON
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// 输出格式为ROW必填
        /// </summary>
        [JsonProperty("RowParam")]
        public RowParam RowParam{ get; set; }

        /// <summary>
        /// 是否保留数据源Topic元数据信息（源Topic、Partition、Offset），默认为false
        /// </summary>
        [JsonProperty("KeepMetadata")]
        public bool? KeepMetadata{ get; set; }

        /// <summary>
        /// 数组解析
        /// </summary>
        [JsonProperty("BatchAnalyse")]
        public BatchAnalyseParam BatchAnalyse{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "FieldChain.", this.FieldChain);
            this.SetParamArrayObj(map, prefix + "FilterParam.", this.FilterParam);
            this.SetParamObj(map, prefix + "FailureParam.", this.FailureParam);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamObj(map, prefix + "RowParam.", this.RowParam);
            this.SetParamSimple(map, prefix + "KeepMetadata", this.KeepMetadata);
            this.SetParamObj(map, prefix + "BatchAnalyse.", this.BatchAnalyse);
        }
    }
}

