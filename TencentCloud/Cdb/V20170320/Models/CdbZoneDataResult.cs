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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdbZoneDataResult : AbstractModel
    {
        
        /// <summary>
        /// 售卖规格所有集合
        /// </summary>
        [JsonProperty("Configs")]
        public CdbSellConfig[] Configs{ get; set; }

        /// <summary>
        /// 售卖地域可用区集合
        /// </summary>
        [JsonProperty("Regions")]
        public CdbRegionSellConf[] Regions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Configs.", this.Configs);
            this.SetParamArrayObj(map, prefix + "Regions.", this.Regions);
        }
    }
}

