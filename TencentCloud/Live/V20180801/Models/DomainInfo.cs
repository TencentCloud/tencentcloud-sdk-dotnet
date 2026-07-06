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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>直播域名。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>域名类型:<br>0: 推流。<br>1: 播放。</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>域名状态:<br>0: 停用。<br>1: 启用。</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>添加时间。<br>注：此字段为北京时间（UTC+8时区）。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>是否有 CName 到固定规则域名:<br>0: 否。<br>1: 是。</p>
        /// </summary>
        [JsonProperty("BCName")]
        public ulong? BCName{ get; set; }

        /// <summary>
        /// <p>cname 对应的域名。</p>
        /// </summary>
        [JsonProperty("TargetDomain")]
        public string TargetDomain{ get; set; }

        /// <summary>
        /// <p>播放区域，只在 Type=1 时该参数有意义。<br>1: 国内。<br>2: 全球。<br>3: 海外。</p>
        /// </summary>
        [JsonProperty("PlayType")]
        public long? PlayType{ get; set; }

        /// <summary>
        /// <p>是否慢直播:<br>0: 普通直播。<br>1: 慢直播。</p>
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }

        /// <summary>
        /// <p>当前客户使用的 cname 信息。</p>
        /// </summary>
        [JsonProperty("CurrentCName")]
        public string CurrentCName{ get; set; }

        /// <summary>
        /// <p>失效参数，可忽略。</p>
        /// </summary>
        [JsonProperty("RentTag")]
        public long? RentTag{ get; set; }

        /// <summary>
        /// <p>失效参数，可忽略。<br>注：此字段为北京时间（UTC+8时区）。</p>
        /// </summary>
        [JsonProperty("RentExpireTime")]
        public string RentExpireTime{ get; set; }

        /// <summary>
        /// <p>0: 标准直播。<br>1: 小程序直播。</p>
        /// </summary>
        [JsonProperty("IsMiniProgramLive")]
        public long? IsMiniProgramLive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BCName", this.BCName);
            this.SetParamSimple(map, prefix + "TargetDomain", this.TargetDomain);
            this.SetParamSimple(map, prefix + "PlayType", this.PlayType);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
            this.SetParamSimple(map, prefix + "CurrentCName", this.CurrentCName);
            this.SetParamSimple(map, prefix + "RentTag", this.RentTag);
            this.SetParamSimple(map, prefix + "RentExpireTime", this.RentExpireTime);
            this.SetParamSimple(map, prefix + "IsMiniProgramLive", this.IsMiniProgramLive);
        }
    }
}

