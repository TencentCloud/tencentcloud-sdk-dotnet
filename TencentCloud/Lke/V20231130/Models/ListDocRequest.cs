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

    public class ListDocRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID, 获取方式参看 [BotBizId](https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa)
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 页码(必须大于0)
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页数量(取值范围1-200)
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 查询内容
        /// 
        /// 输入特定标识 lke:system:untagged  将查询所有未关联标签的文档
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 文档状态： 1-未生成 2-生成中 3-生成成功 4-生成失败 5-删除中 6-删除成功  7-审核中  8-审核失败 9-审核成功  10-待发布  11-发布中  12-已发布  13-学习中  14-学习失败  15-更新中  16-更新失败  17-解析中  18-解析失败  19-导入失败   20-已过期 21-超量失效 22-超量失效恢复
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 查询类型 filename 文档、 attribute 标签
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 分类ID, 调用接口[ListDocCate](https://capi.woa.com/api/detail?product=lke&version=2023-11-30&action=ListDocCate)获取
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// 文件类型分类筛选
        /// </summary>
        [JsonProperty("FileTypes")]
        public string[] FileTypes{ get; set; }

        /// <summary>
        /// 文档列表筛选标识位
        /// </summary>
        [JsonProperty("FilterFlag")]
        public DocFilterFlag[] FilterFlag{ get; set; }

        /// <summary>
        /// 是否只展示当前分类的数据 0不是，1是
        /// </summary>
        [JsonProperty("ShowCurrCate")]
        public ulong? ShowCurrCate{ get; set; }

        /// <summary>
        /// 文档生效域；不检索默认为0
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
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamArraySimple(map, prefix + "FileTypes.", this.FileTypes);
            this.SetParamArrayObj(map, prefix + "FilterFlag.", this.FilterFlag);
            this.SetParamSimple(map, prefix + "ShowCurrCate", this.ShowCurrCate);
            this.SetParamSimple(map, prefix + "EnableScope", this.EnableScope);
        }
    }
}

