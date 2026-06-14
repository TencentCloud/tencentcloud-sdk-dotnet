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

    public class VerifyBizLicenseEnterprise3Request : AbstractModel
    {
        
        /// <summary>
        /// <p>统一社会信用代码</p>
        /// </summary>
        [JsonProperty("CreditCode")]
        public string CreditCode{ get; set; }

        /// <summary>
        /// <p>企业名称</p>
        /// </summary>
        [JsonProperty("EntName")]
        public string EntName{ get; set; }

        /// <summary>
        /// <p>法人代表</p>
        /// </summary>
        [JsonProperty("LrName")]
        public string LrName{ get; set; }

        /// <summary>
        /// <p>核验类型 </p><p>枚举值：</p><ul><li>ENT_2META： 企业名称 、统一社会信用代码</li><li>ENT_3META： 企业名称 、统一社会信用代码 、法人代表名称</li></ul>
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "EntName", this.EntName);
            this.SetParamSimple(map, prefix + "LrName", this.LrName);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
        }
    }
}

