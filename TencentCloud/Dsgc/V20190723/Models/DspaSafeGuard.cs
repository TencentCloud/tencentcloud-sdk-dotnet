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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaSafeGuard : AbstractModel
    {
        
        /// <summary>
        /// 加密状态，可取值如下：
        /// UNSET 未设置
        /// DISABLE 规则设置未启用
        /// ENABLE 规则设置并启用
        /// </summary>
        [JsonProperty("Encrypt")]
        public string Encrypt{ get; set; }

        /// <summary>
        /// 脱敏状态，可取值如下：
        /// UNSET 未设置
        /// DISABLE 规则设置未启用
        /// ENABLE 规则设置并启用
        /// </summary>
        [JsonProperty("Desensitization")]
        public string Desensitization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "Desensitization", this.Desensitization);
        }
    }
}

