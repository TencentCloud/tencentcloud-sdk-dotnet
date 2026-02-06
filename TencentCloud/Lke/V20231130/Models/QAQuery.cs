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

    public class QAQuery : AbstractModel
    {
        
        /// <summary>
        /// 页码 从1开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 页大小 默认15 最大100
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 查询内容
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// 校验状态的枚举值
        /// </summary>
        [JsonProperty("AcceptStatus")]
        public ulong?[] AcceptStatus{ get; set; }

        /// <summary>
        /// 发布状态的枚举值
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public ulong?[] ReleaseStatus{ get; set; }

        /// <summary>
        /// 文档ID
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// QAID
        /// </summary>
        [JsonProperty("QaBizId")]
        public string QaBizId{ get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// 查询答案
        /// </summary>
        [JsonProperty("QueryAnswer")]
        public string QueryAnswer{ get; set; }

        /// <summary>
        /// 查询类型 filename 名称、 attribute 标签
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 问答生效域检索，不检索不传。枚举值如下：
        /// 1-不生效；2-仅开发域生效；3-仅发布域生效；4-开发域和发布域均生效。
        /// </summary>
        [JsonProperty("EnableScope")]
        public long? EnableScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamArraySimple(map, prefix + "AcceptStatus.", this.AcceptStatus);
            this.SetParamArraySimple(map, prefix + "ReleaseStatus.", this.ReleaseStatus);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "QaBizId", this.QaBizId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "QueryAnswer", this.QueryAnswer);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "EnableScope", this.EnableScope);
        }
    }
}

