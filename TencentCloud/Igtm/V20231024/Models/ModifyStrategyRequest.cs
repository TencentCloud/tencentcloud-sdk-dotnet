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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>策略id</p>
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// <p>解析线路，需要全量传参</p>
        /// </summary>
        [JsonProperty("Source")]
        public Source[] Source{ get; set; }

        /// <summary>
        /// <p>主力地址池集合，需要全量传参</p>
        /// </summary>
        [JsonProperty("MainAddressPoolSet")]
        public MainAddressPool[] MainAddressPoolSet{ get; set; }

        /// <summary>
        /// <p>兜底地址池集合，需要全量传参</p>
        /// </summary>
        [JsonProperty("FallbackAddressPoolSet")]
        public MainAddressPool[] FallbackAddressPoolSet{ get; set; }

        /// <summary>
        /// <p>策略名称，不允许重复</p>
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// <p>策略开启状态：ENABLED开启；DISABLED关闭</p>
        /// </summary>
        [JsonProperty("IsEnabled")]
        public string IsEnabled{ get; set; }

        /// <summary>
        /// <p>是否开启策略强制保留默认线路 disabled, enabled，默认不开启且只有一个策略能开启</p>
        /// </summary>
        [JsonProperty("KeepDomainRecords")]
        public string KeepDomainRecords{ get; set; }

        /// <summary>
        /// <p>调度模式：AUTO默认；STOP仅暂停不切换</p>
        /// </summary>
        [JsonProperty("SwitchPoolType")]
        public string SwitchPoolType{ get; set; }

        /// <summary>
        /// <p>是否保留资源</p><p>枚举值：</p><ul><li>false： 全量操作，会有删除逻辑</li><li>true： 不会删除原有资源</li></ul>
        /// </summary>
        [JsonProperty("KeepResource")]
        public bool? KeepResource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamArrayObj(map, prefix + "Source.", this.Source);
            this.SetParamArrayObj(map, prefix + "MainAddressPoolSet.", this.MainAddressPoolSet);
            this.SetParamArrayObj(map, prefix + "FallbackAddressPoolSet.", this.FallbackAddressPoolSet);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "KeepDomainRecords", this.KeepDomainRecords);
            this.SetParamSimple(map, prefix + "SwitchPoolType", this.SwitchPoolType);
            this.SetParamSimple(map, prefix + "KeepResource", this.KeepResource);
        }
    }
}

