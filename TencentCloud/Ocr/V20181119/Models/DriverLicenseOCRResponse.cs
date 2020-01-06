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

    public class DriverLicenseOCRResponse : AbstractModel
    {
        
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
        /// 国籍
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// 初次领证日期
        /// </summary>
        [JsonProperty("DateOfFirstIssue")]
        public string DateOfFirstIssue{ get; set; }

        /// <summary>
        /// 准驾车型
        /// </summary>
        [JsonProperty("Class")]
        public string Class{ get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 有效期截止时间
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 证号
        /// </summary>
        [JsonProperty("CardCode")]
        public string CardCode{ get; set; }

        /// <summary>
        /// 告警码	告警码消息	                                                告警码说明
        /// -9102	WARN_DRIVER_LICENSE_COPY_CARD	        复印件告警
        /// -9103	WARN_DRIVER_LICENSE_SCREENED_CARD	翻拍件告警
        /// -9106	WARN_DRIVER_LICENSE_PS_CARD	                ps告警
        /// 注：告警码可以同时存在多个
        /// </summary>
        [JsonProperty("RecognizeWarnCode")]
        public long?[] RecognizeWarnCode{ get; set; }

        /// <summary>
        /// 告警码说明
        /// 注：告警信息可以同时存在多个
        /// </summary>
        [JsonProperty("RecognizeWarnMsg")]
        public string[] RecognizeWarnMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "DateOfFirstIssue", this.DateOfFirstIssue);
            this.SetParamSimple(map, prefix + "Class", this.Class);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "CardCode", this.CardCode);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnCode.", this.RecognizeWarnCode);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnMsg.", this.RecognizeWarnMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

