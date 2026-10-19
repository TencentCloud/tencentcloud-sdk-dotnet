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

    public class RecognizeGeneralCardWarnResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>卡证类型参数，枚举值：<br>（如入参CardType未填或填入General，返回自动分类的卡证类型，未能分类的其他类型返回General；如入参CardType填入General以外的值，则不进行自动分类、返回相同的值）</p><p>General：其他类型<br>IDCard：身份证<br>Passport：护照<br>BankCard：银行卡<br>VehicleLicense：行驶证<br>DriverLicense：驾驶证<br>BizLicense：营业执照<br>HmtResidentPermit：港澳台居住证<br>ForeignPermanentResident：外国人永居证<br>MainlandPermit：港澳台来往内地通行证<br>SocialSecurityCard：社保卡</p>
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// <p>模糊信息</p>
        /// </summary>
        [JsonProperty("Blur")]
        public GeneralCardWarnInfo Blur{ get; set; }

        /// <summary>
        /// <p>边框不完整信息</p>
        /// </summary>
        [JsonProperty("BorderIncomplete")]
        public GeneralCardWarnInfo BorderIncomplete{ get; set; }

        /// <summary>
        /// <p>复印件信息</p>
        /// </summary>
        [JsonProperty("Copy")]
        public GeneralCardWarnInfo Copy{ get; set; }

        /// <summary>
        /// <p>ps篡改信息</p>
        /// </summary>
        [JsonProperty("Ps")]
        public GeneralCardWarnInfo Ps{ get; set; }

        /// <summary>
        /// <p>反光信息</p>
        /// </summary>
        [JsonProperty("Reflection")]
        public GeneralCardWarnInfo Reflection{ get; set; }

        /// <summary>
        /// <p>翻拍件信息</p>
        /// </summary>
        [JsonProperty("Reprint")]
        public GeneralCardWarnInfo Reprint{ get; set; }

        /// <summary>
        /// <p>是否截图</p>
        /// </summary>
        [JsonProperty("Screenshot")]
        public GeneralCardWarnInfo Screenshot{ get; set; }

        /// <summary>
        /// <p>是否遮挡</p>
        /// </summary>
        [JsonProperty("Cover")]
        public GeneralCardWarnInfo Cover{ get; set; }

        /// <summary>
        /// <p>是否重叠</p>
        /// </summary>
        [JsonProperty("Overlap")]
        public GeneralCardWarnInfo Overlap{ get; set; }

        /// <summary>
        /// <p>是否水印</p>
        /// </summary>
        [JsonProperty("Watermark")]
        public GeneralCardWarnInfo Watermark{ get; set; }

        /// <summary>
        /// <p>是否电子证照（目前仅支持电子身份证、电子营业执照识别</p>
        /// </summary>
        [JsonProperty("Electron")]
        public GeneralCardWarnInfo Electron{ get; set; }

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
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamObj(map, prefix + "Blur.", this.Blur);
            this.SetParamObj(map, prefix + "BorderIncomplete.", this.BorderIncomplete);
            this.SetParamObj(map, prefix + "Copy.", this.Copy);
            this.SetParamObj(map, prefix + "Ps.", this.Ps);
            this.SetParamObj(map, prefix + "Reflection.", this.Reflection);
            this.SetParamObj(map, prefix + "Reprint.", this.Reprint);
            this.SetParamObj(map, prefix + "Screenshot.", this.Screenshot);
            this.SetParamObj(map, prefix + "Cover.", this.Cover);
            this.SetParamObj(map, prefix + "Overlap.", this.Overlap);
            this.SetParamObj(map, prefix + "Watermark.", this.Watermark);
            this.SetParamObj(map, prefix + "Electron.", this.Electron);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

