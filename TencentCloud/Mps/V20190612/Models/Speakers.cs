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

    public class Speakers : AbstractModel
    {
        
        /// <summary>
        /// <p>角色唯一标识</p>
        /// </summary>
        [JsonProperty("SpeakerId")]
        public string SpeakerId{ get; set; }

        /// <summary>
        /// <p>绑定的音色 ID</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>性别：male / female，默认 male</p>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>年龄段：child / teenager / youth / middle_aged/ senior，默认 youth</p>
        /// </summary>
        [JsonProperty("AgeGroup")]
        public string AgeGroup{ get; set; }

        /// <summary>
        /// <p>角色描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>角色人名术语表</p>
        /// </summary>
        [JsonProperty("NameTerms")]
        public TermBase[] NameTerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "AgeGroup", this.AgeGroup);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "NameTerms.", this.NameTerms);
        }
    }
}

