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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeCDBProxyVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。可通过 <a href="https://cloud.tencent.com/document/product/236/15872">DescribeDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>数据库代理 ID。可通过 <a href="https://cloud.tencent.com/document/api/236/90585">DescribeCdbProxyInfo</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>数据库代理当前版本</p>
        /// </summary>
        [JsonProperty("SrcProxyVersion")]
        public string SrcProxyVersion{ get; set; }

        /// <summary>
        /// <p>数据库代理升级版本</p>
        /// </summary>
        [JsonProperty("DstProxyVersion")]
        public string DstProxyVersion{ get; set; }

        /// <summary>
        /// <p>升级切换时间</p><p>枚举值：</p><ul><li>nowTime： 升级完成时</li><li>timeWindow： 实例维护时间</li><li>rollUpgrade： 滚动升级</li></ul>
        /// </summary>
        [JsonProperty("UpgradeTime")]
        public string UpgradeTime{ get; set; }

        /// <summary>
        /// <p>滚动升级等待时间</p><p>取值范围：[10, 3600]</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("RollUpgradeWaitingTime")]
        public long? RollUpgradeWaitingTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "SrcProxyVersion", this.SrcProxyVersion);
            this.SetParamSimple(map, prefix + "DstProxyVersion", this.DstProxyVersion);
            this.SetParamSimple(map, prefix + "UpgradeTime", this.UpgradeTime);
            this.SetParamSimple(map, prefix + "RollUpgradeWaitingTime", this.RollUpgradeWaitingTime);
        }
    }
}

