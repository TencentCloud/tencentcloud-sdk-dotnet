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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// 直播域名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 域名类型。0-推流，1-播放
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 域名状态。0-停用，1-启用
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否有CName到固定规则域名。0-否，1-是
        /// </summary>
        [JsonProperty("BCName")]
        public ulong? BCName{ get; set; }

        /// <summary>
        /// cname对应的域名
        /// </summary>
        [JsonProperty("TargetDomain")]
        public string TargetDomain{ get; set; }

        /// <summary>
        /// 播放区域，只在Type=1时该参数有意义。
        /// 1-国内，2-全球，3-海外。
        /// </summary>
        [JsonProperty("PlayType")]
        public long? PlayType{ get; set; }

        /// <summary>
        /// 0：普通直播，
        /// 1：慢直播。
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }

        /// <summary>
        /// 当前客户使用的cname信息
        /// </summary>
        [JsonProperty("CurrentCName")]
        public string CurrentCName{ get; set; }

        /// <summary>
        /// 是否租用域名
        /// </summary>
        [JsonProperty("RentTag")]
        public long? RentTag{ get; set; }

        /// <summary>
        /// 租用域名过期时间
        /// </summary>
        [JsonProperty("RentExpireTime")]
        public string RentExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

