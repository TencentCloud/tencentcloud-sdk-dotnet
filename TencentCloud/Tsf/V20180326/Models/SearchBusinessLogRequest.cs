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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchBusinessLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志配置项ID
        /// 可通过调用[DescribeBusinessLogConfigs](https://cloud.tencent.com/document/product/649/75777)查询已创建的日志配置项列表或登录[控制台](https://console.cloud.tencent.com/tsf/observable/log?rid=1)进行查看
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 机器实例ID，不传表示全部实例
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 开始时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 请求偏移量，取值范围大于等于0，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 单页请求配置数量，取值范围[1, 200]，默认值为50
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序规则，默认值"time"
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式，取值"asc"或"desc"，默认值"desc"
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// 检索关键词
        /// </summary>
        [JsonProperty("SearchWords")]
        public string[] SearchWords{ get; set; }

        /// <summary>
        /// 部署组ID列表，不传表示全部部署组
        /// 可通过调用[DescribeContainerGroups](https://cloud.tencent.com/document/product/649/36068)或[DescribeGroups](https://cloud.tencent.com/document/product/649/36065)查询已创建的部署组列表或登录[控制台](https://console.cloud.tencent.com/tsf/app-detail?rid=1&id=application-yo7kp9dv&tab=publish&subTab=group)进行查看
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 检索类型，取值 LUCENE：Lucene检索，REGEXP：正则检索，NORMAL：普通检索
        /// </summary>
        [JsonProperty("SearchWordType")]
        public string SearchWordType{ get; set; }

        /// <summary>
        /// 批量请求类型，取值 PAGE：分页查询，SCROLL：滚动查询，SEARCHAFTER：游标查询，默认值PAGE
        /// </summary>
        [JsonProperty("BatchType")]
        public string BatchType{ get; set; }

        /// <summary>
        /// 游标ID
        /// </summary>
        [JsonProperty("ScrollId")]
        public string ScrollId{ get; set; }

        /// <summary>
        /// 查询es使用searchAfter时，游标
        /// </summary>
        [JsonProperty("SearchAfter")]
        public string[] SearchAfter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "SearchWords.", this.SearchWords);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "SearchWordType", this.SearchWordType);
            this.SetParamSimple(map, prefix + "BatchType", this.BatchType);
            this.SetParamSimple(map, prefix + "ScrollId", this.ScrollId);
            this.SetParamArraySimple(map, prefix + "SearchAfter.", this.SearchAfter);
        }
    }
}

