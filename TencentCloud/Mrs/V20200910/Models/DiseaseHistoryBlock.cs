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

    public class DiseaseHistoryBlock : AbstractModel
    {
        
        /// <summary>
        /// 主要病史
        /// </summary>
        [JsonProperty("MainDiseaseHistory")]
        public MainDiseaseHistoryBlock MainDiseaseHistory{ get; set; }

        /// <summary>
        /// 过敏史
        /// </summary>
        [JsonProperty("AllergyHistory")]
        public MainDiseaseHistoryBlock AllergyHistory{ get; set; }

        /// <summary>
        /// 注射史
        /// </summary>
        [JsonProperty("InfectHistory")]
        public MainDiseaseHistoryBlock InfectHistory{ get; set; }

        /// <summary>
        /// 手术史
        /// </summary>
        [JsonProperty("SurgeryHistory")]
        public SurgeryHistoryBlock SurgeryHistory{ get; set; }

        /// <summary>
        /// 输血史
        /// </summary>
        [JsonProperty("TransfusionHistory")]
        public TransfusionHistoryBlock TransfusionHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MainDiseaseHistory.", this.MainDiseaseHistory);
            this.SetParamObj(map, prefix + "AllergyHistory.", this.AllergyHistory);
            this.SetParamObj(map, prefix + "InfectHistory.", this.InfectHistory);
            this.SetParamObj(map, prefix + "SurgeryHistory.", this.SurgeryHistory);
            this.SetParamObj(map, prefix + "TransfusionHistory.", this.TransfusionHistory);
        }
    }
}

