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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>会话所属空间 ID。</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>用户 ID。可通过调用方业务系统接口获取。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>Agent ID。可选。</p>
        /// </summary>
        [JsonProperty("AgentId")]
        [System.Obsolete]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>会话 ID。可通过 CreateSession 或 DescribeSessions 接口获取。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>会话标题，最大长度 256 字符。</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>初始会话状态。</p>
        /// </summary>
        [JsonProperty("State")]
        public SessionState State{ get; set; }

        /// <summary>
        /// <p>创建会话时设置的初始元数据，以键值对数组形式表示。每个元素包含 Metadata 名称和对应值。</p><p>入参限制：本参数可选，最多支持 64 项。Name 不能为空或重复，最大长度为 253 字节；Value 最大长度为 1024 字节，允许为空字符串。Metadata 序列化后的总大小不能超过 64 KiB。</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataVar[] Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamObj(map, prefix + "State.", this.State);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

