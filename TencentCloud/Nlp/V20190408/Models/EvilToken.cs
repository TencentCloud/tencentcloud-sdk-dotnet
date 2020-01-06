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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EvilToken : AbstractModel
    {
        
        /// <summary>
        /// 文本是否恶意：
        /// 0、正常；
        /// 1、恶意；
        /// 2、可疑送审
        /// </summary>
        [JsonProperty("EvilFlag")]
        public ulong? EvilFlag{ get; set; }

        /// <summary>
        /// 恶意关键词组
        /// </summary>
        [JsonProperty("EvilKeywords")]
        public string[] EvilKeywords{ get; set; }

        /// <summary>
        /// 文本恶意类型：
        /// 0、正常；
        /// 1、政治；
        /// 2、色情；
        /// 3、辱骂/低俗；
        /// 4、暴恐/毒品；
        /// 5、广告/灌水；
        /// 6、迷信/邪教；
        /// 7、其他违法（如跨站追杀/恶意竞争等）；
        /// 8、综合；
        /// 9、联系方式/链接
        /// </summary>
        [JsonProperty("EvilType")]
        public ulong? EvilType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvilFlag", this.EvilFlag);
            this.SetParamArraySimple(map, prefix + "EvilKeywords.", this.EvilKeywords);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
        }
    }
}

