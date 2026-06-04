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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationMessage : AbstractModel
    {
        
        /// <summary>
        /// <p>会话 ID</p>
        /// </summary>
        [JsonProperty("ConversationId")]
        public string ConversationId{ get; set; }

        /// <summary>
        /// <p>消息图标</p>
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// <p>消息 ID</p>
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// <p>消息名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>记录 ID</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>消息角色</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>消息状态，pending:待执行，processing:处理中，success:已完成，failed:处理失败，stop:已取消</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>状态描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>消息标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>消息内容列表</p>
        /// </summary>
        [JsonProperty("ContentList")]
        public ConversationContent[] ContentList{ get; set; }

        /// <summary>
        /// <p>消息内容列表</p>
        /// </summary>
        [JsonProperty("Contents")]
        public ConversationContent[] Contents{ get; set; }

        /// <summary>
        /// <p>类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConversationId", this.ConversationId);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamArrayObj(map, prefix + "ContentList.", this.ContentList);
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

