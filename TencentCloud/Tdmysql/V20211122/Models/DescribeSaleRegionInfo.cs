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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSaleRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Region英文字符串</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>售卖Zone列表</p>
        /// </summary>
        [JsonProperty("ZoneList")]
        public DescribeSaleZonesInfo[] ZoneList{ get; set; }

        /// <summary>
        /// <p>Region中文字符串</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>是否售卖。1:售卖，0不售卖</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>多可用可选数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableZoneNum")]
        public long? AvailableZoneNum{ get; set; }

        /// <summary>
        /// <p>是否允许使用日志副本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportedLogReplica")]
        public bool? IsSupportedLogReplica{ get; set; }

        /// <summary>
        /// <p>可用区组合</p>
        /// </summary>
        [JsonProperty("ZoneGroup")]
        public DescribeSaleZonesGroup[] ZoneGroup{ get; set; }

        /// <summary>
        /// <p>是否支持serverless</p>
        /// </summary>
        [JsonProperty("IsSupportServerless")]
        public bool? IsSupportServerless{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "AvailableZoneNum", this.AvailableZoneNum);
            this.SetParamSimple(map, prefix + "IsSupportedLogReplica", this.IsSupportedLogReplica);
            this.SetParamArrayObj(map, prefix + "ZoneGroup.", this.ZoneGroup);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

