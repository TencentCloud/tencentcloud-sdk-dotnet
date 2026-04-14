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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddAlarmPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>告警策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>事件类型 1：资源不合规事件</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>事件范围  1：当前账号  2：多账号</p>
        /// </summary>
        [JsonProperty("EventScope")]
        public long?[] EventScope{ get; set; }

        /// <summary>
        /// <p>风险等级 1：高风险  2：中风险 3：低风险</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long?[] RiskLevel{ get; set; }

        /// <summary>
        /// <p>通知时间段</p>
        /// </summary>
        [JsonProperty("NoticeTime")]
        public string NoticeTime{ get; set; }

        /// <summary>
        /// <p>通知机制</p>
        /// </summary>
        [JsonProperty("NotificationMechanism")]
        public string NotificationMechanism{ get; set; }

        /// <summary>
        /// <p>状态 1：启用 2：停用</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>通知周期</p>
        /// </summary>
        [JsonProperty("NoticePeriod")]
        public long?[] NoticePeriod{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "EventScope.", this.EventScope);
            this.SetParamArraySimple(map, prefix + "RiskLevel.", this.RiskLevel);
            this.SetParamSimple(map, prefix + "NoticeTime", this.NoticeTime);
            this.SetParamSimple(map, prefix + "NotificationMechanism", this.NotificationMechanism);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "NoticePeriod.", this.NoticePeriod);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

