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

    public class ModelInfo : AbstractModel
    {
        
        /// <summary>
        /// 模型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelDesc")]
        public string ModelDesc{ get; set; }

        /// <summary>
        /// 模型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// 资源状态 1：资源可用；2：资源已用尽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }

        /// <summary>
        /// 提示词内容字符限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptWordsLimit")]
        public string PromptWordsLimit{ get; set; }

        /// <summary>
        /// 通过核心采样控制内容生成的多样性，较高的Top P值会导致生成更多样的内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopP")]
        public ModelParameter TopP{ get; set; }

        /// <summary>
        /// 温度控制随机性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Temperature")]
        public ModelParameter Temperature{ get; set; }

        /// <summary>
        /// 最多能生成的token数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxTokens")]
        public ModelParameter MaxTokens{ get; set; }

        /// <summary>
        /// 模型来源 Hunyuan：腾讯混元大模型,Industry：腾讯云行业大模型,Experience：新模型体验,Custom自定义模型
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 模型图标
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// 是否免费
        /// </summary>
        [JsonProperty("IsFree")]
        public bool? IsFree{ get; set; }

        /// <summary>
        /// 模型对话框可输入的上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputLenLimit")]
        public ulong? InputLenLimit{ get; set; }

        /// <summary>
        /// 支持工作流的类型 0:模型不支持; 1: 模型支持工作流； 2： 模型支持效果不佳；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportWorkflowStatus")]
        public ulong? SupportWorkflowStatus{ get; set; }

        /// <summary>
        /// 模型类别 generate：生成模型，thought：思考模型
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelDesc", this.ModelDesc);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "PromptWordsLimit", this.PromptWordsLimit);
            this.SetParamObj(map, prefix + "TopP.", this.TopP);
            this.SetParamObj(map, prefix + "Temperature.", this.Temperature);
            this.SetParamObj(map, prefix + "MaxTokens.", this.MaxTokens);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "IsFree", this.IsFree);
            this.SetParamSimple(map, prefix + "InputLenLimit", this.InputLenLimit);
            this.SetParamSimple(map, prefix + "SupportWorkflowStatus", this.SupportWorkflowStatus);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
        }
    }
}

