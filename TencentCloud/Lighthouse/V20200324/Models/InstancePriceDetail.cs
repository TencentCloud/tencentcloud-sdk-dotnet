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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstancePriceDetail : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 询价信息。
        /// </summary>
        [JsonProperty("InstancePrice")]
        public InstancePrice InstancePrice{ get; set; }

        /// <summary>
        /// 折扣梯度详情，每个梯度包含的信息有：时长，折扣数，总价，折扣价，折扣详情（用户折扣、官网折扣、最终折扣）。
        /// </summary>
        [JsonProperty("DiscountDetail")]
        public DiscountDetail[] DiscountDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "InstancePrice.", this.InstancePrice);
            this.SetParamArrayObj(map, prefix + "DiscountDetail.", this.DiscountDetail);
        }
    }
}

