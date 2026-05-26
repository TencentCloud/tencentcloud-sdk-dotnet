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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWxNFCResultResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>NFC计费结果码，NFC识读成功一次则计费一次（同一个NFC请求重复拉取结果不会重复计费）。计费结果码取值范围：<br>  0：识读成功，计费<br>-1：识读失败，不计费</p>
        /// </summary>
        [JsonProperty("ResultCode")]
        public string ResultCode{ get; set; }

        /// <summary>
        /// <p>身份证号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// <p>姓名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>证件中的人像照片</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture{ get; set; }

        /// <summary>
        /// <p>身份类证件正面照片（人像面）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardFrontImg")]
        public string IdCardFrontImg{ get; set; }

        /// <summary>
        /// <p>身份类证件背面照片（国徽面）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardBackImg")]
        public string IdCardBackImg{ get; set; }

        /// <summary>
        /// <p>出生日期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BirthDate")]
        public string BirthDate{ get; set; }

        /// <summary>
        /// <p>有效期起始时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>有效期结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>住址</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>民族</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// <p>性别</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>证件类型</p><p>枚举值：</p><ul><li>01： 身份证</li><li>03： 中国护照</li><li>06： 港澳通行证</li><li>07： 台胞证</li><li>08： 外国护照</li><li>13： 外国人永久居留证</li><li>14： 港澳台居民居住证</li><li>15： 回乡证</li><li>16： 大陆居民来往台湾通行证</li><li>99： 其他证件</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// <p>英文姓名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// <p>签发机关</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SigningOrganization")]
        public string SigningOrganization{ get; set; }

        /// <summary>
        /// <p>港澳台居民居住证，通行证号码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherIdNum")]
        public string OtherIdNum{ get; set; }

        /// <summary>
        /// <p>旅行证件国籍</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// <p>旅行证件机读区第二行 29~42 位</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonalNumber")]
        public string PersonalNumber{ get; set; }

        /// <summary>
        /// <p>证件的验真结果</p><ul><li>JSON格式如下： {&quot;result_issuer &quot;:&quot;签发者证书合法性验证结果 &quot;,&quot;result_paper&quot;:&quot;证件安全对象合法性验证结果 &quot;,&quot;result_data&quot; :&quot;防数据篡改验证结果 &quot;,&quot;result_chip&quot; :&quot;防证书件芯片被复制验证结果&quot;} 。 - 取值范围： 0:验证通过，1: 验证不通过，2: 未验证，3:部分通过，当4项核验结果都为0时，表示证件为真。</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckMRTD")]
        public string CheckMRTD{ get; set; }

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
            this.SetParamSimple(map, prefix + "IdCardFrontImg", this.IdCardFrontImg);
            this.SetParamSimple(map, prefix + "IdCardBackImg", this.IdCardBackImg);
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

