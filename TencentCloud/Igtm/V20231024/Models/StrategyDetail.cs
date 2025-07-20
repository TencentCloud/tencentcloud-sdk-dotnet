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

    public class StrategyDetail : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 线路
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public Source[] Source{ get; set; }

        /// <summary>
        /// 主力地址池集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MainAddressPoolSet")]
        public MainAddressPool[] MainAddressPoolSet{ get; set; }

        /// <summary>
        /// 兜底地址池id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FallbackAddressPoolSet")]
        public MainAddressPool[] FallbackAddressPoolSet{ get; set; }

        /// <summary>
        /// 是否保留线路：enabled保留，disabled不保留，只保留默认线路
        /// </summary>
        [JsonProperty("KeepDomainRecords")]
        public string KeepDomainRecords{ get; set; }

        /// <summary>
        /// 生效主力地址池id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivateMainPoolId")]
        public ulong? ActivateMainPoolId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// 调度模式：AUTO默认；PAUSE仅暂停不切换
        /// </summary>
        [JsonProperty("SwitchPoolType")]
        public string SwitchPoolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Source.", this.Source);
            this.SetParamArrayObj(map, prefix + "MainAddressPoolSet.", this.MainAddressPoolSet);
            this.SetParamArrayObj(map, prefix + "FallbackAddressPoolSet.", this.FallbackAddressPoolSet);
            this.SetParamSimple(map, prefix + "KeepDomainRecords", this.KeepDomainRecords);
            this.SetParamSimple(map, prefix + "ActivateMainPoolId", this.ActivateMainPoolId);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "SwitchPoolType", this.SwitchPoolType);
        }
    }
}

