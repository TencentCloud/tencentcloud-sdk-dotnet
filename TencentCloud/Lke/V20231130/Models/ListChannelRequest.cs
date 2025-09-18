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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BotBizId")]
        [System.Obsolete]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 渠道类型, 10000: 微信订阅号，10001: 微信服务号，10002：企微应用，10004：微信客服，10005：小程序，10009：企微智能机器人 
        /// </summary>
        [JsonProperty("ChannelType")]
        public ulong?[] ChannelType{ get; set; }

        /// <summary>
        /// 渠道状态 1未发布 2运行中 3已下线
        /// </summary>
        [JsonProperty("ChannelStatus")]
        public ulong?[] ChannelStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "ChannelType.", this.ChannelType);
            this.SetParamArraySimple(map, prefix + "ChannelStatus.", this.ChannelStatus);
        }
    }
}

