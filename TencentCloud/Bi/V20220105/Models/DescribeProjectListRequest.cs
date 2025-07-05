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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProjectListRequest : AbstractModel
    {
        
        /// <summary>
        /// 页容，初版默认20，将来可能根据屏幕宽度动态变化
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 页标
        /// </summary>
        [JsonProperty("PageNo")]
        public ulong? PageNo{ get; set; }

        /// <summary>
        /// 检索模糊字段
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 是否全部展示，如果是ture，则忽略分页
        /// </summary>
        [JsonProperty("AllPage")]
        public bool? AllPage{ get; set; }

        /// <summary>
        /// 角色信息
        /// </summary>
        [JsonProperty("ModuleCollection")]
        public string ModuleCollection{ get; set; }

        /// <summary>
        /// moduleId集合
        /// </summary>
        [JsonProperty("ModuleIdList")]
        public string[] ModuleIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "AllPage", this.AllPage);
            this.SetParamSimple(map, prefix + "ModuleCollection", this.ModuleCollection);
            this.SetParamArraySimple(map, prefix + "ModuleIdList.", this.ModuleIdList);
        }
    }
}

