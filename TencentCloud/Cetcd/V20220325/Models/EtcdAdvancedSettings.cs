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

namespace TencentCloud.Cetcd.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EtcdAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// 安全相关设置
        /// </summary>
        [JsonProperty("SecuritySettings")]
        public EtcdSecuritySettings SecuritySettings{ get; set; }

        /// <summary>
        /// 自动压缩设置
        /// </summary>
        [JsonProperty("AutoCompactionSettings")]
        public EtcdAutoCompactionSettings AutoCompactionSettings{ get; set; }

        /// <summary>
        /// 监控设置
        /// </summary>
        [JsonProperty("MonitorSettings")]
        public EtcdMonitorSettings MonitorSettings{ get; set; }

        /// <summary>
        /// 备份相关设置
        /// </summary>
        [JsonProperty("BackupSettings")]
        public EtcdBackupSettings BackupSettings{ get; set; }

        /// <summary>
        /// 自定义域名
        /// </summary>
        [JsonProperty("CustomDomains")]
        public string CustomDomains{ get; set; }

        /// <summary>
        /// 自定义ip
        /// </summary>
        [JsonProperty("CustomIPs")]
        public string CustomIPs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SecuritySettings.", this.SecuritySettings);
            this.SetParamObj(map, prefix + "AutoCompactionSettings.", this.AutoCompactionSettings);
            this.SetParamObj(map, prefix + "MonitorSettings.", this.MonitorSettings);
            this.SetParamObj(map, prefix + "BackupSettings.", this.BackupSettings);
            this.SetParamSimple(map, prefix + "CustomDomains", this.CustomDomains);
            this.SetParamSimple(map, prefix + "CustomIPs", this.CustomIPs);
        }
    }
}

