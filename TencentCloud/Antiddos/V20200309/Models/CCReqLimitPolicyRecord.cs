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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CCReqLimitPolicyRecord : AbstractModel
    {
        
        /// <summary>
        /// 统计周期，可取值1，10，30，60，单位秒
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 请求数，取值1~20000
        /// </summary>
        [JsonProperty("RequestNum")]
        public ulong? RequestNum{ get; set; }

        /// <summary>
        /// 频率限制策略方式，可取值alg表示验证码，drop表示丢弃
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 频率限制策略时长，可取值1~86400，单位秒
        /// </summary>
        [JsonProperty("ExecuteDuration")]
        public ulong? ExecuteDuration{ get; set; }

        /// <summary>
        /// 策略项比对方式，可取值include表示包含，equal表示等于
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Uri，三个策略项仅可填其中之一
        /// </summary>
        [JsonProperty("Uri")]
        public string Uri{ get; set; }

        /// <summary>
        /// User-Agent，三个策略项仅可填其中之一
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// Cookie，三个策略项仅可填其中之一
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RequestNum", this.RequestNum);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ExecuteDuration", this.ExecuteDuration);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
        }
    }
}

