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

    public class SaleRegion : AbstractModel
    {
        
        /// <summary>
        /// 地域英文名
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 地域数字ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 地域中文名
        /// </summary>
        [JsonProperty("RegionZh")]
        public string RegionZh{ get; set; }

        /// <summary>
        /// 可售卖可用区列表
        /// </summary>
        [JsonProperty("ZoneSet")]
        public SaleZone[] ZoneSet{ get; set; }

        /// <summary>
        /// 引擎类型
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 地域模块支持情况
        /// </summary>
        [JsonProperty("Modules")]
        public Module[] Modules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionZh", this.RegionZh);
            this.SetParamArrayObj(map, prefix + "ZoneSet.", this.ZoneSet);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamArrayObj(map, prefix + "Modules.", this.Modules);
        }
    }
}

