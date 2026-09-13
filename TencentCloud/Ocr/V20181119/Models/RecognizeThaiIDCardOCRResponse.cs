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

    public class RecognizeThaiIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>身份证号码</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>泰文姓名</p>
        /// </summary>
        [JsonProperty("ThaiName")]
        public string ThaiName{ get; set; }

        /// <summary>
        /// <p>英文姓名</p>
        /// </summary>
        [JsonProperty("EnFirstName")]
        public string EnFirstName{ get; set; }

        /// <summary>
        /// <p>英文姓名</p>
        /// </summary>
        [JsonProperty("EnLastName")]
        public string EnLastName{ get; set; }

        /// <summary>
        /// <p>泰文签发日期</p>
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// <p>泰文到期日期</p>
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// <p>英文签发日期</p>
        /// </summary>
        [JsonProperty("EnIssueDate")]
        public string EnIssueDate{ get; set; }

        /// <summary>
        /// <p>英文到期日期</p>
        /// </summary>
        [JsonProperty("EnExpirationDate")]
        public string EnExpirationDate{ get; set; }

        /// <summary>
        /// <p>泰文出生日期</p>
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// <p>英文出生日期</p>
        /// </summary>
        [JsonProperty("EnBirthday")]
        public string EnBirthday{ get; set; }

        /// <summary>
        /// <p>宗教信仰</p>
        /// </summary>
        [JsonProperty("Religion")]
        public string Religion{ get; set; }

        /// <summary>
        /// <p>序列号</p>
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// <p>地址</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>背面号码</p>
        /// </summary>
        [JsonProperty("LaserID")]
        public string LaserID{ get; set; }

        /// <summary>
        /// <p>证件人像照片抠取</p>
        /// </summary>
        [JsonProperty("PortraitImage")]
        public string PortraitImage{ get; set; }

        /// <summary>
        /// <p>告警码<br>-9101 证件边框不完整告警<br>-9102 证件复印件告警<br>-9103 证件翻拍告警<br>-9104 证件PS告警<br>-9107 证件反光告警<br>-9108 证件模糊告警<br>-9109 告警能力未开通</p>
        /// </summary>
        [JsonProperty("WarnCardInfos")]
        public long?[] WarnCardInfos{ get; set; }

        /// <summary>
        /// <p>该字段已废弃， 将固定返回&quot;1&quot;，不建议使用。</p>
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        [System.Obsolete]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// <p>卡证正面图片中，证件主体的数量（仅请求曼谷地域[ap-bangkok]返回）</p>
        /// </summary>
        [JsonProperty("CardCount")]
        public long? CardCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ThaiName", this.ThaiName);
            this.SetParamSimple(map, prefix + "EnFirstName", this.EnFirstName);
            this.SetParamSimple(map, prefix + "EnLastName", this.EnLastName);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "EnIssueDate", this.EnIssueDate);
            this.SetParamSimple(map, prefix + "EnExpirationDate", this.EnExpirationDate);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "EnBirthday", this.EnBirthday);
            this.SetParamSimple(map, prefix + "Religion", this.Religion);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "LaserID", this.LaserID);
            this.SetParamSimple(map, prefix + "PortraitImage", this.PortraitImage);
            this.SetParamArraySimple(map, prefix + "WarnCardInfos.", this.WarnCardInfos);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "CardCount", this.CardCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

