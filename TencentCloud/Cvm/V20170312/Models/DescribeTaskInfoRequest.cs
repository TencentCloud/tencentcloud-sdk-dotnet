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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回数量，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 按照指定的产品类型查询，支持取值：
        /// 
        /// - `CVM`：云服务器
        /// - `CDH`：专用宿主机
        /// - `CPM2.0`：裸金属云服务器
        /// 
        /// 未传入或为空时，默认查询全部产品类型。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 按照一个或多个任务状态ID进行过滤。
        /// `TaskStatus`（任务状态ID）与任务状态中文名的对应关系如下：
        /// 
        /// - `1`：待授权
        /// - `2`：处理中
        /// - `3`：已结束
        /// - `4`：已预约
        /// - `5`：已取消
        /// - `6`：已避免
        /// 
        /// 各任务状态的具体含义，可参考 [任务状态](https://cloud.tencent.com/document/product/213/67789#.E4.BB.BB.E5.8A.A1.E7.8A.B6.E6.80.81)。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long?[] TaskStatus{ get; set; }

        /// <summary>
        /// 按照一个或多个任务类型ID进行过滤。
        /// 
        /// `TaskTypeId`（任务类型ID）与任务类型中文名的对应关系如下：
        /// 
        /// - `101`：实例运行隐患
        /// - `102`：实例运行异常
        /// - `103`：实例硬盘异常
        /// - `104`：实例网络连接异常
        /// - `105`：实例运行预警
        /// - `106`：实例硬盘预警
        /// - `107`：实例维护升级
        /// 
        /// 各任务类型的具体含义，可参考 [维修任务分类](https://cloud.tencent.com/document/product/213/67789#.E7.BB.B4.E4.BF.AE.E4.BB.BB.E5.8A.A1.E5.88.86.E7.B1.BB)。
        /// </summary>
        [JsonProperty("TaskTypeIds")]
        public long?[] TaskTypeIds{ get; set; }

        /// <summary>
        /// 按照一个或者多个任务ID查询。任务ID形如：`rep-xxxxxxxx`。
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 按照一个或者多个实例ID查询。实例ID形如：`ins-xxxxxxxx`，可通过 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) 接口返回值中的`InstanceId`获取。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 按照一个或者多个实例名称查询。
        /// </summary>
        [JsonProperty("Aliases")]
        public string[] Aliases{ get; set; }

        /// <summary>
        /// 时间查询区间的起始位置，会根据任务创建时间`CreateTime`进行过滤，格式为`YYYY-MM-DD hh:mm:ss`。未传入时默认为当天`00:00:00`。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 时间查询区间的终止位置，会根据任务创建时间`CreateTime`进行过滤，格式为`YYYY-MM-DD hh:mm:ss`。未传入时默认为当前时刻。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 指定返回维修任务列表的排序字段，目前支持：
        /// 
        /// - `CreateTime`：任务创建时间
        /// - `AuthTime`：任务授权时间
        /// - `EndTime`：任务结束时间
        /// 
        /// 未传入时或为空时，默认按`CreateTime`字段进行排序。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方式，目前支持：
        /// 
        /// - `0`：升序（默认）
        /// - `1`：降序
        /// 
        /// 未传入或为空时，默认按升序排序。
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "TaskTypeIds.", this.TaskTypeIds);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "Aliases.", this.Aliases);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

