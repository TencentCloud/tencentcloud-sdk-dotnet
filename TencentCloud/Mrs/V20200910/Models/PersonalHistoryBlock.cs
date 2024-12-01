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

    public class PersonalHistoryBlock : AbstractModel
    {
        
        /// <summary>
        /// 出生地
        /// </summary>
        [JsonProperty("BirthPlace")]
        public BirthPlaceBlock BirthPlace{ get; set; }

        /// <summary>
        /// 居住地
        /// </summary>
        [JsonProperty("LivePlace")]
        public BirthPlaceBlock LivePlace{ get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        [JsonProperty("Job")]
        public BirthPlaceBlock Job{ get; set; }

        /// <summary>
        /// 吸烟
        /// </summary>
        [JsonProperty("SmokeHistory")]
        public SmokeHistoryBlock SmokeHistory{ get; set; }

        /// <summary>
        /// 喝酒
        /// </summary>
        [JsonProperty("AlcoholicHistory")]
        public SmokeHistoryBlock AlcoholicHistory{ get; set; }

        /// <summary>
        /// 月经史
        /// </summary>
        [JsonProperty("MenstrualHistory")]
        public MenstrualHistoryBlock MenstrualHistory{ get; set; }

        /// <summary>
        /// 婚姻-生育史
        /// </summary>
        [JsonProperty("ObstericalHistory")]
        public ObstetricalHistoryBlock ObstericalHistory{ get; set; }

        /// <summary>
        /// 家族史
        /// </summary>
        [JsonProperty("FamilyHistory")]
        public FamilyHistoryBlock FamilyHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BirthPlace.", this.BirthPlace);
            this.SetParamObj(map, prefix + "LivePlace.", this.LivePlace);
            this.SetParamObj(map, prefix + "Job.", this.Job);
            this.SetParamObj(map, prefix + "SmokeHistory.", this.SmokeHistory);
            this.SetParamObj(map, prefix + "AlcoholicHistory.", this.AlcoholicHistory);
            this.SetParamObj(map, prefix + "MenstrualHistory.", this.MenstrualHistory);
            this.SetParamObj(map, prefix + "ObstericalHistory.", this.ObstericalHistory);
            this.SetParamObj(map, prefix + "FamilyHistory.", this.FamilyHistory);
        }
    }
}

