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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页返回数量（0-1000)
        /// </summary>
        [JsonProperty("MgoLimit")]
        public long? MgoLimit{ get; set; }

        /// <summary>
        /// FlexDB实例ID
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("MgoOffset")]
        public long? MgoOffset{ get; set; }

        /// <summary>
        /// 过滤标签数组，用于过滤表名，可选值如：HIDDEN、WEDA、WEDA_SYSTEM
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// 模糊搜索查询值
        /// </summary>
        [JsonProperty("SearchValue")]
        public string SearchValue{ get; set; }

        /// <summary>
        /// 是否展示隐藏表
        /// </summary>
        [JsonProperty("ShowHidden")]
        public bool? ShowHidden{ get; set; }

        /// <summary>
        /// 云开发环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// mongo连接器信息
        /// </summary>
        [JsonProperty("MongoConnector")]
        public MongoConnector MongoConnector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MgoLimit", this.MgoLimit);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "MgoOffset", this.MgoOffset);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SearchValue", this.SearchValue);
            this.SetParamSimple(map, prefix + "ShowHidden", this.ShowHidden);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamObj(map, prefix + "MongoConnector.", this.MongoConnector);
        }
    }
}

