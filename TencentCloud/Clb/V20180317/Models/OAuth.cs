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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OAuth : AbstractModel
    {
        
        /// <summary>
        /// 开启或关闭鉴权。
        /// True: 开启;
        /// False: 关闭
        /// </summary>
        [JsonProperty("OAuthEnable")]
        public bool? OAuthEnable{ get; set; }

        /// <summary>
        /// IAP全部故障后，拒绝请求还是放行。BYPASS:通过,
        /// REJECT: 拒绝
        /// </summary>
        [JsonProperty("OAuthFailureStatus")]
        public string OAuthFailureStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OAuthEnable", this.OAuthEnable);
            this.SetParamSimple(map, prefix + "OAuthFailureStatus", this.OAuthFailureStatus);
        }
    }
}

