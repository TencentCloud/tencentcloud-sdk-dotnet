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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdjustCdbProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 代理组ID
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// 节点规格配置
        /// </summary>
        [JsonProperty("ProxyNodeCustom")]
        public ProxyNodeCustom[] ProxyNodeCustom{ get; set; }

        /// <summary>
        /// 重新负载均衡：auto(自动),manual(手动)
        /// </summary>
        [JsonProperty("ReloadBalance")]
        public string ReloadBalance{ get; set; }

        /// <summary>
        /// 升级切换时间：nowTime(升级完成时),timeWindow(维护时间内)
        /// </summary>
        [JsonProperty("UpgradeTime")]
        public string UpgradeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamArrayObj(map, prefix + "ProxyNodeCustom.", this.ProxyNodeCustom);
            this.SetParamSimple(map, prefix + "ReloadBalance", this.ReloadBalance);
            this.SetParamSimple(map, prefix + "UpgradeTime", this.UpgradeTime);
        }
    }
}

