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
        /// 承办人签章文字
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }

        /// <summary>
        /// 签发日期
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// 户主页编号
        /// </summary>
        [JsonProperty("HomePageNumber")]
        public string HomePageNumber{ get; set; }

        /// <summary>
        /// 户主姓名
        /// </summary>
        [JsonProperty("HouseholderName")]
        public string HouseholderName{ get; set; }

        /// <summary>
        /// 户主或与户主关系
        /// </summary>
        [JsonProperty("Relationship")]
        public string Relationship{ get; set; }

        /// <summary>
        /// 本市（县）其他住址
        /// </summary>
        [JsonProperty("OtherAddresses")]
        public string OtherAddresses{ get; set; }

        /// <summary>
        /// 宗教信仰
        /// </summary>
        [JsonProperty("ReligiousBelief")]
        public string ReligiousBelief{ get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 血型
        /// </summary>
        [JsonProperty("BloodType")]
        public string BloodType{ get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        [JsonProperty("MaritalStatus")]
        public string MaritalStatus{ get; set; }

        /// <summary>
        /// 兵役状况
        /// </summary>
        [JsonProperty("VeteranStatus")]
        public string VeteranStatus{ get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// 何时由何地迁来本市(县)
        /// </summary>
        [JsonProperty("MoveToCityInformation")]
        public string MoveToCityInformation{ get; set; }

        /// <summary>
        /// 何时由何地迁来本址
        /// </summary>
        [JsonProperty("MoveToSiteInformation")]
        public string MoveToSiteInformation{ get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        [JsonProperty("RegistrationDate")]
        public string RegistrationDate{ get; set; }

        /// <summary>
        /// 曾用名
        /// </summary>
        [JsonProperty("FormerName")]
        public string FormerName{ get; set; }

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
            this.SetParamSimple(map, prefix + "Signature", this.Signature);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "HomePageNumber", this.HomePageNumber);
            this.SetParamSimple(map, prefix + "HouseholderName", this.HouseholderName);
            this.SetParamSimple(map, prefix + "Relationship", this.Relationship);
            this.SetParamSimple(map, prefix + "OtherAddresses", this.OtherAddresses);
            this.SetParamSimple(map, prefix + "ReligiousBelief", this.ReligiousBelief);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "BloodType", this.BloodType);
            this.SetParamSimple(map, prefix + "MaritalStatus", this.MaritalStatus);
            this.SetParamSimple(map, prefix + "VeteranStatus", this.VeteranStatus);
            this.SetParamSimple(map, prefix + "Profession", this.Profession);
            this.SetParamSimple(map, prefix + "MoveToCityInformation", this.MoveToCityInformation);
            this.SetParamSimple(map, prefix + "MoveToSiteInformation", this.MoveToSiteInformation);
            this.SetParamSimple(map, prefix + "RegistrationDate", this.RegistrationDate);
            this.SetParamSimple(map, prefix + "FormerName", this.FormerName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

