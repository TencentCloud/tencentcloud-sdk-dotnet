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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 策略名称，不允许重复
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 解析线路
        /// </summary>
        [JsonProperty("Source")]
        public Source[] Source{ get; set; }

        /// <summary>
        /// 主力地址池集合，最多允许配置四级
        /// </summary>
        [JsonProperty("MainAddressPoolSet")]
        public MainAddressPool[] MainAddressPoolSet{ get; set; }

        /// <summary>
        /// 兜底地址池集合，只允许配置一级，且地址池数量为1
        /// </summary>
        [JsonProperty("FallbackAddressPoolSet")]
        public MainAddressPool[] FallbackAddressPoolSet{ get; set; }

        /// <summary>
        /// 是否开启策略强制保留默认线路 disabled, enabled，默认不开启且只有一个策略能开启
        /// </summary>
        [JsonProperty("KeepDomainRecords")]
        public string KeepDomainRecords{ get; set; }

        /// <summary>
        /// 策略调度模式：AUTO默认切换；STOP仅暂停不切换
        /// </summary>
        [JsonProperty("SwitchPoolType")]
        public string SwitchPoolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamArrayObj(map, prefix + "Source.", this.Source);
            this.SetParamArrayObj(map, prefix + "MainAddressPoolSet.", this.MainAddressPoolSet);
            this.SetParamArrayObj(map, prefix + "FallbackAddressPoolSet.", this.FallbackAddressPoolSet);
            this.SetParamSimple(map, prefix + "KeepDomainRecords", this.KeepDomainRecords);
            this.SetParamSimple(map, prefix + "SwitchPoolType", this.SwitchPoolType);
        }
    }
}

