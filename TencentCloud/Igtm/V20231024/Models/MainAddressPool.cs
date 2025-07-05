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

    public class MainAddressPool : AbstractModel
    {
        
        /// <summary>
        /// 集合中的地址池id与权重，数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressPools")]
        public MainPoolWeight[] AddressPools{ get; set; }

        /// <summary>
        /// 地址池集合id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MainAddressPoolId")]
        public ulong? MainAddressPoolId{ get; set; }

        /// <summary>
        /// 切换阀值，不能大于主力集合内地址总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinSurviveNum")]
        public ulong? MinSurviveNum{ get; set; }

        /// <summary>
        /// 切换策略:ALL解析所有地址；WEIGHT：负载均衡。当为ALL时，解析地址的权重值为1；当为WEIGHT时；权重为地址池权重*地址权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrafficStrategy")]
        public string TrafficStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AddressPools.", this.AddressPools);
            this.SetParamSimple(map, prefix + "MainAddressPoolId", this.MainAddressPoolId);
            this.SetParamSimple(map, prefix + "MinSurviveNum", this.MinSurviveNum);
            this.SetParamSimple(map, prefix + "TrafficStrategy", this.TrafficStrategy);
        }
    }
}

