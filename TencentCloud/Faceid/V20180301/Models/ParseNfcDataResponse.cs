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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParseNfcDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 结果码。
        /// - 取值范围：0为首次查询成功，-1为查询失败。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultCode")]
        public string ResultCode{ get; set; }

        /// <summary>
        /// 身份证号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// 姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 照片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture{ get; set; }

        /// <summary>
        /// 出生日期。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BirthDate")]
        public string BirthDate{ get; set; }

        /// <summary>
        /// 有效期起始时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 有效期结束时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 住址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 民族。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// 性别。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 类型。
        /// - 取值范围：
        /// 01：身份证。 
        /// 03 ：中国护照。
        /// 04 ：军官证。
        /// 05 ：武警证。
        /// 06：港澳通行证 。
        /// 07 ：台胞证 。
        /// 08：外国护照 。
        /// 09 ：士兵证。
        /// 09 ：临时身份证。
        /// 11：户口本  。
        /// 12 ：警官证 。
        /// 13：外国人永久居留证。
        /// 14：港澳台居民居住证。
        /// 15：回乡证。
        /// 16：大陆居民来往台湾通行证。
        /// 99：其他证件。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// 英文姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// 签发机关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SigningOrganization")]
        public string SigningOrganization{ get; set; }

        /// <summary>
        /// 港澳台居民居住证，通行证号码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherIdNum")]
        public string OtherIdNum{ get; set; }

        /// <summary>
        /// 旅行证件国籍。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 旅行证件机读区第二行 29~42 位。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonalNumber")]
        public string PersonalNumber{ get; set; }

        /// <summary>
        /// 旅行证件类的核验结果。
        /// - JSON格式如下：
        /// {"result_issuer ":"签发者证书合法性验证结果 ","result_pape r":"证件安全对象合法性验证 结果 ","result_data" :"防数据篡改验证结果 ","result_chip" :"防证书件芯片被复制验证结果"} 。
        /// - 取值范围： 0:验证通过，1: 验证不通过，2: 未验证，3:部分通过，当4项核验结果都为0时，表示证件为真。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckMRTD")]
        public string CheckMRTD{ get; set; }

        /// <summary>
        /// 身份证照片面合成图片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageA")]
        public string ImageA{ get; set; }

        /// <summary>
        /// 身份证国徽面合成图片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageB")]
        public string ImageB{ get; set; }

        /// <summary>
        /// 对result code的结果描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultDescription")]
        public string ResultDescription{ get; set; }

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
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Picture", this.Picture);
            this.SetParamSimple(map, prefix + "BirthDate", this.BirthDate);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Nation", this.Nation);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "SigningOrganization", this.SigningOrganization);
            this.SetParamSimple(map, prefix + "OtherIdNum", this.OtherIdNum);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "PersonalNumber", this.PersonalNumber);
            this.SetParamSimple(map, prefix + "CheckMRTD", this.CheckMRTD);
            this.SetParamSimple(map, prefix + "ImageA", this.ImageA);
            this.SetParamSimple(map, prefix + "ImageB", this.ImageB);
            this.SetParamSimple(map, prefix + "ResultDescription", this.ResultDescription);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

