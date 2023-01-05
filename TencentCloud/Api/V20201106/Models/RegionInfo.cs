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

namespace TencentCloud.Api.V20201106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionInfo : AbstractModel
    {
        
        /// <summary>
        /// 地域名称，例如，ap-guangzhou
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 地域描述，例如，华南地区(广州)
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 地域是否可用状态
        /// </summary>
        [JsonProperty("RegionState")]
        public string RegionState{ get; set; }

        /// <summary>
        /// 控制台类型，api调用时默认null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionTypeMC")]
        public long? RegionTypeMC{ get; set; }

        /// <summary>
        /// 不同语言的地区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocationMC")]
        public string LocationMC{ get; set; }

        /// <summary>
        /// 控制台展示的地域描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionNameMC")]
        public string RegionNameMC{ get; set; }

        /// <summary>
        /// 控制台展示的RegionId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionIdMC")]
        public string RegionIdMC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionState", this.RegionState);
            this.SetParamSimple(map, prefix + "RegionTypeMC", this.RegionTypeMC);
            this.SetParamSimple(map, prefix + "LocationMC", this.LocationMC);
            this.SetParamSimple(map, prefix + "RegionNameMC", this.RegionNameMC);
            this.SetParamSimple(map, prefix + "RegionIdMC", this.RegionIdMC);
        }
    }
}

