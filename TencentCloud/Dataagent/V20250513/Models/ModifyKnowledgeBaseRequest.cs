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

    public class ModifyKnowledgeBaseRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 操作类型：Create，Update，Delete
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }

        /// <summary>
        /// 知识库id，update和delete时必填
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 知识库名称，create和update时必填。只允许字母、数字、汉字、下划线
        /// </summary>
        [JsonProperty("KnowledgeBaseName")]
        public string KnowledgeBaseName{ get; set; }

        /// <summary>
        /// 知识库描述，create和update时必填
        /// </summary>
        [JsonProperty("KnowledgeBaseDesc")]
        public string KnowledgeBaseDesc{ get; set; }

        /// <summary>
        /// 1仅自己使用，2指定用户，0全员
        /// </summary>
        [JsonProperty("UseScope")]
        public long? UseScope{ get; set; }

        /// <summary>
        /// 可使用用户列表
        /// </summary>
        [JsonProperty("AuthorityUins")]
        public string[] AuthorityUins{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "KnowledgeBaseName", this.KnowledgeBaseName);
            this.SetParamSimple(map, prefix + "KnowledgeBaseDesc", this.KnowledgeBaseDesc);
            this.SetParamSimple(map, prefix + "UseScope", this.UseScope);
            this.SetParamArraySimple(map, prefix + "AuthorityUins.", this.AuthorityUins);
        }
    }
}

