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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WeeklyReportVul : AbstractModel
    {
        
        /// <summary>
        /// 主机内网IP。
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 漏洞名称。
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 漏洞类型。
        /// <li> WEB : WEB漏洞</li>
        /// <li> SYSTEM :系统组件漏洞</li>
        /// <li> BASELINE : 安全基线</li>
        /// </summary>
        [JsonProperty("VulType")]
        public string VulType{ get; set; }

        /// <summary>
        /// 漏洞描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 漏洞状态。
        /// <li> UN_OPERATED : 待处理</li>
        /// <li> SCANING : 扫描中</li>
        /// <li> FIXED : 已修复</li>
        /// </summary>
        [JsonProperty("VulStatus")]
        public string VulStatus{ get; set; }

        /// <summary>
        /// 最后扫描时间。
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulType", this.VulType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "VulStatus", this.VulStatus);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
        }
    }
}

