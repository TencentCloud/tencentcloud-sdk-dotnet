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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云主账号UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 腾讯云子账号UIN
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 子账号名称
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }

        /// <summary>
        /// 子账号在Linux下的UID
        /// </summary>
        [JsonProperty("LinuxUid")]
        public long? LinuxUid{ get; set; }

        /// <summary>
        /// 子账号在Linux下的GID
        /// </summary>
        [JsonProperty("LinuxGid")]
        public long? LinuxGid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
            this.SetParamSimple(map, prefix + "LinuxUid", this.LinuxUid);
            this.SetParamSimple(map, prefix + "LinuxGid", this.LinuxGid);
        }
    }
}

