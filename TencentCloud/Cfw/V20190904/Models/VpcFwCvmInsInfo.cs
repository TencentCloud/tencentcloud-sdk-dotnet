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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcFwCvmInsInfo : AbstractModel
    {
        
        /// <summary>
        /// VPC防火墙实例ID
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }

        /// <summary>
        /// CVM所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// CVM所在地域中文
        /// </summary>
        [JsonProperty("RegionZh")]
        public string RegionZh{ get; set; }

        /// <summary>
        /// CVM所在地域详情
        /// </summary>
        [JsonProperty("RegionDetail")]
        public string RegionDetail{ get; set; }

        /// <summary>
        /// 主机所在可用区
        /// </summary>
        [JsonProperty("ZoneZh")]
        public string ZoneZh{ get; set; }

        /// <summary>
        /// 备机所在可用区
        /// </summary>
        [JsonProperty("ZoneZhBack")]
        public string ZoneZhBack{ get; set; }

        /// <summary>
        /// 防火墙CVM带宽值
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// 实例主机所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例备机所在可用区
        /// </summary>
        [JsonProperty("ZoneBak")]
        public string ZoneBak{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionZh", this.RegionZh);
            this.SetParamSimple(map, prefix + "RegionDetail", this.RegionDetail);
            this.SetParamSimple(map, prefix + "ZoneZh", this.ZoneZh);
            this.SetParamSimple(map, prefix + "ZoneZhBack", this.ZoneZhBack);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneBak", this.ZoneBak);
        }
    }
}

