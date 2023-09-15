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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyForAntiInfoLeak : AbstractModel
    {
        
        /// <summary>
        /// 匹配条件，returncode（响应码）、keywords（关键字）、information（敏感信息）
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 逻辑符号，固定取值为contains
        /// </summary>
        [JsonProperty("CompareFunc")]
        public string CompareFunc{ get; set; }

        /// <summary>
        /// 匹配内容。
        /// 以下三个对应Field为information时可取的匹配内容：
        /// idcard（身份证）、phone（手机号）、bankcard（银行卡）。
        /// 以下为对应Field为returncode时可取的匹配内容：
        /// 400（状态码400）、403（状态码403）、404（状态码404）、4xx（其它4xx状态码）、500（状态码500）、501（状态码501）、502（状态码502）、504（状态码504）、5xx（其它5xx状态码）。
        /// 当对应Field为keywords时由用户自己输入匹配内容。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "CompareFunc", this.CompareFunc);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

