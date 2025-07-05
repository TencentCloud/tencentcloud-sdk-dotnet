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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePriceRunInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例的机型信息
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 系统盘信息
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 实例个数
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 数据盘信息
        /// </summary>
        [JsonProperty("DataDisk")]
        public DataDisk[] DataDisk{ get; set; }

        /// <summary>
        /// 实例计费类型。其中：
        /// 0，按资源维度后付费，计算当日用量峰值，例如CPU，内存，硬盘等，仅适用于非GNR系列机型；
        /// 1，按小时后付费，单价：xx元/实例/小时，仅适用于GNR机型，如需开通该计费方式请提工单申请；
        /// 2，按月后付费，单价：xx元/实例/月，仅适用于GNR机型；
        /// 该字段不填时，非GNR机型会默认选择0；GNR机型默认选择2。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamArrayObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
        }
    }
}

