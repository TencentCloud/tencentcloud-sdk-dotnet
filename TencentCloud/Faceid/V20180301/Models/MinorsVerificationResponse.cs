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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MinorsVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 结果码，收费情况如下。
        /// 收费结果码：
        /// 0: 成年
        /// -1: 未成年
        /// -3: 姓名和身份证号不一致
        /// 
        /// 不收费结果码：
        /// -2: 未查询到手机号信息
        /// -4: 非法身份证号（长度、校验位等不正确）
        /// -5: 非法姓名（长度、格式等不正确）
        /// -6: 权威数据源服务异常
        /// -7: 未查询到身份信息
        /// -8: 权威数据源升级中，请稍后再试
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 业务结果描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 该字段的值为年龄区间。格式为[a,b)，
        /// [0,8)表示年龄小于8周岁区间，不包括8岁；
        /// [8,16)表示年龄8-16周岁区间，不包括16岁；
        /// [16,18)表示年龄16-18周岁区间，不包括18岁；
        /// [18,+)表示年龄大于18周岁。
        /// </summary>
        [JsonProperty("AgeRange")]
        public string AgeRange{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AgeRange", this.AgeRange);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

