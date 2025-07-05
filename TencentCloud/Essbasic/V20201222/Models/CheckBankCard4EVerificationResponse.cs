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

    public class CheckBankCard4EVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 检测结果
        /// 计费结果码：
        ///   0:  认证通过
        ///   1:  认证未通过
        ///   2:  持卡人信息有误
        ///   3:  未开通无卡支付
        ///   4:  此卡被没收
        ///   5:  无效卡号
        ///   6:  此卡无对应发卡行
        ///   7:  该卡未初始化或睡眠卡
        ///   8:  作弊卡、吞卡
        ///   9:  此卡已挂失
        ///   10: 该卡已过期
        ///   11: 受限制的卡
        ///   12: 密码错误次数超限
        ///   13: 发卡行不支持此交易
        /// 不收费结果码:
        ///   101: 姓名校验不通过
        ///   102: 银行卡号码有误
        ///   103: 验证中心服务繁忙
        ///   104: 身份证号码有误
        ///   105: 手机号码不合法
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

