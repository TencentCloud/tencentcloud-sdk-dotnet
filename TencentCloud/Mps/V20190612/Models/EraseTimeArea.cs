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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EraseTimeArea : AbstractModel
    {
        
        /// <summary>
        /// 开始时间，单位:毫秒
        /// </summary>
        [JsonProperty("BeginMs")]
        public ulong? BeginMs{ get; set; }

        /// <summary>
        /// 结束时间，单位:毫秒
        /// </summary>
        [JsonProperty("EndMs")]
        public ulong? EndMs{ get; set; }

        /// <summary>
        /// 时间段内擦除区域列表
        /// </summary>
        [JsonProperty("Areas")]
        public EraseArea[] Areas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginMs", this.BeginMs);
            this.SetParamSimple(map, prefix + "EndMs", this.EndMs);
            this.SetParamArrayObj(map, prefix + "Areas.", this.Areas);
        }
    }
}

