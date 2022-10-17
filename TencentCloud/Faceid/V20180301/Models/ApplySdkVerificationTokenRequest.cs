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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplySdkVerificationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否需要身份证鉴伪，如果不需要，则仅做证件OCR。当前仅IdCardType为HK支持鉴伪。
        /// </summary>
        [JsonProperty("NeedVerifyIdCard")]
        public bool? NeedVerifyIdCard{ get; set; }

        /// <summary>
        /// 卡证类型，当前仅支持HK（香港身份证），ML（马来西亚身份证），PhilippinesVoteID（菲律宾选民卡），PhilippinesDrivingLicense（菲律宾驾驶证）。默认为HK。
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 是否允许用户修改ocr结果，默认false，允许。
        /// </summary>
        [JsonProperty("DisableChangeOcrResult")]
        public bool? DisableChangeOcrResult{ get; set; }

        /// <summary>
        /// 是否关闭OCR告警，默认false，不关闭。如果为false开启OCR告警，我们会根据Ocr的告警信息进行拦截，当NeedVerifyIdCard为true时该字段将为true。
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }

        /// <summary>
        /// 透传字段，在获取验证结果时返回，最长1024位。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NeedVerifyIdCard", this.NeedVerifyIdCard);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "DisableChangeOcrResult", this.DisableChangeOcrResult);
            this.SetParamSimple(map, prefix + "DisableCheckOcrWarnings", this.DisableCheckOcrWarnings);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

