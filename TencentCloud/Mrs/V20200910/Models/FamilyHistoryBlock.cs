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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FamilyHistoryBlock : AbstractModel
    {
        
        /// <summary>
        /// 家庭成员
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelativeHistory")]
        public RelativeHistoryBlock RelativeHistory{ get; set; }

        /// <summary>
        /// 家族肿瘤史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelativeCancerHistory")]
        public RelativeCancerHistoryBlock RelativeCancerHistory{ get; set; }

        /// <summary>
        /// 家族遗传史
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GeneticHistory")]
        public GeneticHistoryBlock GeneticHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RelativeHistory.", this.RelativeHistory);
            this.SetParamObj(map, prefix + "RelativeCancerHistory.", this.RelativeCancerHistory);
            this.SetParamObj(map, prefix + "GeneticHistory.", this.GeneticHistory);
        }
    }
}

