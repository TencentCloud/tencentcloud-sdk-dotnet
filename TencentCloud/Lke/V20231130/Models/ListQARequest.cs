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

    public class ListQARequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// 若要操作共享知识库，传KnowledgeBizId
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 页码（取值范围>0）
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页大小(取值范围1-200)
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 查询问题
        /// 
        /// 输入特定标识 lke:system:untagged  将查询所有未关联标签的问答
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 校验状态(1未校验2采纳3不采纳)
        /// 如果不填默认值为空数组，表示不筛选，返回所有状态
        /// </summary>
        [JsonProperty("AcceptStatus")]
        public long?[] AcceptStatus{ get; set; }

        /// <summary>
        /// 发布状态(2,4导入成功 7审核中 8审核失败 9人工申述中 11人工申述失败 12已过期 13超量失效 14超量失效恢复)
        /// 如果不填默认值为空数组，表示不筛选返回所有状态
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public long?[] ReleaseStatus{ get; set; }

        /// <summary>
        /// 文档ID
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// 来源(1 文档生成 2 批量导入 3 手动添加)
        /// 不填默认值为0，表示不过滤，返回所有状态
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 查询答案
        /// </summary>
        [JsonProperty("QueryAnswer")]
        public string QueryAnswer{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// QA业务ID列表
        /// </summary>
        [JsonProperty("QaBizIds")]
        public string[] QaBizIds{ get; set; }

        /// <summary>
        /// 查询类型 filename 名称、 attribute 标签
        /// 如果不填默认值为"filename"
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 是否只展示当前分类的数据 0不是，1是
        /// </summary>
        [JsonProperty("ShowCurrCate")]
        public ulong? ShowCurrCate{ get; set; }

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
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArraySimple(map, prefix + "AcceptStatus.", this.AcceptStatus);
            this.SetParamArraySimple(map, prefix + "ReleaseStatus.", this.ReleaseStatus);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "QueryAnswer", this.QueryAnswer);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamArraySimple(map, prefix + "QaBizIds.", this.QaBizIds);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "ShowCurrCate", this.ShowCurrCate);
            this.SetParamSimple(map, prefix + "EnableScope", this.EnableScope);
        }
    }
}

