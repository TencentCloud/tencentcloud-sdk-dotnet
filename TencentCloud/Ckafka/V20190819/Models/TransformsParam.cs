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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterParam")]
        public FilterMapParam[] FilterParam{ get; set; }

        /// <summary>
        /// 失败处理
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureParam")]
        public FailureParam FailureParam{ get; set; }

        /// <summary>
        /// 测试结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 数据来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 输出格式，JSON，ROW，默认为JSON
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// 输出格式为ROW必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RowParam")]
        public RowParam RowParam{ get; set; }

        /// <summary>
        /// 是否保留数据源Topic元数据信息（源Topic、Partition、Offset），默认为false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeepMetadata")]
        public bool? KeepMetadata{ get; set; }


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
        }
    }
}

