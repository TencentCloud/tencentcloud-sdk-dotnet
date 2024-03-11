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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainAssetsResponse : AbstractModel
    {
        
        /// <summary>
        /// -
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// -
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Data")]
        public DomainAssetVO[] Data{ get; set; }

        /// <summary>
        /// 防护状态列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefenseStatusList")]
        public FilterDataObject[] DefenseStatusList{ get; set; }

        /// <summary>
        /// 资产归属地列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetLocationList")]
        public FilterDataObject[] AssetLocationList{ get; set; }

        /// <summary>
        /// 资产类型列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceTypeList")]
        public FilterDataObject[] SourceTypeList{ get; set; }

        /// <summary>
        /// 地域列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionList")]
        public FilterDataObject[] RegionList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "DefenseStatusList.", this.DefenseStatusList);
            this.SetParamArrayObj(map, prefix + "AssetLocationList.", this.AssetLocationList);
            this.SetParamArrayObj(map, prefix + "SourceTypeList.", this.SourceTypeList);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

