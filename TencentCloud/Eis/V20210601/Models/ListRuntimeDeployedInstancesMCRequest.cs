/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Eis.V20210601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListRuntimeDeployedInstancesMCRequest : AbstractModel
    {
        
        /// <summary>
        /// 运行时id
        /// </summary>
        [JsonProperty("RuntimeId")]
        public long? RuntimeId{ get; set; }

        /// <summary>
        /// 最大请求数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 请求偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序类型：1:创建时间排序, 2:更新时间排序（默认）
        /// </summary>
        [JsonProperty("SortType")]
        public long? SortType{ get; set; }

        /// <summary>
        /// 排序方式：asc，desc（默认）
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 运行时地域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 1:3.0版本新控制台传1；否则传0
        /// </summary>
        [JsonProperty("ApiVersion")]
        public long? ApiVersion{ get; set; }

        /// <summary>
        /// -1:不按项目筛选，获取所有
        /// >=0: 按项目id筛选
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// -2: 不按状态筛选，获取所有
        /// 0: 运行中
        /// 2: 已停止
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0: 应用集成
        /// 1: API管理
        /// 2: ETL
        /// </summary>
        [JsonProperty("RuntimeClass")]
        public long? RuntimeClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuntimeId", this.RuntimeId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ApiVersion", this.ApiVersion);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuntimeClass", this.RuntimeClass);
        }
    }
}

