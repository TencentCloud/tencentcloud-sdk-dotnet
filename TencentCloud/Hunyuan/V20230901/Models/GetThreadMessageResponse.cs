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

    public class GetThreadMessageResponse : AbstractSSEModel
    {
        
        /// <summary>
        /// 消息 ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [JsonProperty("Object")]
        public string Object{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// 会话 ID
        /// </summary>
        [JsonProperty("ThreadID")]
        public string ThreadID{ get; set; }

        /// <summary>
        /// 状态，处理中 in_progress，已完成 completed，未完成 incomplete。 
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 未完成原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCompleteDetails")]
        public ThreadMessageInCompleteDetailsObject InCompleteDetails{ get; set; }

        /// <summary>
        /// 完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompletedAt")]
        public long? CompletedAt{ get; set; }

        /// <summary>
        /// 未完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCompleteAt")]
        public long? InCompleteAt{ get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 助手 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssistantID")]
        public string AssistantID{ get; set; }

        /// <summary>
        /// 运行 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunID")]
        public string RunID{ get; set; }

        /// <summary>
        /// 附件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Attachments")]
        public ThreadMessageAttachmentObject[] Attachments{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。本接口为流式响应接口，当请求成功时，RequestId 会被放在 HTTP 响应的 Header "X-TC-RequestId" 中。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Object", this.Object);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "ThreadID", this.ThreadID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "InCompleteDetails.", this.InCompleteDetails);
            this.SetParamSimple(map, prefix + "CompletedAt", this.CompletedAt);
            this.SetParamSimple(map, prefix + "InCompleteAt", this.InCompleteAt);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "AssistantID", this.AssistantID);
            this.SetParamSimple(map, prefix + "RunID", this.RunID);
            this.SetParamArrayObj(map, prefix + "Attachments.", this.Attachments);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

