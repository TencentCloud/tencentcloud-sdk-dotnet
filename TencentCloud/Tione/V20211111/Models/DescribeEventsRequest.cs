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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>服务类型，TRAIN为任务式建模, NOTEBOOK为Notebook, INFER为在线服务, BATCH为批量预测<br>枚举值：</p><ul><li>TRAIN</li><li>NOTEBOOK</li><li>INFER</li><li>BATCH</li></ul>
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// <p>TI工作空间ID</p><p>使用非默认空间必须填写工作空间ID，使用默认空间无需填写工作空间ID。</p>
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// <p>服务ID，和Service参数对应，不同Service的服务ID获取方式不同，具体如下：</p><ul><li>Service类型为TRAIN：<br>调用<a href="/document/product/851/75089">DescribeTrainingTask接口</a>查询训练任务详情，ServiceId为接口返回值中Response.TrainingTaskDetail.LatestInstanceId</li><li>Service类型为NOTEBOOK：<br>调用<a href="/document/product/851/95662">DescribeNotebook接口</a>查询Notebook详情，ServiceId为接口返回值中Response.NotebookDetail.PodName</li><li>Service类型为INFER：<br>调用<a href="/document/product/851/82285">DescribeModelServiceGroup接口</a>查询服务组详情，ServiceId为接口返回值中Response.ServiceGroup.Services.ServiceId</li><li>Service类型为BATCH：<br>调用<a href="/document/product/851/80180">DescribeBatchTask接口</a>查询跑批任务详情，ServiceId为接口返回值中Response.BatchTaskDetail.LatestInstanceId</li></ul>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>查询事件最早发生的时间（RFC3339格式的时间字符串），默认值为当前时间的前一天</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询事件最晚发生的时间（RFC3339格式的时间字符串），默认值为当前时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>分页Limit，默认值为100，最大值为100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>分页Offset，默认值为0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>排列顺序（可选值为ASC, DESC ），默认为DESC</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>排序的依据字段（可选值为FirstTimestamp, LastTimestamp），默认值为LastTimestamp</p>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// <p>过滤条件<br>注意: </p><ol><li>Filter.Name：目前支持ResourceKind（按事件关联的资源类型过滤）；Type（按事件类型过滤）</li><li>Filter.Values：<br>对于Name为ResourceKind，Values的可选取值为Deployment, Replicaset, Pod等K8S资源类型；<br>对于Name为Type，Values的可选取值仅为Normal或者Warning；<br>Values为多个的时候表示同时满足</li><li>Filter. Negative和Filter. Fuzzy没有使用</li></ol>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

