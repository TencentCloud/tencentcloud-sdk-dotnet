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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PassportRecognizeInfos : AbstractModel
    {
        
        /// <summary>
        /// 证件类型（护照信息页识别结果）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 发行国家（护照信息页识别结果）
        /// </summary>
        [JsonProperty("IssuingCountry")]
        public string IssuingCountry{ get; set; }

        /// <summary>
        /// 护照号码（护照信息页识别结果）
        /// </summary>
        [JsonProperty("PassportID")]
        public string PassportID{ get; set; }

        /// <summary>
        /// 姓（护照信息页识别结果）
        /// </summary>
        [JsonProperty("Surname")]
        public string Surname{ get; set; }

        /// <summary>
        /// 名（护照信息页识别结果）
        /// </summary>
        [JsonProperty("GivenName")]
        public string GivenName{ get; set; }

        /// <summary>
        /// 姓名（护照信息页识别结果）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 国籍信息（护照信息页识别结果）
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 出生日期（护照信息页识别结果）
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// 性别（护照信息页识别结果）
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 发行日期（护照信息页识别结果）
        /// </summary>
        [JsonProperty("DateOfIssuance")]
        public string DateOfIssuance{ get; set; }

        /// <summary>
        /// 截止日期（护照信息页识别结果）
        /// </summary>
        [JsonProperty("DateOfExpiration")]
        public string DateOfExpiration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IssuingCountry", this.IssuingCountry);
            this.SetParamSimple(map, prefix + "PassportID", this.PassportID);
            this.SetParamSimple(map, prefix + "Surname", this.Surname);
            this.SetParamSimple(map, prefix + "GivenName", this.GivenName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "DateOfIssuance", this.DateOfIssuance);
            this.SetParamSimple(map, prefix + "DateOfExpiration", this.DateOfExpiration);
        }
    }
}

