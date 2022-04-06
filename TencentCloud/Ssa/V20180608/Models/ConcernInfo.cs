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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConcernInfo : AbstractModel
    {
        
        /// <summary>
        /// 关注点类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcernType")]
        public long? ConcernType{ get; set; }

        /// <summary>
        /// 实体类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EntityType")]
        public long? EntityType{ get; set; }

        /// <summary>
        /// 关注点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Concern")]
        public string Concern{ get; set; }

        /// <summary>
        /// 最近数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatisticsCount")]
        public long? StatisticsCount{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchData")]
        public string SearchData{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpCountryIso")]
        public string IpCountryIso{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpProvinceIso")]
        public string IpProvinceIso{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpCity")]
        public string IpCity{ get; set; }

        /// <summary>
        /// 可疑关注点字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventSubType")]
        public string EventSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConcernType", this.ConcernType);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "Concern", this.Concern);
            this.SetParamSimple(map, prefix + "StatisticsCount", this.StatisticsCount);
            this.SetParamSimple(map, prefix + "SearchData", this.SearchData);
            this.SetParamSimple(map, prefix + "IpCountryIso", this.IpCountryIso);
            this.SetParamSimple(map, prefix + "IpProvinceIso", this.IpProvinceIso);
            this.SetParamSimple(map, prefix + "IpCity", this.IpCity);
            this.SetParamSimple(map, prefix + "EventSubType", this.EventSubType);
        }
    }
}

