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

    public class KBRetrievalConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>数据库检索配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbRetrievalConfig")]
        public DBRetrievalConfig DbRetrievalConfig{ get; set; }

        /// <summary>
        /// <p>文档检索配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocRetrievalConfig")]
        public DocRetrievalConfig DocRetrievalConfig{ get; set; }

        /// <summary>
        /// <p>知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>检索可选配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptionConfig")]
        public RetrievalOption OptionConfig{ get; set; }

        /// <summary>
        /// <p>QA 检索配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QaRetrievalConfig")]
        public QARetrievalConfig QaRetrievalConfig{ get; set; }

        /// <summary>
        /// <p>rerank 配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RerankConfig")]
        public RerankConfig RerankConfig{ get; set; }

        /// <summary>
        /// <p>检索过滤配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchFilterConfig")]
        public SearchFilterConfig SearchFilterConfig{ get; set; }

        /// <summary>
        /// <p>检索策略：1=混合，2=语义，3=关键词，4=无<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>SEARCH_STRATEGY_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SEARCH_STRATEGY_TYPE_MIXING</td><td>1</td><td>混合检索</td></tr><tr><td>SEARCH_STRATEGY_TYPE_SEMANTIC</td><td>2</td><td>语义检索</td></tr><tr><td>SEARCH_STRATEGY_TYPE_KEYWORD</td><td>3</td><td>关键词检索</td></tr><tr><td>SEARCH_STRATEGY_TYPE_NONE</td><td>4</td><td>无语义/向量检索</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// <p>text2sql 模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextToSqlModel")]
        public ModelDetailInfo TextToSqlModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DbRetrievalConfig.", this.DbRetrievalConfig);
            this.SetParamObj(map, prefix + "DocRetrievalConfig.", this.DocRetrievalConfig);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamObj(map, prefix + "OptionConfig.", this.OptionConfig);
            this.SetParamObj(map, prefix + "QaRetrievalConfig.", this.QaRetrievalConfig);
            this.SetParamObj(map, prefix + "RerankConfig.", this.RerankConfig);
            this.SetParamObj(map, prefix + "SearchFilterConfig.", this.SearchFilterConfig);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamObj(map, prefix + "TextToSqlModel.", this.TextToSqlModel);
        }
    }
}

