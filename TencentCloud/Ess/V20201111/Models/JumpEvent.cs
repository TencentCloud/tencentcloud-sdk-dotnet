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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JumpEvent : AbstractModel
    {
        
        /// <summary>
        /// 跳转事件枚举，
        /// * 1 - 企业收录。
        /// * 2 - 超管授权书审核。
        /// * 3 - 认证完成。
        /// </summary>
        [JsonProperty("JumpEventType")]
        public ulong? JumpEventType{ get; set; }

        /// <summary>
        /// 为认证成功后页面进行回跳的URL，请确保回跳地址的可用性。
        /// Endpoint如果是APP 类型，请传递<font color="red">"true"</font>
        /// 如果 Endpoint 是 H5 类型，请参考文档[跳转电子签H5](https://qian.tencent.com/developers/company/openqianh5/)
        /// 
        /// p.s. 如果Endpoint是 APP，传递的跳转地址无效，不会进行跳转，仅会进行回跳。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JumpEventType", this.JumpEventType);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
        }
    }
}

