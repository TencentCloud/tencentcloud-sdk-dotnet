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

    public class DescribeTokenUsageGraphRequest : AbstractModel
    {
        
        /// <summary>
        /// 子账号标识列表，支持批量查询多个子账号。不填时查询主账号下所有子账号的汇总数据
        /// </summary>
        [JsonProperty("UinAccount")]
        public string[] UinAccount{ get; set; }

        /// <summary>
        /// 知识引擎子业务类型:  FileParse(文档解析)、Embedding、Rewrite(多轮改写)、 Concurrency(并发)、KnowledgeSummary(知识总结)   KnowledgeQA(知识问答)、KnowledgeCapacity(知识库容量)、SearchEngine(搜索引擎)
        /// </summary>
        [JsonProperty("SubBizType")]
        public string SubBizType{ get; set; }

        /// <summary>
        /// 模型标识
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 开始时间戳, 单位为秒(废弃)
        /// </summary>
        [JsonProperty("StartTime")]
        [System.Obsolete]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间戳, 单位为秒(废弃)
        /// </summary>
        [JsonProperty("EndTime")]
        [System.Obsolete]
        public string EndTime{ get; set; }

        /// <summary>
        /// 应用ID列表。不填时：若指定SpaceId则查该空间所有应用；否则查用户下所有应用
        /// </summary>
        [JsonProperty("AppBizIds")]
        public string[] AppBizIds{ get; set; }

        /// <summary>
        /// 应用类型。可选值：knowledge_qa(知识问答)/plugin_parsing_qa(插件)/shared_knowledge(知识库)/evaluate_test(评测)。不填时查所有类型
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 筛选子场景
        /// </summary>
        [JsonProperty("SubScenes")]
        public string[] SubScenes{ get; set; }

        /// <summary>
        /// 开始时间。Unix 时间戳，单位是秒，默认为空。
        /// </summary>
        [JsonProperty("StatStartTime")]
        public long? StatStartTime{ get; set; }

        /// <summary>
        /// 结束时间。Unix 时间戳，单位是秒，默认为空。
        /// </summary>
        [JsonProperty("StatEndTime")]
        public long? StatEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "UinAccount.", this.UinAccount);
            this.SetParamSimple(map, prefix + "SubBizType", this.SubBizType);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "AppBizIds.", this.AppBizIds);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamArraySimple(map, prefix + "SubScenes.", this.SubScenes);
            this.SetParamSimple(map, prefix + "StatStartTime", this.StatStartTime);
            this.SetParamSimple(map, prefix + "StatEndTime", this.StatEndTime);
        }
    }
}

