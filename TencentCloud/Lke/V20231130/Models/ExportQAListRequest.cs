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

    public class ExportQAListRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// 若要操作共享知识库，传KnowledgeBizId
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// QA业务ID
        /// </summary>
        [JsonProperty("QaBizIds")]
        public string[] QaBizIds{ get; set; }

        /// <summary>
        /// 查询参数
        /// Filters.pageNumber范围是>0,0<Filters.pageSize<=200
        /// Filters.query用于内容检索，模糊匹配
        /// Filters.AcceptStatus默认值是0，表示不筛选，返回所有状态
        /// Filters.ReleaseStatus默认值是0，表示不筛选，返回所有状态
        /// Filters.Source默认值是0，表示不筛选，返回所有来源。表示来源(1 文档生成 2 批量导入 3 手动添加)。
        /// Filter.QueryType默认值是"filename"，表示查询类型。
        /// ShowCurrCate表示，是否只展示当前分类的数据 0不是，1是
        /// </summary>
        [JsonProperty("Filters")]
        public QAQuery Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamArraySimple(map, prefix + "QaBizIds.", this.QaBizIds);
            this.SetParamObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

