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

    public class MinorsVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 结果码，收费情况如下。
        /// 收费结果码：
        /// 0: 成年
        /// -1: 未成年
        /// -2: 手机号未实名
        /// -3: 姓名和身份证号不一致
        /// 
        /// 不收费结果码：
        /// -4: 非法身份证号（长度、校验位等不正确）
        /// -5: 非法姓名（长度、格式等不正确）
        /// -6: 数据源服务异常
        /// -7: 数据源中无此身份证记录
        /// -8: 公安比对系统升级中，请稍后再试
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 业务结果描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 当结果码为0或者-1时，该字段的值为年龄区间。
        /// 格式为[a,b)，表示年龄在a岁以上（包括a岁），b岁以下（不包括b岁）。若b为+时表示没有上限。
        /// </summary>
        [JsonProperty("AgeRange")]
        public string AgeRange{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AgeRange", this.AgeRange);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

