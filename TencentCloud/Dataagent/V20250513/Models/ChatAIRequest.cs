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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatAIRequest : AbstractModel
    {
        
        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 问题内容
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 上下文
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 模型
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 是否深度思考
        /// </summary>
        [JsonProperty("DeepThinking")]
        public bool? DeepThinking{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceIds")]
        public string[] DataSourceIds{ get; set; }

        /// <summary>
        /// agent类型
        /// </summary>
        [JsonProperty("AgentType")]
        public string AgentType{ get; set; }

        /// <summary>
        /// 需要重新生成答案的记录ID
        /// </summary>
        [JsonProperty("OldRecordId")]
        public string OldRecordId{ get; set; }

        /// <summary>
        /// 知识库id列表
        /// </summary>
        [JsonProperty("KnowledgeBaseIds")]
        public string[] KnowledgeBaseIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "DeepThinking", this.DeepThinking);
            this.SetParamArraySimple(map, prefix + "DataSourceIds.", this.DataSourceIds);
            this.SetParamSimple(map, prefix + "AgentType", this.AgentType);
            this.SetParamSimple(map, prefix + "OldRecordId", this.OldRecordId);
            this.SetParamArraySimple(map, prefix + "KnowledgeBaseIds.", this.KnowledgeBaseIds);
        }
    }
}

