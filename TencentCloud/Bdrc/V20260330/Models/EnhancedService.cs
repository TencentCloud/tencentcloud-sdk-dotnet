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

namespace TencentCloud.Bdrc.V20260330.Models
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
        public RunSecurityServiceEnabled MonitorService{ get; set; }

        /// <summary>
        /// 安装 tat-agent。若不指定该参数，则默认逻辑与 CVM 控制台一致：境外地域不安装、境内非 GPU 机型默认安装、境内 GPU 机型默认不安装。
        /// </summary>
        [JsonProperty("AutomationService")]
        public AutomationServiceEnabled AutomationService{ get; set; }

        /// <summary>
        /// 开启基础服务。
        /// </summary>
        [JsonProperty("BasicService")]
        public BasicServicesSettings BasicService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecurityService.", this.SecurityService);
            this.SetParamObj(map, prefix + "MonitorService.", this.MonitorService);
            this.SetParamObj(map, prefix + "AutomationService.", this.AutomationService);
            this.SetParamObj(map, prefix + "BasicService.", this.BasicService);
        }
    }
}

