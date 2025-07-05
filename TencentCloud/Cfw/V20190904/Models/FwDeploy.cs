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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FwDeploy : AbstractModel
    {
        
        /// <summary>
        /// 防火墙部署地域
        /// </summary>
        [JsonProperty("DeployRegion")]
        public string DeployRegion{ get; set; }

        /// <summary>
        /// 带宽，单位：Mbps
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 异地灾备 1：使用异地灾备；0：不使用异地灾备；为空则默认不使用异地灾备
        /// </summary>
        [JsonProperty("CrossAZone")]
        public long? CrossAZone{ get; set; }

        /// <summary>
        /// 主可用区，为空则选择默认可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 备可用区，为空则选择默认可用区
        /// </summary>
        [JsonProperty("ZoneBak")]
        public string ZoneBak{ get; set; }

        /// <summary>
        /// 若为cdc防火墙时填充该id
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployRegion", this.DeployRegion);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "CrossAZone", this.CrossAZone);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneBak", this.ZoneBak);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
        }
    }
}

