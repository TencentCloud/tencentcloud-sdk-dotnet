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

    public class DescribeAlarmHistoriesRequest : AbstractModel
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
        /// 默认按首次出现时间倒序排列 "ASC"=正序 "DESC"=逆序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 起始时间，默认一天前的时间戳。对应 `FirstOccurTime` 告警首次出现时间，告警历史的 `FirstOccurTime` 晚于 `StartTime` 才可能被搜索到。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间，默认当前时间戳。对应 `FirstOccurTime` 告警首次出现时间，告警历史的 `FirstOccurTime` 早于 `EndTime` 才可能被搜索到。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 根据监控类型过滤 不选默认查所有类型 "MT_QCE"=云产品监控
        /// </summary>
        [JsonProperty("MonitorTypes")]
        public string[] MonitorTypes{ get; set; }

        /// <summary>
        /// 根据告警对象过滤 字符串模糊搜索
        /// </summary>
        [JsonProperty("AlarmObject")]
        public string AlarmObject{ get; set; }

        /// <summary>
        /// 根据告警状态过滤 ALARM=未恢复 OK=已恢复 NO_CONF=已失效 NO_DATA=数据不足，不选默认查所有
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public string[] AlarmStatus{ get; set; }

        /// <summary>
        /// 根据项目ID过滤，-1=无项目 0=默认项目
        /// 可在此页面查询 [项目管理](https://console.cloud.tencent.com/project)
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 根据实例组ID过滤
        /// </summary>
        [JsonProperty("InstanceGroupIds")]
        public long?[] InstanceGroupIds{ get; set; }

        /// <summary>
        /// 根据策略类型过滤，策略类型是监控类型之下的概念，在这里两者都需要传入，例如 `[{"MonitorType": "MT_QCE", "Namespace": "cvm_device"}]`
        /// 可使用 [查询所有名字空间 DescribeAllNamespaces](https://cloud.tencent.com/document/product/248/48683) 接口查询
        /// </summary>
        [JsonProperty("Namespaces")]
        public MonitorTypeNamespace[] Namespaces{ get; set; }

        /// <summary>
        /// 根据指标名过滤
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// 根据策略名称模糊搜索
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 根据告警内容模糊搜索
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 根据接收人搜索，可以使用“访问管理”的 [拉取子用户 ListUsers](https://cloud.tencent.com/document/product/598/34587) 接口获取用户列表 或 [查询子用户 GetUser](https://cloud.tencent.com/document/product/598/34590) 接口查询子用户详情，此处填入返回结果中的 `Uid` 字段
        /// </summary>
        [JsonProperty("ReceiverUids")]
        public long?[] ReceiverUids{ get; set; }

        /// <summary>
        /// 根据接收组搜索，可以使用“访问管理”的 [查询用户组列表 ListGroups](https://cloud.tencent.com/document/product/598/34589) 接口获取用户组列表 或 [列出用户关联的用户组 ListGroupsForUser](https://cloud.tencent.com/document/product/598/34588) 查询某个子用户所在的用户组列表 ，此处填入返回结果中的 `GroupId ` 字段
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public long?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// 根据告警策略 Id 列表搜索
        /// </summary>
        [JsonProperty("PolicyIds")]
        public string[] PolicyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "MonitorTypes.", this.MonitorTypes);
            this.SetParamSimple(map, prefix + "AlarmObject", this.AlarmObject);
            this.SetParamArraySimple(map, prefix + "AlarmStatus.", this.AlarmStatus);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "InstanceGroupIds.", this.InstanceGroupIds);
            this.SetParamArrayObj(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArraySimple(map, prefix + "ReceiverUids.", this.ReceiverUids);
            this.SetParamArraySimple(map, prefix + "ReceiverGroups.", this.ReceiverGroups);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
        }
    }
}

