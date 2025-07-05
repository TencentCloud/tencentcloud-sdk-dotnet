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

    public class InstancePricesPartDetail : AbstractModel
    {
        
        /// <summary>
        /// cpu的价格信息
        /// </summary>
        [JsonProperty("CpuPrice")]
        public PriceDetail CpuPrice{ get; set; }

        /// <summary>
        /// 内存价格信息
        /// </summary>
        [JsonProperty("MemPrice")]
        public PriceDetail MemPrice{ get; set; }

        /// <summary>
        /// 磁盘价格信息
        /// </summary>
        [JsonProperty("DisksPrice")]
        public PriceDetail DisksPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CpuPrice.", this.CpuPrice);
            this.SetParamObj(map, prefix + "MemPrice.", this.MemPrice);
            this.SetParamObj(map, prefix + "DisksPrice.", this.DisksPrice);
        }
    }
}

