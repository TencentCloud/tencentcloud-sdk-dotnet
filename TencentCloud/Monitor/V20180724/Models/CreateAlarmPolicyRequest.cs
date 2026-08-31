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

    public class CreateAlarmPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>固定值，为&quot;monitor&quot;</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>策略名称，不超过60字符</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>监控类型 MT_QCE=云产品监控</p>
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// <p>告警策略类型，由 <a href="https://cloud.tencent.com/document/product/248/48683">DescribeAllNamespaces</a> 获得。对于云产品监控，取接口出参的 QceNamespacesNew.N.Id，例如 cvm_device</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>备注，不超过100字符，仅支持中英文、数字、下划线、-</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>是否启用 0=停用 1=启用，可不传 默认为1</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>项目 Id，对于区分项目的产品必须传入非 -1 的值。 -1=无项目 0=默认项目，如不传 默认为 -1。支持的项目 Id 可以在控制台 <a href="https://console.cloud.tencent.com/project">账号中心-项目管理</a> 中查看。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>触发条件模板 Id，该参数与 Condition 参数二选一。如果策略绑定触发条件模板，则传该参数；否则不传该参数，而是传 Condition 参数。触发条件模板 Id 可以从 <a href="https://cloud.tencent.com/document/api/248/70250">DescribeConditionsTemplateList</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("ConditionTemplateId")]
        public long? ConditionTemplateId{ get; set; }

        /// <summary>
        /// <p>指标触发条件，支持的指标可以从 <a href="https://cloud.tencent.com/document/product/248/51283">DescribeAlarmMetrics</a> 查询。</p>
        /// </summary>
        [JsonProperty("Condition")]
        public AlarmPolicyCondition Condition{ get; set; }

        /// <summary>
        /// <p>事件触发条件，支持的事件可以从 <a href="https://cloud.tencent.com/document/product/248/51284">DescribeAlarmEvents</a> 查询。</p>
        /// </summary>
        [JsonProperty("EventCondition")]
        public AlarmPolicyEventCondition EventCondition{ get; set; }

        /// <summary>
        /// <p>通知规则 Id 列表，由 <a href="https://cloud.tencent.com/document/product/248/51280">DescribeAlarmNotices</a> 获得</p>
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// <p>触发任务列表</p>
        /// </summary>
        [JsonProperty("TriggerTasks")]
        public AlarmPolicyTriggerTask[] TriggerTasks{ get; set; }

        /// <summary>
        /// <p>全局过滤条件</p>
        /// </summary>
        [JsonProperty("Filter")]
        public AlarmPolicyFilter Filter{ get; set; }

        /// <summary>
        /// <p>聚合维度列表，指定按哪些维度 key 来做 group by</p>
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// <p>是否绑定全部对象。如果是的话，不需要再传filter或者调用BindPolicyObject，0=否，1=是，默认为否</p><p>取值范围：[0, 1]</p><p>默认值：0</p><p>不是所有策略类型都支持绑定全部对象</p>
        /// </summary>
        [JsonProperty("IsBindAll")]
        public long? IsBindAll{ get; set; }

        /// <summary>
        /// <p>模板绑定的标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>日志告警信息</p>
        /// </summary>
        [JsonProperty("LogAlarmReqInfo")]
        public LogAlarmReq LogAlarmReqInfo{ get; set; }

        /// <summary>
        /// <p>告警分级通知规则配置</p>
        /// </summary>
        [JsonProperty("HierarchicalNotices")]
        public AlarmHierarchicalNotice[] HierarchicalNotices{ get; set; }

        /// <summary>
        /// <p>迁移策略专用字段，0-走鉴权逻辑，1-跳过鉴权逻辑</p>
        /// </summary>
        [JsonProperty("MigrateFlag")]
        public long? MigrateFlag{ get; set; }

        /// <summary>
        /// <p>事件配置的告警</p>
        /// </summary>
        [JsonProperty("EbSubject")]
        public string EbSubject{ get; set; }

        /// <summary>
        /// <p>附加告警内容</p>
        /// </summary>
        [JsonProperty("AdditionalAlarmContent")]
        public string AdditionalAlarmContent{ get; set; }

        /// <summary>
        /// <p>通知模板绑定信息</p>
        /// </summary>
        [JsonProperty("NoticeContentTmplBindInfos")]
        public NoticeContentTmplBindInfo[] NoticeContentTmplBindInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ConditionTemplateId", this.ConditionTemplateId);
            this.SetParamObj(map, prefix + "Condition.", this.Condition);
            this.SetParamObj(map, prefix + "EventCondition.", this.EventCondition);
            this.SetParamArraySimple(map, prefix + "NoticeIds.", this.NoticeIds);
            this.SetParamArrayObj(map, prefix + "TriggerTasks.", this.TriggerTasks);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamSimple(map, prefix + "IsBindAll", this.IsBindAll);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "LogAlarmReqInfo.", this.LogAlarmReqInfo);
            this.SetParamArrayObj(map, prefix + "HierarchicalNotices.", this.HierarchicalNotices);
            this.SetParamSimple(map, prefix + "MigrateFlag", this.MigrateFlag);
            this.SetParamSimple(map, prefix + "EbSubject", this.EbSubject);
            this.SetParamSimple(map, prefix + "AdditionalAlarmContent", this.AdditionalAlarmContent);
            this.SetParamArrayObj(map, prefix + "NoticeContentTmplBindInfos.", this.NoticeContentTmplBindInfos);
        }
    }
}

