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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnhancedService : AbstractModel
    {
        
        /// <summary>
        /// 开启云安全服务。若不指定该参数，则默认开启云安全服务。
        /// </summary>
        [JsonProperty("SecurityService")]
        public RunSecurityServiceEnabled SecurityService{ get; set; }

        /// <summary>
        /// 开启云监控服务。若不指定该参数，则默认开启云监控服务。
        /// </summary>
        [JsonProperty("MonitorService")]
        public RunMonitorServiceEnabled MonitorService{ get; set; }

        /// <summary>
        /// 该参数已废弃，查询时会返回空值，请勿使用。
        /// </summary>
        [JsonProperty("AutomationService")]
        [System.Obsolete]
        public RunAutomationServiceEnabled[] AutomationService{ get; set; }

        /// <summary>
        /// 开启自动化助手服务。若不指定该参数，则默认逻辑与CVM保持一致。注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutomationToolsService")]
        public RunAutomationServiceEnabled AutomationToolsService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecurityService.", this.SecurityService);
            this.SetParamObj(map, prefix + "MonitorService.", this.MonitorService);
            this.SetParamArrayObj(map, prefix + "AutomationService.", this.AutomationService);
            this.SetParamObj(map, prefix + "AutomationToolsService.", this.AutomationToolsService);
        }
    }
}

