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

    public class DescribeAttributeLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，获取方法参看如何获取[BotBizId](https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa)
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("AttributeBizId")]
        public string AttributeBizId{ get; set; }

        /// <summary>
        /// 每次请求返回的最大标签数量​，限制单次接口返回的标签数量，避免数据量过大。取值范围：大于0。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

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
        /// 搜索关键词，用于查询标签标准词或相似词
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 滚动加载游标，上一次请求返回的最后一个标签ID
        /// </summary>
        [JsonProperty("LastLabelBizId")]
        public string LastLabelBizId{ get; set; }

        /// <summary>
        /// 查询范围 all(或者传空):标准词和相似词 standard:标准词 similar:相似词
        /// </summary>
        [JsonProperty("QueryScope")]
        public string QueryScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "AttributeBizId", this.AttributeBizId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "LastLabelBizId", this.LastLabelBizId);
            this.SetParamSimple(map, prefix + "QueryScope", this.QueryScope);
        }
    }
}

