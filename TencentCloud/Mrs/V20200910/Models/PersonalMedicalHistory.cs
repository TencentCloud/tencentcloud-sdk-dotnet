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

    public class PersonalMedicalHistory : AbstractModel
    {
        
        /// <summary>
        /// 出生史
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// 居住史
        /// </summary>
        [JsonProperty("LivePlace")]
        public string LivePlace{ get; set; }

        /// <summary>
        /// 工作史
        /// </summary>
        [JsonProperty("Job")]
        public string Job{ get; set; }

        /// <summary>
        /// 吸烟史
        /// </summary>
        [JsonProperty("SmokeHistory")]
        public string SmokeHistory{ get; set; }

        /// <summary>
        /// 饮酒史
        /// </summary>
        [JsonProperty("AlcoholicHistory")]
        public string AlcoholicHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "LivePlace", this.LivePlace);
            this.SetParamSimple(map, prefix + "Job", this.Job);
            this.SetParamSimple(map, prefix + "SmokeHistory", this.SmokeHistory);
            this.SetParamSimple(map, prefix + "AlcoholicHistory", this.AlcoholicHistory);
        }
    }
}

