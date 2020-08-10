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

    public class VerifyBasicBizLicenseResponse : AbstractModel
    {
        
        /// <summary>
        /// 状态码，成功时返回0
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("CreditCode")]
        public string CreditCode{ get; set; }

        /// <summary>
        /// 经营期限自（YYYY-MM-DD）
        /// </summary>
        [JsonProperty("Opfrom")]
        public string Opfrom{ get; set; }

        /// <summary>
        /// 经营期限至（YYYY-MM-DD）
        /// </summary>
        [JsonProperty("Opto")]
        public string Opto{ get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonProperty("Frname")]
        public string Frname{ get; set; }

        /// <summary>
        /// 经营状态（在营、注销、吊销、其他）
        /// </summary>
        [JsonProperty("Entstatus")]
        public string Entstatus{ get; set; }

        /// <summary>
        /// 经营业务范围
        /// </summary>
        [JsonProperty("Zsopscope")]
        public string Zsopscope{ get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 原注册号
        /// </summary>
        [JsonProperty("Oriregno")]
        public string Oriregno{ get; set; }

        /// <summary>
        /// 要核验的工商注册号
        /// </summary>
        [JsonProperty("VerifyRegno")]
        public string VerifyRegno{ get; set; }

        /// <summary>
        /// 工商注册号
        /// </summary>
        [JsonProperty("Regno")]
        public string Regno{ get; set; }

        /// <summary>
        /// 要核验的企业名称
        /// </summary>
        [JsonProperty("VerifyEntname")]
        public string VerifyEntname{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("Entname")]
        public string Entname{ get; set; }

        /// <summary>
        /// 要核验的住址
        /// </summary>
        [JsonProperty("VerifyDom")]
        public string VerifyDom{ get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [JsonProperty("Dom")]
        public string Dom{ get; set; }

        /// <summary>
        /// 验证结果
        /// </summary>
        [JsonProperty("RegNumResult")]
        public BizLicenseVerifyResult RegNumResult{ get; set; }

        /// <summary>
        /// 注册资本（单位：万元）,只有输入参数regCapital为1的时候才输出
        /// </summary>
        [JsonProperty("RegCapital")]
        public string RegCapital{ get; set; }

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
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "Opfrom", this.Opfrom);
            this.SetParamSimple(map, prefix + "Opto", this.Opto);
            this.SetParamSimple(map, prefix + "Frname", this.Frname);
            this.SetParamSimple(map, prefix + "Entstatus", this.Entstatus);
            this.SetParamSimple(map, prefix + "Zsopscope", this.Zsopscope);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Oriregno", this.Oriregno);
            this.SetParamSimple(map, prefix + "VerifyRegno", this.VerifyRegno);
            this.SetParamSimple(map, prefix + "Regno", this.Regno);
            this.SetParamSimple(map, prefix + "VerifyEntname", this.VerifyEntname);
            this.SetParamSimple(map, prefix + "Entname", this.Entname);
            this.SetParamSimple(map, prefix + "VerifyDom", this.VerifyDom);
            this.SetParamSimple(map, prefix + "Dom", this.Dom);
            this.SetParamObj(map, prefix + "RegNumResult.", this.RegNumResult);
            this.SetParamSimple(map, prefix + "RegCapital", this.RegCapital);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

