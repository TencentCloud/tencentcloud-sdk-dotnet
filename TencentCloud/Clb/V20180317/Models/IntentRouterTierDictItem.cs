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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntentRouterTierDictItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Tier 标识</p><p>枚举值：</p><ul><li>default： 默认</li><li>general_chat： 通用对话</li><li>transformation_rewrite： 转换与改写</li><li>knowledge_qa： 知识问答</li><li>summarization： 摘要</li><li>extraction_structuring： 抽取与结构化输出</li><li>content_generation： 内容生成</li><li>coding_technical： 编码与技术</li><li>data_math_analysis： 数据、数学与分析</li><li>reasoning_planning： 推理与规划</li><li>tool_agentic_workflow： 工具与智能体工作流</li></ul>
        /// </summary>
        [JsonProperty("TierId")]
        public string TierId{ get; set; }

        /// <summary>
        /// <p>Tier 显示名称（已国际化）</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>Tier 描述（已国际化）</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TierId", this.TierId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

