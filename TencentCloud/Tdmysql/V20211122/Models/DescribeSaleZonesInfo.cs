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

    public class DescribeSaleZonesInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Zone英文字符串</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Zone中文字符串</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>是否售卖，1：售卖；0：不售卖</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>是否是默认主可用区,0不是，1是</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDefaultMaster")]
        public long? IsDefaultMaster{ get; set; }

        /// <summary>
        /// <p>可用区可选磁盘类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableDiskTypes")]
        public string[] AvailableDiskTypes{ get; set; }

        /// <summary>
        /// <p>是否是独享可用区</p>
        /// </summary>
        [JsonProperty("SupportTypes")]
        public string[] SupportTypes{ get; set; }

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
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "IsDefaultMaster", this.IsDefaultMaster);
            this.SetParamArraySimple(map, prefix + "AvailableDiskTypes.", this.AvailableDiskTypes);
            this.SetParamArraySimple(map, prefix + "SupportTypes.", this.SupportTypes);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

