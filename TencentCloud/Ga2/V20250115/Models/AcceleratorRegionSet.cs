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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AcceleratorRegionSet : AbstractModel
    {
        
        /// <summary>
        /// <p>地域中文名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>是否可用；0：不可用，1:可用。</p>
        /// </summary>
        [JsonProperty("IsAvailable")]
        public long? IsAvailable{ get; set; }

        /// <summary>
        /// <p>地域信息。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>地区名称。</p>
        /// </summary>
        [JsonProperty("AreaName")]
        public string AreaName{ get; set; }

        /// <summary>
        /// <p>是否中国地域。</p>
        /// </summary>
        [JsonProperty("IsChinaMainland")]
        public ulong? IsChinaMainland{ get; set; }

        /// <summary>
        /// <p>支持IspType类型。</p>
        /// </summary>
        [JsonProperty("SupportIspType")]
        public string[] SupportIspType{ get; set; }

        /// <summary>
        /// <p>是否腾讯地域。</p>
        /// </summary>
        [JsonProperty("IsTencentRegion")]
        public ulong? IsTencentRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsAvailable", this.IsAvailable);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AreaName", this.AreaName);
            this.SetParamSimple(map, prefix + "IsChinaMainland", this.IsChinaMainland);
            this.SetParamArraySimple(map, prefix + "SupportIspType.", this.SupportIspType);
            this.SetParamSimple(map, prefix + "IsTencentRegion", this.IsTencentRegion);
        }
    }
}

