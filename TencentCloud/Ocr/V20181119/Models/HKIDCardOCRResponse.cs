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

    public class HKIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>中文姓名</p>
        /// </summary>
        [JsonProperty("CnName")]
        public string CnName{ get; set; }

        /// <summary>
        /// <p>英文姓名</p>
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// <p>中文姓名对应电码</p>
        /// </summary>
        [JsonProperty("TelexCode")]
        public string TelexCode{ get; set; }

        /// <summary>
        /// <p>性别 ：“男M”或“女F”</p>
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>出生日期</p>
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// <p>永久性居民身份证。<br>0：非永久；<br>1：永久；<br>-1：未知。</p>
        /// </summary>
        [JsonProperty("Permanent")]
        public long? Permanent{ get; set; }

        /// <summary>
        /// <p>身份证号码</p>
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// <p>证件符号，出生日期下的符号，例如&quot;***AZ&quot;</p>
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// <p>首次签发日期</p>
        /// </summary>
        [JsonProperty("FirstIssueDate")]
        public string FirstIssueDate{ get; set; }

        /// <summary>
        /// <p>最近领用日期</p>
        /// </summary>
        [JsonProperty("CurrentIssueDate")]
        public string CurrentIssueDate{ get; set; }

        /// <summary>
        /// <p>真假判断。<br>0：无法判断（图像模糊、不完整、反光、过暗等导致无法判断）；<br>1：假；<br>2：真。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FakeDetectResult")]
        [System.Obsolete]
        public long? FakeDetectResult{ get; set; }

        /// <summary>
        /// <p>Base64编码的证件左侧人像大图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadImage")]
        public string HeadImage{ get; set; }

        /// <summary>
        /// <p>Base64编码的证件右侧人像小图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmallHeadImage")]
        public string SmallHeadImage{ get; set; }

        /// <summary>
        /// <p>该字段已废弃， 将固定返回空数组，不建议使用。</p>
        /// </summary>
        [JsonProperty("WarningCode")]
        [System.Obsolete]
        public long?[] WarningCode{ get; set; }

        /// <summary>
        /// <p>该字段仅对国际站请求起作用，国内站该字段将固定返回空数组。国际站告警码如下：    告警码-9101 证件边框不完整告警-9102 证件复印件告警-9103 证件翻拍告警-9104 证件PS告警-9107 证件反光告警-9108 证件模糊告警-9109 告警能力未开通</p>
        /// </summary>
        [JsonProperty("WarnCardInfos")]
        public long?[] WarnCardInfos{ get; set; }

        /// <summary>
        /// <p>证件透明视窗内的文本信息</p>
        /// </summary>
        [JsonProperty("WindowEmbeddedText")]
        public string WindowEmbeddedText{ get; set; }

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
            this.SetParamSimple(map, prefix + "CnName", this.CnName);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "TelexCode", this.TelexCode);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "Permanent", this.Permanent);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "FirstIssueDate", this.FirstIssueDate);
            this.SetParamSimple(map, prefix + "CurrentIssueDate", this.CurrentIssueDate);
            this.SetParamSimple(map, prefix + "FakeDetectResult", this.FakeDetectResult);
            this.SetParamSimple(map, prefix + "HeadImage", this.HeadImage);
            this.SetParamSimple(map, prefix + "SmallHeadImage", this.SmallHeadImage);
            this.SetParamArraySimple(map, prefix + "WarningCode.", this.WarningCode);
            this.SetParamArraySimple(map, prefix + "WarnCardInfos.", this.WarnCardInfos);
            this.SetParamSimple(map, prefix + "WindowEmbeddedText", this.WindowEmbeddedText);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

