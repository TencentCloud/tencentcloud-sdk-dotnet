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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocateHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例所在的位置。通过该参数可以指定实例所属可用区，所属项目等属性。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。
        /// </summary>
        [JsonProperty("HostChargePrepaid")]
        public ChargePrepaid HostChargePrepaid{ get; set; }

        /// <summary>
        /// 实例计费类型。目前仅支持：PREPAID（预付费，即包年包月模式）。
        /// </summary>
        [JsonProperty("HostChargeType")]
        public string HostChargeType{ get; set; }

        /// <summary>
        /// CDH实例机型，默认为：'HS1'。
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// 购买CDH实例数量。
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到相应的资源实例。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "HostChargePrepaid.", this.HostChargePrepaid);
            this.SetParamSimple(map, prefix + "HostChargeType", this.HostChargeType);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
        }
    }
}

