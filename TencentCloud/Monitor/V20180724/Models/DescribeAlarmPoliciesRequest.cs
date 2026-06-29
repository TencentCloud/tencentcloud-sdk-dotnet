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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>固定值，为&quot;monitor&quot;</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>页数，从 1 开始计数，默认 1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页的数量，取值1~100，默认20</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>按策略名称模糊搜索</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>根据监控类型过滤 不选默认查所有类型 &quot;MT_QCE&quot;=云产品监控,当Dimension不为空时，该项为必填项</p>
        /// </summary>
        [JsonProperty("MonitorTypes")]
        public string[] MonitorTypes{ get; set; }

        /// <summary>
        /// <p>根据命名空间过滤，不同策略类型的值详见<br><a href="https://cloud.tencent.com/document/product/248/50397">策略类型列表</a>当Dimension不为空时，该项为必填项</p>
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// <p>告警对象列表，JSON 字符串。外层数组，对应多个实例，内层为对象的维度。例如“云服务器-基础监控”可写为：<code>[[{&quot;name&quot;:&quot;unInstanceId&quot;,&quot;value&quot;:&quot;ins-qr888845g&quot;}]]</code>具体也可以参考下方的示例 2。不同云产品参数示例详见 <a href="https://cloud.tencent.com/document/product/248/50397">维度信息Dimensions列表</a>注意：如果NeedCorrespondence传入1，即需要返回策略与实例对应关系，请传入不多于20个告警对象维度，否则容易请求超时</p>
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// <p>根据接收人搜索，可以使用“访问管理”的 <a href="https://cloud.tencent.com/document/product/598/34587">拉取子用户 ListUsers</a> 接口获取用户列表 或 <a href="https://cloud.tencent.com/document/product/598/34590">查询子用户 GetUser</a> 接口查询子用户详情，此处填入返回结果中的 <code>Uid</code> 字段</p>
        /// </summary>
        [JsonProperty("ReceiverUids")]
        public long?[] ReceiverUids{ get; set; }

        /// <summary>
        /// <p>根据接收组搜索，可以使用“访问管理”的 <a href="https://cloud.tencent.com/document/product/598/34589">查询用户组列表 ListGroups</a> 接口获取用户组列表 或 <a href="https://cloud.tencent.com/document/product/598/34588">列出用户关联的用户组 ListGroupsForUser</a> 查询某个子用户所在的用户组列表 ，此处填入返回结果中的 <code>GroupId</code> 字段</p>
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public long?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// <p>根据默认策略筛选 不传展示全部策略 DEFAULT=展示默认策略 NOT_DEFAULT=展示非默认策略</p>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string[] PolicyType{ get; set; }

        /// <summary>
        /// <p>排序字段，例如按照最后修改时间排序，Field: &quot;UpdateTime&quot;</p>
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// <p>排序顺序：升序：ASC  降序：DESC</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>策略所属项目的id数组，可在此页面查看<br><a href="https://console.cloud.tencent.com/project">项目管理</a></p>
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// <p>通知模板的id列表，可查询通知模板列表获取。<br>可使用 <a href="https://cloud.tencent.com/document/product/248/51280">查询通知模板列表</a> 接口查询。</p>
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// <p>根据触发条件筛选 不传展示全部策略 STATIC=展示静态阈值策略 DYNAMIC=展示动态阈值策略</p>
        /// </summary>
        [JsonProperty("RuleTypes")]
        public string[] RuleTypes{ get; set; }

        /// <summary>
        /// <p>告警启停筛选，[1]：启用   [0]：停止，全部[0, 1]</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long?[] Enable{ get; set; }

        /// <summary>
        /// <p>传 1 查询未配置通知规则的告警策略；不传或传其他数值，查询所有策略。</p>
        /// </summary>
        [JsonProperty("NotBindingNoticeRule")]
        public long? NotBindingNoticeRule{ get; set; }

        /// <summary>
        /// <p>实例分组id</p>
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// <p>是否需要策略与入参过滤维度参数的对应关系，1：是  0：否，默认为0</p>
        /// </summary>
        [JsonProperty("NeedCorrespondence")]
        public long? NeedCorrespondence{ get; set; }

        /// <summary>
        /// <p>按照触发任务（例如弹性伸缩）过滤策略。最多10个</p>
        /// </summary>
        [JsonProperty("TriggerTasks")]
        public AlarmPolicyTriggerTask[] TriggerTasks{ get; set; }

        /// <summary>
        /// <p>根据一键告警策略筛选 不传展示全部策略 ONECLICK=展示一键告警策略 NOT_ONECLICK=展示非一键告警策略</p>
        /// </summary>
        [JsonProperty("OneClickPolicyType")]
        public string[] OneClickPolicyType{ get; set; }

        /// <summary>
        /// <p>返回结果过滤掉绑定全部对象的策略，1代表需要过滤，0则无需过滤</p>
        /// </summary>
        [JsonProperty("NotBindAll")]
        public long? NotBindAll{ get; set; }

        /// <summary>
        /// <p>返回结果过滤掉关联实例为实例分组的策略，1代表需要过滤，0则无需过滤</p>
        /// </summary>
        [JsonProperty("NotInstanceGroup")]
        public long? NotInstanceGroup{ get; set; }

        /// <summary>
        /// <p>策略根据标签过滤</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>prom实例id，自定义指标策略时会用到</p>
        /// </summary>
        [JsonProperty("PromInsId")]
        public string PromInsId{ get; set; }

        /// <summary>
        /// <p>根据排班表搜索</p>
        /// </summary>
        [JsonProperty("ReceiverOnCallFormIDs")]
        public string[] ReceiverOnCallFormIDs{ get; set; }

        /// <summary>
        /// <p>通知内容模板ID筛选</p>
        /// </summary>
        [JsonProperty("NoticeContentTmplIDs")]
        public string[] NoticeContentTmplIDs{ get; set; }

        /// <summary>
        /// <p>是否为预设策略，1是，0否</p>
        /// </summary>
        [JsonProperty("IsPredefined")]
        public long? IsPredefined{ get; set; }


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
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "NeedCorrespondence", this.NeedCorrespondence);
            this.SetParamArrayObj(map, prefix + "TriggerTasks.", this.TriggerTasks);
            this.SetParamArraySimple(map, prefix + "OneClickPolicyType.", this.OneClickPolicyType);
            this.SetParamSimple(map, prefix + "NotBindAll", this.NotBindAll);
            this.SetParamSimple(map, prefix + "NotInstanceGroup", this.NotInstanceGroup);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PromInsId", this.PromInsId);
            this.SetParamArraySimple(map, prefix + "ReceiverOnCallFormIDs.", this.ReceiverOnCallFormIDs);
            this.SetParamArraySimple(map, prefix + "NoticeContentTmplIDs.", this.NoticeContentTmplIDs);
            this.SetParamSimple(map, prefix + "IsPredefined", this.IsPredefined);
        }
    }
}

