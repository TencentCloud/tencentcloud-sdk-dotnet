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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Message : AbstractModel
    {
        
        /// <summary>
        /// 角色，可选值包括 system、user、assistant、 tool。
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 多种类型内容（目前支持文本、图片和视频），图片支持混元图生文系列模型，视频支持混元视频生文系列模型，详情参考[产品概述](https://cloud.tencent.com/document/product/1729/104753)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Contents")]
        public Content[] Contents{ get; set; }

        /// <summary>
        /// 当role为tool时传入，标识具体的函数调用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ToolCallId")]
        public string ToolCallId{ get; set; }

        /// <summary>
        /// 模型生成的工具调用，仅 hunyuan-pro 或者 hunyuan-functioncall 模型支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ToolCalls")]
        public ToolCall[] ToolCalls{ get; set; }

        /// <summary>
        /// 文件标识符。单次最大 50 个文件。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileIDs")]
        public string[] FileIDs{ get; set; }

        /// <summary>
        /// 思维链内容。用于展示模型思考过程，仅 Hunyuan-T1 系列模型可用。注意：在进行多轮对话时，请**不要**将此字段拼接到 messages 中。请求 messages 的请求参数中包含 reasoning_content，接口将报错。
        /// </summary>
        [JsonProperty("ReasoningContent")]
        public string ReasoningContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
            this.SetParamSimple(map, prefix + "ToolCallId", this.ToolCallId);
            this.SetParamArrayObj(map, prefix + "ToolCalls.", this.ToolCalls);
            this.SetParamArraySimple(map, prefix + "FileIDs.", this.FileIDs);
            this.SetParamSimple(map, prefix + "ReasoningContent", this.ReasoningContent);
        }
    }
}

