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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteCasterInputInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 导播台ID
        /// </summary>
        [JsonProperty("CasterId")]
        public ulong? CasterId{ get; set; }

        /// <summary>
        /// 导播台输入Index。
        /// 范围[0,20]
        /// 注：该Index对应的输入源需存在。
        /// </summary>
        [JsonProperty("InputIndex")]
        public ulong? InputIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "InputIndex", this.InputIndex);
        }
    }
}

