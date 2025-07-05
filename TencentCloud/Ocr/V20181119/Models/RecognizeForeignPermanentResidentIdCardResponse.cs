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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeForeignPermanentResidentIdCardResponse : AbstractModel
    {
        
        /// <summary>
        /// 中文姓名。
        /// </summary>
        [JsonProperty("CnName")]
        public string CnName{ get; set; }

        /// <summary>
        /// 英文名。
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// 性别。
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 出生日期。规范格式为 XXXX年XX月XX日。
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// 国籍。
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 有效期限。
        /// </summary>
        [JsonProperty("PeriodOfValidity")]
        public string PeriodOfValidity{ get; set; }

        /// <summary>
        /// 证件号码。
        /// </summary>
        [JsonProperty("No")]
        public string No{ get; set; }

        /// <summary>
        /// 曾持证件号码。
        /// </summary>
        [JsonProperty("PreviousNumber")]
        public string PreviousNumber{ get; set; }

        /// <summary>
        /// 签发机关。
        /// </summary>
        [JsonProperty("IssuedAuthority")]
        public string IssuedAuthority{ get; set; }

        /// <summary>
        /// 头像和坐标信息。
        /// </summary>
        [JsonProperty("PortraitImageInfo")]
        public PortraitImageInfo PortraitImageInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CnName", this.CnName);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "PeriodOfValidity", this.PeriodOfValidity);
            this.SetParamSimple(map, prefix + "No", this.No);
            this.SetParamSimple(map, prefix + "PreviousNumber", this.PreviousNumber);
            this.SetParamSimple(map, prefix + "IssuedAuthority", this.IssuedAuthority);
            this.SetParamObj(map, prefix + "PortraitImageInfo.", this.PortraitImageInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

