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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Chat : AbstractModel
    {
        
        /// <summary>
        /// <p>聊天文本内容，不含HTML、不含昵称，限2000字符</p>
        /// </summary>
        [JsonProperty("ChatText")]
        public string ChatText{ get; set; }

        /// <summary>
        /// <p>频道类型，枚举值：world-世界 / guild-公会 / single-单聊 / other-其他</p>
        /// </summary>
        [JsonProperty("ChannelType")]
        public string ChannelType{ get; set; }

        /// <summary>
        /// <p>群/频道唯一ID（单聊时为空）</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>群/频道名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>群主/管理员ID</p>
        /// </summary>
        [JsonProperty("GroupAdministrator")]
        public string GroupAdministrator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChatText", this.ChatText);
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupAdministrator", this.GroupAdministrator);
        }
    }
}

