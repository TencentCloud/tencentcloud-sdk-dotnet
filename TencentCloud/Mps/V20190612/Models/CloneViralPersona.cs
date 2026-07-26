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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneViralPersona : AbstractModel
    {
        
        /// <summary>
        /// <p>模特性别。male/female/any</p>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>年龄段。teenager/youth/middle_aged/senior</p>
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// <p>外观特征。caucasian/asian/latino/african/middle_eastern</p>
        /// </summary>
        [JsonProperty("Ethnicity")]
        public string Ethnicity{ get; set; }

        /// <summary>
        /// <p>体型。slim / standard / athletic / chubby</p>
        /// </summary>
        [JsonProperty("BodyType")]
        public string BodyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Ethnicity", this.Ethnicity);
            this.SetParamSimple(map, prefix + "BodyType", this.BodyType);
        }
    }
}

