/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// 可用区数值形式的唯一ID，如：100001
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 可用区字符串形式的唯一ID，如：ap-guangzhou-1
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 可用区名称，如：广州一区
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 可用区所属地域，如：ap-guangzhou
        /// </summary>
        [JsonProperty("ZoneRegion")]
        public string ZoneRegion{ get; set; }

        /// <summary>
        /// 可用区是否是LocalZone可用区，如：false
        /// </summary>
        [JsonProperty("LocalZone")]
        public bool? LocalZone{ get; set; }

        /// <summary>
        /// 可用区是否是EdgeZone可用区，如：false
        /// </summary>
        [JsonProperty("EdgeZone")]
        public bool? EdgeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneRegion", this.ZoneRegion);
            this.SetParamSimple(map, prefix + "LocalZone", this.LocalZone);
            this.SetParamSimple(map, prefix + "EdgeZone", this.EdgeZone);
        }
    }
}

