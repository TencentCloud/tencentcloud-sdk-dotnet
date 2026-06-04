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

    public class AgentReleasePreview : AbstractModel
    {
        
        /// <summary>
        /// <p>AgentID</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>Agent名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>更新时间, unix 秒时间戳 (s)</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>状态, 状态值：1:新增, 2:修改, 3:删除</p>
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// <p>动作描述</p>
        /// </summary>
        [JsonProperty("ActionDescription")]
        public string ActionDescription{ get; set; }

        /// <summary>
        /// <p>发布消息</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>发布详情</p>
        /// </summary>
        [JsonProperty("ReleaseList")]
        public AgentRelease[] ReleaseList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ActionDescription", this.ActionDescription);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "ReleaseList.", this.ReleaseList);
        }
    }
}

