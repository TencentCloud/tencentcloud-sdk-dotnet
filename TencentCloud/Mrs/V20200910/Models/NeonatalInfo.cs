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

    public class NeonatalInfo : AbstractModel
    {
        
        /// <summary>
        /// 新生儿名字
        /// </summary>
        [JsonProperty("NeonatalName")]
        public string NeonatalName{ get; set; }

        /// <summary>
        /// 新生儿性别
        /// </summary>
        [JsonProperty("NeonatalGender")]
        public string NeonatalGender{ get; set; }

        /// <summary>
        /// 出生身长
        /// </summary>
        [JsonProperty("BirthLength")]
        public string BirthLength{ get; set; }

        /// <summary>
        /// 出生体重
        /// </summary>
        [JsonProperty("BirthWeight")]
        public string BirthWeight{ get; set; }

        /// <summary>
        /// 出生孕周
        /// </summary>
        [JsonProperty("GestationalAge")]
        public string GestationalAge{ get; set; }

        /// <summary>
        /// 出生时间
        /// </summary>
        [JsonProperty("BirthTime")]
        public string BirthTime{ get; set; }

        /// <summary>
        /// 出生地点
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// 医疗机构
        /// </summary>
        [JsonProperty("MedicalInstitutions")]
        public string MedicalInstitutions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NeonatalName", this.NeonatalName);
            this.SetParamSimple(map, prefix + "NeonatalGender", this.NeonatalGender);
            this.SetParamSimple(map, prefix + "BirthLength", this.BirthLength);
            this.SetParamSimple(map, prefix + "BirthWeight", this.BirthWeight);
            this.SetParamSimple(map, prefix + "GestationalAge", this.GestationalAge);
            this.SetParamSimple(map, prefix + "BirthTime", this.BirthTime);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "MedicalInstitutions", this.MedicalInstitutions);
        }
    }
}

