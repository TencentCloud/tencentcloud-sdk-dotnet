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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeQaSearch : AbstractModel
    {
        
        /// <summary>
        /// 知识来源 doc：文档，qa：问答  taskflow：业务流程，search：搜索增强，database:数据库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 问答-回复灵活度 1：已采纳答案直接回复 2：已采纳润色后回复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplyFlexibility")]
        public ulong? ReplyFlexibility{ get; set; }

        /// <summary>
        /// 搜索增强-搜索引擎状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseSearchEngine")]
        public bool? UseSearchEngine{ get; set; }

        /// <summary>
        /// 是否显示搜索引擎检索状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowSearchEngine")]
        public bool? ShowSearchEngine{ get; set; }

        /// <summary>
        /// 知识来源，是否选择
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEnabled")]
        public bool? IsEnabled{ get; set; }

        /// <summary>
        /// 问答最大召回数量, 默认2，限制5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QaTopN")]
        public ulong? QaTopN{ get; set; }

        /// <summary>
        /// 文档最大召回数量, 默认3，限制5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocTopN")]
        public ulong? DocTopN{ get; set; }

        /// <summary>
        /// 检索置信度，针对文档和问答有效，最小0.01，最大0.99
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 资源状态 1：资源可用；2：资源已用尽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ReplyFlexibility", this.ReplyFlexibility);
            this.SetParamSimple(map, prefix + "UseSearchEngine", this.UseSearchEngine);
            this.SetParamSimple(map, prefix + "ShowSearchEngine", this.ShowSearchEngine);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "QaTopN", this.QaTopN);
            this.SetParamSimple(map, prefix + "DocTopN", this.DocTopN);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
        }
    }
}

