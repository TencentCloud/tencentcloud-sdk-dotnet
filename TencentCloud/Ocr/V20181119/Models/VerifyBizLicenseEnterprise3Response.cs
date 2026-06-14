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

    public class VerifyBizLicenseEnterprise3Response : AbstractModel
    {
        
        /// <summary>
        /// <p>0 成功，计费<br>1 系统异常，不计费<br>2 查询无结果，不计费</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// <p>验证结果<br>1：三要素完全匹配<br>0：三要素不完全匹配<br>仅StatusCode为0时返回</p>
        /// </summary>
        [JsonProperty("VerifyResult")]
        public long? VerifyResult{ get; set; }

        /// <summary>
        /// <p>企业状态</p><p>枚举值：</p><ul><li>1： 开业（在营）/ 在营</li><li>2： 迁出 / 非在营</li><li>3： 注销</li><li>4： 吊销</li><li>5： 撤销</li><li>6： 停业</li><li>7： 撤销登记</li><li>0： 其他</li><li>/： 无法查询</li></ul><p>企业状态  当VerifyType参数为ENT_2META时，可返回：  0-7,  /   当VerifyType参数为ENT_3META时，可返回  1，2</p>
        /// </summary>
        [JsonProperty("OperatingStatus")]
        public string OperatingStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "VerifyResult", this.VerifyResult);
            this.SetParamSimple(map, prefix + "OperatingStatus", this.OperatingStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

