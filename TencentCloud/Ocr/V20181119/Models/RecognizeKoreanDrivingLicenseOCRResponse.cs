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

    public class RecognizeKoreanDrivingLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 驾照号码
        /// </summary>
        [JsonProperty("LicenseNumber")]
        public string LicenseNumber{ get; set; }

        /// <summary>
        /// 居民登记号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 驾照类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 换证时间
        /// </summary>
        [JsonProperty("AptitudeTesDate")]
        public string AptitudeTesDate{ get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [JsonProperty("DateOfIssue")]
        public string DateOfIssue{ get; set; }

        /// <summary>
        /// 人像截图Base64后的结果
        /// </summary>
        [JsonProperty("Photo")]
        public string Photo{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 生日，格式为dd/mm/yyyy
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

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
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "LicenseNumber", this.LicenseNumber);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AptitudeTesDate", this.AptitudeTesDate);
            this.SetParamSimple(map, prefix + "DateOfIssue", this.DateOfIssue);
            this.SetParamSimple(map, prefix + "Photo", this.Photo);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

