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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FamilyMedicalHistory : AbstractModel
    {
        
        /// <summary>
        /// 家族成员史
        /// </summary>
        [JsonProperty("RelativeHistory")]
        public string RelativeHistory{ get; set; }

        /// <summary>
        /// 家族肿瘤史
        /// </summary>
        [JsonProperty("RelativeCancerHistory")]
        public string RelativeCancerHistory{ get; set; }

        /// <summary>
        /// 家族遗传史
        /// </summary>
        [JsonProperty("GeneticHistory")]
        public string GeneticHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RelativeHistory", this.RelativeHistory);
            this.SetParamSimple(map, prefix + "RelativeCancerHistory", this.RelativeCancerHistory);
            this.SetParamSimple(map, prefix + "GeneticHistory", this.GeneticHistory);
        }
    }
}

