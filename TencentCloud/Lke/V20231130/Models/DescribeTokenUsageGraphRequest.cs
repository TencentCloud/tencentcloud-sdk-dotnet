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
        /// 腾讯云主账号
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
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间戳, 单位为秒(废弃)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 应用id列表
        /// </summary>
        [JsonProperty("AppBizIds")]
        public string[] AppBizIds{ get; set; }

        /// <summary>
        /// 应用类型(knowledge_qa应用管理， shared_knowlege 共享知识库)
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 筛选子场景
        /// </summary>
        [JsonProperty("SubScenes")]
        public string[] SubScenes{ get; set; }

        /// <summary>
        /// 开始时间戳, 单位为秒
        /// </summary>
        [JsonProperty("StatStartTime")]
        public long? StatStartTime{ get; set; }

        /// <summary>
        /// 结束时间戳, 单位为秒
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

