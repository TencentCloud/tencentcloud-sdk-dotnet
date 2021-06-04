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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceCreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例的套餐 ID。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 创建数量，默认为 1。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 应用镜像 ID，使用收费应用镜像时必填。可通过[DescribeBlueprints](https://cloud.tencent.com/document/product/1207/47689)接口返回值中的BlueprintId获取。
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
        }
    }
}

