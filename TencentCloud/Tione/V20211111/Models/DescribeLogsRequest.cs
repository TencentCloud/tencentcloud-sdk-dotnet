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

    public class DescribeLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>服务类型，TRAIN为任务式建模, NOTEBOOK为Notebook, INFER为在线服务, BATCH为批量预测<br>枚举值：</p><ul><li>TRAIN</li><li>NOTEBOOK</li><li>INFER</li><li>BATCH</li></ul>
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// <p>日志查询开始时间（RFC3339格式的时间字符串），默认值为当前时间的前一个小时</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>日志查询结束时间（RFC3339格式的时间字符串），默认值为当前时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>日志查询条数，默认值100，最大值1000</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>服务ID，和Service参数对应，不同Service的服务ID获取方式不同，具体如下：</p><ul><li>Service类型为TRAIN：<br>调用<a href="/document/product/851/75089">DescribeTrainingTask接口</a>查询训练任务详情，ServiceId为接口返回值中Response.TrainingTaskDetail.LatestInstanceId</li><li>Service类型为NOTEBOOK：<br>调用<a href="/document/product/851/95662">DescribeNotebook接口</a>查询Notebook详情，ServiceId为接口返回值中Response.NotebookDetail.PodName</li><li>Service类型为INFER：<br>调用<a href="/document/product/851/82285">DescribeModelServiceGroup接口</a>查询服务组详情，ServiceId为接口返回值中Response.ServiceGroup.Services.ServiceId</li><li>Service类型为BATCH：<br>调用<a href="/document/product/851/80180">DescribeBatchTask接口</a>查询跑批任务详情，ServiceId为接口返回值中Response.BatchTaskDetail.LatestInstanceId</li></ul>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>Pod的名称，即需要查询服务对应的Pod，和Service参数对应，不同Service的PodName获取方式不同，具体如下：</p><ul><li>Service类型为TRAIN：<br>调用<a href="/document/product/851/75088">DescribeTrainingTaskPods接口</a>查询训练任务pod列表，PodName为接口返回值中Response.PodNames</li><li>Service类型为NOTEBOOK：<br>调用<a href="/document/product/851/95662">DescribeNotebook接口</a>查询Notebook详情，PodName为接口返回值中Response.NotebookDetail.PodName</li><li>Service类型为INFER：<br>调用<a href="/document/product/851/82287">DescribeModelService接口</a>查询单个服务详情，PodName为接口返回值中Response.Service.ServiceInfo.PodInfos</li><li>Service类型为BATCH：<br>调用<a href="/document/product/851/80180">DescribeBatchTask接口</a>查询跑批任务详情，PodName为接口返回值中Response.BatchTaskDetail. PodList<br>注：支持结尾通配符*</li></ul>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>排序方向（可选值为ASC, DESC ），默认为DESC</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>按哪个字段排序（可选值为Timestamp），默认值为Timestamp</p>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// <p>日志查询上下文，查询下一页的时候需要回传这个字段，该字段来自本接口的返回</p>
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// <p>过滤条件<br>注意: </p><ol><li>Filter.Name：目前只支持Key（也就是按关键字过滤日志）</li><li>Filter.Values：表示过滤日志的关键字；Values为多个的时候表示同时满足</li><li>Filter. Negative和Filter. Fuzzy没有使用</li></ol>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>使用OFFSET分页查询时，指定返回的数据偏移量，默认为0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

