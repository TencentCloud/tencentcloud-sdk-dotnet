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
        /// 服务类型，TRAIN为任务式建模, NOTEBOOK为Notebook, INFER为在线服务, BATCH为批量预测
        /// 枚举值：
        /// - TRAIN
        /// - NOTEBOOK
        /// - INFER
        /// - BATCH
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 日志查询开始时间（RFC3339格式的时间字符串），默认值为当前时间的前一个小时
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 日志查询结束时间（RFC3339格式的时间字符串），默认值为当前时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 日志查询条数，默认值100，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 服务ID，和Service参数对应，不同Service的服务ID获取方式不同，具体如下：
        /// - Service类型为TRAIN：
        ///   调用[DescribeTrainingTask接口](/document/product/851/75089)查询训练任务详情，ServiceId为接口返回值中Response.TrainingTaskDetail.LatestInstanceId
        /// - Service类型为NOTEBOOK：
        ///   调用[DescribeNotebook接口](/document/product/851/95662)查询Notebook详情，ServiceId为接口返回值中Response.NotebookDetail.PodName
        /// - Service类型为INFER：
        ///   调用[DescribeModelServiceGroup接口](/document/product/851/82285)查询服务组详情，ServiceId为接口返回值中Response.ServiceGroup.Services.ServiceId
        /// - Service类型为BATCH：
        ///   调用[DescribeBatchTask接口](/document/product/851/80180)查询跑批任务详情，ServiceId为接口返回值中Response.BatchTaskDetail.LatestInstanceId
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Pod的名称，即需要查询服务对应的Pod，和Service参数对应，不同Service的PodName获取方式不同，具体如下：
        /// - Service类型为TRAIN：
        ///   调用[DescribeTrainingTaskPods接口](/document/product/851/75088)查询训练任务pod列表，PodName为接口返回值中Response.PodNames
        /// - Service类型为NOTEBOOK：
        ///   调用[DescribeNotebook接口](/document/product/851/95662)查询Notebook详情，PodName为接口返回值中Response.NotebookDetail.PodName
        /// - Service类型为INFER：
        ///   调用[DescribeModelService接口](/document/product/851/82287)查询单个服务详情，PodName为接口返回值中Response.Service.ServiceInfo.PodInfos
        /// - Service类型为BATCH：
        ///   调用[DescribeBatchTask接口](/document/product/851/80180)查询跑批任务详情，PodName为接口返回值中Response.BatchTaskDetail. PodList
        /// 注：支持结尾通配符*
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// 排序方向（可选值为ASC, DESC ），默认为DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 按哪个字段排序（可选值为Timestamp），默认值为Timestamp
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 日志查询上下文，查询下一页的时候需要回传这个字段，该字段来自本接口的返回
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 过滤条件
        /// 注意: 
        /// 1. Filter.Name：目前只支持Key（也就是按关键字过滤日志）
        /// 2. Filter.Values：表示过滤日志的关键字；Values为多个的时候表示同时满足
        /// 3. Filter. Negative和Filter. Fuzzy没有使用
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


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
        }
    }
}

