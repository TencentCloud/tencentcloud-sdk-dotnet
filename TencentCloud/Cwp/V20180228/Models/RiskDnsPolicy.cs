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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskDnsPolicy : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略类型[0:系统,1:用户]
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// 策略动作[0:告警,1:放行,2:拦截+告警]
        /// </summary>
        [JsonProperty("PolicyAction")]
        public long? PolicyAction{ get; set; }

        /// <summary>
        /// 主机范围[1: 所有专业版+旗舰版|2:所有旗舰版|0: 部分主机]
        /// </summary>
        [JsonProperty("HostScope")]
        public long? HostScope{ get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// 域名,作为入参时需要进行base64 encode
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 是否生效[0:生效,1:不生效]
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("PolicyDesc")]
        public string PolicyDesc{ get; set; }

        /// <summary>
        /// 是否处理之前的事件[0:不处理|1:处理]
        /// </summary>
        [JsonProperty("IsDealOldEvent")]
        public long? IsDealOldEvent{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyAction", this.PolicyAction);
            this.SetParamSimple(map, prefix + "HostScope", this.HostScope);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyDesc", this.PolicyDesc);
            this.SetParamSimple(map, prefix + "IsDealOldEvent", this.IsDealOldEvent);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

