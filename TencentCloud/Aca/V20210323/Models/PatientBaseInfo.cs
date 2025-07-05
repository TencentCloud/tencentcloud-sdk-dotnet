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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PatientBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 身高 单位cm
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 体重 单位kg
        /// </summary>
        [JsonProperty("Weight")]
        public string Weight{ get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        [JsonProperty("PatientId")]
        public string PatientId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// 出生地
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// 居住地
        /// </summary>
        [JsonProperty("LivePlace")]
        public string LivePlace{ get; set; }

        /// <summary>
        /// 出生日期和年龄必须传一个
        /// </summary>
        [JsonProperty("BirthDay")]
        public string BirthDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PatientId", this.PatientId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "LivePlace", this.LivePlace);
            this.SetParamSimple(map, prefix + "BirthDay", this.BirthDay);
        }
    }
}

