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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>仅支持 PostPay，区分大小写</p><p>枚举值：</p><ul><li>PostPay： 后付费 按量计费模式</li></ul><p>仅支持 PostPay，区分大小写</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>客户端生成的创建请求标识。同一次逻辑创建发生重试时，须使用相同的值。</p><p>参数格式：1～64 个可见 ASCII 字符（! 至 ~）。</p><p>入参限制：必填；不能含空格、中文或控制字符。建议使用 ssm-&lt;UUID&gt;，不要包含密钥或个人信息。</p><p>默认值：留空，由调用方生成；不要设置固定默认值。</p><p>SSM 将其透传给计费侧，不存储或返回。订单状态不明时先核单，再决定是否用原值重试。</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
        }
    }
}

