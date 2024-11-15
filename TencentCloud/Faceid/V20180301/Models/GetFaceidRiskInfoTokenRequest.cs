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

    public class GetFaceidRiskInfoTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// SDK中生成的Meta字符串。
        /// </summary>
        [JsonProperty("Meta")]
        public string Meta{ get; set; }

        /// <summary>
        /// 透传参数 1000长度字符串。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Meta", this.Meta);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

