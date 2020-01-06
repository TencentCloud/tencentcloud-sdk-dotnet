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

    public class ResidenceBookletOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 户号
        /// </summary>
        [JsonProperty("HouseholdNumber")]
        public string HouseholdNumber{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 出生地
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        [JsonProperty("NativePlace")]
        public string NativePlace{ get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [JsonProperty("BirthDate")]
        public string BirthDate{ get; set; }

        /// <summary>
        /// 公民身份证件编号
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 文化程度
        /// </summary>
        [JsonProperty("EducationDegree")]
        public string EducationDegree{ get; set; }

        /// <summary>
        /// 服务处所
        /// </summary>
        [JsonProperty("ServicePlace")]
        public string ServicePlace{ get; set; }

        /// <summary>
        /// 户别
        /// </summary>
        [JsonProperty("Household")]
        public string Household{ get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HouseholdNumber", this.HouseholdNumber);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "Nation", this.Nation);
            this.SetParamSimple(map, prefix + "NativePlace", this.NativePlace);
            this.SetParamSimple(map, prefix + "BirthDate", this.BirthDate);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "EducationDegree", this.EducationDegree);
            this.SetParamSimple(map, prefix + "ServicePlace", this.ServicePlace);
            this.SetParamSimple(map, prefix + "Household", this.Household);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

