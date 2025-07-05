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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionInfo : AbstractModel
    {
        
        /// <summary>
        /// 地域名称，例如“ap-guangzhou"
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 地域描述，例如"广州”
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 地域唯一标记
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 地域下所有可用区列表
        /// </summary>
        [JsonProperty("Zones")]
        public ZoneInfo[] Zones{ get; set; }

        /// <summary>
        /// 该地域下集群数目
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 0代表是国际站 1代表不是
        /// </summary>
        [JsonProperty("IsInternationalSite")]
        public ulong? IsInternationalSite{ get; set; }

        /// <summary>
        /// 桶
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 存算分离集群数
        /// </summary>
        [JsonProperty("SSCCount")]
        public long? SSCCount{ get; set; }

        /// <summary>
        /// 是否开通存算分离
        /// </summary>
        [JsonProperty("EnableSSC")]
        public bool? EnableSSC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamArrayObj(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "IsInternationalSite", this.IsInternationalSite);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "SSCCount", this.SSCCount);
            this.SetParamSimple(map, prefix + "EnableSSC", this.EnableSSC);
        }
    }
}

