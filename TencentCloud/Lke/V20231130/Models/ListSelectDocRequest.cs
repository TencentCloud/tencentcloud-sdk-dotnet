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

    public class ListSelectDocRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID,获取方法参看如何获取[BotBizId](https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa)
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 文档名称。可通过文档名称检索支持生成问答的文档，不支持xlsx、xls、csv格式
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文档状态筛选。文档状态对应码为7 审核中、8 审核失败、10 待发布、11 发布中、12 已发布、13 学习中、14 学习失败 20 已过期。其中仅状态为10 待发布、12 已发布的文档支持生成问答（未填写时默认值为空数组）
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
        }
    }
}

