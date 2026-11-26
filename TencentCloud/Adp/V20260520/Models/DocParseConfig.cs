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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocParseConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>内容过滤配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentFilter")]
        public ContentFilter ContentFilter{ get; set; }

        /// <summary>
        /// <p>文档解析策略：1=OCR解析 2=智能解析 3=MLLM解析；不传默认智能解析<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>DOC_PARSE_STRATEGY_UNKNOWN</td><td>0</td><td>未指定，走服务端默认（智能解析）</td></tr><tr><td>DOC_PARSE_STRATEGY_OCR</td><td>1</td><td>OCR 解析</td></tr><tr><td>DOC_PARSE_STRATEGY_SMART</td><td>2</td><td>智能解析（按图片类型自动选择：数据图/思维导图/架构图/流程图用 MLLM，其他图片用 OCR）</td></tr><tr><td>DOC_PARSE_STRATEGY_MLLM</td><td>3</td><td>MLLM 解析</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ParseStrategy")]
        public long? ParseStrategy{ get; set; }

        /// <summary>
        /// <p>分割规则</p>
        /// </summary>
        [JsonProperty("SplitRule")]
        public string SplitRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ContentFilter.", this.ContentFilter);
            this.SetParamSimple(map, prefix + "ParseStrategy", this.ParseStrategy);
            this.SetParamSimple(map, prefix + "SplitRule", this.SplitRule);
        }
    }
}

