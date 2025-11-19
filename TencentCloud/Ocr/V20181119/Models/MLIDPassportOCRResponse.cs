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

    public class MLIDPassportOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 护照ID（机读码区的解析结果）
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 姓名（机读码区的解析结果）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 出生日期（机读码区的解析结果）
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// 性别（F女，M男）（机读码区的解析结果）
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 有效期（机读码区的解析结果）
        /// </summary>
        [JsonProperty("DateOfExpiration")]
        public string DateOfExpiration{ get; set; }

        /// <summary>
        /// 发行国（机读码区的解析结果）
        /// </summary>
        [JsonProperty("IssuingCountry")]
        public string IssuingCountry{ get; set; }

        /// <summary>
        /// 国家地区代码（机读码区的解析结果）
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 该字段已废弃， 将固定返回空数组，不建议使用。
        /// </summary>
        [JsonProperty("Warn")]
        [System.Obsolete]
        public long?[] Warn{ get; set; }

        /// <summary>
        /// 证件中的人像图片base64
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 该字段已废弃， 将固定返回"1"，不建议使用。
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        [System.Obsolete]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// 最下方第一行 MRZ Code 序列
        /// </summary>
        [JsonProperty("CodeSet")]
        public string CodeSet{ get; set; }

        /// <summary>
        /// 最下方第二行 MRZ Code 序列
        /// </summary>
        [JsonProperty("CodeCrc")]
        public string CodeCrc{ get; set; }

        /// <summary>
        /// 姓（机读码区的解析结果）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Surname")]
        public string Surname{ get; set; }

        /// <summary>
        /// 名（机读码区的解析结果）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GivenName")]
        public string GivenName{ get; set; }

        /// <summary>
        /// 类型（机读码区的解析结果）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 信息区证件内容
        /// </summary>
        [JsonProperty("PassportRecognizeInfos")]
        public PassportRecognizeInfos PassportRecognizeInfos{ get; set; }

        /// <summary>
        /// 该字段仅对国际站请求起作用，国内站该字段将固定返回空数组。国际站告警码如下：  告警码-9101 证件边框不完整告警-9102 证件复印件告警-9103 证件翻拍告警-9104 证件PS告警-9107 证件反光告警-9108 证件模糊告警-9109 告警能力未开通
        /// </summary>
        [JsonProperty("WarnCardInfos")]
        public long?[] WarnCardInfos{ get; set; }

        /// <summary>
        /// 输入图片中的卡证数量（仅请求曼谷地域[ap-bangkok]返回）
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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "DateOfExpiration", this.DateOfExpiration);
            this.SetParamSimple(map, prefix + "IssuingCountry", this.IssuingCountry);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamArraySimple(map, prefix + "Warn.", this.Warn);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "CodeSet", this.CodeSet);
            this.SetParamSimple(map, prefix + "CodeCrc", this.CodeCrc);
            this.SetParamSimple(map, prefix + "Surname", this.Surname);
            this.SetParamSimple(map, prefix + "GivenName", this.GivenName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PassportRecognizeInfos.", this.PassportRecognizeInfos);
            this.SetParamArraySimple(map, prefix + "WarnCardInfos.", this.WarnCardInfos);
            this.SetParamSimple(map, prefix + "CardCount", this.CardCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

