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

    public class KnowledgeQaConfig : AbstractModel
    {
        
        /// <summary>
        /// 欢迎语，200字符以内
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Greeting")]
        public string Greeting{ get; set; }

        /// <summary>
        /// 角色描述，4000字符以内。通过填写描述，设定应用的 #角色名称、 #风格特点 及可达成的#意图。建议按照下面的模板填写，且自定义意图建议不超过5个。
        /// 
        /// #角色名称：
        /// #风格特点：
        /// #输出要求：
        /// #能力限制：
        /// 
        /// 能够达成以下用户意图
        /// ##意图名称：
        /// ##意图描述：
        /// ##意图示例：
        /// ##意图实现：
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoleDescription")]
        public string RoleDescription{ get; set; }

        /// <summary>
        /// 生成模型配置
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
        /// 应用模式，standard:标准模式, agent: agent模式，single_workflow：单工作流模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// 检索策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchStrategy")]
        public SearchStrategy SearchStrategy{ get; set; }

        /// <summary>
        /// 单工作流ID，Pattern为single_workflow时传入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SingleWorkflow")]
        public KnowledgeQaSingleWorkflow SingleWorkflow{ get; set; }

        /// <summary>
        /// 应用关联插件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Plugins")]
        public KnowledgeQaPlugin[] Plugins{ get; set; }

        /// <summary>
        /// 思考模型配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThoughtModel")]
        public AppModel ThoughtModel{ get; set; }

        /// <summary>
        /// 意图达成方式优先级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentAchievements")]
        public IntentAchievement[] IntentAchievements{ get; set; }

        /// <summary>
        /// 是否开启图文检索
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageTextRetrieval")]
        public bool? ImageTextRetrieval{ get; set; }

        /// <summary>
        /// 配置语音通话参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiCall")]
        public AICallConfig AiCall{ get; set; }

        /// <summary>
        /// 共享知识库关联配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareKnowledgeBases")]
        public ShareKnowledgeBase[] ShareKnowledgeBases{ get; set; }

        /// <summary>
        /// 背景图相关信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackgroundImage")]
        public BackgroundImageConfig BackgroundImage{ get; set; }

        /// <summary>
        /// 开场问题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpeningQuestions")]
        public string[] OpeningQuestions{ get; set; }

        /// <summary>
        /// 长期记忆开关
        /// </summary>
        [JsonProperty("LongMemoryOpen")]
        public bool? LongMemoryOpen{ get; set; }

        /// <summary>
        /// 长期记忆时效
        /// </summary>
        [JsonProperty("LongMemoryDay")]
        public ulong? LongMemoryDay{ get; set; }

        /// <summary>
        /// agent配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Agent")]
        public KnowledgeQaAgent Agent{ get; set; }

        /// <summary>
        /// 知识库模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeModelConfig")]
        public KnowledgeModelConfig KnowledgeModelConfig{ get; set; }

        /// <summary>
        /// 知识库高级设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeAdvancedConfig")]
        public KnowledgeAdvancedConfig KnowledgeAdvancedConfig{ get; set; }


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
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamObj(map, prefix + "SearchStrategy.", this.SearchStrategy);
            this.SetParamObj(map, prefix + "SingleWorkflow.", this.SingleWorkflow);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamObj(map, prefix + "ThoughtModel.", this.ThoughtModel);
            this.SetParamArrayObj(map, prefix + "IntentAchievements.", this.IntentAchievements);
            this.SetParamSimple(map, prefix + "ImageTextRetrieval", this.ImageTextRetrieval);
            this.SetParamObj(map, prefix + "AiCall.", this.AiCall);
            this.SetParamArrayObj(map, prefix + "ShareKnowledgeBases.", this.ShareKnowledgeBases);
            this.SetParamObj(map, prefix + "BackgroundImage.", this.BackgroundImage);
            this.SetParamArraySimple(map, prefix + "OpeningQuestions.", this.OpeningQuestions);
            this.SetParamSimple(map, prefix + "LongMemoryOpen", this.LongMemoryOpen);
            this.SetParamSimple(map, prefix + "LongMemoryDay", this.LongMemoryDay);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "KnowledgeModelConfig.", this.KnowledgeModelConfig);
            this.SetParamObj(map, prefix + "KnowledgeAdvancedConfig.", this.KnowledgeAdvancedConfig);
        }
    }
}

