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
        /// 根据命名空间过滤
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// 告警对象列表
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// 根据接收人搜索
        /// </summary>
        [JsonProperty("ReceiverUids")]
        public long?[] ReceiverUids{ get; set; }

        /// <summary>
        /// 根据接收组搜索
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public long?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// 根据默认策略筛选 不传展示全部策略 DEFAULT=展示默认策略 NOT_DEFAULT=展示非默认策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public string[] PolicyType{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 排序顺序：升序：ASC  降序：DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 项目id数组
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 告警通知id列表
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// 根据触发条件筛选 不传展示全部策略 STATIC=展示静态阈值策略 DYNAMIC=展示动态阈值策略
        /// </summary>
        [JsonProperty("RuleTypes")]
        public string[] RuleTypes{ get; set; }

        /// <summary>
        /// 启停，1：启用   0：停止
        /// </summary>
        [JsonProperty("Enable")]
        public long?[] Enable{ get; set; }

        /// <summary>
        /// 是否未配置通知规则，1：未配置，0：配置
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

