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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConsoleSharingRequest : AbstractModel
    {
        
        /// <summary>
        /// 免密分享链接Id
        /// </summary>
        [JsonProperty("SharingId")]
        public string SharingId{ get; set; }

        /// <summary>
        /// 指定分享链接有效期，单位：毫秒，最长可设定有效期为30天
        /// </summary>
        [JsonProperty("DurationMilliseconds")]
        public ulong? DurationMilliseconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SharingId", this.SharingId);
            this.SetParamSimple(map, prefix + "DurationMilliseconds", this.DurationMilliseconds);
        }
    }
}

