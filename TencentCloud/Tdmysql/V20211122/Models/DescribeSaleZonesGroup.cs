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

    public class DescribeSaleZonesGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>可用区数</p>
        /// </summary>
        [JsonProperty("ZoneNum")]
        public long? ZoneNum{ get; set; }

        /// <summary>
        /// <p>可用区组合</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>支持的类型</p>
        /// </summary>
        [JsonProperty("SupportTypes")]
        public string[] SupportTypes{ get; set; }

        /// <summary>
        /// <p>支持的磁盘类型</p><p>枚举值：</p><ul><li>CLOUD_TCS： 本地盘</li><li>CLOUD_HSSD： 增强型云盘</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableDiskTypes")]
        public string[] AvailableDiskTypes{ get; set; }

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
            this.SetParamSimple(map, prefix + "ZoneNum", this.ZoneNum);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArraySimple(map, prefix + "SupportTypes.", this.SupportTypes);
            this.SetParamArraySimple(map, prefix + "AvailableDiskTypes.", this.AvailableDiskTypes);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

