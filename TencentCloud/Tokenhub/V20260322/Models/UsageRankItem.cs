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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageRankItem : AbstractModel
    {
        
        /// <summary>
        /// 全局排名（从 1 起）。分页场景下仍为全量排序中的位次，非页内序号
        /// </summary>
        [JsonProperty("Rank")]
        public long? Rank{ get; set; }

        /// <summary>
        /// 对象标识。apikey 维度为 APIKey ID；endpoint 维度为接入点；model 维度为模型名。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 对象展示名。apikey 维度返回 APIKey 名称（已删除的 APIKey 仍保留原名）；
        /// endpoint / model 维度等于 Key。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 时间周期内的统计值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Stats")]
        public UsageStats Stats{ get; set; }

        /// <summary>
        /// 时间周期内的时序点列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Series")]
        public UsageSeries Series{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Rank", this.Rank);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Stats.", this.Stats);
            this.SetParamObj(map, prefix + "Series.", this.Series);
        }
    }
}

