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
        /// 告警策略名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件范围  1：当前账号  2：多账号
        /// </summary>
        [JsonProperty("EventScope")]
        public long?[] EventScope{ get; set; }

        /// <summary>
        /// 风险等级 1：高风险  2：中风险 3：低风险
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long?[] RiskLevel{ get; set; }

        /// <summary>
        /// 通知时间段
        /// </summary>
        [JsonProperty("NoticeTime")]
        public string NoticeTime{ get; set; }

        /// <summary>
        /// 通知机制
        /// </summary>
        [JsonProperty("NotificationMechanism")]
        public string NotificationMechanism{ get; set; }

        /// <summary>
        /// 状态 1：启用 2：停用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 通知周期
        /// </summary>
        [JsonProperty("NoticePeriod")]
        public long?[] NoticePeriod{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
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

