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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeQaConfig : AbstractModel
    {
        
        /// <summary>
        /// 欢迎语，200字符以内
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Greeting")]
        public string Greeting{ get; set; }

        /// <summary>
        /// 角色描述，300字符以内
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoleDescription")]
        public string RoleDescription{ get; set; }

        /// <summary>
        /// 模型配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Model")]
        public AppModel Model{ get; set; }

        /// <summary>
        /// 知识搜索配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Search")]
        public KnowledgeQaSearch[] Search{ get; set; }

        /// <summary>
        /// 知识管理输出配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Output")]
        public KnowledgeQaOutput Output{ get; set; }

        /// <summary>
        /// 工作流程配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Workflow")]
        public KnowledgeWorkflow Workflow{ get; set; }

        /// <summary>
        /// 检索范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchRange")]
        public SearchRange SearchRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Greeting", this.Greeting);
            this.SetParamSimple(map, prefix + "RoleDescription", this.RoleDescription);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamArrayObj(map, prefix + "Search.", this.Search);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "Workflow.", this.Workflow);
            this.SetParamObj(map, prefix + "SearchRange.", this.SearchRange);
        }
    }
}

