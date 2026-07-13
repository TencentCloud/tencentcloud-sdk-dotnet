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

    public class DriverLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>驾驶证正页姓名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>性别</p>
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>国籍</p>
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// <p>住址</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>出生日期（YYYY-MM-DD）</p>
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// <p>初次领证日期（YYYY-MM-DD）</p>
        /// </summary>
        [JsonProperty("DateOfFirstIssue")]
        public string DateOfFirstIssue{ get; set; }

        /// <summary>
        /// <p>准驾车型</p>
        /// </summary>
        [JsonProperty("Class")]
        public string Class{ get; set; }

        /// <summary>
        /// <p>有效期开始时间（YYYY-MM-DD）</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>有效期截止时间（新版驾驶证返回 YYYY-MM-DD，老版驾驶证返回有效期限 X年；若驾驶证有效期为长期，则返回&quot;长期&quot;）</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// <p>驾驶证正页证号</p>
        /// </summary>
        [JsonProperty("CardCode")]
        public string CardCode{ get; set; }

        /// <summary>
        /// <p>档案编号</p>
        /// </summary>
        [JsonProperty("ArchivesCode")]
        public string ArchivesCode{ get; set; }

        /// <summary>
        /// <p>记录</p>
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// <p>Code 告警码列表和释义：<br>-9102  复印件告警<br>-9103  翻拍件告警<br>-9104  反光告警<br>-9105  模糊告警<br>-9106  边框不完整告警<br>注：告警码可以同时存在多个</p>
        /// </summary>
        [JsonProperty("RecognizeWarnCode")]
        public long?[] RecognizeWarnCode{ get; set; }

        /// <summary>
        /// <p>告警码说明：<br>WARN_DRIVER_LICENSE_COPY_CARD 复印件告警<br>WARN_DRIVER_LICENSE_SCREENED_CARD 翻拍件告警<br>WARN_DRIVER_LICENSE_REFLECTION 反光告警<br>WARN_DRIVER_LICENSE_BLUR 模糊告警<br>WARN_DRIVER_LICENSE_BORDER_INCOMPLETE 边框不完整告警<br>注：告警信息可以同时存在多个</p>
        /// </summary>
        [JsonProperty("RecognizeWarnMsg")]
        public string[] RecognizeWarnMsg{ get; set; }

        /// <summary>
        /// <p>发证单位</p>
        /// </summary>
        [JsonProperty("IssuingAuthority")]
        public string IssuingAuthority{ get; set; }

        /// <summary>
        /// <p>状态（仅电子驾驶证支持返回该字段）</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>累积记分（仅电子驾驶证支持返回该字段）</p>
        /// </summary>
        [JsonProperty("CumulativeScore")]
        public string CumulativeScore{ get; set; }

        /// <summary>
        /// <p>当前时间（仅电子驾驶证支持返回该字段）</p>
        /// </summary>
        [JsonProperty("CurrentTime")]
        public string CurrentTime{ get; set; }

        /// <summary>
        /// <p>生成时间（仅电子驾驶证支持返回该字段）</p>
        /// </summary>
        [JsonProperty("GenerateTime")]
        public string GenerateTime{ get; set; }

        /// <summary>
        /// <p>驾驶证副页姓名</p>
        /// </summary>
        [JsonProperty("BackPageName")]
        public string BackPageName{ get; set; }

        /// <summary>
        /// <p>驾驶证副页证号</p>
        /// </summary>
        [JsonProperty("BackPageCardCode")]
        public string BackPageCardCode{ get; set; }

        /// <summary>
        /// <p>驾驶证类型<br>电子驾驶证：Electronic<br>普通驾驶证：Normal</p>
        /// </summary>
        [JsonProperty("DriverLicenseType")]
        public string DriverLicenseType{ get; set; }

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
            this.SetParamSimple(map, prefix + "ArchivesCode", this.ArchivesCode);
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnCode.", this.RecognizeWarnCode);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnMsg.", this.RecognizeWarnMsg);
            this.SetParamSimple(map, prefix + "IssuingAuthority", this.IssuingAuthority);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CumulativeScore", this.CumulativeScore);
            this.SetParamSimple(map, prefix + "CurrentTime", this.CurrentTime);
            this.SetParamSimple(map, prefix + "GenerateTime", this.GenerateTime);
            this.SetParamSimple(map, prefix + "BackPageName", this.BackPageName);
            this.SetParamSimple(map, prefix + "BackPageCardCode", this.BackPageCardCode);
            this.SetParamSimple(map, prefix + "DriverLicenseType", this.DriverLicenseType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

