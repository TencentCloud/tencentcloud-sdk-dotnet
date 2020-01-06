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

    public class DescribeLiveDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名状态过滤。0-停用，1-启用
        /// </summary>
        [JsonProperty("DomainStatus")]
        public ulong? DomainStatus{ get; set; }

        /// <summary>
        /// 域名类型过滤。0-推流，1-播放
        /// </summary>
        [JsonProperty("DomainType")]
        public ulong? DomainType{ get; set; }

        /// <summary>
        /// 分页大小，范围：10~100。默认10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 取第几页，范围：1~100000。默认1
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 0 普通直播 1慢直播 默认0
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public ulong? IsDelayLive{ get; set; }

        /// <summary>
        /// 域名前缀
        /// </summary>
        [JsonProperty("DomainPrefix")]
        public string DomainPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "DomainType", this.DomainType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
            this.SetParamSimple(map, prefix + "DomainPrefix", this.DomainPrefix);
        }
    }
}

