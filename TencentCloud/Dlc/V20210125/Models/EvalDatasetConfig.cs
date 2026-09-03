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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EvalDatasetConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>验证集模式：none / split / separate</p>
        /// </summary>
        [JsonProperty("EvalMode")]
        public string EvalMode{ get; set; }

        /// <summary>
        /// <p>自动拆分比例（1-20，即 1%-20%），仅 split 生效</p>
        /// </summary>
        [JsonProperty("EvalSplitRatio")]
        public float? EvalSplitRatio{ get; set; }

        /// <summary>
        /// <p>独立验证数据集 ID（dataset 表），仅 separate 生效；与 Catalog 二选一</p>
        /// </summary>
        [JsonProperty("EvalDatasetId")]
        public string EvalDatasetId{ get; set; }

        /// <summary>
        /// <p>验证数据集名称（dataset 表 name 字段，与 EvalDatasetId 配对）</p>
        /// </summary>
        [JsonProperty("EvalDatasetName")]
        public string EvalDatasetName{ get; set; }

        /// <summary>
        /// <p>原始 Catalog 卷定义 JSON（仅 separate 生效，无数据集 ID 时使用，直接并入顶层 Catalog；与 EvalDatasetId 二选一）</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>验证用单文件名（可选，JSONL/parquet 文件名，位于挂载目录下；仅基于单个文件验证时指定）</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvalMode", this.EvalMode);
            this.SetParamSimple(map, prefix + "EvalSplitRatio", this.EvalSplitRatio);
            this.SetParamSimple(map, prefix + "EvalDatasetId", this.EvalDatasetId);
            this.SetParamSimple(map, prefix + "EvalDatasetName", this.EvalDatasetName);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
        }
    }
}

