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

    public class MenstrualMedicalHistory : AbstractModel
    {
        
        /// <summary>
        /// 末次月经时间
        /// </summary>
        [JsonProperty("LastMenstrualPeriod")]
        public string LastMenstrualPeriod{ get; set; }

        /// <summary>
        /// 经量
        /// </summary>
        [JsonProperty("MenstrualFlow")]
        public string MenstrualFlow{ get; set; }

        /// <summary>
        /// 月经初潮年龄
        /// </summary>
        [JsonProperty("MenarcheAge")]
        public string MenarcheAge{ get; set; }

        /// <summary>
        /// 是否来月经
        /// </summary>
        [JsonProperty("MenstruationOrNot")]
        public string MenstruationOrNot{ get; set; }

        /// <summary>
        /// 月经周期
        /// </summary>
        [JsonProperty("MenstrualCycles")]
        public string MenstrualCycles{ get; set; }

        /// <summary>
        /// 月经持续天数
        /// </summary>
        [JsonProperty("MenstrualPeriod")]
        public string MenstrualPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LastMenstrualPeriod", this.LastMenstrualPeriod);
            this.SetParamSimple(map, prefix + "MenstrualFlow", this.MenstrualFlow);
            this.SetParamSimple(map, prefix + "MenarcheAge", this.MenarcheAge);
            this.SetParamSimple(map, prefix + "MenstruationOrNot", this.MenstruationOrNot);
            this.SetParamSimple(map, prefix + "MenstrualCycles", this.MenstrualCycles);
            this.SetParamSimple(map, prefix + "MenstrualPeriod", this.MenstrualPeriod);
        }
    }
}

