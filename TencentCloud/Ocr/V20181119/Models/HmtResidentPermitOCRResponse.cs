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

    public class HmtResidentPermitOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>证件姓名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>性别</p>
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>出生日期</p>
        /// </summary>
        [JsonProperty("Birth")]
        public string Birth{ get; set; }

        /// <summary>
        /// <p>地址</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>身份证号</p>
        /// </summary>
        [JsonProperty("IdCardNo")]
        public string IdCardNo{ get; set; }

        /// <summary>
        /// <p>0-正面<br>1-反面</p>
        /// </summary>
        [JsonProperty("CardType")]
        public long? CardType{ get; set; }

        /// <summary>
        /// <p>证件有效期限</p>
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// <p>签发机关</p>
        /// </summary>
        [JsonProperty("Authority")]
        public string Authority{ get; set; }

        /// <summary>
        /// <p>签发次数</p>
        /// </summary>
        [JsonProperty("VisaNum")]
        public string VisaNum{ get; set; }

        /// <summary>
        /// <p>通行证号码</p>
        /// </summary>
        [JsonProperty("PassNo")]
        public string PassNo{ get; set; }

        /// <summary>
        /// <p>头像和坐标信息</p>
        /// </summary>
        [JsonProperty("PortraitImageInfo")]
        public PortraitImageInfo PortraitImageInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "Birth", this.Birth);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "IdCardNo", this.IdCardNo);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "Authority", this.Authority);
            this.SetParamSimple(map, prefix + "VisaNum", this.VisaNum);
            this.SetParamSimple(map, prefix + "PassNo", this.PassNo);
            this.SetParamObj(map, prefix + "PortraitImageInfo.", this.PortraitImageInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

