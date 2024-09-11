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

    public class MainlandPermitOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 中文姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 英文姓名
        /// </summary>
        [JsonProperty("EnglishName")]
        public string EnglishName{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// 签发机关
        /// </summary>
        [JsonProperty("IssueAuthority")]
        public string IssueAuthority{ get; set; }

        /// <summary>
        /// 有效期限
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 签发地点
        /// </summary>
        [JsonProperty("IssueAddress")]
        public string IssueAddress{ get; set; }

        /// <summary>
        /// 签发次数
        /// </summary>
        [JsonProperty("IssueNumber")]
        public string IssueNumber{ get; set; }

        /// <summary>
        /// 证件类别， 如：台湾居民来往大陆通行证、港澳居民来往内地通行证。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// RetProfile为True时返回头像字段， Base64编码
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 背面字段信息
        /// </summary>
        [JsonProperty("MainlandTravelPermitBackInfos")]
        public MainlandTravelPermitBackInfos MainlandTravelPermitBackInfos{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnglishName", this.EnglishName);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "IssueAuthority", this.IssueAuthority);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "IssueAddress", this.IssueAddress);
            this.SetParamSimple(map, prefix + "IssueNumber", this.IssueNumber);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamObj(map, prefix + "MainlandTravelPermitBackInfos.", this.MainlandTravelPermitBackInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

