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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BuiltinModel : AbstractModel
    {
        
        /// <summary>
        /// 模型唯一标识
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 模型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 供应商，如 TENCENT、OPENAI、ANTHROPIC、DEEPSEEK 等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// 最大输出 Token 数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxOutputTokens")]
        public long? MaxOutputTokens{ get; set; }

        /// <summary>
        /// 最大输入 Token 数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxInputTokens")]
        public long? MaxInputTokens{ get; set; }

        /// <summary>
        /// 是否支持函数调用（Tool Call）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportsToolCall")]
        public bool? SupportsToolCall{ get; set; }

        /// <summary>
        /// 是否支持视觉（图片输入）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportsImages")]
        public bool? SupportsImages{ get; set; }

        /// <summary>
        /// 模型是否支持思考。仅用于展示；能否配置思考强度以 ThinkingLevels 和 CanDisableThinking 为准
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportsThinking")]
        public bool? SupportsThinking{ get; set; }

        /// <summary>
        /// 可选的思考强度，取值：MINIMAL、LOW、MEDIUM、HIGH、XHIGH、MAX，数组顺序即展示顺序。不包含「关闭」，空数组表示不支持调整强度。在 Agent 版本 Manifest 中配置 thinking.level 时使用对应的小写值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThinkingLevels")]
        public string[] ThinkingLevels{ get; set; }

        /// <summary>
        /// 模型默认的思考强度，取值同 ThinkingLevels；空字符串表示未声明。Agent 版本 Manifest 未配置 thinking 时按模型默认档位运行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultThinkingLevel")]
        public string DefaultThinkingLevel{ get; set; }

        /// <summary>
        /// 是否支持关闭思考。为 true 时，可在 Agent 版本 Manifest 中配置 thinking.level 为 disabled
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanDisableThinking")]
        public bool? CanDisableThinking{ get; set; }

        /// <summary>
        /// 模型中文描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescriptionZh")]
        public string DescriptionZh{ get; set; }

        /// <summary>
        /// 模型英文描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescriptionEn")]
        public string DescriptionEn{ get; set; }

        /// <summary>
        /// 模型标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 支持的客户端列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Clients")]
        public string[] Clients{ get; set; }

        /// <summary>
        /// 服务接入地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceEndpoint")]
        public string ServiceEndpoint{ get; set; }

        /// <summary>
        /// 状态：ENABLED（已启用）/ DISABLED（已停用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 本企业内绑定该模型的 Agent 数（过滤软删除 Agent/版本与调试 Agent）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentCount")]
        public long? AgentCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "MaxOutputTokens", this.MaxOutputTokens);
            this.SetParamSimple(map, prefix + "MaxInputTokens", this.MaxInputTokens);
            this.SetParamSimple(map, prefix + "SupportsToolCall", this.SupportsToolCall);
            this.SetParamSimple(map, prefix + "SupportsImages", this.SupportsImages);
            this.SetParamSimple(map, prefix + "SupportsThinking", this.SupportsThinking);
            this.SetParamArraySimple(map, prefix + "ThinkingLevels.", this.ThinkingLevels);
            this.SetParamSimple(map, prefix + "DefaultThinkingLevel", this.DefaultThinkingLevel);
            this.SetParamSimple(map, prefix + "CanDisableThinking", this.CanDisableThinking);
            this.SetParamSimple(map, prefix + "DescriptionZh", this.DescriptionZh);
            this.SetParamSimple(map, prefix + "DescriptionEn", this.DescriptionEn);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Clients.", this.Clients);
            this.SetParamSimple(map, prefix + "ServiceEndpoint", this.ServiceEndpoint);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AgentCount", this.AgentCount);
        }
    }
}

