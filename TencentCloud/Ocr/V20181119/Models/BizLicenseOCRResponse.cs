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

    public class BizLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 统一社会信用代码（三合一之前为注册号）
        /// </summary>
        [JsonProperty("RegNum")]
        public string RegNum{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [JsonProperty("Capital")]
        public string Capital{ get; set; }

        /// <summary>
        /// 法定代表人
        /// </summary>
        [JsonProperty("Person")]
        public string Person{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// 组成形式
        /// </summary>
        [JsonProperty("ComposingForm")]
        public string ComposingForm{ get; set; }

        /// <summary>
        /// 成立日期
        /// </summary>
        [JsonProperty("SetDate")]
        public string SetDate{ get; set; }

        /// <summary>
        /// Code 告警码列表和释义：
        /// -9102 黑白复印件告警
        /// -9104 翻拍件告警
        /// </summary>
        [JsonProperty("RecognizeWarnCode")]
        public long?[] RecognizeWarnCode{ get; set; }

        /// <summary>
        /// 告警码说明：
        /// WARN_COPY_CARD 黑白复印件告警
        /// WARN_RESHOOT_CARD翻拍件告警
        /// </summary>
        [JsonProperty("RecognizeWarnMsg")]
        public string[] RecognizeWarnMsg{ get; set; }

        /// <summary>
        /// 是否为副本。1为是，-1为不是。
        /// </summary>
        [JsonProperty("IsDuplication")]
        public long? IsDuplication{ get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        [JsonProperty("RegistrationDate")]
        public string RegistrationDate{ get; set; }

        /// <summary>
        ///  图片旋转角度(角度制)，文本的水平方向为0度；顺时针为正，角度范围是0-360度
        /// 
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// 是否有国徽。0为没有，1为有。
        /// </summary>
        [JsonProperty("NationalEmblem")]
        public bool? NationalEmblem{ get; set; }

        /// <summary>
        /// 是否有二维码。0为没有，1为有。
        /// </summary>
        [JsonProperty("QRCode")]
        public bool? QRCode{ get; set; }

        /// <summary>
        /// 是否有印章。0为没有，1为有。
        /// </summary>
        [JsonProperty("Seal")]
        public bool? Seal{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [JsonProperty("RegistrationAuthority")]
        public string RegistrationAuthority{ get; set; }

        /// <summary>
        /// 是否是电子营业执照。0为不是，1为是。
        /// </summary>
        [JsonProperty("Electronic")]
        public bool? Electronic{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

