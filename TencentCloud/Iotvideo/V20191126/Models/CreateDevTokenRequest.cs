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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDevTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户的终端用户在IoT Video上的唯一标识ID
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// 设备TID列表,0<元素数量<=100
        /// </summary>
        [JsonProperty("Tids")]
        public string[] Tids{ get; set; }

        /// <summary>
        /// Token的TTL(time to alive)分钟数
        /// </summary>
        [JsonProperty("TtlMinutes")]
        public ulong? TtlMinutes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamArraySimple(map, prefix + "Tids.", this.Tids);
            this.SetParamSimple(map, prefix + "TtlMinutes", this.TtlMinutes);
        }
    }
}

