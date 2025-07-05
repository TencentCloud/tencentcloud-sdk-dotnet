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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreDetail : AbstractModel
    {
        
        /// <summary>
        /// 扣分项分类，取值包括：可用性、可维护性、性能及可靠性。
        /// </summary>
        [JsonProperty("IssueType")]
        public string IssueType{ get; set; }

        /// <summary>
        /// 扣分总分。
        /// </summary>
        [JsonProperty("ScoreLost")]
        public long? ScoreLost{ get; set; }

        /// <summary>
        /// 扣分总分上限。
        /// </summary>
        [JsonProperty("ScoreLostMax")]
        public long? ScoreLostMax{ get; set; }

        /// <summary>
        /// 扣分项列表。
        /// </summary>
        [JsonProperty("Items")]
        public ScoreItem[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IssueType", this.IssueType);
            this.SetParamSimple(map, prefix + "ScoreLost", this.ScoreLost);
            this.SetParamSimple(map, prefix + "ScoreLostMax", this.ScoreLostMax);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

