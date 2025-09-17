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

    public class ListUnsatisfiedReplyRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BotBizId")]
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
        /// 登录用户主账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// 登录用户子账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// 用户请求(问题或答案)
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 错误类型检索
        /// </summary>
        [JsonProperty("Reasons")]
        public string[] Reasons{ get; set; }

        /// <summary>
        /// 操作状态  0-全部 1-待处理  2-已处理【包括答案纠错，拒答，忽略】
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArraySimple(map, prefix + "Reasons.", this.Reasons);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

