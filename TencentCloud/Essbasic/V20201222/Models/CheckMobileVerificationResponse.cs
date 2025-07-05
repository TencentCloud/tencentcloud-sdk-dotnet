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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckMobileVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 检测结果
        /// 计费结果码：
        ///   0:  验证结果一致
        ///   1:  手机号未实名
        ///   2:  姓名和手机号不一致
        ///   3:  信息不一致(手机号已实名,但姓名和身份证号与实名信息不一致)
        /// 不收费结果码:
        ///   101: 查无记录
        ///   102: 非法姓名(长度,格式等不正确)
        ///   103: 非法手机号(长度,格式等不正确)
        ///   104: 非法身份证号(长度,校验位等不正确)
        ///   105: 认证未通过
        ///   106: 验证平台异常
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }

        /// <summary>
        /// 结果描述; 未通过时必选
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

