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

    public class RecognizePhilippinesDrivingLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 人像照片Base64后的结果
        /// </summary>
        [JsonProperty("HeadPortrait")]
        public TextDetectionResult HeadPortrait{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public TextDetectionResult Name{ get; set; }

        /// <summary>
        /// 姓氏
        /// </summary>
        [JsonProperty("LastName")]
        public TextDetectionResult LastName{ get; set; }

        /// <summary>
        /// 首姓名
        /// </summary>
        [JsonProperty("FirstName")]
        public TextDetectionResult FirstName{ get; set; }

        /// <summary>
        /// 中间姓名
        /// </summary>
        [JsonProperty("MiddleName")]
        public TextDetectionResult MiddleName{ get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonProperty("Nationality")]
        public TextDetectionResult Nationality{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Sex")]
        public TextDetectionResult Sex{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public TextDetectionResult Address{ get; set; }

        /// <summary>
        /// 证号
        /// </summary>
        [JsonProperty("LicenseNo")]
        public TextDetectionResult LicenseNo{ get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("ExpiresDate")]
        public TextDetectionResult ExpiresDate{ get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [JsonProperty("AgencyCode")]
        public TextDetectionResult AgencyCode{ get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [JsonProperty("Birthday")]
        public TextDetectionResult Birthday{ get; set; }

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
            this.SetParamObj(map, prefix + "HeadPortrait.", this.HeadPortrait);
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamObj(map, prefix + "LastName.", this.LastName);
            this.SetParamObj(map, prefix + "FirstName.", this.FirstName);
            this.SetParamObj(map, prefix + "MiddleName.", this.MiddleName);
            this.SetParamObj(map, prefix + "Nationality.", this.Nationality);
            this.SetParamObj(map, prefix + "Sex.", this.Sex);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamObj(map, prefix + "LicenseNo.", this.LicenseNo);
            this.SetParamObj(map, prefix + "ExpiresDate.", this.ExpiresDate);
            this.SetParamObj(map, prefix + "AgencyCode.", this.AgencyCode);
            this.SetParamObj(map, prefix + "Birthday.", this.Birthday);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

