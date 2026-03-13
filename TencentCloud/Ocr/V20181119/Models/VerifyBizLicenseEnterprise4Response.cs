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

    public class VerifyBizLicenseEnterprise4Response : AbstractModel
    {
        
        /// <summary>
        /// <p>请求状态</p><p>枚举值：</p><ul><li>0： 成功，计费</li><li>1： 系统异常，不计费</li></ul>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// <p>验证结果<br>1：四要素完全匹配<br>0：四要素不完全匹配<br>仅StatusCode为0时返回</p>
        /// </summary>
        [JsonProperty("VerifyResult")]
        public long? VerifyResult{ get; set; }

        /// <summary>
        /// <p>统一社会信用代码是否一致<br>仅StatusCode为0时返回</p>
        /// </summary>
        [JsonProperty("IsCreditCodeConsistent")]
        public bool? IsCreditCodeConsistent{ get; set; }

        /// <summary>
        /// <p>企业名称是否一致<br>仅StatusCode为0时返回</p>
        /// </summary>
        [JsonProperty("IsEntNameConsistent")]
        public bool? IsEntNameConsistent{ get; set; }

        /// <summary>
        /// <p>法人代表是否一致<br>仅StatusCode为0时返回，企业名称与统一社会信用代码均未查得时，固定返回false</p>
        /// </summary>
        [JsonProperty("IsLrNameConsistent")]
        public bool? IsLrNameConsistent{ get; set; }

        /// <summary>
        /// <p>注册登记证件号码是否一致<br>仅StatusCode为0时返回，企业名称与统一社会信用代码均未查得时，固定返回false</p>
        /// </summary>
        [JsonProperty("IsIdNumConsistent")]
        public bool? IsIdNumConsistent{ get; set; }

        /// <summary>
        /// <p>经营状态</p><p>枚举值：</p><ul><li>1： 开业（在营）</li><li>2： 迁出</li><li>3： 注销</li><li>4： 吊销</li><li>5： 撤销</li><li>6： 停业</li><li>0： 其他</li><li>-10002： 企业信息不正确，无法查询</li></ul>
        /// </summary>
        [JsonProperty("OperatingStatus")]
        public string OperatingStatus{ get; set; }

        /// <summary>
        /// <p>营业期限：一般包括营业开始时间和结束时间</p><p>参数格式：yyyy-MM-dd/yyyy-MM-dd</p><p>无固定期限的格式为：yyyy-MM-dd/<br>部分企业历史数据可能为空，将返回：/<br>企业信息不正确，无法查询，将返回：-10002</p>
        /// </summary>
        [JsonProperty("OperatingPeriod")]
        public string OperatingPeriod{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsCreditCodeConsistent", this.IsCreditCodeConsistent);
            this.SetParamSimple(map, prefix + "IsEntNameConsistent", this.IsEntNameConsistent);
            this.SetParamSimple(map, prefix + "IsLrNameConsistent", this.IsLrNameConsistent);
            this.SetParamSimple(map, prefix + "IsIdNumConsistent", this.IsIdNumConsistent);
            this.SetParamSimple(map, prefix + "OperatingStatus", this.OperatingStatus);
            this.SetParamSimple(map, prefix + "OperatingPeriod", this.OperatingPeriod);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

