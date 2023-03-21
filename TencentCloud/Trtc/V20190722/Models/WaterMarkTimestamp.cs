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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterMarkTimestamp : AbstractModel
    {
        
        /// <summary>
        /// 时间戳的位置，取值范围0-6，分别代表上左，上右，下左，下右，上居中，下居中，居中
        /// </summary>
        [JsonProperty("Pos")]
        public ulong? Pos{ get; set; }

        /// <summary>
        /// 显示时间戳的时区，默认东八区
        /// </summary>
        [JsonProperty("TimeZone")]
        public ulong? TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pos", this.Pos);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

