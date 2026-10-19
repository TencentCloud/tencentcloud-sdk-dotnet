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

    public class BizLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>统一社会信用代码（三合一之前为注册号）</p>
        /// </summary>
        [JsonProperty("RegNum")]
        public string RegNum{ get; set; }

        /// <summary>
        /// <p>公司名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>注册资本</p>
        /// </summary>
        [JsonProperty("Capital")]
        public string Capital{ get; set; }

        /// <summary>
        /// <p>法定代表人</p>
        /// </summary>
        [JsonProperty("Person")]
        public string Person{ get; set; }

        /// <summary>
        /// <p>地址</p>
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>经营范围</p>
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// <p>主体类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>营业期限</p>
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// <p>组成形式</p>
        /// </summary>
        [JsonProperty("ComposingForm")]
        public string ComposingForm{ get; set; }

        /// <summary>
        /// <p>成立日期</p>
        /// </summary>
        [JsonProperty("SetDate")]
        public string SetDate{ get; set; }

        /// <summary>
        /// <p>Code 告警码列表和释义：<br>-9102 黑白复印件告警<br>-9104 翻拍件告警<br>-9108 经营范围识别异常告警（由于文字过小、模糊、反光、遮挡或明显倾斜等情况导致未能正常识别）</p>
        /// </summary>
        [JsonProperty("RecognizeWarnCode")]
        public long?[] RecognizeWarnCode{ get; set; }

        /// <summary>
        /// <p>告警码说明：<br>WARN_COPY_CARD 黑白复印件告警<br>WARN_RESHOOT_CARD翻拍件告警<br>WARN_EARLY_STOP 经营范围识别异常告警</p>
        /// </summary>
        [JsonProperty("RecognizeWarnMsg")]
        public string[] RecognizeWarnMsg{ get; set; }

        /// <summary>
        /// <p>是否为副本。1为是，-1为不是。</p>
        /// </summary>
        [JsonProperty("IsDuplication")]
        public long? IsDuplication{ get; set; }

        /// <summary>
        /// <p>登记日期</p>
        /// </summary>
        [JsonProperty("RegistrationDate")]
        public string RegistrationDate{ get; set; }

        /// <summary>
        /// <p>图片旋转角度(角度制)，文本的水平方向为0度；顺时针为正，角度范围是0-360度</p>
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// <p>是否有国徽。false为没有，true为有。</p>
        /// </summary>
        [JsonProperty("NationalEmblem")]
        public bool? NationalEmblem{ get; set; }

        /// <summary>
        /// <p>是否有二维码。false为没有，true为有。</p>
        /// </summary>
        [JsonProperty("QRCode")]
        public bool? QRCode{ get; set; }

        /// <summary>
        /// <p>是否有印章。false为没有，true为有。</p>
        /// </summary>
        [JsonProperty("Seal")]
        public bool? Seal{ get; set; }

        /// <summary>
        /// <p>标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>编号</p>
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// <p>登记机关</p>
        /// </summary>
        [JsonProperty("RegistrationAuthority")]
        public string RegistrationAuthority{ get; set; }

        /// <summary>
        /// <p>是否是电子营业执照。false为没有，true为有。</p>
        /// </summary>
        [JsonProperty("Electronic")]
        public bool? Electronic{ get; set; }

        /// <summary>
        /// <p>非营业执照的营业类证件识别结果，将以结构化形式呈现。</p>
        /// </summary>
        [JsonProperty("BusinessCertificate")]
        public BusinessCertificateInfo[] BusinessCertificate{ get; set; }

        /// <summary>
        /// <p>重要提示字段</p>
        /// </summary>
        [JsonProperty("Important")]
        public string Important{ get; set; }

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
            this.SetParamSimple(map, prefix + "RegNum", this.RegNum);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Capital", this.Capital);
            this.SetParamSimple(map, prefix + "Person", this.Person);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ComposingForm", this.ComposingForm);
            this.SetParamSimple(map, prefix + "SetDate", this.SetDate);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnCode.", this.RecognizeWarnCode);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnMsg.", this.RecognizeWarnMsg);
            this.SetParamSimple(map, prefix + "IsDuplication", this.IsDuplication);
            this.SetParamSimple(map, prefix + "RegistrationDate", this.RegistrationDate);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamSimple(map, prefix + "NationalEmblem", this.NationalEmblem);
            this.SetParamSimple(map, prefix + "QRCode", this.QRCode);
            this.SetParamSimple(map, prefix + "Seal", this.Seal);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "RegistrationAuthority", this.RegistrationAuthority);
            this.SetParamSimple(map, prefix + "Electronic", this.Electronic);
            this.SetParamArrayObj(map, prefix + "BusinessCertificate.", this.BusinessCertificate);
            this.SetParamSimple(map, prefix + "Important", this.Important);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

