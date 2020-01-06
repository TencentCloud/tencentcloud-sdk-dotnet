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

    public class DescribeLiveStreamEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间。 
        /// UTC 格式，例如：2018-12-29T19:00:00Z。
        /// 支持查询60天内的历史记录。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// UTC 格式，例如：2018-12-29T20:00:00Z。
        /// 不超过当前时间，且和起始时间相差不得超过30天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 推流路径，与推流和播放地址中的AppName保持一致，默认为 live。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 流名称，不支持通配符（*）查询，默认模糊匹配。
        /// 可使用IsStrict字段改为精确查询。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 取得第几页。
        /// 默认值：1。
        /// 注： 目前只支持10000条内的查询。
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 分页大小。
        /// 最大值：100。
        /// 取值范围：1~100 之前的任意整数。
        /// 默认值：10。
        /// 注： 目前只支持10000条内的查询。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 是否过滤，默认不过滤。
        /// 0：不进行任何过滤。
        /// 1：过滤掉开播失败的，只返回开播成功的。
        /// </summary>
        [JsonProperty("IsFilter")]
        public long? IsFilter{ get; set; }

        /// <summary>
        /// 是否精确查询，默认模糊匹配。
        /// 0：模糊匹配。
        /// 1：精确查询。
        /// 注：使用StreamName时该参数生效。
        /// </summary>
        [JsonProperty("IsStrict")]
        public long? IsStrict{ get; set; }

        /// <summary>
        /// 是否按结束时间正序显示，默认逆序。
        /// 0：逆序。
        /// 1：正序。
        /// </summary>
        [JsonProperty("IsAsc")]
        public long? IsAsc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "IsFilter", this.IsFilter);
            this.SetParamSimple(map, prefix + "IsStrict", this.IsStrict);
            this.SetParamSimple(map, prefix + "IsAsc", this.IsAsc);
        }
    }
}

