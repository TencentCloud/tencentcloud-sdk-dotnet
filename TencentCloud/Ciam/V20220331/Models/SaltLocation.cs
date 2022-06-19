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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaltLocation : AbstractModel
    {
        
        /// <summary>
        /// 密码加盐的类型（HEAD，TAIL，OTHER）
        /// </summary>
        [JsonProperty("SaltLocationTypeEnum")]
        public string SaltLocationTypeEnum{ get; set; }

        /// <summary>
        /// 加盐规则
        /// </summary>
        [JsonProperty("SaltLocationRule")]
        public SaltLocationRule SaltLocationRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SaltLocationTypeEnum", this.SaltLocationTypeEnum);
            this.SetParamObj(map, prefix + "SaltLocationRule.", this.SaltLocationRule);
        }
    }
}

