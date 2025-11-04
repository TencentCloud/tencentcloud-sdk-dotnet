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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceMultiSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区,每个地域提供最佳实践
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例购买类型，可选值为：PREPAID, POSTPAID, SERVERLESS
        /// </summary>
        [JsonProperty("InstancePayMode")]
        public string InstancePayMode{ get; set; }

        /// <summary>
        /// 存储购买类型，可选值为：PREPAID, POSTPAID
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public string StoragePayMode{ get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonProperty("GoodsSpecs")]
        public GoodsSpec[] GoodsSpecs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstancePayMode", this.InstancePayMode);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamArrayObj(map, prefix + "GoodsSpecs.", this.GoodsSpecs);
        }
    }
}

