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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PriceScopeConf : AbstractModel
    {
        
        /// <summary>
        /// 最高价格 单位元
        /// </summary>
        [JsonProperty("MaxPrice")]
        public float? MaxPrice{ get; set; }

        /// <summary>
        /// 最低价格 单位元
        /// </summary>
        [JsonProperty("MinPrice")]
        public float? MinPrice{ get; set; }

        /// <summary>
        /// 价格幅度 单位元
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// 保证金 单位元
        /// </summary>
        [JsonProperty("DepositPrice")]
        public float? DepositPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxPrice", this.MaxPrice);
            this.SetParamSimple(map, prefix + "MinPrice", this.MinPrice);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "DepositPrice", this.DepositPrice);
        }
    }
}

