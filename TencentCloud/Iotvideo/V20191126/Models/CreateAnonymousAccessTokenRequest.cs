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

    public class CreateAnonymousAccessTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// Token的TTL(time to alive)分钟数,最大值1440(即24小时)
        /// </summary>
        [JsonProperty("TtlMinutes")]
        public long? TtlMinutes{ get; set; }

        /// <summary>
        /// 设备ID。创建Token时, 此参数为必须项
        /// </summary>
        [JsonProperty("Tid")]
        public string Tid{ get; set; }

        /// <summary>
        /// 旧的AccessToken。续期Token时，此参数为必须
        /// </summary>
        [JsonProperty("OldAccessToken")]
        public string OldAccessToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TtlMinutes", this.TtlMinutes);
            this.SetParamSimple(map, prefix + "Tid", this.Tid);
            this.SetParamSimple(map, prefix + "OldAccessToken", this.OldAccessToken);
        }
    }
}

