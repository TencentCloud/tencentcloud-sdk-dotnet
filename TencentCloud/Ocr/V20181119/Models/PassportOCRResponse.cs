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

    public class PassportOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 国家码
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 护照号
        /// </summary>
        [JsonProperty("PassportNo")]
        public string PassportNo{ get; set; }

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
        /// 出生日期
        /// </summary>
        [JsonProperty("BirthDate")]
        public string BirthDate{ get; set; }

        /// <summary>
        /// 出生地点
        /// </summary>
        [JsonProperty("BirthPlace")]
        public string BirthPlace{ get; set; }

        /// <summary>
        /// 签发日期
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// 签发地点
        /// </summary>
        [JsonProperty("IssuePlace")]
        public string IssuePlace{ get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonProperty("ExpiryDate")]
        public string ExpiryDate{ get; set; }

        /// <summary>
        /// 持证人签名
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }

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
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

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
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "PassportNo", this.PassportNo);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "BirthDate", this.BirthDate);
            this.SetParamSimple(map, prefix + "BirthPlace", this.BirthPlace);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "IssuePlace", this.IssuePlace);
            this.SetParamSimple(map, prefix + "ExpiryDate", this.ExpiryDate);
            this.SetParamSimple(map, prefix + "Signature", this.Signature);
            this.SetParamSimple(map, prefix + "CodeSet", this.CodeSet);
            this.SetParamSimple(map, prefix + "CodeCrc", this.CodeCrc);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "FamilyName", this.FamilyName);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

