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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersonalInfo : AbstractModel
    {
        
        /// <summary>
        /// 姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 性别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// 年龄
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Age")]
        public string Age{ get; set; }

        /// <summary>
        /// 身份证号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IDCard")]
        public string IDCard{ get; set; }

        /// <summary>
        /// 健康卡号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCardNum")]
        public string HealthCardNum{ get; set; }

        /// <summary>
        /// 社保号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SocialSecurityCardNum")]
        public string SocialSecurityCardNum{ get; set; }

        /// <summary>
        /// 出生日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// 民族
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ethnicity")]
        public string Ethnicity{ get; set; }

        /// <summary>
        /// 国籍
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 婚姻状况
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Married")]
        public string Married{ get; set; }

        /// <summary>
        /// 职业
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// 教育程度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EducationBackground")]
        public string EducationBackground{ get; set; }

        /// <summary>
        /// 籍贯
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// 医保卡类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MedicalInsuranceType")]
        public string MedicalInsuranceType{ get; set; }

        /// <summary>
        /// 联系电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkPhone")]
        public string LinkPhone{ get; set; }

        /// <summary>
        /// 联系地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkAddress")]
        public string LinkAddress{ get; set; }

        /// <summary>
        /// 家属姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KinsfolkName")]
        public string KinsfolkName{ get; set; }

        /// <summary>
        /// 家属关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KinsfolkRelation")]
        public string KinsfolkRelation{ get; set; }

        /// <summary>
        /// 家属联系电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KinsfolkPhone")]
        public string KinsfolkPhone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "IDCard", this.IDCard);
            this.SetParamSimple(map, prefix + "HealthCardNum", this.HealthCardNum);
            this.SetParamSimple(map, prefix + "SocialSecurityCardNum", this.SocialSecurityCardNum);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "Ethnicity", this.Ethnicity);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Married", this.Married);
            this.SetParamSimple(map, prefix + "Profession", this.Profession);
            this.SetParamSimple(map, prefix + "EducationBackground", this.EducationBackground);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "MedicalInsuranceType", this.MedicalInsuranceType);
            this.SetParamSimple(map, prefix + "LinkPhone", this.LinkPhone);
            this.SetParamSimple(map, prefix + "LinkAddress", this.LinkAddress);
            this.SetParamSimple(map, prefix + "KinsfolkName", this.KinsfolkName);
            this.SetParamSimple(map, prefix + "KinsfolkRelation", this.KinsfolkRelation);
            this.SetParamSimple(map, prefix + "KinsfolkPhone", this.KinsfolkPhone);
        }
    }
}

