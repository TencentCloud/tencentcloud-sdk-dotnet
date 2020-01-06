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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddLiveDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名名称。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 域名类型，
        /// 0：推流域名，
        /// 1：播放域名。
        /// </summary>
        [JsonProperty("DomainType")]
        public ulong? DomainType{ get; set; }

        /// <summary>
        /// 拉流域名类型：
        /// 1：国内，
        /// 2：全球，
        /// 3：境外。
        /// 默认值：1。
        /// </summary>
        [JsonProperty("PlayType")]
        public ulong? PlayType{ get; set; }

        /// <summary>
        /// 是否是慢直播：
        /// 0： 普通直播，
        /// 1 ：慢直播 。
        /// 默认值： 0。
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "DomainType", this.DomainType);
            this.SetParamSimple(map, prefix + "PlayType", this.PlayType);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
        }
    }
}

