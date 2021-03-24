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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定值，为"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 页数，从 1 开始计数，默认 1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页的数量，取值1~100，默认20
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 按策略名称模糊搜索
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 根据监控类型过滤 不选默认查所有类型 "MT_QCE"=云产品监控
        /// </summary>
        [JsonProperty("MonitorTypes")]
        public string[] MonitorTypes{ get; set; }

        /// <summary>
        /// 根据命名空间过滤，不同策略类型的值详见
        /// [策略类型列表](https://cloud.tencent.com/document/product/248/50397)
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// 告警对象列表，外层数组，对应多个实例
        /// 内层数组，每个数组对应一个实例，里面的object对应的是这个实例的维度信息。格式为
        /// [
        /// 	[{"name":"unInstanceId","value":"ins-qr888845g"}],
        /// 	[{"name":"unInstanceId","value":"ins-qr8d555g"}]
        /// 	...
        /// ]
        /// 不同云产品参数示例详见
        /// [维度信息Dimensions列表](https://cloud.tencent.com/document/product/248/50397)
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// 根据接收人的uid搜索，需要调用访问管理的api查询。详见
        /// [拉取子用户](https://cloud.tencent.com/document/product/598/34587)
        /// </summary>
        [JsonProperty("ReceiverUids")]
        public long?[] ReceiverUids{ get; set; }

        /// <summary>
        /// 根据接收组的uid搜索，需要调用访问管理的api查询，详见
        /// [查询用户组列表](https://cloud.tencent.com/document/product/598/34589)
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public long?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// 根据默认策略筛选 不传展示全部策略 DEFAULT=展示默认策略 NOT_DEFAULT=展示非默认策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public string[] PolicyType{ get; set; }

        /// <summary>
        /// 排序字段，例如按照最后修改时间排序，Field: "UpdateTime"
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 排序顺序：升序：ASC  降序：DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 策略所属项目的id数组，可在此页面查看
        /// [项目管理](https://console.cloud.tencent.com/project)
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 通知模版的id列表，可查询通知模版列表获取。
        /// [查询通知模板列表](https://cloud.tencent.com/document/product/248/51280)
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// 根据触发条件筛选 不传展示全部策略 STATIC=展示静态阈值策略 DYNAMIC=展示动态阈值策略
        /// </summary>
        [JsonProperty("RuleTypes")]
        public string[] RuleTypes{ get; set; }

        /// <summary>
        /// 告警启停筛选，[1]：启用   [0]：停止，全部[0, 1]
        /// </summary>
        [JsonProperty("Enable")]
        public long?[] Enable{ get; set; }

        /// <summary>
        /// 传 1 查询未配置通知规则的告警策略；不传或传其他数值，查询所有策略。
        /// </summary>
        [JsonProperty("NotBindingNoticeRule")]
        public long? NotBindingNoticeRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamArraySimple(map, prefix + "MonitorTypes.", this.MonitorTypes);
            this.SetParamArraySimple(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "ReceiverUids.", this.ReceiverUids);
            this.SetParamArraySimple(map, prefix + "ReceiverGroups.", this.ReceiverGroups);
            this.SetParamArraySimple(map, prefix + "PolicyType.", this.PolicyType);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "NoticeIds.", this.NoticeIds);
            this.SetParamArraySimple(map, prefix + "RuleTypes.", this.RuleTypes);
            this.SetParamArraySimple(map, prefix + "Enable.", this.Enable);
            this.SetParamSimple(map, prefix + "NotBindingNoticeRule", this.NotBindingNoticeRule);
        }
    }
}

