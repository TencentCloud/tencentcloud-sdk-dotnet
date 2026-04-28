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

    public class Scene : AbstractModel
    {
        
        /// <summary>
        /// <p>场景ID</p>
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// <p>场景名称</p>
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// <p>技能列表，包含：rag（知识检索）、data_analytics（数据分析）、data_prediction（数据预测）</p>
        /// </summary>
        [JsonProperty("Skills")]
        public string[] Skills{ get; set; }

        /// <summary>
        /// <p>提示词文本</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>检索配置</p>
        /// </summary>
        [JsonProperty("SearchConfig")]
        public SearchConfig SearchConfig{ get; set; }

        /// <summary>
        /// <p>示例问答列表</p>
        /// </summary>
        [JsonProperty("ExampleQAList")]
        public ExampleQA[] ExampleQAList{ get; set; }

        /// <summary>
        /// <p>记录的创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>记录的最后更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>创建者Uin</p>
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// <p>知识</p>
        /// </summary>
        [JsonProperty("Knowledge")]
        public string Knowledge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamArraySimple(map, prefix + "Skills.", this.Skills);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "SearchConfig.", this.SearchConfig);
            this.SetParamArrayObj(map, prefix + "ExampleQAList.", this.ExampleQAList);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "Knowledge", this.Knowledge);
        }
    }
}

